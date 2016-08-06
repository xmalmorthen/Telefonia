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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObjetivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.frmModemStatus1 = new CellTrack.Views.UserControls.frmModemStatus();
            this.frmUserInformation = new CellTrack.Views.UserControls.frmUserInformation();
            this.frmModemSignal1 = new CellTrack.Views.UserControls.frmModemSignal();
            this.frmSaldo = new CellTrack.Views.UserControls.frmSaldo();
            this.mainMenu = new CellTrack.Views.UserControls.menu();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Location = new System.Drawing.Point(30, 97);
            this.panel.Margin = new System.Windows.Forms.Padding(10);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(5);
            this.panel.Size = new System.Drawing.Size(964, 624);
            this.panel.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // frmModemStatus1
            // 
            this.frmModemStatus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmModemStatus1.BackColor = System.Drawing.Color.Transparent;
            this.frmModemStatus1.Location = new System.Drawing.Point(328, 734);
            this.frmModemStatus1.Name = "frmModemStatus1";
            this.frmModemStatus1.Size = new System.Drawing.Size(285, 32);
            this.frmModemStatus1.TabIndex = 34;
            // 
            // frmUserInformation
            // 
            this.frmUserInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frmUserInformation.BackColor = System.Drawing.Color.Transparent;
            this.frmUserInformation.Location = new System.Drawing.Point(425, 63);
            this.frmUserInformation.Name = "frmUserInformation";
            this.frmUserInformation.Size = new System.Drawing.Size(576, 26);
            this.frmUserInformation.TabIndex = 33;
            // 
            // frmModemSignal1
            // 
            this.frmModemSignal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmModemSignal1.BackColor = System.Drawing.Color.Transparent;
            this.frmModemSignal1.Location = new System.Drawing.Point(619, 734);
            this.frmModemSignal1.Name = "frmModemSignal1";
            this.frmModemSignal1.Size = new System.Drawing.Size(395, 26);
            this.frmModemSignal1.TabIndex = 32;
            // 
            // frmSaldo
            // 
            this.frmSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.frmSaldo.BackColor = System.Drawing.Color.Transparent;
            this.frmSaldo.Location = new System.Drawing.Point(11, 734);
            this.frmSaldo.Name = "frmSaldo";
            this.frmSaldo.Size = new System.Drawing.Size(192, 26);
            this.frmSaldo.TabIndex = 31;
            this.frmSaldo.Visible = false;
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = true;
            this.mainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Location = new System.Drawing.Point(26, 16);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(240, 79);
            this.mainMenu.TabIndex = 27;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = global::CellTrack.Properties.Resources.icon_039920_256;
            this.BackImagePadding = new System.Windows.Forms.Padding(30);
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomRight;
            this.BackMaxSize = 256;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frmModemStatus1);
            this.Controls.Add(this.frmUserInformation);
            this.Controls.Add(this.frmModemSignal1);
            this.Controls.Add(this.frmSaldo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.mainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Movable = false;
            this.Name = "frmDashboard";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Panel CellTrack";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmiObjetivos;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCredito;
        private UserControls.menu mainMenu;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Panel panel;
        private UserControls.frmSaldo frmSaldo;
        private UserControls.frmModemSignal frmModemSignal1;
        private UserControls.frmUserInformation frmUserInformation;
        private UserControls.frmModemStatus frmModemStatus1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}