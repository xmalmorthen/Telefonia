namespace CellTrack.Views
{
    partial class gMapStaticImageGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gMapStaticImageGenerate));
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.pb = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(453, 13);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 44);
            this.btnCancel.TabIndex = 37;
            this.metroToolTip1.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblInfo.Location = new System.Drawing.Point(23, 42);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(146, 15);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "Marcador de mapa estático";
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(23, 13);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(424, 23);
            this.pb.TabIndex = 35;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // gMapStaticImageGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(520, 65);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pb);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "gMapStaticImageGenerate";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Generando mapa";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.gMapStaticImageGenerate_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.ComponentModel.BackgroundWorker bg;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private MetroFramework.Controls.MetroProgressBar pb;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}