namespace CellTrack.Views.UserControls
{
    partial class frmModemStatus
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbFree = new System.Windows.Forms.PictureBox();
            this.pbOcuppied = new System.Windows.Forms.PictureBox();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.btnFree = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.tmGetModemSignal = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcuppied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel1.Controls.Add(this.pbFree);
            this.flowLayoutPanel1.Controls.Add(this.pbOcuppied);
            this.flowLayoutPanel1.Controls.Add(this.lbl);
            this.flowLayoutPanel1.Controls.Add(this.btnFree);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 32);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 7);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 7, 11, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Estado del Model";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pbFree
            // 
            this.pbFree.Image = global::CellTrack.Properties.Resources._1467326378_padlock_open;
            this.pbFree.Location = new System.Drawing.Point(142, 8);
            this.pbFree.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.pbFree.Name = "pbFree";
            this.pbFree.Size = new System.Drawing.Size(16, 16);
            this.pbFree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFree.TabIndex = 12;
            this.pbFree.TabStop = false;
            this.metroToolTip.SetToolTip(this.pbFree, "Desocupado");
            // 
            // pbOcuppied
            // 
            this.pbOcuppied.Image = global::CellTrack.Properties.Resources._1467326406_padlock_closed;
            this.pbOcuppied.Location = new System.Drawing.Point(164, 8);
            this.pbOcuppied.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.pbOcuppied.Name = "pbOcuppied";
            this.pbOcuppied.Size = new System.Drawing.Size(16, 16);
            this.pbOcuppied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOcuppied.TabIndex = 41;
            this.pbOcuppied.TabStop = false;
            this.metroToolTip.SetToolTip(this.pbOcuppied, "Ocupado");
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl.Location = new System.Drawing.Point(186, 9);
            this.lbl.Margin = new System.Windows.Forms.Padding(3, 9, 11, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 15);
            this.lbl.Style = MetroFramework.MetroColorStyle.Black;
            this.lbl.TabIndex = 42;
            this.lbl.Text = "Desocupado";
            this.lbl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl.UseStyleColors = true;
            // 
            // btnFree
            // 
            this.btnFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFree.AutoSize = true;
            this.btnFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFree.BackgroundImage = global::CellTrack.Properties.Resources._1467326850_lighting;
            this.btnFree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFree.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFree.Location = new System.Drawing.Point(271, 3);
            this.btnFree.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(24, 26);
            this.btnFree.TabIndex = 40;
            this.metroToolTip.SetToolTip(this.btnFree, "Desocupar modem");
            this.btnFree.UseSelectable = true;
            this.btnFree.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tmGetModemSignal
            // 
            this.tmGetModemSignal.Enabled = true;
            this.tmGetModemSignal.Interval = 500;
            this.tmGetModemSignal.Tick += new System.EventHandler(this.tmGetModemSignal_Tick);
            // 
            // frmModemStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmModemStatus";
            this.Size = new System.Drawing.Size(306, 32);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcuppied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pbFree;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Timer tmGetModemSignal;
        private MetroFramework.Controls.MetroButton btnFree;
        private System.Windows.Forms.PictureBox pbOcuppied;
        private MetroFramework.Controls.MetroLabel lbl;
    }
}
