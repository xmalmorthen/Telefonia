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

        private object tag;
        public object Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public markersModel() { 
        }

        public markersModel(double lat, double lng, string desc, object tag)
        {
            Lat = lat;
            Lng = lng;
            Desc = desc;
            Tag = tag;
        }

        public markersModel(double lat, double lng, string desc) {
            Lat = lat;
            Lng = lng;
            Desc = desc;
            Tag = null;
        }

    }
}
