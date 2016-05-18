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
            this.mCMCuenta = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObjetivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new CellTrack.Views.UserControls.menu();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.mCMCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // mainMenu
            // 
            this.mainMenu.AutoSize = true;
            this.mainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenu.Location = new System.Drawing.Point(23, 63);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(80, 253);
            this.mainMenu.TabIndex = 27;
            this.mainMenu.Load += new System.EventHandler(this.mainMenu_Load);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.Resizable = false;
            this.Text = "Panel CellTrack [ 2g / 3g / 4g ]";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.mCMCuenta.ResumeLayout(false);
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
        private UserControls.menu mainMenu;
    }
}