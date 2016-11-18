namespace Satelites.Views
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
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlProc = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLocalizations = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.pnlProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(23, 33);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(848, 513);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // pnlProc
            // 
            this.pnlProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProc.Controls.Add(this.label1);
            this.pnlProc.Controls.Add(this.pictureBox1);
            this.pnlProc.HorizontalScrollbarBarColor = true;
            this.pnlProc.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProc.HorizontalScrollbarSize = 10;
            this.pnlProc.Location = new System.Drawing.Point(27, 209);
            this.pnlProc.Name = "pnlProc";
            this.pnlProc.Size = new System.Drawing.Size(318, 333);
            this.pnlProc.TabIndex = 3;
            this.pnlProc.VerticalScrollbarBarColor = true;
            this.pnlProc.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProc.VerticalScrollbarSize = 10;
            this.pnlProc.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procesando, favor de esperar...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Satelites.Properties.Resources.loading_gallery;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLocalizations
            // 
            this.btnLocalizations.AutoSize = true;
            this.btnLocalizations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocalizations.BackgroundImage")));
            this.btnLocalizations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizations.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLocalizations.Location = new System.Drawing.Point(29, 39);
            this.btnLocalizations.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnLocalizations.Name = "btnLocalizations";
            this.btnLocalizations.Size = new System.Drawing.Size(60, 60);
            this.btnLocalizations.TabIndex = 2;
            this.btnLocalizations.Tag = "0";
            this.metroToolTip.SetToolTip(this.btnLocalizations, "Agregar antena...");
            this.btnLocalizations.UseSelectable = true;
            this.btnLocalizations.UseStyleColors = true;
            this.btnLocalizations.Click += new System.EventHandler(this.btnLocalizations_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 569);
            this.Controls.Add(this.pnlProc);
            this.Controls.Add(this.btnLocalizations);
            this.Controls.Add(this.pnlMain);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmDashboard";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Panel de Antenas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.pnlProc.ResumeLayout(false);
            this.pnlProc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroButton btnLocalizations;
        private MetroFramework.Controls.MetroPanel pnlProc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}