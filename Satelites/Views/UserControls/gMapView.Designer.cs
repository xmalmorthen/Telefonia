namespace Satelites.Views.UserControls
{
    partial class gMapView
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zoomTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.cmbMapsType = new MetroFramework.Controls.MetroComboBox();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.zoomTrackBar.Location = new System.Drawing.Point(887, 676);
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(275, 23);
            this.zoomTrackBar.TabIndex = 40;
            this.zoomTrackBar.Text = "metroTrackBar1";
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // cmbMapsType
            // 
            this.cmbMapsType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMapsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMapsType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbMapsType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cmbMapsType.FormattingEnabled = true;
            this.cmbMapsType.ItemHeight = 19;
            this.cmbMapsType.Location = new System.Drawing.Point(887, 3);
            this.cmbMapsType.Name = "cmbMapsType";
            this.cmbMapsType.Size = new System.Drawing.Size(275, 25);
            this.cmbMapsType.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbMapsType.TabIndex = 39;
            this.cmbMapsType.UseSelectable = true;
            this.cmbMapsType.UseStyleColors = true;
            this.cmbMapsType.DropDownClosed += new System.EventHandler(this.cmbMapsType_DropDownClosed);
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.AliceBlue;
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 17;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(1165, 702);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 0D;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // gMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.zoomTrackBar);
            this.Controls.Add(this.cmbMapsType);
            this.Controls.Add(this.MainMap);
            this.Name = "gMapView";
            this.Size = new System.Drawing.Size(1165, 702);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        internal GMap.NET.WindowsForms.GMapControl MainMap;
        private MetroFramework.Controls.MetroComboBox cmbMapsType;
        private MetroFramework.Controls.MetroTrackBar zoomTrackBar;
    }
}
