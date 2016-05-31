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
using MetroFramework.Controls;
using System.Threading;
using CellTrack.Views.UserControls.Localización;
using MetroFramework;
using CellTrack.Models.DataBases;
using CellTrack.Controllers;

namespace CellTrack.Views.UserControls
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;

            List<reperfilroles> roles = usuarioController.usuarioLogueado.info.caperfiles.reperfilroles.Where(qry => qry.caroles.isDeleted.Equals(false) && qry.caroles.activo.Equals(true)).ToList();            
            
            this.changeAccessRoles(mCMLocalizations.Items, roles);
            this.changeAccessRoles(mCMRegs.Items, roles);

            foreach (Control item in this.Controls)
                if (item is Button) {
                    reperfilroles rol = roles.SingleOrDefault(qry => qry.caroles.tag.Equals((string)item.Tag, StringComparison.InvariantCultureIgnoreCase));
                    item.Visible = rol != null;
                }


        }

        private void changeAccessRoles(ToolStripItemCollection collection, List<reperfilroles> roles)
        {
            foreach (ToolStripMenuItem item in collection)
            {
                reperfilroles rol = roles.SingleOrDefault(qry => qry.caroles.tag.Equals((string)item.Tag, StringComparison.InvariantCultureIgnoreCase));
                item.Visible = rol != null;

                if (item is ToolStripDropDownItem)
                {
                    ToolStripDropDownItem dropDownItem = (ToolStripDropDownItem)item;
                    if (dropDownItem.DropDownItems.Count > 0)
                        this.changeAccessRoles(dropDownItem.DropDownItems, roles);
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmUserAdmin());
        }

        private void btnConfigs_Click(object sender, EventArgs e)
        {
            this.openFrm<frmAdmin>();
        }

        private void btnFinder_Click(object sender, EventArgs e)
        {
            Program.FrmDashboard.renderControl(new frmInvestigacion());
        }

        private void btnDataBases_Click(object sender, EventArgs e)
        {
            mCMRegs.Show((MetroButton)sender, new Point(0, ((MetroButton)sender).Height));
            //Program.FrmDashboard.renderControl(new frmBaseDatos());
        }

        private void btnLocalizations_Click(object sender, EventArgs e)
        {
            mCMLocalizations.Show((MetroButton)sender, new Point(0,((MetroButton)sender).Height));            
        }

        private void openFrm<TForm>() where TForm : UserControl, new()
        {
            Program.FrmDashboard.renderControl(new frmProccessingShow());
            Application.DoEvents();
            Program.FrmDashboard.renderControl(new TForm());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.openFrm<frmObjetivos>();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPHostEntry internet = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MetroMessageBox.Show(this,"No hay conexión a internet." + Environment.NewLine + "No es posible usar esta función", "Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.openFrm<frmPDU>();
        }
        
    }
}
