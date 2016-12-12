using GMap.NET;
using Satelites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satelites.Controllers
{
    static class Populate
    {
        private static Random rnd = new Random();

        public static IOrderedEnumerable<cellsModel> Cells(int antenas)
        {
            List<cellsModel> List = new List<cellsModel>();

            for (int i = 0; i < rnd.Next(100,800); i++)
            {
                string Provider = string.Empty;

                switch (rnd.Next(1, 3))
                {
                    case 1:
                        Provider = "Iusacell";
                        break;
                    case 2:
                        Provider = "Movistar";
                        break;
                    case 3:
                        Provider = "Telcel";
                        break;
                    default:
                        Provider = "Telcel";
                        break;
                }

                List.Add(new cellsModel()
                {
                    Id = string.Format("Antena {0:00}", rnd.Next(1,antenas+1)),
                    ARFCN = string.Format("{0:000}", rnd.Next(999)),
                    CellId = string.Format("{0:00000}", rnd.Next(99999)),
                    Band = (rnd.Next(100) % 2 == 0) ? "GSM850" : "PCS1900",
                    RxLevel = string.Format("{0:00} dBm", rnd.Next(99)),
                    LAC = string.Format("{0:00000}", rnd.Next(99999)),
                    MCC = string.Format("{0:000}", rnd.Next(999)),
                    MNC = string.Format("{0:00}", rnd.Next(99)),
                    Provider = Provider,
                    IMEI = string.Empty
                });
            }
            return List.OrderBy(ob => ob.Id);
        }

        public static List<PointLatLng> MapMarkerModel(PointLatLng position, int radius)
        {
            double x0, y0;
            List<PointLatLng> List = new List<PointLatLng>();
            Random rng = new Random();

            x0= position.Lng;
            y0 = position.Lat;
            double radiusInDegrees = radius / 111000f;

            for (int i = 0; i < rnd.Next(5, 10); i++)
            {
                double u = rng.NextDouble();
                double v = rng.NextDouble();
                double w = radiusInDegrees * Math.Sqrt(u);
                double t = 2 * Math.PI * v;
                double x = w * Math.Cos(t);
                double y = w * Math.Sin(t);

                // Adjust the x-coordinate for the shrinking of the east-west distances
                double new_x = x / Math.Cos(y0);

                double foundLongitude = new_x + x0;
                double foundLatitude = y + y0;

                PointLatLng pos = new PointLatLng(foundLatitude, foundLongitude);
                List.Add(pos);
            }

            return List;
        }
    }
}
