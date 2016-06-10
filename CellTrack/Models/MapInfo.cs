using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public struct MapInfo
    {
        public RectLatLng Area;
        public int Zoom;
        public GMapProvider Type;
        public bool MakeWorldFile;
        public bool MakeKmz;

        public MapInfo(RectLatLng Area, int Zoom, GMapProvider Type, bool makeWorldFile, bool MakeKmz)
        {
            this.Area = Area;
            this.Zoom = Zoom;
            this.Type = Type;
            this.MakeWorldFile = makeWorldFile;
            this.MakeKmz = MakeKmz;
        }
    }
}
