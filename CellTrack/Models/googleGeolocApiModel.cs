using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class googleGeolocApiModel
    {
        public LocationApiResponse location { get; set; }
        public double accuracy { get; set; }
        public ErrorApiResponse error {get;  set;}
    }

    public class LocationApiResponse {
        public double lat { get; set; }
        public double lng { get; set; }    
    }

    public class ErrorApiResponse {
        List<ErrorsApiResponse> errors {get; set;}
        public int code {get; set;}
        public string message {get; set;}
    }

    public class ErrorsApiResponse {
        public string domain {get; set;}
        public string reason {get; set;}
        public string message {get; set;}
    }

}
