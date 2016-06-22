namespace CellTrack.Views.UserControls
{
    partial class frmTELMEX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.chkNumero = new MetroFramework.Controls.MetroCheckBox();
            this.chkNombre = new MetroFramework.Controls.MetroCheckBox();
            this.chkDomicilio = new MetroFramework.Controls.MetroCheckBox();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.bsTipos = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tgExacta = new MetroFramework.Controls.MetroToggle();
            this.lblExacta = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkCP = new MetroFramework.Controls.MetroCheckBox();
            this.cmbEntidad = new MetroFramework.Controls.MetroComboBox();
            this.bsEntidades = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtCad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblCantReg = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.gdTELMEX = new MetroFramework.Controls.MetroGrid();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTELMEX = new System.Windows.Forms.BindingSource(this.components);
            this.tlpProc = new System.Windows.Forms.FlowLayoutPanel();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdTELMEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTELMEX)).BeginInit();
            this.tlpProc.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.AutoSize = true;
            this.btnFind.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFind.Location = new System.Drawing.Point(899, 136);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(63, 59);
            this.btnFind.TabIndex = 7;
            this.metroToolTip.SetToolTip(this.btnFind, "Buscar");
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 9, 5, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 44);
            this.btnCancel.TabIndex = 11;
            this.metroToolTip.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.AutoSize = true;
            this.btnFilter.BackgroundImage = global::CellTrack.Properties.Resources._1464813353_zoom;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFilter.Location = new System.Drawing.Point(429, 3);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 9, 5, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(30, 30);
            this.btnFilter.TabIndex = 9;
            this.metroToolTip.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chkNumero
            // 
            this.chkNumero.AutoSize = true;
            this.chkNumero.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkNumero.Location = new System.Drawing.Point(110, 3);
            this.chkNumero.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.chkNumero.Name = "chkNumero";
            this.chkNumero.Size = new System.Drawing.Size(93, 25);
            this.chkNumero.TabIndex = 3;
            this.chkNumero.Text = "Número";
            this.chkNumero.UseSelectable = true;
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkNombre.Location = new System.Drawing.Point(3, 3);
            this.chkNombre.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(94, 25);
            this.chkNombre.TabIndex = 2;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseSelectable = true;
            // 
            // chkDomicilio
            // 
            this.chkDomicilio.AutoSize = true;
            this.chkDomicilio.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkDomicilio.Location = new System.Drawing.Point(216, 3);
            this.chkDomicilio.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.chkDomicilio.Name = "chkDomicilio";
            this.chkDomicilio.Size = new System.Drawing.Size(103, 25);
            this.chkDomicilio.TabIndex = 4;
            this.chkDomicilio.Text = "Domicilio";
            this.chkDomicilio.UseSelectable = true;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registros [ TELMEX ]";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 441;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 35;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(982, 596);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(7, 40);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.cmbTipo);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel6);
            this.splitContainer.Panel1.Controls.Add(this.btnFind);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer.Panel1.Controls.Add(this.tgExacta);
            this.splitContainer.Panel1.Controls.Add(this.lblExacta);
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer.Panel1.Controls.Add(this.cmbEntidad);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel15);
            this.splitContainer.Panel1.Controls.Add(this.txtCad);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer.Panel1MinSize = 150;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnFilter);
            this.splitContainer.Panel2.Controls.Add(this.lblCantReg);
            this.splitContainer.Panel2.Controls.Add(this.metroLabel5);
            this.splitContainer.Panel2.Controls.Add(this.txtFind);
            this.splitContainer.Panel2.Controls.Add(this.gdTELMEX);
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(969, 553);
            this.splitContainer.SplitterDistance = 205;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 19;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.DataSource = this.bsTipos;
            this.cmbTipo.DisplayMember = "value";
            this.cmbTipo.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Location = new System.Drawing.Point(503, 33);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(459, 29);
            this.cmbTipo.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbTipo.TabIndex = 49;
            this.cmbTipo.UseSelectable = true;
            this.cmbTipo.UseStyleColors = true;
            this.cmbTipo.ValueMember = "key";
            // 
            // bsTipos
            // 
            this.bsTipos.DataSource = typeof(CellTrack.Models.Registros.tipoTELMEXModel);
            this.bsTipos.CurrentChanged += new System.EventHandler(this.bsTipos_CurrentChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(503, 2);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 25);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Tipo";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(503, 133);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 25);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Búsqueda Exacta";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 133);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 25);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Buscar en";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgExacta
            // 
            this.tgExacta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tgExacta.AutoSize = true;
            this.tgExacta.DisplayStatus = false;
            this.tgExacta.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tgExacta.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.tgExacta.Location = new System.Drawing.Point(667, 170);
            this.tgExacta.Name = "tgExacta";
            this.tgExacta.Size = new System.Drawing.Size(50, 17);
            this.tgExacta.TabIndex = 6;
            this.tgExacta.Text = "Off";
            this.tgExacta.UseSelectable = true;
            this.tgExacta.CheckedChanged += new System.EventHandler(this.tgExacta_CheckedChanged);
            // 
            // lblExacta
            // 
            this.lblExacta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExacta.AutoSize = true;
            this.lblExacta.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblExacta.Location = new System.Drawing.Point(721, 172);
            this.lblExacta.Margin = new System.Windows.Forms.Padding(3);
            this.lblExacta.Name = "lblExacta";
            this.lblExacta.Size = new System.Drawing.Size(23, 15);
            this.lblExacta.TabIndex = 46;
            this.lblExacta.Text = "No";
            this.lblExacta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.chkNombre);
            this.flowLayoutPanel1.Controls.Add(this.chkNumero);
            this.flowLayoutPanel1.Controls.Add(this.chkDomicilio);
            this.flowLayoutPanel1.Controls.Add(this.chkCP);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 164);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(481, 31);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // chkCP
            // 
            this.chkCP.AutoSize = true;
            this.chkCP.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkCP.Location = new System.Drawing.Point(332, 3);
            this.chkCP.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.chkCP.Name = "chkCP";
            this.chkCP.Size = new System.Drawing.Size(139, 25);
            this.chkCP.TabIndex = 5;
            this.chkCP.Text = "Código Postal";
            this.chkCP.UseSelectable = true;
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEntidad.DataSource = this.bsEntidades;
            this.cmbEntidad.DisplayMember = "noment";
            this.cmbEntidad.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbEntidad.FormattingEnabled = true;
            this.cmbEntidad.ItemHeight = 23;
            this.cmbEntidad.Location = new System.Drawing.Point(3, 33);
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.Size = new System.Drawing.Size(494, 29);
            this.cmbEntidad.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbEntidad.TabIndex = 0;
            this.cmbEntidad.UseSelectable = true;
            this.cmbEntidad.UseStyleColors = true;
            this.cmbEntidad.ValueMember = "nument";
            // 
            // bsEntidades
            // 
            this.bsEntidades.DataSource = typeof(CellTrack.Models.Registros.entidadesModel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(3, 68);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(151, 25);
            this.metroLabel15.TabIndex = 22;
            this.metroLabel15.Text = "Cadena a buscar";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCad
            // 
            this.txtCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCad.CustomButton.Image = null;
            this.txtCad.CustomButton.Location = new System.Drawing.Point(931, 1);
            this.txtCad.CustomButton.Name = "";
            this.txtCad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCad.CustomButton.TabIndex = 1;
            this.txtCad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCad.CustomButton.UseSelectable = true;
            this.txtCad.CustomButton.Visible = false;
            this.txtCad.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCad.Lines = new string[0];
            this.txtCad.Location = new System.Drawing.Point(3, 98);
            this.txtCad.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtCad.MaxLength = 32767;
            this.txtCad.Name = "txtCad";
            this.txtCad.PasswordChar = '\0';
            this.txtCad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCad.SelectedText = "";
            this.txtCad.SelectionLength = 0;
            this.txtCad.SelectionStart = 0;
            this.txtCad.Size = new System.Drawing.Size(959, 29);
            this.txtCad.TabIndex = 1;
            this.txtCad.UseSelectable = true;
            this.txtCad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 2);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Entidad";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantReg
            // 
            this.lblCantReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantReg.AutoSize = true;
            this.lblCantReg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCantReg.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCantReg.Location = new System.Drawing.Point(3, 308);
            this.lblCantReg.Margin = new System.Windows.Forms.Padding(3);
            this.lblCantReg.Name = "lblCantReg";
            this.lblCantReg.Size = new System.Drawing.Size(251, 25);
            this.lblCantReg.TabIndex = 55;
            this.lblCantReg.Text = "[ 00 ] Registros Encontrados";
            this.lblCantReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(1, 4);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 25);
            this.metroLabel5.TabIndex = 54;
            this.metroLabel5.Text = "Filtrar";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(326, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(69, 3);
            this.txtFind.MaxLength = 30;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.Size = new System.Drawing.Size(354, 29);
            this.txtFind.TabIndex = 8;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gdTELMEX
            // 
            this.gdTELMEX.AllowUserToAddRows = false;
            this.gdTELMEX.AllowUserToDeleteRows = false;
            this.gdTELMEX.AllowUserToOrderColumns = true;
            this.gdTELMEX.AllowUserToResizeRows = false;
            this.gdTELMEX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdTELMEX.AutoGenerateColumns = false;
            this.gdTELMEX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdTELMEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdTELMEX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdTELMEX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdTELMEX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdTELMEX.ColumnHeadersHeight = 30;
            this.gdTELMEX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdTELMEX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.cpostalDataGridViewTextBoxColumn,
            this.coloniaDataGridViewTextBoxColumn,
            this.municipioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.centralDataGridViewTextBoxColumn});
            this.gdTELMEX.DataSource = this.bsTELMEX;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdTELMEX.DefaultCellStyle = dataGridViewCellStyle5;
            this.gdTELMEX.EnableHeadersVisualStyles = false;
            this.gdTELMEX.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gdTELMEX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdTELMEX.HighLightPercentage = 0.5F;
            this.gdTELMEX.Location = new System.Drawing.Point(6, 38);
            this.gdTELMEX.MultiSelect = false;
            this.gdTELMEX.Name = "gdTELMEX";
            this.gdTELMEX.ReadOnly = true;
            this.gdTELMEX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdTELMEX.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdTELMEX.RowHeadersVisible = false;
            this.gdTELMEX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gdTELMEX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdTELMEX.ShowEditingIcon = false;
            this.gdTELMEX.Size = new System.Drawing.Size(956, 264);
            this.gdTELMEX.StandardTab = true;
            this.gdTELMEX.Style = MetroFramework.MetroColorStyle.Orange;
            this.gdTELMEX.TabIndex = 10;
            this.gdTELMEX.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gdTELMEX.UseStyleColors = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 82;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpostalDataGridViewTextBoxColumn
            // 
            this.cpostalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cpostalDataGridViewTextBoxColumn.DataPropertyName = "cpostal";
            this.cpostalDataGridViewTextBoxColumn.HeaderText = "Código Postal";
            this.cpostalDataGridViewTextBoxColumn.Name = "cpostalDataGridViewTextBoxColumn";
            this.cpostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpostalDataGridViewTextBoxColumn.Width = 116;
            // 
            // coloniaDataGridViewTextBoxColumn
            // 
            this.coloniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coloniaDataGridViewTextBoxColumn.DataPropertyName = "colonia";
            this.coloniaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.Name = "coloniaDataGridViewTextBoxColumn";
            this.coloniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.coloniaDataGridViewTextBoxColumn.Width = 78;
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            this.municipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.municipioDataGridViewTextBoxColumn.Width = 92;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 73;
            // 
            // centralDataGridViewTextBoxColumn
            // 
            this.centralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.centralDataGridViewTextBoxColumn.DataPropertyName = "central";
            this.centralDataGridViewTextBoxColumn.HeaderText = "Central";
            this.centralDataGridViewTextBoxColumn.Name = "centralDataGridViewTextBoxColumn";
            this.centralDataGridViewTextBoxColumn.ReadOnly = true;
            this.centralDataGridViewTextBoxColumn.Width = 76;
            // 
            // bsTELMEX
            // 
            this.bsTELMEX.DataSource = typeof(CellTrack.Models.Registros.TELMEXModel);
            this.bsTELMEX.DataSourceChanged += new System.EventHandler(this.bsTELMEX_DataSourceChanged);
            // 
            // tlpProc
            // 
            this.tlpProc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpProc.AutoSize = true;
            this.tlpProc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpProc.Controls.Add(this.metroProgressSpinner3);
            this.tlpProc.Controls.Add(this.metroLabel4);
            this.tlpProc.Controls.Add(this.btnCancel);
            this.tlpProc.Location = new System.Drawing.Point(300, 365);
            this.tlpProc.Name = "tlpProc";
            this.tlpProc.Size = new System.Drawing.Size(378, 62);
            this.tlpProc.TabIndex = 24;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(5, 5);
            this.metroProgressSpinner3.Margin = new System.Windows.Forms.Padding(5);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(50, 50);
            this.metroProgressSpinner3.TabIndex = 21;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 50;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel4.Location = new System.Drawing.Point(63, 18);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(258, 25);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Buscando, favor de esperar...";
            // 
            // frmTELMEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpProc);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmTELMEX";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTipos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdTELMEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTELMEX)).EndInit();
            this.tlpProc.ResumeLayout(false);
            this.tlpProc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtCad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbEntidad;
        private MetroFramework.Controls.MetroGrid gdTELMEX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroCheckBox chkNumero;
        private MetroFramework.Controls.MetroCheckBox chkNombre;
        private MetroFramework.Controls.MetroCheckBox chkDomicilio;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle tgExacta;
        private MetroFramework.Controls.MetroLabel lblExacta;
        private MetroFramework.Controls.MetroButton btnFind;
        private System.Windows.Forms.BindingSource bsEntidades;
        private System.Windows.Forms.BindingSource bsTELMEX;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private System.Windows.Forms.FlowLayoutPanel tlpProc;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private MetroFramework.Controls.MetroLabel lblCantReg;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.BindingSource bsTipos;
        private MetroFramework.Controls.MetroCheckBox chkCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralDataGridViewTextBoxColumn;
    }
}
