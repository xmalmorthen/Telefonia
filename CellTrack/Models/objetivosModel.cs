using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models
{
    public class objetivosModel
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string asunto;

        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }
        private string objetivo;

        public string Objetivo
        {
            get { return objetivo; }
            set { objetivo = value; }
        }
        private string carrier;

        public string Carrier
        {
            get { return carrier; }
            set { carrier = value; }
        }
        private string agenda;

        public string Agenda
        {
            get { return agenda; }
            set { agenda = value; }
        }
        private string frecuencia;

        public string Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }
    }
}
