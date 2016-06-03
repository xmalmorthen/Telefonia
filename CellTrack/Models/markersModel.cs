using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class markersModel
    {
        private double lat;
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        private double lng;
        public double Lng
        {
            get { return lng; }
            set { lng = value; }
        }

        private string desc;
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public markersModel() { 
        }

        public markersModel(double lat, double lng, string desc) {
            Lat = lat;
            Lng = lng;
            Desc = desc;
        }

    }
}
