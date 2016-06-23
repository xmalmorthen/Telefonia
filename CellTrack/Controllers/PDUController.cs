using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class PDUController
    {
        public static markersModel PDUFind(PDUModel item, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                string message = string.Empty;
                if (sshCmds.PDU(item, out message)) { 
                    // TODO: Leer respuesta y llenar modelo maPDU

                    //SIMULACIÓN DE MODELO
                    // TODO: Eliminar al implementar
                    Random rng = new Random();

                    int lat = rng.Next(516400146, 630304598);
                    int lon = rng.Next(224464416, 341194152);
                
                    mapdu target = new mapdu()
                    {
                        tipo = "GPS/IMEI",
                        idLocalizations = item.obj.id,
                        fIns = DateTime.Now,
                        toNotify = rng.NextDouble() < 50 / 100.0,
                        desmsrecibidos = new desmsrecibidos()
                        {
                            radio = "LTE",
                            MCC = "334",
                            MNC = "20",
                            LAC = "5146",
                            BTS = "9135",
                            V = "0",
                            LAT = 20d + lat / 1000000000d,
                            LNG = -103d - lon / 1000000000d
                        }
                    };

                    DAL.Db.mapdu.Add(target);
                    DAL.Db.SaveChanges();

                    if (!target.toNotify)
                    {
                        marker = new markersModel(target.desmsrecibidos.LAT.Value, target.desmsrecibidos.LNG.Value, item.descrip);

                        controller.MarkersOverlays.Clear();
                        controller.TriangulationsOverlays.Clear();
                        controller.MainMap.Overlays.Clear();

                        controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(Color.DarkRed, 2));
                        controller.AddMarker(marker);
                        controller.setPosition(marker);
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return marker;
        }


        private static class sshCmds
        {
            public static Boolean PDU(PDUModel item, out string message)
            {
                Boolean result = false;
                message = string.Empty;
                
                sshCnn ssh;
                if (Program.SshCnn.TryGetValue("PDU", out ssh));
                try
                {
                    string num = item.obj.objetivo;
                    string objetivo = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",num[1],num[0],num[3],num[2],num[5],num[4],num[7],num[6],num[9],num[8]);
                    string cmnd = string.Format("PDU.sh {0} {1}",objetivo,(char)26);

                    StringBuilder output = ssh.script(cmnd);
                    if (output != null)
                    {
                        result = output.ToString().Trim().Length > 0;
                        message = output.ToString();    
                    }
                }
                catch (Exception ex)
                {
                    exceptionHandlerCatch.registerLogException(ex);
                }
                
                return result;
            }
        }
    }
}
