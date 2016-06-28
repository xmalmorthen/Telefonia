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
                string message = null;
                //if (sshCmds.PDU(item, out message))
                {
                    mapdu target = new mapdu();
                    desmsrecibidos smsInfo = new desmsrecibidos();

                    message = "+CMGL: 2,\"REC UNREAD\",\"3121220995\",,\"16/06/27,15:58:52-20\",33042013030FC3";

                    string[] dataParts = message.Split(',');

                    smsInfo.LAC = dataParts[dataParts.Length - 1].Substring(dataParts[dataParts.Length - 1].Length - 8, 4);
                    smsInfo.BTS = dataParts[dataParts.Length - 1].Substring(dataParts[dataParts.Length - 1].Length - 4, 4);


                    smsInfo.LAC = ((4096 * int.Parse(smsInfo.LAC[0].ToString())) + (256 * int.Parse(smsInfo.LAC[1].ToString())) + (16 * int.Parse(smsInfo.LAC[2].ToString())) + int.Parse(smsInfo.LAC[3].ToString())).ToString();
                    smsInfo.BTS = ((4096 * int.Parse(smsInfo.BTS[0].ToString())) + (256 * int.Parse(smsInfo.BTS[1].ToString())) + (16 * int.Parse(smsInfo.BTS[2].ToString())) + int.Parse(smsInfo.BTS[3].ToString())).ToString();

                    string qry = string.Format(@"select * from bts where lac={1} LIMIT 1", smsInfo.LAC);


                    if ()
                    string responseMessage = string.Empty;
                    btsController.getApiGeoReference(controller, double.Parse(smsInfo.BTS), double.Parse(smsInfo.LAC), 334, 20, out responseMessage);



                    /*
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
                     */
 

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

        private static sshCnn ssh;
        private static class sshCmds
        {
            public static Boolean PDU(PDUModel item, out string message)
            {
                Boolean result = false;
                message = null;
                
                if (Program.SshCnn.TryGetValue("PDU", out ssh));
                try
                {
                    string num = item.obj.objetivo;
                    string objetivo = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",num[1],num[0],num[3],num[2],num[5],num[4],num[7],num[6],num[9],num[8]);
                    string cmnd = string.Format("PDU.sh {0} {1}",objetivo,(char)26);
                    ssh.script(cmnd);

                    short iter = 0;
                    do
                    {
                        message = checkSMS(item.obj.objetivo);
                        iter++;
                    } while (string.IsNullOrEmpty(message) && iter < 3 );

                    result = !string.IsNullOrEmpty(message);

                    borraSMS();
                }
                catch (Exception ex)
                {
                    exceptionHandlerCatch.registerLogException(ex);
                }                
                return result;
            }

            private static string checkSMS(string objetivo) {
                string returnResult = string.Empty;
                string cmnd = string.Format("checksms0.sh");
                StringBuilder output = ssh.script(cmnd);
                if (output != null)
                    using (StringReader reader = new StringReader(output.ToString()))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                            if (line.Contains("+CMGL:") && line.Contains(objetivo))
                            {
                                reader.ReadLine();
                                string datapos = reader.ReadLine();
                                returnResult = string.Format("{0},{1}", line, datapos);
                            }
                    }
                return returnResult;
            }

            private static void borraSMS() {
                string cmnd = string.Format("borra0.sh");
                ssh.script(cmnd);
            }
        }
    }
}
