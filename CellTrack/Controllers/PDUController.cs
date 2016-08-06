using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using GMap.NET;
using GMap.NET.WindowsForms;
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

        public static markersModel PDUFind(PDUModel item, gMapController controller, Boolean onlyCheckSMS = false, MarkerEnter OnMarkerEnter = null, MarkerLeave OnMarkerLeave = null)
        {
            markersModel marker = null;

            mapdu target = new mapdu();
            target.tipo = "GPS/IMEI";
            target.idLocalizations = item.obj.id;
            target.fIns = DateTime.Now;
            target.toNotify = true;

            Boolean finded = false;
            try
            {
                string message = null;
                finded = sshCmds.PDU(item, out message, onlyCheckSMS);
                if (finded)
                {
                    
                    desmsrecibidos smsInfo = new desmsrecibidos();
                    List<desmsrecibidos> smsInfoList = new List<desmsrecibidos>();

                    target.toNotify = false;
                    target.desmsrecibidos = smsInfoList;

                    //Respuestas de prueba
                    //LTE
                    //message = "+CMGL: 2,\"REC UNREAD\",\"3121220995\",,\"16/06/27,15:58:52-20\",33042013030FC3";
                    //UMTS
                    //message = "+CMGL: 2,\"REC UNREAD\",\"3121329762\",,\"16/06/30,10:34:54-20\",330420792B9AF8";
                    //Respuestas longitud larga                    
                    //message = "+CMGL: 3,\"REC READ\",\"6643345656\",,\"16/06/12,20:38:32-20\",07330420794469F50BE4";

                    string[] dataParts = message.Split(',');

                    if (dataParts[dataParts.Length - 1].Length == 14)
                    {
                        smsInfo.LAC = dataParts[dataParts.Length - 1].Substring(dataParts[dataParts.Length - 1].Length - 8, 4);
                        smsInfo.BTS = dataParts[dataParts.Length - 1].Substring(dataParts[dataParts.Length - 1].Length - 4, 4);
                    }
                    else if (dataParts[dataParts.Length - 1].Length == 20) {
                        smsInfo.LAC = dataParts[dataParts.Length - 1].Substring(dataParts[dataParts.Length - 1].Length - 12, 4);
                        smsInfo.BTS = dataParts[dataParts.Length - 1].Substring(dataParts[dataParts.Length - 1].Length - 8, 4);
                    }

                    if (string.IsNullOrEmpty(smsInfo.LAC)) throw new NullReferenceException(string.Format("Error al obtener el LAC y BTS de la cadena [ {0} ] ", message));

                    smsInfo.LAC = Convert.ToInt32(smsInfo.LAC.ToString(), 16).ToString();
                    smsInfo.BTS = Convert.ToInt32(smsInfo.BTS.ToString(), 16).ToString();

                    //smsInfo.LAC = ((4096 * smsInfo.LAC[0]) + (256 * smsInfo.LAC[1]) + (16 * smsInfo.LAC[2]) + smsInfo.LAC[3]).ToString();
                    //smsInfo.BTS = ((4096 * smsInfo.BTS[0]) + (256 * smsInfo.BTS[1]) + (16 * smsInfo.BTS[2]) + smsInfo.BTS[3]).ToString();

                    string qry = string.Format(@"select radio,mcc,mnc,lac,cellid,rnc,enbi from bts where lac={0} LIMIT 1", smsInfo.LAC);
                    bdRegistrosEntities bd = new bdRegistrosEntities();
                    
                    bd.Database.CommandTimeout = 0;
                    BTSDataBaseModel data = bd.Database.SqlQuery<BTSDataBaseModel>(qry).SingleOrDefault();
                    if (data == null) throw new NullReferenceException(String.Format("LAC no encontrada en tabla bts [ {0} ]", smsInfo.LAC));

                    smsInfo.radio = data.radio;
                    smsInfo.MCC = data.mcc;
                    smsInfo.MNC = data.mnc;                        

                    string responseMessage = string.Empty;
                    btsModel model = null;
                    Boolean geoRef = false;
                    switch (data.radio)
                    {
                        case "GSM":
                            geoRef = btsController.getApiGeoReference(controller, double.Parse(smsInfo.BTS), double.Parse(smsInfo.LAC), double.Parse(smsInfo.MCC), double.Parse(smsInfo.MNC), out responseMessage, out model, false);
                        break;
                        case "UMTS":
                            smsInfo.BTS = ((Convert.ToInt32(data.rnc) * 65536) + Convert.ToInt32(smsInfo.BTS)).ToString();
                            //smsInfo.BTS = data.cellid;
                            geoRef = btsController.getApiGeoReference(controller, double.Parse(smsInfo.BTS), double.Parse(smsInfo.LAC), double.Parse(smsInfo.MCC), double.Parse(smsInfo.MNC), out responseMessage, out model, false);
                        break;
                        case "LTE":
                            qry = string.Format(@"select radio,mcc,mnc,lac,cellid,rnc,enbi from bts where lac={0} && cid={1} order by cellid,rnc", smsInfo.LAC, smsInfo.BTS);
                            List<BTSDataBaseModel> dataList = bd.Database.SqlQuery<BTSDataBaseModel>(qry).ToList();
                            if (dataList == null) throw new NullReferenceException(String.Format("LAC y CID no encontrada en tabla bts [ {0}, {1} ]", smsInfo.LAC,smsInfo.BTS));

                            List<btsModel> modelsLTE = new List<btsModel>();
                            btsModel itemModel = null;

                            foreach (BTSDataBaseModel reg in dataList)
                                if (btsController.getApiGeoReference(controller, double.Parse(reg.cellid), double.Parse(reg.lac), double.Parse(reg.mcc), double.Parse(reg.mnc), out responseMessage, out itemModel, false))
                                    modelsLTE.Add(itemModel);

                            if (controller != null)
                            {
                                controller.MarkersOverlays.Clear();
                                controller.TriangulationsOverlays.Clear();
                                controller.MainMap.Overlays.Clear();
                            }

                            List<PointLatLng> points = new List<PointLatLng>();

                            int iter = 1;
                            int group = 1;

                            Random randomGen = new Random();
                            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                            foreach (btsModel reg in modelsLTE)
                            {
                                Color fill = Color.Green, stroke = Color.Green;

                                if (group == 1 && iter == 1){
                                    fill = Color.Green;
                                    stroke = Color.Green;
                                } else if (iter == 1) {
                                    KnownColor randomColorName = names[randomGen.Next(names.Length)];
                                    fill = stroke = Color.FromKnownColor(randomColorName);
                                }

                                desmsrecibidos detalle = new desmsrecibidos()
                                {
                                    radio = data.radio,
                                    MCC = reg.mcc.ToString(),
                                    MNC = reg.mnc.ToString(),
                                    LAC = reg.lac.ToString(),
                                    BTS = reg.cellid.ToString(),
                                    V = reg.cellid.ToString().Trim().Length == 4 ? "0" : reg.cellid.ToString().Trim()[0].ToString(),
                                    LAT = reg.lat,
                                    LNG = reg.lng
                                };

                                marker = new markersModel(reg.lat, reg.lng, item.descrip, detalle);

                                if (controller != null)
                                {
                                    controller.MainMap.OnMarkerEnter += OnMarkerEnter;
                                    controller.MainMap.OnMarkerLeave += OnMarkerLeave;

                                    controller.CreateCircle(new System.Drawing.PointF((float)reg.lat, (float)reg.lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(stroke, 2));
                                    controller.AddMarker(marker, GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver);
                                }

                                points.Add(new PointLatLng(reg.lat,reg.lng));

                                if (iter == 3)
                                {
                                    if (controller != null)                                  
                                        controller.CreateTriangulation(points, fill, stroke);                                   
                                    points.Clear();
                                }

                                group = iter == 3 ? group + 1 : group;
                                iter = iter < 3 ? iter + 1 : 1;
                                
                                smsInfoList.Add(detalle);
                            }

                            if (!onlyCheckSMS)
                            {
                                DAL.Db.mapdu.Add(target);
                                DAL.Db.SaveChanges();
                            }
                            else if (finded)
                            {
                                mapdu reg = DAL.Db.mapdu.FirstOrDefault(qrySel => qrySel.id.Equals(item.id));
                                reg.toNotify = false;
                                reg.desmsrecibidos = target.desmsrecibidos;
                                DAL.Db.SaveChanges();
                            }
                        return marker;
                    }

                    if (!geoRef) throw new NullReferenceException(String.Format("No se pudo geolocalizar por medio del api de google [ CellId: {0}, LAC: {1}, MCC: {2}, MNC: {3} ], mensaje recibido del API: {4}", smsInfo.BTS, smsInfo.LAC, smsInfo.MCC, smsInfo.MNC, responseMessage));
                    smsInfo.LAT = model.lat;
                    smsInfo.LNG = model.lng;

                    smsInfo.V = smsInfo.BTS.Trim().Length == 4 ? "0" : smsInfo.BTS.Trim()[0].ToString();

                    smsInfoList.Add(smsInfo);

                    marker = new markersModel(smsInfo.LAT.Value, smsInfo.LNG.Value, item.descrip, smsInfo);

                    if (controller != null)
                    {
                        controller.MainMap.OnMarkerEnter += OnMarkerEnter;
                        controller.MainMap.OnMarkerLeave += OnMarkerLeave;

                        controller.MarkersOverlays.Clear();
                        controller.TriangulationsOverlays.Clear();
                        controller.MainMap.Overlays.Clear();

                        controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(Color.DarkRed, 2));
                        controller.AddMarker(marker, GMap.NET.WindowsForms.MarkerTooltipMode.Always);                        
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
                return null;
            }

            if (!onlyCheckSMS)
            {
                DAL.Db.mapdu.Add(target);
                DAL.Db.SaveChanges();
            }
            else if (finded)
            {
                mapdu reg = DAL.Db.mapdu.FirstOrDefault(qrySel => qrySel.id.Equals(item.id));
                reg.toNotify = false;
                reg.desmsrecibidos = target.desmsrecibidos;
                DAL.Db.SaveChanges();
            }

            return marker;
        }

        private static sshCnn ssh;
        private static class sshCmds
        {
            public static Boolean PDU(PDUModel item, out string message, Boolean onlyCheckSMS)
            {
                Boolean result = false;
                message = null;
                
                if (Program.SshCnn.TryGetValue("PDU", out ssh));
                try
                {
                    if (!onlyCheckSMS)
                    {
                        string num = item.obj.objetivo;
                        string objetivo = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", num[1], num[0], num[3], num[2], num[5], num[4], num[7], num[6], num[9], num[8]);
                        string cmnd = string.Format("PDU.sh {0}", objetivo);

                        while (!modemStatus.Free)
                        {
                            Thread.Sleep(1000);
                        }

                        modemStatus.Occupied();
                        ssh.script(cmnd);
                        modemStatus.Vacant();
                    }

                    short iter = 0;
                    do
                    {                        
                        message = checkSMS(item.obj.objetivo);

                        if (string.IsNullOrEmpty(message) && iter < 5) Thread.Sleep(Properties.Settings.Default.PDUWaith);

                        iter++;
                    } while (string.IsNullOrEmpty(message) && iter < 5 );

                    result = !string.IsNullOrEmpty(message);                    
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

                while (!modemStatus.Free)
                {
                    Thread.Sleep(1000);
                }

                modemStatus.Occupied();
                StringBuilder output = ssh.script(cmnd);
                modemStatus.Vacant();
                if (output != null)
                    using (StringReader reader = new StringReader(output.ToString()))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("+CMGL:") && line.Contains(objetivo))
                            {
                                string memory = line.Split(',')[0].Split(':')[1].Trim();
                                reader.ReadLine();
                                string datapos = reader.ReadLine();
                                returnResult = string.Format("{0},{1}", line, datapos);

                                int mem;
                                if (int.TryParse(memory,out mem)) 
                                    borraSMS(int.Parse(memory));

                                break;
                            }
                        }
                    }
                return returnResult;
            }

            private static void borraSMS(int memory) {
                string cmnd = string.Format("borraMemEspecifica.sh {0}",memory);
                ssh.script(cmnd);
            }
        }
    }
}
