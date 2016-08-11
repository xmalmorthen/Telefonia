namespace CellTrack.Views.UserControls
{
    partial class menu
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnLocalizations = new MetroFramework.Controls.MetroButton();
            this.btnRegs = new MetroFramework.Controls.MetroButton();
            this.btnFinder = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnConfigs = new MetroFramework.Controls.MetroButton();
            this.mCMLocalizations = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCMRegs = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.mCMLocalizations.SuspendLayout();
            this.mCMRegs.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnLocalizations
            // 
            this.btnLocalizations.AutoSize = true;
            this.btnLocalizations.BackgroundImage = global::CellTrack.Properties.Resources._1463451442_target;
            this.btnLocalizations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizations.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLocalizations.Location = new System.Drawing.Point(5, 5);
            this.btnLocalizations.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnLocalizations.Name = "btnLocalizations";
            this.btnLocalizations.Size = new System.Drawing.Size(60, 60);
            this.btnLocalizations.TabIndex = 1;
            this.btnLocalizations.Tag = "0";
            this.metroToolTip.SetToolTip(this.btnLocalizations, "Localización");
            this.btnLocalizations.UseSelectable = true;
            this.btnLocalizations.UseStyleColors = true;
            this.btnLocalizations.Click += new System.EventHandler(this.btnLocalizations_Click);
            // 
            // btnRegs
            // 
            this.btnRegs.AutoSize = true;
            this.btnRegs.BackgroundImage = global::CellTrack.Properties.Resources._1463451426_db;
            this.btnRegs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegs.Location = new System.Drawing.Point(70, 5);
            this.btnRegs.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnRegs.Name = "btnRegs";
            this.btnRegs.Size = new System.Drawing.Size(60, 60);
            this.btnRegs.TabIndex = 2;
            this.btnRegs.Tag = "1";
            this.metroToolTip.SetToolTip(this.btnRegs, "Registros");
            this.btnRegs.UseSelectable = true;
            this.btnRegs.UseStyleColors = true;
            this.btnRegs.Click += new System.EventHandler(this.btnDataBases_Click);
            // 
            // btnFinder
            // 
            this.btnFinder.AutoSize = true;
            this.btnFinder.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinder.Location = new System.Drawing.Point(135, 5);
            this.btnFinder.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(60, 60);
            this.btnFinder.TabIndex = 3;
            this.btnFinder.Tag = "2";
            this.metroToolTip.SetToolTip(this.btnFinder, "Investigación");
            this.btnFinder.UseSelectable = true;
            this.btnFinder.UseStyleColors = true;
            this.btnFinder.Click += new System.EventHandler(this.btnFinder_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.BackgroundImage = global::CellTrack.Properties.Resources._1470786806_chart_bar;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(200, 5);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(60, 60);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Tag = "2";
            this.metroToolTip.SetToolTip(this.metroButton1, "SOKAN");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackgroundImage = global::CellTrack.Properties.Resources._1463451253_user;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUser.Location = new System.Drawing.Point(5, 5);
            this.btnUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(23, 23);
            this.btnUser.TabIndex = 0;
            this.metroToolTip.SetToolTip(this.btnUser, "Información de usuario");
            this.btnUser.UseSelectable = true;
            this.btnUser.UseStyleColors = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnConfigs
            // 
            this.btnConfigs.AutoSize = true;
            this.btnConfigs.BackgroundImage = global::CellTrack.Properties.Resources._1463451293_cog;
            this.btnConfigs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfigs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfigs.Location = new System.Drawing.Point(5, 39);
            this.btnConfigs.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Size = new System.Drawing.Size(23, 23);
            this.btnConfigs.TabIndex = 4;
            this.btnConfigs.Tag = "3";
            this.metroToolTip.SetToolTip(this.btnConfigs, "Configuraciones");
            this.btnConfigs.UseSelectable = true;
            this.btnConfigs.UseStyleColors = true;
            this.btnConfigs.Click += new System.EventHandler(this.btnConfigs_Click);
            // 
            // mCMLocalizations
            // 
            this.mCMLocalizations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.supervisiónToolStripMenuItem});
            this.mCMLocalizations.Name = "metroContextMenu1";
            this.mCMLocalizations.Size = new System.Drawing.Size(174, 186);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem1.Tag = "0-1";
            this.toolStripMenuItem1.Text = "Registrar Objetivos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem2.Tag = "0-2";
            this.toolStripMenuItem2.Text = "PDU";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem3.Tag = "0-3";
            this.toolStripMenuItem3.Text = "SS7";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem4.Tag = "0-4";
            this.toolStripMenuItem4.Text = "Recibidos";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem5.Tag = "0-5";
            this.toolStripMenuItem5.Text = "Seguimiento";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem6.Tag = "0-6";
            this.toolStripMenuItem6.Text = "BTS";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // supervisiónToolStripMenuItem
            // 
            this.supervisiónToolStripMenuItem.Name = "supervisiónToolStripMenuItem";
            this.supervisiónToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supervisiónToolStripMenuItem.Text = "Supervisión";
            // 
            // mCMRegs
            // 
            this.mCMRegs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripSeparator2,
            this.toolStripMenuItem10});
            this.mCMRegs.Name = "metroContextMenu1";
            this.mCMRegs.Size = new System.Drawing.Size(120, 186);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem7.Tag = "1-1";
            this.toolStripMenuItem7.Text = "Padrón";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem8.Tag = "1-2";
            this.toolStripMenuItem8.Text = "CFE";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem9.Tag = "1-3";
            this.toolStripMenuItem9.Text = "IMSS";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem12.Tag = "1-4";
            this.toolStripMenuItem12.Text = "RENAUT";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem13.Tag = "1-5";
            this.toolStripMenuItem13.Text = "TELMEX";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem14.Tag = "1-6";
            this.toolStripMenuItem14.Text = "TELCEL";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem15.Tag = "1-7";
            this.toolStripMenuItem15.Text = "NEXTEL";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem10.Tag = "1-8";
            this.toolStripMenuItem10.Text = "GLOBAL";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnLocalizations);
            this.flowLayoutPanel1.Controls.Add(this.btnRegs);
            this.flowLayoutPanel1.Controls.Add(this.btnFinder);
            this.flowLayoutPanel1.Controls.Add(this.metroButton1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(299, 73);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnConfigs);
            this.panel1.Location = new System.Drawing.Point(263, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 67);
            this.panel1.TabIndex = 4;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(528, 77);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.mCMLocalizations.ResumeLayout(false);
            this.mCMRegs.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroButton btnConfigs;
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnLocalizations;
        private MetroFramework.Controls.MetroButton btnRegs;
        private MetroFramework.Controls.MetroButton btnFinder;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Controls.MetroContextMenu mCMLocalizations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem supervisiónToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu mCMRegs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
