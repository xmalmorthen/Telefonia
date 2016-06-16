using CellTrack.Models.DataBases;
using CellTrack.Models.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers.RegistrosControllers
{
    public static class IFEController
    {
        private static bdRegistrosEntities bd = new bdRegistrosEntities();

        public static List<IFEModel> find(string idEntidad, List<string> searchFields, string cad, Boolean exacta)
        {
            string qry = @"
(
SELECT
    clave,
    CONCAT_WS(' ',nombre,paterno,materno) nombre,
    fnac,
    calle,
    numext,
    numint,
    colonia,
    codpos,
    nmpio,
    entidad
FROM
    ife{0}
WHERE
    {1}
)";
            string preFab = exacta ? string.Format(@"= '{0}'",cad) : string.Format(@"LIKE '%{0}%'",cad);
            string where = string.Empty;
            foreach (string item in searchFields)
	        {
		        switch (item.ToLower())
	            {
                    case "nombre":
                        where += string.Format (@"CONCAT_WS(' ',nombre,paterno,materno) {0}",preFab);
                    break;
                    case "clave":
                        where += string.Format (@"{0} clave {1}",!string.IsNullOrEmpty(where) ? " AND " : string.Empty,preFab);
                    break;
                    case "calle":
                        where += string.Format (@"{0} CONCAT_WS(' ',calle,numext,numint) {1}",!string.IsNullOrEmpty(where) ? " AND " : string.Empty,preFab);
                    break;
                    case "cp":
                        where += string.Format (@"{0} codpos {1}",!string.IsNullOrEmpty(where) ? " AND " : string.Empty,preFab);
                    break;
	            }
	        }

            if (idEntidad.Equals("00"))
            {
                string preQryFab = string.Empty;
                for (int i = 1; i <= 32; i++)
                {
                    preQryFab += string.Format(qry, i.ToString("00"), where);
                    preQryFab += i < 32 ? " UNION " : string.Empty;
                }
                qry = preQryFab;
            }
            else
            {
                qry = string.Format(qry, idEntidad.Equals("00") ? string.Empty : idEntidad, where);
            }

            List<IFEModel> data = null;
            try
            {
                data = bd.Database.SqlQuery<IFEModel>(qry).ToList();
            }
            catch (Exception ex)
            {
                
            }
            return data;
        }

    }
}
