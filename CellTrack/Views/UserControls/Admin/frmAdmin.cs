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

        public frmAdmin()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            visualStyles.apply(this, msmMain);
            metroToolTip.StyleManager = msmMain;
            tbConfigs_SelectedIndexChanged(tbConfigs, null);
        }

        private void tbConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((MetroTabControl)sender).SelectedIndex)
            {
                case 0: //TAB DE USUARIOS
                    this.tbPageUsuarios.Controls.Clear();
                    this.tbPageUsuarios.Controls.Add(renderControl(CtrlUsuarios));
                    break;
                case 1: //TAB DE PERFILES Y ROLES
                    break;
                case 2: //TAB DE CATÁLOGOS
                    break;
                case 3: //TAB DE GRUPOS
                    this.tbPageGrupos.Controls.Clear();
                    this.tbPageGrupos.Controls.Add(renderControl(CtrlGpos));
                    break;
            } 
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
