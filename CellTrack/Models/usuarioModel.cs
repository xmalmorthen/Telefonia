using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class usuarioModel
    {
        public int id { get; set; }
        public string NombreCompleto { get; set; }
        public string usuario { get; set; }
        public string Perfil { get; set; }
        public string Grupo { get; set; }
        public string esSupervisor { get; set; }
        public string active { get; set; }
        public string cantidadLocalizaciones { get; set; }
        public string fIns { get; set; }
        public string fAct { get; set; }
    }
}
