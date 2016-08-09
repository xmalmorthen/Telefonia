using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLR.Classes
{
    public class googleGeolocApiModel
    {
        public LocationApiResponse location { get; set; }
        public double accuracy { get; set; }
        public ErrorApiResponse error { get; set; }
    }

    public class LocationApiResponse
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class ErrorApiResponse
    {
        List<ErrorsApiResponse> errors { get; set; }
        public int code { get; set; }
        public string message { get; set; }
    }

    public class ErrorsApiResponse
    {
        public string domain { get; set; }
        public string reason { get; set; }
        public string message { get; set; }
    }

    class googleApiGeoReference
    {
        public googleGeolocApiModel invoque(double cellid, double lac, double mcc, double mnc, out string message)
        {
            googleGeolocApiModel returnResult = null;
            message = string.Empty;

            string body = @"{'cellTowers':[{'cellId':" + cellid + ",'locationAreaCode':" + lac + ",'mobileCountryCode':" + mcc + ",'mobileNetworkCode':" + mnc + "}]}";

            var client = new RestClient(Properties.Settings.Default.GoogleApi);
            var request = new RestRequest(Properties.Settings.Default.GoogleApiRequest, Method.POST);
            request.AddUrlSegment("key", Properties.Settings.Default.GoogleApiKey);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            try
            {
                RestResponse<googleGeolocApiModel> response = client.Execute<googleGeolocApiModel>(request) as RestResponse<googleGeolocApiModel>;
                if (response.Data.error != null)
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
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
                throw;
            }

            return returnResult;
        }
    }
}
