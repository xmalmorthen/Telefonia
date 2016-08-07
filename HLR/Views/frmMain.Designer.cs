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
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mse = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.ucDoHealthCheck1 = new HLR.Views.UserControls.UCDoHealthCheck();
            this.ucGetBalance1 = new HLR.Views.UserControls.UCGetBalance();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.HorizontalScrollbar = true;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(23, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(972, 351);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.VerticalScrollbar = true;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // msm
            // 
            this.msm.Owner = this;
            this.msm.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // ucDoHealthCheck1
            // 
            this.ucDoHealthCheck1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDoHealthCheck1.AutoSize = true;
            this.ucDoHealthCheck1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDoHealthCheck1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDoHealthCheck1.Location = new System.Drawing.Point(23, 420);
            this.ucDoHealthCheck1.Name = "ucDoHealthCheck1";
            this.ucDoHealthCheck1.Size = new System.Drawing.Size(747, 57);
            this.ucDoHealthCheck1.TabIndex = 1;
            this.ucDoHealthCheck1.UseSelectable = true;
            // 
            // ucGetBalance1
            // 
            this.ucGetBalance1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGetBalance1.AutoSize = true;
            this.ucGetBalance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGetBalance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucGetBalance1.Location = new System.Drawing.Point(776, 420);
            this.ucGetBalance1.Name = "ucGetBalance1";
            this.ucGetBalance1.Size = new System.Drawing.Size(219, 57);
            this.ucGetBalance1.TabIndex = 0;
            this.ucGetBalance1.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::HLR.Properties.Resources._1464210083_target;
            this.BackImagePadding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.BackMaxSize = 48;
            this.ClientSize = new System.Drawing.Size(1024, 500);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ucDoHealthCheck1);
            this.Controls.Add(this.ucGetBalance1);
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmMain";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "    HLR";
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Views.UserControls.UCGetBalance ucGetBalance1;
        private Views.UserControls.UCDoHealthCheck ucDoHealthCheck1;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Components.MetroStyleManager msm;
        private MetroFramework.Components.MetroStyleExtender mse;

    }
}

