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
using CellTrack.Models;
using CellTrack.Controllers;

namespace CellTrack.Views.UserControls
{
    public partial class frmObjetivos : UserControl
    {
        public frmObjetivos()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            this.populate();
        }

        private void populate()
        {
            bsCarriers.DataSource = catalogosController.activeCarriers;
            bsNotifications.DataSource = usuarioController.usersNotifications;
        }
        
    }
}
