namespace Satelites.Views.UserControls
{
    partial class gMapViewLite
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
            this.zoomTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.cmbMapsType = new MetroFramework.Controls.MetroComboBox();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnCenter = new MetroFramework.Controls.MetroButton();
            this.btnReload = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.zoomTrackBar.Location = new System.Drawing.Point(813, 678);
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(351, 23);
            this.zoomTrackBar.TabIndex = 40;
            this.zoomTrackBar.Text = "metroTrackBar1";
            this.zoomTrackBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // cmbMapsType
            // 
            this.cmbMapsType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMapsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMapsType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbMapsType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cmbMapsType.FormattingEnabled = true;
            this.cmbMapsType.ItemHeight = 19;
            this.cmbMapsType.Location = new System.Drawing.Point(813, 3);
            this.cmbMapsType.Name = "cmbMapsType";
            this.cmbMapsType.Size = new System.Drawing.Size(318, 25);
            this.cmbMapsType.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbMapsType.TabIndex = 39;
            this.cmbMapsType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbMapsType.UseSelectable = true;
            this.cmbMapsType.UseStyleColors = true;
            this.cmbMapsType.DropDownClosed += new System.EventHandler(this.cmbMapsType_DropDownClosed);
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnCenter
            // 
            this.btnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCenter.AutoSize = true;
            this.btnCenter.BackgroundImage = global::Satelites.Properties.Resources._1464210083_target;
            this.btnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCenter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCenter.Location = new System.Drawing.Point(1104, 610);
            this.btnCenter.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(60, 60);
            this.btnCenter.TabIndex = 42;
            this.btnCenter.Tag = "0";
            this.metroToolTip.SetToolTip(this.btnCenter, "Centrar antenas en el mapa...");
            this.btnCenter.UseSelectable = true;
            this.btnCenter.UseStyleColors = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.AutoSize = true;
            this.btnReload.BackgroundImage = global::Satelites.Properties.Resources._1463558060_playback_reload;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReload.Location = new System.Drawing.Point(1139, 3);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 25);
            this.btnReload.TabIndex = 41;
            this.btnReload.Tag = "0";
            this.metroToolTip.SetToolTip(this.btnReload, "Recargar mapa...");
            this.btnReload.UseSelectable = true;
            this.btnReload.UseStyleColors = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.AliceBlue;
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 17;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(1167, 704);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 0D;
            // 
            // gMapViewLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.zoomTrackBar);
            this.Controls.Add(this.cmbMapsType);
            this.Controls.Add(this.MainMap);
            this.Name = "gMapViewLite";
            this.Size = new System.Drawing.Size(1167, 704);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        internal GMap.NET.WindowsForms.GMapControl MainMap;
        private MetroFramework.Controls.MetroComboBox cmbMapsType;
        private MetroFramework.Controls.MetroTrackBar zoomTrackBar;
        private MetroFramework.Controls.MetroButton btnReload;
        private MetroFramework.Controls.MetroButton btnCenter;
    }
}
