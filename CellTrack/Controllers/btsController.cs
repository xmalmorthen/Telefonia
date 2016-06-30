using CellTrack.Classes;
using CellTrack.Models;
using CellTrack.Models.DataBases;
using CellTrack.Views;
using GMap.NET.WindowsForms;
using Microsoft.Reporting.WinForms;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace CellTrack.Controllers
{
    public static class btsController
    {
        private static Boolean _get(gMapController controller, double cellid, double lac, double mcc, double mnc, out string message, out btsModel model, Boolean putMarker)
        {
            Boolean returnResult = false;
            message = string.Empty;
            model = null;

            string body = @"{'cellTowers':[{'cellId':" + cellid + ",'locationAreaCode':" + lac + ",'mobileCountryCode':" + mcc + ",'mobileNetworkCode':" + mnc + "}]}";

            var client = new RestClient("https://www.googleapis.com/");
            var request = new RestRequest("geolocation/v1/geolocate?key={key}", Method.POST);
            request.AddUrlSegment("key", Properties.Settings.Default.GoogleApiKey);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            RestResponse<googleGeolocApiModel> response = client.Execute<googleGeolocApiModel>(request) as RestResponse<googleGeolocApiModel>;

            if (response.Data.error != null)
            {
                switch (response.Data.error.code)
                {
                    case 403:
                        message = "Límite de solicitudes continuas o diarias excedidas.";
                        break;
                    case 400:
                        message = "Formato mal construido.";
                        break;
                    case 404:
                        message = "Sin resultados de respuesta.";
                        break;
                }
            }
            else
            {
                model = new btsModel()
                {
                    cellid = cellid,
                    lac = lac,
                    mcc = mcc,
                    mnc = mnc,
                    lat = response.Data.location.lat,
                    lng = response.Data.location.lng,
                    accuracy = response.Data.accuracy
                };
                returnResult = true;

                if (putMarker)
                {
                    setMarker(model, controller);
                    controller.centerInMarkers();
                }
            }

            return returnResult;
        }

        public static Boolean getApiGeoReference(gMapController controller, double cellid, double lac, double mcc, double mnc, out string message, out btsModel model, Boolean putMarker = true)
        {
            return _get(controller, cellid, lac, mcc, mnc, out message, out model, putMarker);
        }

        public static Boolean getApiGeoReference(gMapController controller, double cellid, double lac, double mcc, double mnc, out string message, Boolean putMarker = true)
        {
            btsModel model = null;
            return _get(controller, cellid, lac, mcc, mnc, out message, out model, putMarker);
        }

        private static markersModel setMarker(btsModel model, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                marker = new markersModel(model.lat,
                                          model.lng,
                                          string.Format("CELLID: {0}{1}LAC: {2}{3}MCC: {4}{5}MNC: {6}{7}LAT: {8} - LNG: {9}", 
                                                    model.cellid,
                                                    Environment.NewLine,
                                                    model.lac,
                                                    Environment.NewLine,
                                                    model.mcc, 
                                                    Environment.NewLine,
                                                    model.mnc,
                                                    Environment.NewLine,
                                                    model.lat, 
                                                    model.lng
                                                    ));
                controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat, (float)marker.Lng), Properties.Settings.Default.mapRadioCircle, Properties.Settings.Default.mapSegments, new Pen(Color.DarkRed, 2));
                controller.AddMarker(marker, MarkerTooltipMode.Always);
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return marker;
        }
        
    }
}
