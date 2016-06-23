namespace CellTrack.Views.UserControls
{
    partial class frmModemSignal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mpbModemSignal = new MetroFramework.Controls.MetroProgressBar();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.tmGetModemSignal = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.lblErr = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.mpbModemSignal);
            this.flowLayoutPanel1.Controls.Add(this.lblErr);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(620, 32);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 6);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 6, 11, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Modem";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CellTrack.Properties.Resources._1464222032_air_signal;
            this.pictureBox1.Location = new System.Drawing.Point(78, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // mpbModemSignal
            // 
            this.mpbModemSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpbModemSignal.Location = new System.Drawing.Point(100, 6);
            this.mpbModemSignal.Maximum = 31;
            this.mpbModemSignal.Minimum = 1;
            this.mpbModemSignal.Name = "mpbModemSignal";
            this.mpbModemSignal.Size = new System.Drawing.Size(255, 20);
            this.mpbModemSignal.Style = MetroFramework.MetroColorStyle.Black;
            this.mpbModemSignal.TabIndex = 14;
            this.mpbModemSignal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip.SetToolTip(this.mpbModemSignal, "asdasdasd");
            this.mpbModemSignal.Value = 15;
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
            this.tmGetModemSignal.Interval = 60000;
            this.tmGetModemSignal.Tick += new System.EventHandler(this.tmGetModemSignal_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.BackgroundImage = global::CellTrack.Properties.Resources._1463558222_Update;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRefresh.Location = new System.Drawing.Point(588, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 26);
            this.btnRefresh.TabIndex = 40;
            this.metroToolTip.SetToolTip(this.btnRefresh, "Actualizar señal del modem");
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErr.Location = new System.Drawing.Point(361, 9);
            this.lblErr.Margin = new System.Windows.Forms.Padding(3, 9, 11, 3);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(213, 15);
            this.lblErr.Style = MetroFramework.MetroColorStyle.Black;
            this.lblErr.TabIndex = 41;
            this.lblErr.Text = "No se pudo obtener la señal del modem.";
            this.lblErr.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblErr.UseStyleColors = true;
            this.lblErr.Visible = false;
            // 
            // frmModemSignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmModemSignal";
            this.Size = new System.Drawing.Size(620, 32);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar mpbModemSignal;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Timer tmGetModemSignal;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroLabel lblErr;
    }
}
