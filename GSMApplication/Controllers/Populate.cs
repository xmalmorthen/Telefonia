using GSMApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Controllers
{
    static class Populate
    {
        private static Random rnd = new Random();

        public static List<CellsModel> Cells() {
            List<CellsModel> List = new List<CellsModel>();

            for (int i = 0; i < rnd.Next(500); i++)
            {
                string Provider = string.Empty;

                switch (rnd.Next(1,3))
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

                List.Add(new CellsModel()
                {
                    Id = string.Format("{0:00}", rnd.Next(99)),
                    ARFCN = string.Format("{0:000}", rnd.Next(999)),
                    CellId = string.Format("{0:00000}", rnd.Next(99999)),
                    Band = (rnd.Next(100) % 2 == 0) ? "GSM850" : "PCS1900",
                    RxLevel = string.Format("{0:00} dBm", rnd.Next(99)),
                    LAC = string.Format("{0:00000}", rnd.Next(99999)),
                    MCC = string.Format("{0:000}", rnd.Next(999)),
                    MNC = string.Format("{0:00}", rnd.Next(99)),
                    Provider = Provider,
                    Comment = string.Empty
                });
            }
            return List;
        }

        public static List<TMSICatcher> TMSICatcher()
        {
            List<TMSICatcher> List = new List<TMSICatcher>();

            for (int i = 0; i < rnd.Next(500); i++)
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

                string LastAction = string.Empty;
                switch (rnd.Next(1, 3))
                {
                    case 1:
                        LastAction = "LocationUpdate";
                        break;
                    case 2:
                        LastAction = "PagingResponse";
                        break;
                    case 3:
                        LastAction = "CmServiceRequest";
                        break;
                    default:
                        LastAction = "LocationUpdate";
                        break;
                }

                List.Add(new TMSICatcher()
                {
                    Identity = string.Format("{0:000000000}", rnd.Next(999999999)),
                    RxLevel = string.Format("-{0:000} dBm", rnd.Next(999)),
                    ARFCN = string.Format("{0:000}", rnd.Next(999)),
                    Provider = Provider,
                    LastAction = LastAction,
                    Activ = string.Format("{0:0}", rnd.Next(0,1)),
                    Time = DateTime.Now.ToString()
                });
            }
            return List;
        }

        public static List<DecryptedTraffic> DecryptedTraffic()
        {
            List<DecryptedTraffic> List = new List<DecryptedTraffic>();

            for (int i = 0; i < rnd.Next(500); i++)
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

                List.Add(new DecryptedTraffic()
                {
                    Name = "Unknown",
                    Time = DateTime.Now.ToString(),
                    From = string.Format("{0:000000000}", rnd.Next(999999999)),
                    To   = string.Format("{0:000000000}", rnd.Next(999999999)),
                    ARFCN = string.Format("{0:000}", rnd.Next(999)),
                    Provider = Provider,
                    Img = global::GSMApplication.Properties.Resources._1459393936_081_Pen,
                    Context = "Texto ---"                    
                });
            }
            return List;
        }

    }
}
