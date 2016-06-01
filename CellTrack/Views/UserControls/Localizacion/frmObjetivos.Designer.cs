namespace CellTrack.Views.UserControls
{
    partial class frmObjetivos
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
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtfrecuencia = new MetroFramework.Controls.MetroTextBox();
            this.bsObjetivos = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbAgendaA = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbAgendaDe = new MetroFramework.Controls.MetroComboBox();
            this.cmbNotification = new MetroFramework.Controls.MetroComboBox();
            this.bsNotifications = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCarrier = new MetroFramework.Controls.MetroComboBox();
            this.bsCarriers = new System.Windows.Forms.BindingSource(this.components);
            this.pBtns = new System.Windows.Forms.Panel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAsunto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCel = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdObjetivos = new MetroFramework.Controls.MetroGrid();
            this.localizationsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNotificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarriers)).BeginInit();
            this.pBtns.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackgroundImage = global::CellTrack.Properties.Resources._1464227257_save;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(2, 10);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(78, 125);
            this.btnAccept.TabIndex = 13;
            this.metroToolTip.SetToolTip(this.btnAccept, "Guardar");
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(45, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 36);
            this.btnCancel.TabIndex = 15;
            this.metroToolTip.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.AutoSize = true;
            this.btnClear.BackgroundImage = global::CellTrack.Properties.Resources._1464225333_checkbox_unchecked;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(2, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 36);
            this.btnClear.TabIndex = 14;
            this.metroToolTip.SetToolTip(this.btnClear, "Limpiar formulario");
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackgroundImage = global::CellTrack.Properties.Resources._1464226920_pencil;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdit.Location = new System.Drawing.Point(2, 69);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 60);
            this.btnEdit.TabIndex = 2;
            this.metroToolTip.SetToolTip(this.btnEdit, "Editar");
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.BackgroundImage = global::CellTrack.Properties.Resources._1463558222_Update;
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnrefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnrefresh.Location = new System.Drawing.Point(46, 135);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(35, 36);
            this.btnrefresh.TabIndex = 4;
            this.metroToolTip.SetToolTip(this.btnrefresh, "Recargar lista");
            this.btnrefresh.UseSelectable = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackgroundImage = global::CellTrack.Properties.Resources._1464227143_trash;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Location = new System.Drawing.Point(3, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 36);
            this.btnDelete.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.btnDelete, "Eliminar");
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackgroundImage = global::CellTrack.Properties.Resources._1464385007_doc_plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 60);
            this.btnAdd.TabIndex = 1;
            this.metroToolTip.SetToolTip(this.btnAdd, "Agregar nuevo objetivo");
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.label1.Size = new System.Drawing.Size(315, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Localización [ Objetivos ]";
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
            this.splitContainer.Panel1.Controls.Add(this.metroLabel9);
            this.splitContainer.Panel1.Controls.Add(this.txtfrecuencia);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel8);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel7);
            this.splitContainer.Panel1.Controls.Add(this.cmbAgendaA);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel6);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel5);
            this.splitContainer.Panel1.Controls.Add(this.cmbAgendaDe);
            this.splitContainer.Panel1.Controls.Add(this.cmbNotification);
            this.splitContainer.Panel1.Controls.Add(this.cmbCarrier);
            this.splitContainer.Panel1.Controls.Add(this.pBtns);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel15);
            this.splitContainer.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer.Panel1.Controls.Add(this.txtAsunto);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer.Panel1.Controls.Add(this.txtCel);
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.gdObjetivos);
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(969, 553);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 19;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(807, 177);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "minutos";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtfrecuencia
            // 
            this.txtfrecuencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtfrecuencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtfrecuencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtfrecuencia.CustomButton.Image = null;
            this.txtfrecuencia.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtfrecuencia.CustomButton.Name = "";
            this.txtfrecuencia.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtfrecuencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfrecuencia.CustomButton.TabIndex = 1;
            this.txtfrecuencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfrecuencia.CustomButton.UseSelectable = true;
            this.txtfrecuencia.CustomButton.Visible = false;
            this.txtfrecuencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObjetivos, "agendaFrecuencia", true));
            this.txtfrecuencia.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtfrecuencia.Lines = new string[] {
        "30"};
            this.txtfrecuencia.Location = new System.Drawing.Point(765, 167);
            this.txtfrecuencia.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtfrecuencia.MaxLength = 2;
            this.txtfrecuencia.Name = "txtfrecuencia";
            this.txtfrecuencia.PasswordChar = '\0';
            this.txtfrecuencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfrecuencia.SelectedText = "";
            this.txtfrecuencia.SelectionLength = 0;
            this.txtfrecuencia.SelectionStart = 0;
            this.txtfrecuencia.Size = new System.Drawing.Size(38, 29);
            this.txtfrecuencia.TabIndex = 12;
            this.txtfrecuencia.Text = "30";
            this.txtfrecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfrecuencia.UseSelectable = true;
            this.txtfrecuencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfrecuencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtfrecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfrecuencia_KeyPress);
            // 
            // bsObjetivos
            // 
            this.bsObjetivos.DataSource = typeof(CellTrack.Models.localizationsModel);
            this.bsObjetivos.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsObjetivos_AddingNew);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(689, 177);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "frecuencia";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(603, 177);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(16, 19);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "a";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAgendaA
            // 
            this.cmbAgendaA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbAgendaA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObjetivos, "agendaA", true));
            this.cmbAgendaA.FormattingEnabled = true;
            this.cmbAgendaA.ItemHeight = 23;
            this.cmbAgendaA.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbAgendaA.Location = new System.Drawing.Point(625, 167);
            this.cmbAgendaA.Name = "cmbAgendaA";
            this.cmbAgendaA.Size = new System.Drawing.Size(58, 29);
            this.cmbAgendaA.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbAgendaA.TabIndex = 11;
            this.cmbAgendaA.UseSelectable = true;
            this.cmbAgendaA.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(509, 177);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(24, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "de";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(509, 136);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 25);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Agenda";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAgendaDe
            // 
            this.cmbAgendaDe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbAgendaDe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObjetivos, "agendaDe", true));
            this.cmbAgendaDe.FormattingEnabled = true;
            this.cmbAgendaDe.ItemHeight = 23;
            this.cmbAgendaDe.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbAgendaDe.Location = new System.Drawing.Point(539, 167);
            this.cmbAgendaDe.Name = "cmbAgendaDe";
            this.cmbAgendaDe.Size = new System.Drawing.Size(58, 29);
            this.cmbAgendaDe.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbAgendaDe.TabIndex = 10;
            this.cmbAgendaDe.UseSelectable = true;
            this.cmbAgendaDe.UseStyleColors = true;
            // 
            // cmbNotification
            // 
            this.cmbNotification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbNotification.DataSource = this.bsNotifications;
            this.cmbNotification.DisplayMember = "Usuario";
            this.cmbNotification.FormattingEnabled = true;
            this.cmbNotification.ItemHeight = 23;
            this.cmbNotification.Location = new System.Drawing.Point(509, 101);
            this.cmbNotification.Name = "cmbNotification";
            this.cmbNotification.Size = new System.Drawing.Size(357, 29);
            this.cmbNotification.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbNotification.TabIndex = 8;
            this.cmbNotification.UseSelectable = true;
            this.cmbNotification.UseStyleColors = true;
            this.cmbNotification.ValueMember = "id";
            // 
            // bsNotifications
            // 
            this.bsNotifications.DataSource = typeof(CellTrack.Models.DataBases.vwusernotifications);
            // 
            // cmbCarrier
            // 
            this.cmbCarrier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbCarrier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsObjetivos, "idCarrier", true));
            this.cmbCarrier.DataSource = this.bsCarriers;
            this.cmbCarrier.DisplayMember = "carrier";
            this.cmbCarrier.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbCarrier.FormattingEnabled = true;
            this.cmbCarrier.ItemHeight = 23;
            this.cmbCarrier.Location = new System.Drawing.Point(509, 35);
            this.cmbCarrier.Name = "cmbCarrier";
            this.cmbCarrier.Size = new System.Drawing.Size(357, 29);
            this.cmbCarrier.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbCarrier.TabIndex = 6;
            this.cmbCarrier.UseSelectable = true;
            this.cmbCarrier.UseStyleColors = true;
            this.cmbCarrier.ValueMember = "id";
            // 
            // bsCarriers
            // 
            this.bsCarriers.DataSource = typeof(CellTrack.Models.DataBases.vwactivecarriers);
            // 
            // pBtns
            // 
            this.pBtns.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pBtns.AutoSize = true;
            this.pBtns.Controls.Add(this.btnAccept);
            this.pBtns.Controls.Add(this.btnCancel);
            this.pBtns.Controls.Add(this.btnClear);
            this.pBtns.Location = new System.Drawing.Point(877, 5);
            this.pBtns.Name = "pBtns";
            this.pBtns.Size = new System.Drawing.Size(85, 191);
            this.pBtns.TabIndex = 31;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(3, 4);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(81, 25);
            this.metroLabel15.TabIndex = 22;
            this.metroLabel15.Text = "Nombre";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(466, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObjetivos, "nombre", true));
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(3, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(494, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(509, 5);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Carrier";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 70);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 25);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Asunto";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtAsunto.CustomButton.Image = null;
            this.txtAsunto.CustomButton.Location = new System.Drawing.Point(466, 1);
            this.txtAsunto.CustomButton.Name = "";
            this.txtAsunto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAsunto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAsunto.CustomButton.TabIndex = 1;
            this.txtAsunto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAsunto.CustomButton.UseSelectable = true;
            this.txtAsunto.CustomButton.Visible = false;
            this.txtAsunto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObjetivos, "asunto", true));
            this.txtAsunto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAsunto.Lines = new string[0];
            this.txtAsunto.Location = new System.Drawing.Point(3, 101);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtAsunto.MaxLength = 32767;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.PasswordChar = '\0';
            this.txtAsunto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAsunto.SelectedText = "";
            this.txtAsunto.SelectionLength = 0;
            this.txtAsunto.SelectionStart = 0;
            this.txtAsunto.Size = new System.Drawing.Size(494, 29);
            this.txtAsunto.TabIndex = 7;
            this.txtAsunto.UseSelectable = true;
            this.txtAsunto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAsunto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(509, 70);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 25);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Notificación";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 136);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Celular";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCel
            // 
            this.txtCel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCel.CustomButton.Image = null;
            this.txtCel.CustomButton.Location = new System.Drawing.Point(466, 1);
            this.txtCel.CustomButton.Name = "";
            this.txtCel.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCel.CustomButton.TabIndex = 1;
            this.txtCel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCel.CustomButton.UseSelectable = true;
            this.txtCel.CustomButton.Visible = false;
            this.txtCel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObjetivos, "objetivo", true));
            this.txtCel.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCel.Lines = new string[0];
            this.txtCel.Location = new System.Drawing.Point(3, 167);
            this.txtCel.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtCel.MaxLength = 10;
            this.txtCel.Name = "txtCel";
            this.txtCel.PasswordChar = '\0';
            this.txtCel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCel.SelectedText = "";
            this.txtCel.SelectionLength = 0;
            this.txtCel.SelectionStart = 0;
            this.txtCel.Size = new System.Drawing.Size(494, 29);
            this.txtCel.TabIndex = 9;
            this.txtCel.UseSelectable = true;
            this.txtCel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(877, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 175);
            this.panel1.TabIndex = 32;
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
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.objetivoDataGridViewTextBoxColumn,
            this.idNotificationDataGridViewTextBoxColumn,
            this.notificationNameDataGridViewTextBoxColumn,
            this.idCarrierDataGridViewTextBoxColumn,
            this.carrierDataGridViewTextBoxColumn,
            this.agendaDataGridViewTextBoxColumn});
            this.gdObjetivos.DataSource = this.localizationsModelBindingSource;
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
            this.gdObjetivos.Location = new System.Drawing.Point(3, 3);
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
            this.gdObjetivos.Size = new System.Drawing.Size(865, 331);
            this.gdObjetivos.StandardTab = true;
            this.gdObjetivos.Style = MetroFramework.MetroColorStyle.Orange;
            this.gdObjetivos.TabIndex = 0;
            this.gdObjetivos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gdObjetivos.UseStyleColors = true;
            // 
            // localizationsModelBindingSource
            // 
            this.localizationsModelBindingSource.DataSource = typeof(CellTrack.Models.localizationsModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 44;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objetivoDataGridViewTextBoxColumn
            // 
            this.objetivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.objetivoDataGridViewTextBoxColumn.DataPropertyName = "objetivo";
            this.objetivoDataGridViewTextBoxColumn.HeaderText = "Objetivo";
            this.objetivoDataGridViewTextBoxColumn.Name = "objetivoDataGridViewTextBoxColumn";
            this.objetivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.objetivoDataGridViewTextBoxColumn.Width = 84;
            // 
            // idNotificationDataGridViewTextBoxColumn
            // 
            this.idNotificationDataGridViewTextBoxColumn.DataPropertyName = "idNotification";
            this.idNotificationDataGridViewTextBoxColumn.HeaderText = "idNotification";
            this.idNotificationDataGridViewTextBoxColumn.Name = "idNotificationDataGridViewTextBoxColumn";
            this.idNotificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNotificationDataGridViewTextBoxColumn.Visible = false;
            // 
            // notificationNameDataGridViewTextBoxColumn
            // 
            this.notificationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notificationNameDataGridViewTextBoxColumn.DataPropertyName = "NotificationName";
            this.notificationNameDataGridViewTextBoxColumn.HeaderText = "Notificación";
            this.notificationNameDataGridViewTextBoxColumn.Name = "notificationNameDataGridViewTextBoxColumn";
            this.notificationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCarrierDataGridViewTextBoxColumn
            // 
            this.idCarrierDataGridViewTextBoxColumn.DataPropertyName = "idCarrier";
            this.idCarrierDataGridViewTextBoxColumn.HeaderText = "idCarrier";
            this.idCarrierDataGridViewTextBoxColumn.Name = "idCarrierDataGridViewTextBoxColumn";
            this.idCarrierDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarrierDataGridViewTextBoxColumn.Visible = false;
            // 
            // carrierDataGridViewTextBoxColumn
            // 
            this.carrierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carrierDataGridViewTextBoxColumn.DataPropertyName = "Carrier";
            this.carrierDataGridViewTextBoxColumn.HeaderText = "Carrier";
            this.carrierDataGridViewTextBoxColumn.Name = "carrierDataGridViewTextBoxColumn";
            this.carrierDataGridViewTextBoxColumn.ReadOnly = true;
            this.carrierDataGridViewTextBoxColumn.Width = 73;
            // 
            // agendaDataGridViewTextBoxColumn
            // 
            this.agendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.agendaDataGridViewTextBoxColumn.DataPropertyName = "Agenda";
            this.agendaDataGridViewTextBoxColumn.HeaderText = "Agenda";
            this.agendaDataGridViewTextBoxColumn.Name = "agendaDataGridViewTextBoxColumn";
            this.agendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmObjetivos";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarriers)).EndInit();
            this.pBtns.ResumeLayout(false);
            this.pBtns.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationsModelBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel pBtns;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAsunto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCel;
        private MetroFramework.Controls.MetroComboBox cmbNotification;
        private MetroFramework.Controls.MetroComboBox cmbCarrier;
        private MetroFramework.Controls.MetroGrid gdObjetivos;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnrefresh;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.BindingSource bsCarriers;
        private System.Windows.Forms.BindingSource bsNotifications;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtfrecuencia;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbAgendaA;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbAgendaDe;
        private System.Windows.Forms.BindingSource bsObjetivos;
        private System.Windows.Forms.BindingSource localizationsModelBindingSource;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNotificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agendaDataGridViewTextBoxColumn;
    }
}
