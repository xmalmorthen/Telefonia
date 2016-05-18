using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Classes
{
    public static class visualStyles
    {
        private static void iterControls(Control control, MetroStyleManager msmMain)
        {
            foreach (Control item in control.Controls)
            {
                iterControls(item, msmMain);
                if (item is IMetroControl)
                    ((IMetroControl)item).StyleManager = msmMain;
            }
        }

        public static void apply(Control frm, MetroStyleManager msmMain)
        {
            msmMain.Owner = (ContainerControl)frm;
            msmMain = Properties.Settings.Default.mainStyle;
            try
            {
                ((MetroForm)frm).StyleManager = msmMain;
            }
            catch (Exception){}            
            visualStyles.iterControls(frm, msmMain);
        }

    }
}
