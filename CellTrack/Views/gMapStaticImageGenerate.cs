using CellTrack.Classes;
using CellTrack.Controllers;
using CellTrack.Models;
using GMap.NET;
using GMap.NET.WindowsForms;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Views
{
    public partial class gMapStaticImageGenerate : MetroForm
    {
        private gMapController gMap;
        private readonly List<GPoint> tileArea = new List<GPoint>();

        public string FullPathMap = string.Empty;

        public gMapStaticImageGenerate(gMapController gMap)
        {
            InitializeComponent();            
            this.gMap = gMap;
            this.init();            
        }
        
        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
        }

        private void generate()
        {
            RectLatLng? area = null;
            area = gMap.MainMap.ViewArea;

            bg.WorkerReportsProgress = true;
            bg.WorkerSupportsCancellation = true;
            bg.DoWork += new DoWorkEventHandler(bg_DoWork);
            bg.ProgressChanged += new ProgressChangedEventHandler(bg_ProgressChanged);
            bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_RunWorkerCompleted);

            if (!bg.IsBusy)
            {
                lock (tileArea)
                {
                    tileArea.Clear();
                    tileArea.AddRange(gMap.MainMap.MapProvider.Projection.GetAreaTileList(area.Value, (int)gMap.MainMap.Zoom, 1));
                    tileArea.TrimExcess();
                }

                pb.Value = 0;
                gMap.MainMap.HoldInvalidation = true;

                bg.RunWorkerAsync(
                    new MapInfo(
                        area.Value,
                        (int)gMap.MainMap.Zoom,
                        gMap.MainMap.MapProvider,
                        false,
                        false));
            }     
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            MapInfo info = (MapInfo)e.Argument;
            if (!info.Area.IsEmpty)
            {
                string applicationPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
#if DEBUG
                applicationPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
#endif
                string fileName = @"map.jpg";
                string bigImage = string.Format(@"{0}\{1}", applicationPath, fileName);
                
                e.Result = bigImage;

                // current area
                GPoint topLeftPx = info.Type.Projection.FromLatLngToPixel(info.Area.LocationTopLeft, info.Zoom);
                GPoint rightButtomPx = info.Type.Projection.FromLatLngToPixel(info.Area.Bottom, info.Area.Right, info.Zoom);
                GPoint pxDelta = new GPoint(rightButtomPx.X - topLeftPx.X, rightButtomPx.Y - topLeftPx.Y);
                GMap.NET.GSize maxOfTiles = info.Type.Projection.GetTileMatrixMaxXY(info.Zoom);

                int padding = info.MakeWorldFile || info.MakeKmz ? 0 : 22;
                {
                    using (Bitmap bmpDestination = new Bitmap((int)(pxDelta.X + padding * 2), (int)(pxDelta.Y + padding * 2)))
                    {
                        using (Graphics gfx = Graphics.FromImage(bmpDestination))
                        {
                            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            gfx.SmoothingMode = SmoothingMode.HighQuality;

                            int i = 0;

                            // get tiles & combine into one
                            lock (tileArea)
                            {
                                foreach (var p in tileArea)
                                {
                                    if (bg.CancellationPending)
                                    {
                                        e.Cancel = true;
                                        return;
                                    }

                                    int pc = (int)(((double)++i / tileArea.Count) * 100);
                                    bg.ReportProgress(pc, p);

                                    foreach (var tp in info.Type.Overlays)
                                    {
                                        Exception ex;
                                        GMapImage tile;

                                        // tile number inversion(BottomLeft -> TopLeft) for pergo maps
                                        if (tp.InvertedAxisY)
                                        {
                                            tile = GMaps.Instance.GetImageFrom(tp, new GPoint(p.X, maxOfTiles.Height - p.Y), info.Zoom, out ex) as GMapImage;
                                        }
                                        else // ok
                                        {
                                            tile = GMaps.Instance.GetImageFrom(tp, p, info.Zoom, out ex) as GMapImage;
                                        }

                                        if (tile != null)
                                        {
                                            using (tile)
                                            {
                                                long x = p.X * info.Type.Projection.TileSize.Width - topLeftPx.X + padding;
                                                long y = p.Y * info.Type.Projection.TileSize.Width - topLeftPx.Y + padding;
                                                {
                                                    gfx.DrawImage(tile.Img, x, y, info.Type.Projection.TileSize.Width, info.Type.Projection.TileSize.Height);
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            // draw markers
                            {
                                foreach (GMapMarker r in gMap.MarkersOverlays.Markers)
                                {
                                    if (r.IsVisible)
                                    {
                                        var pr = r.Position;
                                        GPoint px = info.Type.Projection.FromLatLngToPixel(pr.Lat, pr.Lng, info.Zoom);

                                        px.Offset(padding, padding);
                                        px.Offset(-topLeftPx.X, -topLeftPx.Y);
                                        px.Offset(r.Offset.X, r.Offset.Y);

                                        gfx.ResetTransform();
                                        gfx.TranslateTransform(-r.LocalPosition.X, -r.LocalPosition.Y);
                                        gfx.TranslateTransform((int)px.X, (int)px.Y);

                                        r.OnRender(gfx);
                                    }
                                }

                                foreach (GMapMarker r in gMap.TriangulationsOverlays.Markers)
                                {
                                    if (r.IsVisible)
                                    {
                                        var pr = r.Position;
                                        GPoint px = info.Type.Projection.FromLatLngToPixel(pr.Lat, pr.Lng, info.Zoom);

                                        px.Offset(padding, padding);
                                        px.Offset(-topLeftPx.X, -topLeftPx.Y);
                                        px.Offset(r.Offset.X, r.Offset.Y);

                                        gfx.ResetTransform();
                                        gfx.TranslateTransform(-r.LocalPosition.X, -r.LocalPosition.Y);
                                        gfx.TranslateTransform((int)px.X, (int)px.Y);

                                        r.OnRender(gfx);
                                    }
                                }
                                gfx.ResetTransform();
                            }

                            // draw info
                            if (!info.MakeWorldFile)
                            {
                                System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
                                {
                                    rect.Location = new System.Drawing.Point(padding, padding);
                                    rect.Size = new System.Drawing.Size((int)pxDelta.X, (int)pxDelta.Y);
                                }

                                using (Font f = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold))
                                {
                                    // draw bounds & coordinates
                                    using (Pen p = new Pen(Brushes.DimGray, 3))
                                    {
                                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

                                        gfx.DrawRectangle(p, rect);

                                        string topleft = info.Area.LocationTopLeft.ToString();
                                        SizeF s = gfx.MeasureString(topleft, f);

                                        gfx.DrawString(topleft, f, p.Brush, rect.X + s.Height / 2, rect.Y + s.Height / 2);

                                        string rightBottom = new PointLatLng(info.Area.Bottom, info.Area.Right).ToString();
                                        SizeF s2 = gfx.MeasureString(rightBottom, f);

                                        gfx.DrawString(rightBottom, f, p.Brush, rect.Right - s2.Width - s2.Height / 2, rect.Bottom - s2.Height - s2.Height / 2);
                                    }

                                    // draw scale
                                    using (Pen p = new Pen(Brushes.Blue, 1))
                                    {
                                        double rez = info.Type.Projection.GetGroundResolution(info.Zoom, info.Area.Bottom);
                                        int px100 = (int)(100.0 / rez); // 100 meters
                                        int px1000 = (int)(1000.0 / rez); // 1km   

                                        gfx.DrawRectangle(p, rect.X + 10, rect.Bottom - 20, px1000, 10);
                                        gfx.DrawRectangle(p, rect.X + 10, rect.Bottom - 20, px100, 10);

                                        string leftBottom = "scale: 100m | 1Km";
                                        SizeF s = gfx.MeasureString(leftBottom, f);
                                        gfx.DrawString(leftBottom, f, p.Brush, rect.X + 10, rect.Bottom - s.Height - 20);
                                    }
                                }
                            }
                        }

                        bmpDestination.Save(bigImage, ImageFormat.Jpeg);
                    }
                }

                //The worldfile for the original image is:

                //0.000067897543      // the horizontal size of a pixel in coordinate units (longitude degrees in this case);
                //0.0000000
                //0.0000000
                //-0.0000554613012    // the comparable vertical pixel size in latitude degrees, negative because latitude decreases as you go from top to bottom in the image.
                //-111.743323868834   // longitude of the pixel in the upper-left-hand corner.
                //35.1254392635083    // latitude of the pixel in the upper-left-hand corner.

                // generate world file
                if (info.MakeWorldFile)
                {
                    string wf = bigImage + "w";
                    using (StreamWriter world = File.CreateText(wf))
                    {
                        world.WriteLine("{0:0.000000000000}", (info.Area.WidthLng / pxDelta.X));
                        world.WriteLine("0.0000000");
                        world.WriteLine("0.0000000");
                        world.WriteLine("{0:0.000000000000}", (-info.Area.HeightLat / pxDelta.Y));
                        world.WriteLine("{0:0.000000000000}", info.Area.Left);
                        world.WriteLine("{0:0.000000000000}", info.Area.Top);
                        world.Close();
                    }
                }

                if (info.MakeKmz)
                {
                    var kmzFile = Path.GetDirectoryName(bigImage) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(bigImage) + ".kmz";
                    e.Result = kmzFile;

                    using (ZipStorer zip = ZipStorer.Create(kmzFile, "GMap.NET"))
                    {
                        zip.AddFile(ZipStorer.Compression.Store, bigImage, "files/map.jpg", "map");

                        using (var readme = new MemoryStream(
                          Encoding.UTF8.GetBytes(
                           string.Format(CultureInfo.InvariantCulture, @"<?xml version=""1.0"" encoding=""UTF-8""?> 
<kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"" xmlns:kml=""http://www.opengis.net/kml/2.2"" xmlns:atom=""http://www.w3.org/2005/Atom"">
<GroundOverlay>
	<name>{8}</name>
	<LookAt>
		<longitude>{6}</longitude>
		<latitude>{7}</latitude>
		<altitude>0</altitude>
		<heading>0</heading>
		<tilt>0</tilt>
		<range>69327.55500845652</range>
	</LookAt>
	<color>91ffffff</color>
	<Icon>
		<href>files/map.jpg</href>
	</Icon>
	<gx:LatLonQuad>
		<coordinates>
			{0},{1},0 {2},{3},0 {4},{5},0 {6},{7},0 
		</coordinates>
	</gx:LatLonQuad>
</GroundOverlay>
</kml>", info.Area.Left, info.Area.Bottom,
               info.Area.Right, info.Area.Bottom,
               info.Area.Right, info.Area.Top,
               info.Area.Left, info.Area.Top,
               kmzFile))))
                        {

                            zip.AddStream(ZipStorer.Compression.Store, "doc.kml", readme, DateTime.Now, "kml");
                            zip.Close();
                        }
                    }
                }
            }
        }

        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb.Value = e.ProgressPercentage;

            GPoint p = (GPoint)e.UserState;
            lblInfo.Text = "Marcador de mapa estático: Descargando [ " + p + " ]: " + tileArea.IndexOf(p) + " de " + tileArea.Count;
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (e.Error != null)
                    MessageBox.Show(this, e.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (e.Result != null)
                {
                    try
                    {
                        this.FullPathMap = e.Result as string;
                        this.DialogResult = File.Exists(FullPathMap) ? System.Windows.Forms.DialogResult.Yes : System.Windows.Forms.DialogResult.No;
                    }
                    catch
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bg.IsBusy)
                bg.CancelAsync();
        }       

        private void gMapStaticImageGenerate_Shown(object sender, EventArgs e)
        {
            generate();
        }

    }
}
