namespace HLR
{
    partial class frmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mse = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wrkr = new System.ComponentModel.BackgroundWorker();
            this.tt = new MetroFramework.Components.MetroToolTip();
            this.btnNewFind = new MetroFramework.Controls.MetroButton();
            this.wrkrInternet = new System.ComponentModel.BackgroundWorker();
            this.pnlSuper = new MetroFramework.Controls.MetroPanel();
            this.pnlJob = new MetroFramework.Controls.MetroPanel();
            this.pbJob = new MetroFramework.Controls.MetroProgressBar();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.pnlCell = new MetroFramework.Controls.MetroPanel();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.pnlInternet = new MetroFramework.Controls.MetroPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ucDoHealthCheck = new HLR.Views.UserControls.UCDoHealthCheck();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.pnlSuper.SuspendLayout();
            this.pnlJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlCell.SuspendLayout();
            this.pnlInternet.SuspendLayout();
            this.SuspendLayout();
            // 
            // msm
            // 
            this.msm.Owner = this;
            this.msm.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // label4
            // 
            this.mse.SetApplyMetroTheme(this.label4, true);
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Favor de volver a conectar...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.mse.SetApplyMetroTheme(this.label2, true);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ej. ( +5213121220990 ) ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.mse.SetApplyMetroTheme(this.label1, true);
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Celular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrkr
            // 
            this.wrkr.WorkerReportsProgress = true;
            this.wrkr.WorkerSupportsCancellation = true;
            this.wrkr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkr_DoWork);
            this.wrkr.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.wrkr_ProgressChanged);
            this.wrkr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wrkr_RunWorkerCompleted);
            // 
            // tt
            // 
            this.tt.Style = MetroFramework.MetroColorStyle.Blue;
            this.tt.StyleManager = null;
            this.tt.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnNewFind
            // 
            this.btnNewFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFind.AutoSize = true;
            this.btnNewFind.BackgroundImage = global::HLR.Properties.Resources._1459303405_Find01;
            this.btnNewFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNewFind.Location = new System.Drawing.Point(10, 5);
            this.btnNewFind.Margin = new System.Windows.Forms.Padding(3, 113, 3, 3);
            this.btnNewFind.Name = "btnNewFind";
            this.btnNewFind.Size = new System.Drawing.Size(53, 53);
            this.btnNewFind.TabIndex = 44;
            this.tt.SetToolTip(this.btnNewFind, "Nueva búsqueda");
            this.btnNewFind.UseSelectable = true;
            this.btnNewFind.Click += new System.EventHandler(this.btnNewFind_Click);
            // 
            // wrkrInternet
            // 
            this.wrkrInternet.WorkerReportsProgress = true;
            this.wrkrInternet.WorkerSupportsCancellation = true;
            this.wrkrInternet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkrInternet_DoWork);
            this.wrkrInternet.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.wrkrInternet_ProgressChanged);
            // 
            // pnlSuper
            // 
            this.pnlSuper.Controls.Add(this.btnNewFind);
            this.pnlSuper.Controls.Add(this.pnlJob);
            this.pnlSuper.Controls.Add(this.pnlMain);
            this.pnlSuper.Controls.Add(this.ucDoHealthCheck);
            this.pnlSuper.HorizontalScrollbarBarColor = true;
            this.pnlSuper.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSuper.HorizontalScrollbarSize = 10;
            this.pnlSuper.Location = new System.Drawing.Point(23, 63);
            this.pnlSuper.Name = "pnlSuper";
            this.pnlSuper.Size = new System.Drawing.Size(978, 420);
            this.pnlSuper.TabIndex = 0;
            this.pnlSuper.VerticalScrollbarBarColor = true;
            this.pnlSuper.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSuper.VerticalScrollbarSize = 10;
            // 
            // pnlJob
            // 
            this.pnlJob.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlJob.BackColor = System.Drawing.Color.White;
            this.pnlJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJob.Controls.Add(this.pbJob);
            this.pnlJob.Controls.Add(this.btnCancel);
            this.pnlJob.Controls.Add(this.label3);
            this.pnlJob.Controls.Add(this.pictureBox1);
            this.pnlJob.HorizontalScrollbarBarColor = true;
            this.pnlJob.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlJob.HorizontalScrollbarSize = 10;
            this.pnlJob.Location = new System.Drawing.Point(417, 91);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(184, 184);
            this.pnlJob.TabIndex = 43;
            this.pnlJob.VerticalScrollbarBarColor = true;
            this.pnlJob.VerticalScrollbarHighlightOnWheel = false;
            this.pnlJob.VerticalScrollbarSize = 10;
            this.pnlJob.Visible = false;
            // 
            // pbJob
            // 
            this.pbJob.Location = new System.Drawing.Point(3, 138);
            this.pbJob.Name = "pbJob";
            this.pbJob.Size = new System.Drawing.Size(176, 23);
            this.pbJob.TabIndex = 36;
            this.pbJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::HLR.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(135, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 113, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 44);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "favor de esperar...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HLR.Properties.Resources.loading_gallery;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlCell);
            this.pnlMain.HorizontalScrollbar = true;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(978, 356);
            this.pnlMain.TabIndex = 40;
            this.pnlMain.VerticalScrollbar = true;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // pnlCell
            // 
            this.pnlCell.AutoSize = true;
            this.pnlCell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCell.BackColor = System.Drawing.Color.White;
            this.pnlCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCell.Controls.Add(this.btnFind);
            this.pnlCell.Controls.Add(this.label2);
            this.pnlCell.Controls.Add(this.label1);
            this.pnlCell.Controls.Add(this.txtCell);
            this.pnlCell.HorizontalScrollbarBarColor = true;
            this.pnlCell.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCell.HorizontalScrollbarSize = 10;
            this.pnlCell.Location = new System.Drawing.Point(272, 131);
            this.pnlCell.Name = "pnlCell";
            this.pnlCell.Size = new System.Drawing.Size(465, 96);
            this.pnlCell.TabIndex = 3;
            this.pnlCell.VerticalScrollbarBarColor = true;
            this.pnlCell.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCell.VerticalScrollbarSize = 10;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.AutoSize = true;
            this.btnFind.BackgroundImage = global::HLR.Properties.Resources._1459303405_Find01;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFind.Location = new System.Drawing.Point(407, 38);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 113, 3, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 53);
            this.btnFind.TabIndex = 34;
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCell
            // 
            this.txtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell.Location = new System.Drawing.Point(3, 38);
            this.txtCell.MaxLength = 14;
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(398, 53);
            this.txtCell.TabIndex = 0;
            this.txtCell.Text = "+5213121220995";
            this.txtCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlInternet
            // 
            this.pnlInternet.AutoSize = true;
            this.pnlInternet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInternet.BackColor = System.Drawing.Color.White;
            this.pnlInternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInternet.Controls.Add(this.label4);
            this.pnlInternet.Controls.Add(this.label5);
            this.pnlInternet.HorizontalScrollbarBarColor = true;
            this.pnlInternet.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInternet.HorizontalScrollbarSize = 10;
            this.pnlInternet.Location = new System.Drawing.Point(155, 222);
            this.pnlInternet.Name = "pnlInternet";
            this.pnlInternet.Size = new System.Drawing.Size(740, 98);
            this.pnlInternet.TabIndex = 45;
            this.pnlInternet.VerticalScrollbarBarColor = true;
            this.pnlInternet.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInternet.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(732, 76);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sin conexión a internet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDoHealthCheck
            // 
            this.ucDoHealthCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDoHealthCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDoHealthCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucDoHealthCheck.Location = new System.Drawing.Point(0, 358);
            this.ucDoHealthCheck.Name = "ucDoHealthCheck";
            this.ucDoHealthCheck.Size = new System.Drawing.Size(978, 62);
            this.ucDoHealthCheck.TabIndex = 42;
            this.ucDoHealthCheck.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::HLR.Properties.Resources._1464210083_target;
            this.BackImagePadding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.BackMaxSize = 48;
            this.ClientSize = new System.Drawing.Size(1024, 500);
            this.Controls.Add(this.pnlInternet);
            this.Controls.Add(this.pnlSuper);
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmMain";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "     SS7";
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.pnlSuper.ResumeLayout(false);
            this.pnlSuper.PerformLayout();
            this.pnlJob.ResumeLayout(false);
            this.pnlJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCell.ResumeLayout(false);
            this.pnlCell.PerformLayout();
            this.pnlInternet.ResumeLayout(false);
            this.pnlInternet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msm;
        private MetroFramework.Components.MetroStyleExtender mse;
        public System.ComponentModel.BackgroundWorker wrkr;
        private MetroFramework.Components.MetroToolTip tt;
        private System.ComponentModel.BackgroundWorker wrkrInternet;
        private MetroFramework.Controls.MetroPanel pnlSuper;
        private MetroFramework.Controls.MetroPanel pnlInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnNewFind;
        private MetroFramework.Controls.MetroPanel pnlJob;
        private MetroFramework.Controls.MetroProgressBar pbJob;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroPanel pnlCell;
        private MetroFramework.Controls.MetroButton btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCell;
        private Views.UserControls.UCDoHealthCheck ucDoHealthCheck;

    }
}

