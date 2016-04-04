using GSMApplication.Forms;
using GSMApplication.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Controllers
{
    static class Online
    {
        public static DialogResult init(System.Windows.Forms.Form owner) {
            StatusWindow SWin = new StatusWindow();
            return SWin.ShowDialog(owner);
        }
        
    }
}
