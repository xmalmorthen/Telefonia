using CellTrack.Models.DataBases;
using CellTrack.Models.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers.RegistrosControllers
{
    public static class entidadesController
    {
        private static bdRegistrosEntities bd = new bdRegistrosEntities();

        private static List<entidadesModel> entidades;

        public static List<entidadesModel> getEntidades {get {
            if (entidades == null)
                entidades = bd.Database.SqlQuery<entidadesModel>("select nument,noment from entidades").ToList();

            return entidades;
        }}
    }
}
