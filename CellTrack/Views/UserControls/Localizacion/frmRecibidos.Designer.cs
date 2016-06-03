namespace CellTrack.Views.UserControls.Localización
{
    partial class frmRecibidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.cmbTargets = new MetroFramework.Controls.MetroComboBox();
            this.bsObjetivos = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fRegistro = new MetroFramework.Controls.MetroLabel();
            this.recibidosModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAct = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblActivo = new MetroFramework.Controls.MetroLabel();
            this.lblSupervisor = new MetroFramework.Controls.MetroLabel();
            this.lblGrupo = new MetroFramework.Controls.MetroLabel();
            this.lblPerfil = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gdObjetivos = new MetroFramework.Controls.MetroGrid();
            this.objetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recibidosModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdObjetivos)).BeginInit();
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
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.AutoSize = true;
            this.btnFind.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFind.Location = new System.Drawing.Point(906, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(63, 59);
            this.btnFind.TabIndex = 32;
            this.metroToolTip.SetToolTip(this.btnFind, "Buscar");
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Localización [ Recibidos ]";
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
            this.splitContainer.Location = new System.Drawing.Point(7, 40);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.cmbTargets);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            this.splitContainer.Panel1.Controls.Add(this.gdObjetivos);
            this.splitContainer.Panel1.Controls.Add(this.btnFind);
            this.splitContainer.Panel1MinSize = 260;
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(972, 553);
            this.splitContainer.SplitterDistance = 260;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 19;
            // 
            // cmbTargets
            // 
            this.cmbTargets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTargets.DataSource = this.bsObjetivos;
            this.cmbTargets.DisplayMember = "descrip";
            this.cmbTargets.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbTargets.FormattingEnabled = true;
            this.cmbTargets.ItemHeight = 23;
            this.cmbTargets.Location = new System.Drawing.Point(3, 33);
            this.cmbTargets.Name = "cmbTargets";
            this.cmbTargets.Size = new System.Drawing.Size(897, 29);
            this.cmbTargets.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbTargets.TabIndex = 35;
            this.cmbTargets.UseSelectable = true;
            this.cmbTargets.UseStyleColors = true;
            this.cmbTargets.ValueMember = "id";
            // 
            // bsObjetivos
            // 
            this.bsObjetivos.DataSource = typeof(CellTrack.Models.PDUModel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 3);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 25);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Objetivo";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fRegistro);
            this.panel1.Controls.Add(this.fAct);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.lblActivo);
            this.panel1.Controls.Add(this.lblSupervisor);
            this.panel1.Controls.Add(this.lblGrupo);
            this.panel1.Controls.Add(this.lblPerfil);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel15);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(779, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 189);
            this.panel1.TabIndex = 34;
            // 
            // fRegistro
            // 
            this.fRegistro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fRegistro.AutoSize = true;
            this.fRegistro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "LAT", true));
            this.fRegistro.FontSize = MetroFramework.MetroLabelSize.Small;
            this.fRegistro.Location = new System.Drawing.Point(45, 145);
            this.fRegistro.Margin = new System.Windows.Forms.Padding(3);
            this.fRegistro.Name = "fRegistro";
            this.fRegistro.Size = new System.Drawing.Size(23, 15);
            this.fRegistro.TabIndex = 82;
            this.fRegistro.Text = "No";
            this.fRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recibidosModelBindingSource
            // 
            this.recibidosModelBindingSource.DataSource = typeof(CellTrack.Models.recibidosModel);
            this.recibidosModelBindingSource.CurrentChanged += new System.EventHandler(this.recibidosModelBindingSource_CurrentChanged);
            // 
            // fAct
            // 
            this.fAct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fAct.AutoSize = true;
            this.fAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "LNG", true));
            this.fAct.FontSize = MetroFramework.MetroLabelSize.Small;
            this.fAct.Location = new System.Drawing.Point(45, 168);
            this.fAct.Margin = new System.Windows.Forms.Padding(3);
            this.fAct.Name = "fAct";
            this.fAct.Size = new System.Drawing.Size(23, 15);
            this.fAct.TabIndex = 81;
            this.fAct.Text = "No";
            this.fAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(3, 164);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 23);
            this.metroLabel11.TabIndex = 80;
            this.metroLabel11.Text = "LNG";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(3, 141);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 23);
            this.metroLabel7.TabIndex = 79;
            this.metroLabel7.Text = "LAT";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActivo
            // 
            this.lblActivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActivo.AutoSize = true;
            this.lblActivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "V", true));
            this.lblActivo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblActivo.Location = new System.Drawing.Point(45, 122);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(3);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(23, 15);
            this.lblActivo.TabIndex = 78;
            this.lblActivo.Text = "No";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "BTS", true));
            this.lblSupervisor.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSupervisor.Location = new System.Drawing.Point(45, 99);
            this.lblSupervisor.Margin = new System.Windows.Forms.Padding(3);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(23, 15);
            this.lblSupervisor.TabIndex = 77;
            this.lblSupervisor.Text = "No";
            this.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "LAC", true));
            this.lblGrupo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblGrupo.Location = new System.Drawing.Point(45, 76);
            this.lblGrupo.Margin = new System.Windows.Forms.Padding(3);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(23, 15);
            this.lblGrupo.TabIndex = 76;
            this.lblGrupo.Text = "No";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerfil
            // 
            this.lblPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "MNC", true));
            this.lblPerfil.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPerfil.Location = new System.Drawing.Point(45, 53);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(3);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(23, 15);
            this.lblPerfil.TabIndex = 75;
            this.lblPerfil.Text = "No";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "MCC", true));
            this.lblUsuario.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUsuario.Location = new System.Drawing.Point(45, 30);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(23, 15);
            this.lblUsuario.TabIndex = 74;
            this.lblUsuario.Text = "No";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recibidosModelBindingSource, "radio", true));
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNombre.Location = new System.Drawing.Point(45, 7);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(23, 15);
            this.lblNombre.TabIndex = 73;
            this.lblNombre.Text = "No";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(3, 118);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(39, 23);
            this.metroLabel10.TabIndex = 72;
            this.metroLabel10.Text = "V";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(3, 95);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(39, 23);
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = "BTS";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 72);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 23);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "LAC";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 49);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 23);
            this.metroLabel4.TabIndex = 69;
            this.metroLabel4.Text = "MNC";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(3, 3);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(39, 23);
            this.metroLabel15.TabIndex = 67;
            this.metroLabel15.Text = "Radio";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 26);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 23);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "MCC";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gdObjetivos
            // 
            this.gdObjetivos.AllowUserToAddRows = false;
            this.gdObjetivos.AllowUserToDeleteRows = false;
            this.gdObjetivos.AllowUserToOrderColumns = true;
            this.gdObjetivos.AllowUserToResizeRows = false;
            this.gdObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdObjetivos.AutoGenerateColumns = false;
            this.gdObjetivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdObjetivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdObjetivos.ColumnHeadersHeight = 30;
            this.gdObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objetivo,
            this.Carrier,
            this.nombre,
            this.tipoDataGridViewTextBoxColumn,
            this.fInsDataGridViewTextBoxColumn});
            this.gdObjetivos.DataSource = this.recibidosModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdObjetivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdObjetivos.EnableHeadersVisualStyles = false;
            this.gdObjetivos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gdObjetivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdObjetivos.HighLightPercentage = 0.5F;
            this.gdObjetivos.Location = new System.Drawing.Point(3, 68);
            this.gdObjetivos.MultiSelect = false;
            this.gdObjetivos.Name = "gdObjetivos";
            this.gdObjetivos.ReadOnly = true;
            this.gdObjetivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gdObjetivos.RowHeadersVisible = false;
            this.gdObjetivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gdObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdObjetivos.ShowEditingIcon = false;
            this.gdObjetivos.Size = new System.Drawing.Size(770, 189);
            this.gdObjetivos.StandardTab = true;
            this.gdObjetivos.Style = MetroFramework.MetroColorStyle.Orange;
            this.gdObjetivos.TabIndex = 33;
            this.gdObjetivos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gdObjetivos.UseStyleColors = true;
            // 
            // objetivo
            // 
            this.objetivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.objetivo.DataPropertyName = "objetivo";
            this.objetivo.HeaderText = "Objetivo";
            this.objetivo.Name = "objetivo";
            this.objetivo.ReadOnly = true;
            this.objetivo.Width = 84;
            // 
            // Carrier
            // 
            this.Carrier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Carrier.DataPropertyName = "Carrier";
            this.Carrier.HeaderText = "Carrier";
            this.Carrier.Name = "Carrier";
            this.Carrier.ReadOnly = true;
            this.Carrier.Width = 73;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 58;
            // 
            // fInsDataGridViewTextBoxColumn
            // 
            this.fInsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fInsDataGridViewTextBoxColumn.DataPropertyName = "fIns";
            this.fInsDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fInsDataGridViewTextBoxColumn.Name = "fInsDataGridViewTextBoxColumn";
            this.fInsDataGridViewTextBoxColumn.ReadOnly = true;
            this.fInsDataGridViewTextBoxColumn.Width = 67;
            // 
            // frmRecibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmRecibidos";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recibidosModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdObjetivos)).EndInit();
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
        private MetroFramework.Controls.MetroGrid gdObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fInsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recibidosModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox cmbTargets;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource bsObjetivos;
        private MetroFramework.Controls.MetroLabel fRegistro;
        private MetroFramework.Controls.MetroLabel fAct;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblActivo;
        private MetroFramework.Controls.MetroLabel lblSupervisor;
        private MetroFramework.Controls.MetroLabel lblGrupo;
        private MetroFramework.Controls.MetroLabel lblPerfil;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnFind;
    }
}
