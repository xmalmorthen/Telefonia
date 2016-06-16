using CellTrack.Controllers.RegistrosControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models.Registros
{
    public class IFEModel
    {
        public string clave { get; set; }
        public string nombre { get; set; }

        private string _fnac;
        public string fnac
        {
            get {
                string[] format = { "yyyyMMdd" };
                DateTime date;
                if (DateTime.TryParseExact(_fnac,
                                           format,
                                           System.Globalization.CultureInfo.InvariantCulture,
                                           System.Globalization.DateTimeStyles.None,
                                           out date))
                    return date.ToShortDateString();
                else
                    return string.Empty;
            }
            set { _fnac = value; }
        }

        public string calle { get; set; }
        public string numext { get; set; }
        public string numint { get; set; }
        public string colonia { get; set; }
        public string codpos { get; set; }
        public string nmpio { get; set; }
        
        private string _entidad;
        public string entidad
        {
          get { return entidadesController.getEntidades.SingleOrDefault(qry => qry.nument.Equals(_entidad)).noment.ToString().ToUpper(); }
          set { _entidad = value; }
        }
        
    }
}
