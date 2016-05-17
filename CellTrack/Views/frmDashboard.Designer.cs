namespace CellTrack.Views
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnLocalizations = new MetroFramework.Controls.MetroButton();
            this.btnDataBases = new MetroFramework.Controls.MetroButton();
            this.btnFinder = new MetroFramework.Controls.MetroButton();
            this.btnConfigs = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.mCMCuenta = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObjetivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.mCMCuenta.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnLocalizations
            // 
            this.btnLocalizations.AutoSize = true;
            this.btnLocalizations.BackgroundImage = global::CellTrack.Properties.Resources._1463451442_target;
            this.btnLocalizations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizations.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLocalizations.Location = new System.Drawing.Point(10, 10);
            this.btnLocalizations.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.btnLocalizations.Name = "btnLocalizations";
            this.btnLocalizations.Size = new System.Drawing.Size(51, 51);
            this.btnLocalizations.TabIndex = 13;
            this.toolTipController.SetTitle(this.btnLocalizations, "czxc");
            this.toolTipController.SetToolTip(this.btnLocalizations, "zxczcx");
            this.toolTipController.SetToolTipIconType(this.btnLocalizations, DevExpress.Utils.ToolTipIconType.Information);
            this.btnLocalizations.UseSelectable = true;
            // 
            // btnDataBases
            // 
            this.btnDataBases.AutoSize = true;
            this.btnDataBases.BackgroundImage = global::CellTrack.Properties.Resources._1463451426_db;
            this.btnDataBases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDataBases.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDataBases.Location = new System.Drawing.Point(10, 71);
            this.btnDataBases.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnDataBases.Name = "btnDataBases";
            this.btnDataBases.Size = new System.Drawing.Size(51, 51);
            this.btnDataBases.TabIndex = 12;
            this.btnDataBases.UseSelectable = true;
            // 
            // btnFinder
            // 
            this.btnFinder.AutoSize = true;
            this.btnFinder.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinder.Location = new System.Drawing.Point(10, 132);
            this.btnFinder.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(51, 51);
            this.btnFinder.TabIndex = 10;
            this.btnFinder.UseSelectable = true;
            // 
            // btnConfigs
            // 
            this.btnConfigs.AutoSize = true;
            this.btnConfigs.BackgroundImage = global::CellTrack.Properties.Resources._1463451293_cog;
            this.btnConfigs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfigs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfigs.Location = new System.Drawing.Point(42, 193);
            this.btnConfigs.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Size = new System.Drawing.Size(19, 19);
            this.btnConfigs.TabIndex = 15;
            this.btnConfigs.UseSelectable = true;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackgroundImage = global::CellTrack.Properties.Resources._1463451253_user;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUser.Location = new System.Drawing.Point(10, 193);
            this.btnUser.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(19, 19);
            this.btnUser.TabIndex = 14;
            this.btnUser.UseSelectable = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // mCMCuenta
            // 
            this.mCMCuenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditar,
            this.tsmiObjetivos,
            this.tss1,
            this.tsmiCredito});
            this.mCMCuenta.Name = "metroContextMenu1";
            this.mCMCuenta.Size = new System.Drawing.Size(147, 76);
            this.mCMCuenta.Style = MetroFramework.MetroColorStyle.Orange;
            this.mCMCuenta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mCMCuenta.UseStyleColors = true;
            // 
            // tsmiEditar
            // 
            this.tsmiEditar.Image = global::CellTrack.Properties.Resources._1463512306_pencil;
            this.tsmiEditar.Name = "tsmiEditar";
            this.tsmiEditar.Size = new System.Drawing.Size(146, 22);
            this.tsmiEditar.Text = "Editar usuario";
            // 
            // tsmiObjetivos
            // 
            this.tsmiObjetivos.Image = global::CellTrack.Properties.Resources._1463512483_eye;
            this.tsmiObjetivos.Name = "tsmiObjetivos";
            this.tsmiObjetivos.Size = new System.Drawing.Size(146, 22);
            this.tsmiObjetivos.Text = "Objetivos";
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(143, 6);
            // 
            // tsmiCredito
            // 
            this.tsmiCredito.Image = global::CellTrack.Properties.Resources._1463512603_cur_dollar;
            this.tsmiCredito.Name = "tsmiCredito";
            this.tsmiCredito.Size = new System.Drawing.Size(146, 22);
            this.tsmiCredito.Text = "Crédito";
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel1.Controls.Add(this.btnConfigs);
            this.metroPanel1.Controls.Add(this.btnUser);
            this.metroPanel1.Controls.Add(this.btnLocalizations);
            this.metroPanel1.Controls.Add(this.btnDataBases);
            this.metroPanel1.Controls.Add(this.btnFinder);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(71, 222);
            this.metroPanel1.TabIndex = 25;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoSize = true;
            this.metroPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 298);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(71, 222);
            this.metroPanel2.TabIndex = 26;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = false;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.BackgroundImage = global::CellTrack.Properties.Resources._1463451293_cog;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(42, 193);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(19, 19);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.UseSelectable = true;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(297, 389);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit1.TabIndex = 27;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(390, 461);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(270, 554);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "labelControl1";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.Resizable = false;
            this.Text = "Panel CellTrack [ 2g / 3g / 4g ]";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.mCMCuenta.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroContextMenu mCMCuenta;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmiObjetivos;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCredito;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnLocalizations;
        private MetroFramework.Controls.MetroButton btnDataBases;
        private MetroFramework.Controls.MetroButton btnFinder;
        private MetroFramework.Controls.MetroButton btnConfigs;
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private DevExpress.Utils.ToolTipController toolTipController;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.StyleController styleController1;
    }
}