namespace HLR.Views.UserControls
{
    partial class mapViewer
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
            this.cmbMapsTypes = new MetroFramework.Controls.MetroComboBox();
            this.btnCentrar = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLessZoom = new MetroFramework.Controls.MetroButton();
            this.tkBarZoom = new MetroFramework.Controls.MetroTrackBar();
            this.btnMoreZoom = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMapsTypes
            // 
            this.cmbMapsTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMapsTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMapsTypes.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbMapsTypes.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cmbMapsTypes.FormattingEnabled = true;
            this.cmbMapsTypes.ItemHeight = 19;
            this.cmbMapsTypes.Location = new System.Drawing.Point(321, 3);
            this.cmbMapsTypes.Name = "cmbMapsTypes";
            this.cmbMapsTypes.Size = new System.Drawing.Size(294, 25);
            this.cmbMapsTypes.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbMapsTypes.TabIndex = 40;
            this.cmbMapsTypes.UseSelectable = true;
            this.cmbMapsTypes.UseStyleColors = true;
            this.cmbMapsTypes.DropDownClosed += new System.EventHandler(this.cmbMapsTypes_DropDownClosed);
            // 
            // btnCentrar
            // 
            this.btnCentrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCentrar.AutoSize = true;
            this.btnCentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCentrar.BackgroundImage = global::HLR.Properties.Resources._1464210083_target;
            this.btnCentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCentrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCentrar.Location = new System.Drawing.Point(595, 193);
            this.btnCentrar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnCentrar.Name = "btnCentrar";
            this.btnCentrar.Size = new System.Drawing.Size(49, 49);
            this.btnCentrar.TabIndex = 43;
            this.btnCentrar.UseSelectable = true;
            this.btnCentrar.Click += new System.EventHandler(this.btnCentrar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnLessZoom);
            this.flowLayoutPanel1.Controls.Add(this.tkBarZoom);
            this.flowLayoutPanel1.Controls.Add(this.btnMoreZoom);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(321, 245);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 29);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // btnLessZoom
            // 
            this.btnLessZoom.AutoSize = true;
            this.btnLessZoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLessZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLessZoom.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLessZoom.Location = new System.Drawing.Point(3, 3);
            this.btnLessZoom.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnLessZoom.Name = "btnLessZoom";
            this.btnLessZoom.Size = new System.Drawing.Size(20, 23);
            this.btnLessZoom.TabIndex = 35;
            this.btnLessZoom.Text = "-";
            this.btnLessZoom.UseSelectable = true;
            this.btnLessZoom.Click += new System.EventHandler(this.btnLessZoom_Click);
            // 
            // tkBarZoom
            // 
            this.tkBarZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tkBarZoom.BackColor = System.Drawing.Color.Transparent;
            this.tkBarZoom.LargeChange = 2;
            this.tkBarZoom.Location = new System.Drawing.Point(26, 3);
            this.tkBarZoom.Maximum = 24;
            this.tkBarZoom.Minimum = 1;
            this.tkBarZoom.Name = "tkBarZoom";
            this.tkBarZoom.Size = new System.Drawing.Size(268, 23);
            this.tkBarZoom.TabIndex = 34;
            this.tkBarZoom.Value = 5;
            this.tkBarZoom.ValueChanged += new System.EventHandler(this.tkBarZoom_ValueChanged);
            // 
            // btnMoreZoom
            // 
            this.btnMoreZoom.AutoSize = true;
            this.btnMoreZoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoreZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoreZoom.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMoreZoom.Location = new System.Drawing.Point(297, 3);
            this.btnMoreZoom.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnMoreZoom.Name = "btnMoreZoom";
            this.btnMoreZoom.Size = new System.Drawing.Size(23, 23);
            this.btnMoreZoom.TabIndex = 36;
            this.btnMoreZoom.Text = "+";
            this.btnMoreZoom.UseSelectable = true;
            this.btnMoreZoom.Click += new System.EventHandler(this.btnMoreZoom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.BackgroundImage = global::HLR.Properties.Resources._1463558222_Update;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRefresh.Location = new System.Drawing.Point(621, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // mapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCentrar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbMapsTypes);
            this.Name = "mapViewer";
            this.Size = new System.Drawing.Size(648, 274);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbMapsTypes;
        private MetroFramework.Controls.MetroButton btnCentrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnLessZoom;
        private MetroFramework.Controls.MetroTrackBar tkBarZoom;
        private MetroFramework.Controls.MetroButton btnMoreZoom;
        public MetroFramework.Controls.MetroButton btnRefresh;
    }
}
