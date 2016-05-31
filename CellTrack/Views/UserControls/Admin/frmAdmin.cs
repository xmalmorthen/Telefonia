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
using CellTrack.Models.DataBases;
using MetroFramework;
using MetroFramework.Controls;
using CellTrack.Views.UserControls.Admin;

namespace CellTrack.Views.UserControls
{
    public partial class frmAdmin : UserControl
    {
        private usrCtrlUsuarios CtrlUsuarios = new usrCtrlUsuarios();
        private usrCtrlGpos CtrlGpos = new usrCtrlGpos();
        private usrCtrlPerfilesRoles CtrlPerfilesRoles = new usrCtrlPerfilesRoles();

        public frmAdmin()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
            
            this.tbPageUsuarios.Controls.Add(renderControl(CtrlUsuarios));
            this.tbPagePerfilesRoles.Controls.Add(renderControl(CtrlPerfilesRoles));
            this.tbPageGrupos.Controls.Add(renderControl(CtrlGpos));

            tbConfigs.SelectedIndex = 0;
            tbConfigs.Focus();
        }        

        public UserControl renderControl(UserControl ctrl)
        {
            Application.DoEvents();
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.Location = new System.Drawing.Point(0, 0);
            ctrl.TabIndex = 0;

            return ctrl;            
        }

        
    }
}
