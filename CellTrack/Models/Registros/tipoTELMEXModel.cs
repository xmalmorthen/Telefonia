using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Models.Registros
{    

    public class tipoTELMEXModel
    {
        public string key { get; set; }
        public string value { get; set; }

        public static List<tipoTELMEXModel> populate
        {
            get
            {
                return new List<tipoTELMEXModel>() {
                    new tipoTELMEXModel() {
                    key = "telbca",
                    value =  "PÁGINAS BLANCAS"
                    },
                    new tipoTELMEXModel() {
                    key = "telpriv",
                    value =  "PRIVADOS"
                    },
                    new tipoTELMEXModel() {
                    key = "telcas",
                    value =  "CASETAS"
                    }
                };
            }
        }

    }

    

}
