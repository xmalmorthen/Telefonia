using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class localizationsModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string asunto { get; set; }
        public string objetivo { get; set; }
        public int idNotification { get; set; }
        public string NotificationName { get; set; }
        public int idCarrier { get; set; }
        public string Carrier { get; set; }
        public string Agenda { get; set; }
        public Nullable<short> agendaDe { get; set; }
        public Nullable<short> agendaA { get; set; }
        public Nullable<short> agendaFrecuencia { get; set; }
    }
}
