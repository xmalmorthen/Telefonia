using Duplicator.Models;
using Duplicator.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicator.Controllers
{
    static class duplicatorController
    {
        private static Random rnd = new Random();
        private static DBDuplicatorDataContext dbDuplicator = new DBDuplicatorDataContext();

        public static List<duplicatorModel> duplicatorList(int idUser)
        {
            List<reUsersDuplicators> re = dbDuplicator.GetTable<reUsersDuplicators>().Where(qry => qry.active == true && qry.idUser == idUser && qry.maDuplicator.active == true).ToList();
            List<duplicatorModel> List = new List<duplicatorModel>();

            int cont = 1;
            foreach (reUsersDuplicators item in re)
            {
                List.Add(new duplicatorModel()
                {
                    Id = cont.ToString(),
                    Number = item.maDuplicator.number,
                    Carrier = item.maDuplicator.carrier,
                    Country = item.maDuplicator.country
                });
                cont++;
            }


            /*for (int i = 0; i < rnd.Next(10); i++)
            {
                string Carrier = string.Empty;

                switch (rnd.Next(1, 3))
                {
                    case 1:
                        Carrier = "IUSACELL";
                        break;
                    case 2:
                        Carrier = "MOVISTAR";
                        break;
                    case 3:
                        Carrier = "TELCEL";
                        break;
                    default:
                        Carrier = "TELCEL";
                        break;
                }

                List.Add(new duplicatorModel()
                {
                    Id = string.Format("{0:00}", i),
                    Number = string.Format("33{0:00000000}", rnd.Next(99999999)),
                    Carrier = Carrier,
                    Country = "MEXICO"
                });
            }*/

            return List;
        }


    }
}
