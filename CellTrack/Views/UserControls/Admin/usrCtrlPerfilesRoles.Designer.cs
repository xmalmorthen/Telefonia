namespace CellTrack.Views.UserControls.Admin
{
    partial class usrCtrlPerfilesRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnRefreshRoles = new MetroFramework.Controls.MetroButton();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnSelectionNone = new MetroFramework.Controls.MetroButton();
            this.btnSelectAll = new MetroFramework.Controls.MetroButton();
            this.gdRolesAsignados = new MetroFramework.Controls.MetroGrid();
            this.carolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tgGpoActivo = new MetroFramework.Controls.MetroToggle();
            this.caperfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblActivo = new MetroFramework.Controls.MetroLabel();
            this.pnlBtnsActions = new System.Windows.Forms.Panel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtPerfil = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gd = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reperfilrolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectRol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fActDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.causuariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reperfilrolesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdRolesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caperfilesBindingSource)).BeginInit();
            this.pnlBtnsActions.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnRefreshRoles
            // 
            this.btnRefreshRoles.AutoSize = true;
            this.btnRefreshRoles.BackgroundImage = global::CellTrack.Properties.Resources._1463558222_Update;
            this.btnRefreshRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshRoles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefreshRoles.Location = new System.Drawing.Point(3, 171);
            this.btnRefreshRoles.Name = "btnRefreshRoles";
            this.btnRefreshRoles.Size = new System.Drawing.Size(35, 36);
            this.btnRefreshRoles.TabIndex = 10;
            this.metroToolTip.SetToolTip(this.btnRefreshRoles, "Recargar lista");
            this.btnRefreshRoles.UseSelectable = true;
            this.btnRefreshRoles.Click += new System.EventHandler(this.btnRefreshRoles_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackgroundImage = global::CellTrack.Properties.Resources._1464227257_save;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(78, 120);
            this.btnAccept.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.btnAccept, "Guardar");
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(46, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 36);
            this.btnCancel.TabIndex = 5;
            this.metroToolTip.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackgroundImage = global::CellTrack.Properties.Resources._1464225333_checkbox_unchecked;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(3, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 36);
            this.btnClear.TabIndex = 4;
            this.metroToolTip.SetToolTip(this.btnClear, "Limpiar formulario");
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnAdd.TabIndex = 7;
            this.metroToolTip.SetToolTip(this.btnAdd, "Agregar nuevo usuario");
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.TabIndex = 8;
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
            this.btnrefresh.TabIndex = 10;
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
            this.btnDelete.TabIndex = 9;
            this.metroToolTip.SetToolTip(this.btnDelete, "Eliminar");
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnSelectionNone);
            this.splitContainer.Panel1.Controls.Add(this.btnSelectAll);
            this.splitContainer.Panel1.Controls.Add(this.gdRolesAsignados);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer.Panel1.Controls.Add(this.tgGpoActivo);
            this.splitContainer.Panel1.Controls.Add(this.lblActivo);
            this.splitContainer.Panel1.Controls.Add(this.pnlBtnsActions);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel20);
            this.splitContainer.Panel1.Controls.Add(this.txtPerfil);
            this.splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.metroLabel11);
            this.splitContainer.Panel2.Controls.Add(this.metroLabel7);
            this.splitContainer.Panel2.Controls.Add(this.txtFind);
            this.splitContainer.Panel2.Controls.Add(this.panel3);
            this.splitContainer.Panel2.Controls.Add(this.gd);
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(961, 614);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 24;
            // 
            // btnSelectionNone
            // 
            this.btnSelectionNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectionNone.AutoSize = true;
            this.btnSelectionNone.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSelectionNone.Location = new System.Drawing.Point(628, 72);
            this.btnSelectionNone.Name = "btnSelectionNone";
            this.btnSelectionNone.Size = new System.Drawing.Size(100, 23);
            this.btnSelectionNone.TabIndex = 49;
            this.btnSelectionNone.Text = "Seleccionar nada";
            this.btnSelectionNone.UseSelectable = true;
            this.btnSelectionNone.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.AutoSize = true;
            this.btnSelectAll.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSelectAll.Location = new System.Drawing.Point(525, 72);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(97, 23);
            this.btnSelectAll.TabIndex = 48;
            this.btnSelectAll.Text = "Seleccionar todo";
            this.btnSelectAll.UseSelectable = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // gdRolesAsignados
            // 
            this.gdRolesAsignados.AllowUserToAddRows = false;
            this.gdRolesAsignados.AllowUserToDeleteRows = false;
            this.gdRolesAsignados.AllowUserToOrderColumns = true;
            this.gdRolesAsignados.AllowUserToResizeRows = false;
            this.gdRolesAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdRolesAsignados.AutoGenerateColumns = false;
            this.gdRolesAsignados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdRolesAsignados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdRolesAsignados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdRolesAsignados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdRolesAsignados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdRolesAsignados.ColumnHeadersHeight = 30;
            this.gdRolesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdRolesAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fInsDataGridViewTextBoxColumn,
            this.fActDataGridViewTextBoxColumn,
            this.reperfilrolesDataGridViewTextBoxColumn,
            this.SelectRol});
            this.gdRolesAsignados.DataSource = this.carolesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdRolesAsignados.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdRolesAsignados.EnableHeadersVisualStyles = false;
            this.gdRolesAsignados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gdRolesAsignados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gdRolesAsignados.HighLightPercentage = 0.5F;
            this.gdRolesAsignados.Location = new System.Drawing.Point(3, 101);
            this.gdRolesAsignados.MultiSelect = false;
            this.gdRolesAsignados.Name = "gdRolesAsignados";
            this.gdRolesAsignados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdRolesAsignados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gdRolesAsignados.RowHeadersVisible = false;
            this.gdRolesAsignados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gdRolesAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdRolesAsignados.ShowEditingIcon = false;
            this.gdRolesAsignados.Size = new System.Drawing.Size(861, 144);
            this.gdRolesAsignados.StandardTab = true;
            this.gdRolesAsignados.Style = MetroFramework.MetroColorStyle.Orange;
            this.gdRolesAsignados.TabIndex = 47;
            this.gdRolesAsignados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gdRolesAsignados.UseStyleColors = true;
            // 
            // carolesBindingSource
            // 
            this.carolesBindingSource.DataSource = typeof(CellTrack.Models.DataBases.caroles);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 70);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 25);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "Roles";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgGpoActivo
            // 
            this.tgGpoActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tgGpoActivo.AutoSize = true;
            this.tgGpoActivo.Checked = true;
            this.tgGpoActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgGpoActivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.caperfilesBindingSource, "activo", true));
            this.tgGpoActivo.DisplayStatus = false;
            this.tgGpoActivo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tgGpoActivo.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.tgGpoActivo.Location = new System.Drawing.Point(770, 70);
            this.tgGpoActivo.Name = "tgGpoActivo";
            this.tgGpoActivo.Size = new System.Drawing.Size(50, 17);
            this.tgGpoActivo.TabIndex = 2;
            this.tgGpoActivo.Text = "On";
            this.tgGpoActivo.UseSelectable = true;
            this.tgGpoActivo.CheckedChanged += new System.EventHandler(this.tgGpoActivo_CheckedChanged);
            // 
            // caperfilesBindingSource
            // 
            this.caperfilesBindingSource.DataSource = typeof(CellTrack.Models.DataBases.caperfiles);
            this.caperfilesBindingSource.CurrentChanged += new System.EventHandler(this.caperfilesBindingSource_CurrentChanged);
            // 
            // lblActivo
            // 
            this.lblActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActivo.AutoSize = true;
            this.lblActivo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblActivo.Location = new System.Drawing.Point(826, 70);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(3);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(38, 15);
            this.lblActivo.TabIndex = 44;
            this.lblActivo.Text = "Activo";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBtnsActions
            // 
            this.pnlBtnsActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnsActions.AutoSize = true;
            this.pnlBtnsActions.Controls.Add(this.btnRefreshRoles);
            this.pnlBtnsActions.Controls.Add(this.btnAccept);
            this.pnlBtnsActions.Controls.Add(this.btnCancel);
            this.pnlBtnsActions.Controls.Add(this.btnClear);
            this.pnlBtnsActions.Location = new System.Drawing.Point(872, 3);
            this.pnlBtnsActions.Name = "pnlBtnsActions";
            this.pnlBtnsActions.Size = new System.Drawing.Size(84, 210);
            this.pnlBtnsActions.TabIndex = 31;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(3, 4);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(161, 25);
            this.metroLabel20.TabIndex = 22;
            this.metroLabel20.Text = "Nombre del Perfil";
            this.metroLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPerfil
            // 
            this.txtPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPerfil.CustomButton.Image = null;
            this.txtPerfil.CustomButton.Location = new System.Drawing.Point(833, 1);
            this.txtPerfil.CustomButton.Name = "";
            this.txtPerfil.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPerfil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPerfil.CustomButton.TabIndex = 1;
            this.txtPerfil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPerfil.CustomButton.UseSelectable = true;
            this.txtPerfil.CustomButton.Visible = false;
            this.txtPerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caperfilesBindingSource, "perfil", true));
            this.txtPerfil.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPerfil.Lines = new string[0];
            this.txtPerfil.Location = new System.Drawing.Point(3, 35);
            this.txtPerfil.MaxLength = 50;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.PasswordChar = '\0';
            this.txtPerfil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPerfil.SelectedText = "";
            this.txtPerfil.SelectionLength = 0;
            this.txtPerfil.SelectionStart = 0;
            this.txtPerfil.Size = new System.Drawing.Size(861, 29);
            this.txtPerfil.TabIndex = 0;
            this.txtPerfil.UseSelectable = true;
            this.txtPerfil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPerfil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(411, 4);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(90, 15);
            this.metroLabel11.TabIndex = 46;
            this.metroLabel11.Text = "Filtra por [ Perfil ]";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(3, 21);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 25);
            this.metroLabel7.TabIndex = 40;
            this.metroLabel7.Text = "Filtrar";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtFind.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(71, 20);
            this.txtFind.MaxLength = 30;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.Size = new System.Drawing.Size(430, 29);
            this.txtFind.TabIndex = 39;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnrefresh);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(870, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 175);
            this.panel3.TabIndex = 32;
            // 
            // gd
            // 
            this.gd.AllowUserToAddRows = false;
            this.gd.AllowUserToDeleteRows = false;
            this.gd.AllowUserToOrderColumns = true;
            this.gd.AllowUserToResizeRows = false;
            this.gd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gd.AutoGenerateColumns = false;
            this.gd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gd.ColumnHeadersHeight = 30;
            this.gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.perfilDataGridViewTextBoxColumn,
            this.fInsDataGridViewTextBoxColumn1,
            this.fActDataGridViewTextBoxColumn1,
            this.activoDataGridViewCheckBoxColumn,
            this.causuariosDataGridViewTextBoxColumn,
            this.reperfilrolesDataGridViewTextBoxColumn1});
            this.gd.DataSource = this.caperfilesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gd.DefaultCellStyle = dataGridViewCellStyle5;
            this.gd.EnableHeadersVisualStyles = false;
            this.gd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gd.HighLightPercentage = 0.5F;
            this.gd.Location = new System.Drawing.Point(3, 55);
            this.gd.MultiSelect = false;
            this.gd.Name = "gd";
            this.gd.ReadOnly = true;
            this.gd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gd.RowHeadersVisible = false;
            this.gd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd.ShowEditingIcon = false;
            this.gd.Size = new System.Drawing.Size(861, 291);
            this.gd.StandardTab = true;
            this.gd.Style = MetroFramework.MetroColorStyle.Orange;
            this.gd.TabIndex = 6;
            this.gd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gd.UseStyleColors = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.Width = 51;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // fInsDataGridViewTextBoxColumn
            // 
            this.fInsDataGridViewTextBoxColumn.DataPropertyName = "fIns";
            this.fInsDataGridViewTextBoxColumn.HeaderText = "fIns";
            this.fInsDataGridViewTextBoxColumn.Name = "fInsDataGridViewTextBoxColumn";
            this.fInsDataGridViewTextBoxColumn.Visible = false;
            // 
            // fActDataGridViewTextBoxColumn
            // 
            this.fActDataGridViewTextBoxColumn.DataPropertyName = "fAct";
            this.fActDataGridViewTextBoxColumn.HeaderText = "fAct";
            this.fActDataGridViewTextBoxColumn.Name = "fActDataGridViewTextBoxColumn";
            this.fActDataGridViewTextBoxColumn.Visible = false;
            // 
            // reperfilrolesDataGridViewTextBoxColumn
            // 
            this.reperfilrolesDataGridViewTextBoxColumn.DataPropertyName = "reperfilroles";
            this.reperfilrolesDataGridViewTextBoxColumn.HeaderText = "reperfilroles";
            this.reperfilrolesDataGridViewTextBoxColumn.Name = "reperfilrolesDataGridViewTextBoxColumn";
            this.reperfilrolesDataGridViewTextBoxColumn.Visible = false;
            // 
            // SelectRol
            // 
            this.SelectRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectRol.HeaderText = "Asignado";
            this.SelectRol.MinimumWidth = 59;
            this.SelectRol.Name = "SelectRol";
            this.SelectRol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectRol.Width = 89;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 44;
            // 
            // perfilDataGridViewTextBoxColumn
            // 
            this.perfilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.perfilDataGridViewTextBoxColumn.DataPropertyName = "perfil";
            this.perfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.perfilDataGridViewTextBoxColumn.Name = "perfilDataGridViewTextBoxColumn";
            this.perfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.perfilDataGridViewTextBoxColumn.Width = 61;
            // 
            // fInsDataGridViewTextBoxColumn1
            // 
            this.fInsDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fInsDataGridViewTextBoxColumn1.DataPropertyName = "fIns";
            this.fInsDataGridViewTextBoxColumn1.HeaderText = "Fecha de Registro";
            this.fInsDataGridViewTextBoxColumn1.Name = "fInsDataGridViewTextBoxColumn1";
            this.fInsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fInsDataGridViewTextBoxColumn1.Width = 140;
            // 
            // fActDataGridViewTextBoxColumn1
            // 
            this.fActDataGridViewTextBoxColumn1.DataPropertyName = "fAct";
            this.fActDataGridViewTextBoxColumn1.HeaderText = "fAct";
            this.fActDataGridViewTextBoxColumn1.Name = "fActDataGridViewTextBoxColumn1";
            this.fActDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fActDataGridViewTextBoxColumn1.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 51;
            // 
            // causuariosDataGridViewTextBoxColumn
            // 
            this.causuariosDataGridViewTextBoxColumn.DataPropertyName = "causuarios";
            this.causuariosDataGridViewTextBoxColumn.HeaderText = "causuarios";
            this.causuariosDataGridViewTextBoxColumn.Name = "causuariosDataGridViewTextBoxColumn";
            this.causuariosDataGridViewTextBoxColumn.ReadOnly = true;
            this.causuariosDataGridViewTextBoxColumn.Visible = false;
            // 
            // reperfilrolesDataGridViewTextBoxColumn1
            // 
            this.reperfilrolesDataGridViewTextBoxColumn1.DataPropertyName = "reperfilroles";
            this.reperfilrolesDataGridViewTextBoxColumn1.HeaderText = "reperfilroles";
            this.reperfilrolesDataGridViewTextBoxColumn1.Name = "reperfilrolesDataGridViewTextBoxColumn1";
            this.reperfilrolesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.reperfilrolesDataGridViewTextBoxColumn1.Visible = false;
            // 
            // usrCtrlPerfilesRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.Name = "usrCtrlPerfilesRoles";
            this.Size = new System.Drawing.Size(961, 614);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdRolesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caperfilesBindingSource)).EndInit();
            this.pnlBtnsActions.ResumeLayout(false);
            this.pnlBtnsActions.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.BindingSource carolesBindingSource;
        private System.Windows.Forms.BindingSource caperfilesBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer;
        private MetroFramework.Controls.MetroButton btnRefreshRoles;
        private MetroFramework.Controls.MetroGrid gdRolesAsignados;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle tgGpoActivo;
        private MetroFramework.Controls.MetroLabel lblActivo;
        private System.Windows.Forms.Panel pnlBtnsActions;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtPerfil;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnrefresh;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroGrid gd;
        private MetroFramework.Controls.MetroButton btnSelectionNone;
        private MetroFramework.Controls.MetroButton btnSelectAll;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fInsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reperfilrolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fInsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fActDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causuariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reperfilrolesDataGridViewTextBoxColumn1;
    }
}
