namespace Satelites.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.gdCells = new MetroFramework.Controls.MetroGrid();
            this.pnlMap = new MetroFramework.Controls.MetroPanel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.gdReceivers = new MetroFramework.Controls.MetroGrid();
            this.pnlProc = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRFCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rxLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRFCNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rxLevelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eRRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiversModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCells)).BeginInit();
            this.pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdReceivers)).BeginInit();
            this.pnlProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiversModelBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImage = global::Satelites.Properties.Resources._1463426130_delete;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(811, 23);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 4;
            this.btnClose.Tag = "0";
            this.metroToolTip.SetToolTip(this.btnClose, "Cerrar sistema...");
            this.btnClose.UseSelectable = true;
            this.btnClose.UseStyleColors = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.gdCells);
            this.pnlMain.Controls.Add(this.pnlMap);
            this.pnlMain.Controls.Add(this.gdReceivers);
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(23, 91);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(848, 455);
            this.pnlMain.TabIndex = 5;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            this.pnlMain.Resize += new System.EventHandler(this.pnlMain_Resize);
            // 
            // gdCells
            // 
            this.gdCells.AllowUserToAddRows = false;
            this.gdCells.AllowUserToDeleteRows = false;
            this.gdCells.AllowUserToOrderColumns = true;
            this.gdCells.AllowUserToResizeRows = false;
            this.gdCells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gdCells.AutoGenerateColumns = false;
            this.gdCells.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdCells.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdCells.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdCells.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdCells.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdCells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdCells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aRFCNDataGridViewTextBoxColumn,
            this.cellIdDataGridViewTextBoxColumn,
            this.bandDataGridViewTextBoxColumn,
            this.rxLevelDataGridViewTextBoxColumn,
            this.lACDataGridViewTextBoxColumn,
            this.mCCDataGridViewTextBoxColumn,
            this.mNCDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.iMEIDataGridViewTextBoxColumn});
            this.gdCells.DataSource = this.cellsModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdCells.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdCells.EnableHeadersVisualStyles = false;
            this.gdCells.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gdCells.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdCells.Location = new System.Drawing.Point(3, 3);
            this.gdCells.Name = "gdCells";
            this.gdCells.ReadOnly = true;
            this.gdCells.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdCells.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gdCells.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gdCells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdCells.Size = new System.Drawing.Size(393, 447);
            this.gdCells.Style = MetroFramework.MetroColorStyle.Brown;
            this.gdCells.TabIndex = 4;
            this.gdCells.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pnlMap
            // 
            this.pnlMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMap.Controls.Add(this.gMapControl1);
            this.pnlMap.HorizontalScrollbarBarColor = true;
            this.pnlMap.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMap.HorizontalScrollbarSize = 10;
            this.pnlMap.Location = new System.Drawing.Point(402, 245);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(441, 205);
            this.pnlMap.TabIndex = 3;
            this.pnlMap.VerticalScrollbarBarColor = true;
            this.pnlMap.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMap.VerticalScrollbarSize = 10;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(441, 205);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 0D;
            // 
            // gdReceivers
            // 
            this.gdReceivers.AllowUserToAddRows = false;
            this.gdReceivers.AllowUserToDeleteRows = false;
            this.gdReceivers.AllowUserToOrderColumns = true;
            this.gdReceivers.AllowUserToResizeRows = false;
            this.gdReceivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gdReceivers.AutoGenerateColumns = false;
            this.gdReceivers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdReceivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdReceivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdReceivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdReceivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdReceivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdReceivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.aRFCNDataGridViewTextBoxColumn1,
            this.cellIdDataGridViewTextBoxColumn1,
            this.rxLevelDataGridViewTextBoxColumn1,
            this.eRRDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn});
            this.gdReceivers.DataSource = this.receiversModelBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdReceivers.DefaultCellStyle = dataGridViewCellStyle5;
            this.gdReceivers.EnableHeadersVisualStyles = false;
            this.gdReceivers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gdReceivers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdReceivers.Location = new System.Drawing.Point(402, 3);
            this.gdReceivers.Name = "gdReceivers";
            this.gdReceivers.ReadOnly = true;
            this.gdReceivers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdReceivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdReceivers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gdReceivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdReceivers.Size = new System.Drawing.Size(441, 236);
            this.gdReceivers.Style = MetroFramework.MetroColorStyle.Brown;
            this.gdReceivers.TabIndex = 2;
            this.gdReceivers.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.pnlProc.Location = new System.Drawing.Point(27, 414);
            this.pnlProc.Name = "pnlProc";
            this.pnlProc.Size = new System.Drawing.Size(238, 128);
            this.pnlProc.TabIndex = 6;
            this.pnlProc.VerticalScrollbarBarColor = true;
            this.pnlProc.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProc.VerticalScrollbarSize = 10;
            this.pnlProc.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-2, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procesando, favor de esperar...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Satelites.Properties.Resources.loading_gallery;
            this.pictureBox1.Location = new System.Drawing.Point(68, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aRFCNDataGridViewTextBoxColumn
            // 
            this.aRFCNDataGridViewTextBoxColumn.DataPropertyName = "ARFCN";
            this.aRFCNDataGridViewTextBoxColumn.HeaderText = "ARFCN";
            this.aRFCNDataGridViewTextBoxColumn.Name = "aRFCNDataGridViewTextBoxColumn";
            this.aRFCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellIdDataGridViewTextBoxColumn
            // 
            this.cellIdDataGridViewTextBoxColumn.DataPropertyName = "CellId";
            this.cellIdDataGridViewTextBoxColumn.HeaderText = "Cell-Id";
            this.cellIdDataGridViewTextBoxColumn.Name = "cellIdDataGridViewTextBoxColumn";
            this.cellIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bandDataGridViewTextBoxColumn
            // 
            this.bandDataGridViewTextBoxColumn.DataPropertyName = "Band";
            this.bandDataGridViewTextBoxColumn.HeaderText = "Band";
            this.bandDataGridViewTextBoxColumn.Name = "bandDataGridViewTextBoxColumn";
            this.bandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rxLevelDataGridViewTextBoxColumn
            // 
            this.rxLevelDataGridViewTextBoxColumn.DataPropertyName = "RxLevel";
            this.rxLevelDataGridViewTextBoxColumn.HeaderText = "RxLevel";
            this.rxLevelDataGridViewTextBoxColumn.Name = "rxLevelDataGridViewTextBoxColumn";
            this.rxLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lACDataGridViewTextBoxColumn
            // 
            this.lACDataGridViewTextBoxColumn.DataPropertyName = "LAC";
            this.lACDataGridViewTextBoxColumn.HeaderText = "LAC";
            this.lACDataGridViewTextBoxColumn.Name = "lACDataGridViewTextBoxColumn";
            this.lACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mCCDataGridViewTextBoxColumn
            // 
            this.mCCDataGridViewTextBoxColumn.DataPropertyName = "MCC";
            this.mCCDataGridViewTextBoxColumn.HeaderText = "MCC";
            this.mCCDataGridViewTextBoxColumn.Name = "mCCDataGridViewTextBoxColumn";
            this.mCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mNCDataGridViewTextBoxColumn
            // 
            this.mNCDataGridViewTextBoxColumn.DataPropertyName = "MNC";
            this.mNCDataGridViewTextBoxColumn.HeaderText = "MNC";
            this.mNCDataGridViewTextBoxColumn.Name = "mNCDataGridViewTextBoxColumn";
            this.mNCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMEIDataGridViewTextBoxColumn
            // 
            this.iMEIDataGridViewTextBoxColumn.DataPropertyName = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.HeaderText = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.Name = "iMEIDataGridViewTextBoxColumn";
            this.iMEIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellsModelBindingSource
            // 
            this.cellsModelBindingSource.DataSource = typeof(Satelites.Models.cellsModel);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aRFCNDataGridViewTextBoxColumn1
            // 
            this.aRFCNDataGridViewTextBoxColumn1.DataPropertyName = "ARFCN";
            this.aRFCNDataGridViewTextBoxColumn1.HeaderText = "ARFCN";
            this.aRFCNDataGridViewTextBoxColumn1.Name = "aRFCNDataGridViewTextBoxColumn1";
            this.aRFCNDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cellIdDataGridViewTextBoxColumn1
            // 
            this.cellIdDataGridViewTextBoxColumn1.DataPropertyName = "CellId";
            this.cellIdDataGridViewTextBoxColumn1.HeaderText = "Cell-Id";
            this.cellIdDataGridViewTextBoxColumn1.Name = "cellIdDataGridViewTextBoxColumn1";
            this.cellIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rxLevelDataGridViewTextBoxColumn1
            // 
            this.rxLevelDataGridViewTextBoxColumn1.DataPropertyName = "RxLevel";
            this.rxLevelDataGridViewTextBoxColumn1.HeaderText = "RxLevel";
            this.rxLevelDataGridViewTextBoxColumn1.Name = "rxLevelDataGridViewTextBoxColumn1";
            this.rxLevelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eRRDataGridViewTextBoxColumn
            // 
            this.eRRDataGridViewTextBoxColumn.DataPropertyName = "ERR";
            this.eRRDataGridViewTextBoxColumn.HeaderText = "Err%";
            this.eRRDataGridViewTextBoxColumn.Name = "eRRDataGridViewTextBoxColumn";
            this.eRRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiversModelBindingSource
            // 
            this.receiversModelBindingSource.DataSource = typeof(Satelites.Models.receiversModel);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 569);
            this.Controls.Add(this.pnlProc);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnClose);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Panel de Antenas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdCells)).EndInit();
            this.pnlMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdReceivers)).EndInit();
            this.pnlProc.ResumeLayout(false);
            this.pnlProc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiversModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroGrid gdCells;
        private MetroFramework.Controls.MetroPanel pnlMap;
        private MetroFramework.Controls.MetroGrid gdReceivers;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private MetroFramework.Controls.MetroPanel pnlProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRFCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cellsModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRFCNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxLevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eRRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receiversModelBindingSource;
    }
}