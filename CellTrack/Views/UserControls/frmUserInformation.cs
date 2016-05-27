using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellTrack.Classes;
using CellTrack.Controllers;

namespace CellTrack.Views.UserControls
{
    public partial class frmUserInformation : UserControl
    {
        public frmUserInformation()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;            
        }

        public void refreshUserName() {
            lblUser.Text = string.Format("{0} {1} {2}", usuarioController.usuarioLogueado.info.Nombres, usuarioController.usuarioLogueado.info.PrimerApellido, usuarioController.usuarioLogueado.info.SegundoApellido);
        }

    }
}
