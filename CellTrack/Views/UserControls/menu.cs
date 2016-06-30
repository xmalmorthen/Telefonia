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
            this.changeAccessButtonsRoles(this.Controls, roles);
            
        }

        private void changeAccessButtonsRoles(ControlCollection ctrl, List<reperfilroles> roles)
        {
            foreach (Control item in ctrl)
            {
                if (item.Controls.Count > 0) this.changeAccessButtonsRoles(item.Controls, roles);
                if (item is Button)
                    if (!string.IsNullOrEmpty(item.Tag as string))
                    {
                        reperfilroles rol = roles.SingleOrDefault(qry => qry.caroles.tag.Equals((string)item.Tag, StringComparison.InvariantCultureIgnoreCase));
                        item.Visible = rol != null;
                    }
            }
        }

        private void changeAccessRoles(ToolStripItemCollection collection, List<reperfilroles> roles)
        {
            try
            {
                foreach (var obj in collection)
                {
                    if (obj.GetType() == typeof(ToolStripMenuItem))
                    {
                        ToolStripMenuItem item = (ToolStripMenuItem)obj;

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
            }
            catch (Exception)
            {
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

        private frmProccessingShow FrmProccessingShow = new frmProccessingShow();        
        private void openFrm<TForm>() where TForm : UserControl, new()
        {
            Program.FrmDashboard.renderControl(FrmProccessingShow);
            Application.DoEvents();
            UserControl frm = null;
            Type type = typeof(TForm);
            try
            {
                if (!Program.frmsOpenned.TryGetValue(type.Name, out frm))
                {
                    frm = new TForm();
                    Program.frmsOpenned.Add(type.Name, frm);
                }
                Program.FrmDashboard.renderControl(frm);
            }
            catch (Exception ex)
            {
                string msgErr = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MetroMessageBox.Show(this, msgErr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.FrmDashboard.renderNone();
            }
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.openFrm<frmRecibidos>();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.openFrm<frmSeguimiento>();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //this.openFrm<frmGlobal>();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.openFrm<frmIFE>();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.openFrm<frmCFE>();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.openFrm<frmTELCEL>();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.openFrm<frmNEXTEL>();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.openFrm<frmTELMEX>();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.openFrm<frmRENAUT>();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.openFrm<frmBTS>();
        }
        
    }
}
