namespace CellTrack.Views.UserControls
{
    partial class frmUserAdmin
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnConfigs = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnLocalizations = new MetroFramework.Controls.MetroButton();
            this.btnDataBases = new MetroFramework.Controls.MetroButton();
            this.btnFinder = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.metroPanel1.Location = new System.Drawing.Point(165, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(71, 222);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // frmUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmUserAdmin";
            this.Size = new System.Drawing.Size(358, 352);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnConfigs;
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnLocalizations;
        private MetroFramework.Controls.MetroButton btnDataBases;
        private MetroFramework.Controls.MetroButton btnFinder;
    }
}
