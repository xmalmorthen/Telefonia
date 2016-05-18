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
            this.msmMain = new MetroFramework.Components.MetroStyleManager();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnConfigs = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnFinder = new MetroFramework.Controls.MetroButton();
            this.btnDataBases = new MetroFramework.Controls.MetroButton();
            this.btnLocalizations = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnConfigs
            // 
            this.btnConfigs.AutoSize = true;
            this.btnConfigs.BackgroundImage = global::CellTrack.Properties.Resources._1463451293_cog;
            this.btnConfigs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfigs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfigs.Location = new System.Drawing.Point(200, 42);
            this.btnConfigs.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Size = new System.Drawing.Size(23, 23);
            this.btnConfigs.TabIndex = 4;
            this.metroToolTip.SetToolTip(this.btnConfigs, "Configuraciones");
            this.btnConfigs.UseSelectable = true;
            this.btnConfigs.UseStyleColors = true;
            this.btnConfigs.Click += new System.EventHandler(this.btnConfigs_Click);
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackgroundImage = global::CellTrack.Properties.Resources._1463451253_user;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUser.Location = new System.Drawing.Point(200, 5);
            this.btnUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(23, 23);
            this.btnUser.TabIndex = 0;
            this.metroToolTip.SetToolTip(this.btnUser, "Información de usuario");
            this.btnUser.UseSelectable = true;
            this.btnUser.UseStyleColors = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnFinder
            // 
            this.btnFinder.AutoSize = true;
            this.btnFinder.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinder.Location = new System.Drawing.Point(135, 5);
            this.btnFinder.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(60, 60);
            this.btnFinder.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.btnFinder, "Investigación");
            this.btnFinder.UseSelectable = true;
            this.btnFinder.UseStyleColors = true;
            this.btnFinder.Click += new System.EventHandler(this.btnFinder_Click);
            // 
            // btnDataBases
            // 
            this.btnDataBases.AutoSize = true;
            this.btnDataBases.BackgroundImage = global::CellTrack.Properties.Resources._1463451426_db;
            this.btnDataBases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDataBases.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDataBases.Location = new System.Drawing.Point(70, 5);
            this.btnDataBases.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnDataBases.Name = "btnDataBases";
            this.btnDataBases.Size = new System.Drawing.Size(60, 60);
            this.btnDataBases.TabIndex = 2;
            this.metroToolTip.SetToolTip(this.btnDataBases, "Base de datos");
            this.btnDataBases.UseSelectable = true;
            this.btnDataBases.UseStyleColors = true;
            this.btnDataBases.Click += new System.EventHandler(this.btnDataBases_Click);
            // 
            // btnLocalizations
            // 
            this.btnLocalizations.AutoSize = true;
            this.btnLocalizations.BackgroundImage = global::CellTrack.Properties.Resources._1463451442_target;
            this.btnLocalizations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizations.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLocalizations.Location = new System.Drawing.Point(5, 5);
            this.btnLocalizations.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnLocalizations.Name = "btnLocalizations";
            this.btnLocalizations.Size = new System.Drawing.Size(60, 60);
            this.btnLocalizations.TabIndex = 1;
            this.metroToolTip.SetToolTip(this.btnLocalizations, "Localización");
            this.btnLocalizations.UseSelectable = true;
            this.btnLocalizations.UseStyleColors = true;
            this.btnLocalizations.Click += new System.EventHandler(this.btnLocalizations_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnConfigs);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnFinder);
            this.Controls.Add(this.btnDataBases);
            this.Controls.Add(this.btnLocalizations);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(226, 68);
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
