using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class recibidosModel
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string fIns { get; set; }
        public string nombre { get; set; }
        public string asunto { get; set; }
        public string objetivo { get; set; }
        public string Carrier { get; set; }
        public List<detalleRecibidosModel> detalle { get; set; }
    }

    public class detalleRecibidosModel {
        public int id { get; set; }
        public string radio { get; set; }
        public string MCC { get; set; }
        public string MNC { get; set; }
        public string LAC { get; set; }
        public string BTS { get; set; }
        public string V { get; set; }
        public string LAT { get; set; }
        public string LNG { get; set; }
    }
}
