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
            this.btnConfigs = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnLocalizations = new MetroFramework.Controls.MetroButton();
            this.btnDataBases = new MetroFramework.Controls.MetroButton();
            this.btnFinder = new MetroFramework.Controls.MetroButton();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnConfigs
            // 
            this.btnConfigs.AutoSize = true;
            this.btnConfigs.BackgroundImage = global::CellTrack.Properties.Resources._1463451293_cog;
            this.btnConfigs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfigs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfigs.Location = new System.Drawing.Point(47, 220);
            this.btnConfigs.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Size = new System.Drawing.Size(23, 23);
            this.btnConfigs.TabIndex = 9;
            this.btnConfigs.UseSelectable = true;
            this.btnConfigs.UseStyleColors = true;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackgroundImage = global::CellTrack.Properties.Resources._1463451253_user;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUser.Location = new System.Drawing.Point(10, 220);
            this.btnUser.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(23, 23);
            this.btnUser.TabIndex = 8;
            this.btnUser.UseSelectable = true;
            this.btnUser.UseStyleColors = true;
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
            this.btnLocalizations.Size = new System.Drawing.Size(60, 60);
            this.btnLocalizations.TabIndex = 5;
            this.btnLocalizations.UseSelectable = true;
            this.btnLocalizations.UseStyleColors = true;
            // 
            // btnDataBases
            // 
            this.btnDataBases.AutoSize = true;
            this.btnDataBases.BackgroundImage = global::CellTrack.Properties.Resources._1463451426_db;
            this.btnDataBases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDataBases.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDataBases.Location = new System.Drawing.Point(10, 80);
            this.btnDataBases.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnDataBases.Name = "btnDataBases";
            this.btnDataBases.Size = new System.Drawing.Size(60, 60);
            this.btnDataBases.TabIndex = 6;
            this.btnDataBases.UseSelectable = true;
            this.btnDataBases.UseStyleColors = true;
            // 
            // btnFinder
            // 
            this.btnFinder.AutoSize = true;
            this.btnFinder.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinder.Location = new System.Drawing.Point(10, 150);
            this.btnFinder.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(60, 60);
            this.btnFinder.TabIndex = 7;
            this.btnFinder.UseSelectable = true;
            this.btnFinder.UseStyleColors = true;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfigs);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLocalizations);
            this.Controls.Add(this.btnDataBases);
            this.Controls.Add(this.btnFinder);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(110, 371);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroButton btnConfigs;
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnLocalizations;
        private MetroFramework.Controls.MetroButton btnDataBases;
        private MetroFramework.Controls.MetroButton btnFinder;
        private MetroFramework.Components.MetroToolTip metroToolTip;
    }
}
