namespace CellTrack.Views.UserControls.Admin
{
    partial class usrCtrlGpos
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
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tgGpoActivo = new MetroFramework.Controls.MetroToggle();
            this.cagruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblActivo = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtGrupo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtDescrip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gd = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.causuariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cagruposBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
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
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackgroundImage = global::CellTrack.Properties.Resources._1464227257_save;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(5, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(78, 59);
            this.btnAccept.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.btnAccept, "Guardar");
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(48, 68);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 36);
            this.btnCancel.TabIndex = 5;
            this.metroToolTip.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.BackgroundImage = global::CellTrack.Properties.Resources._1464225333_checkbox_unchecked;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(5, 68);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
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
            this.splitContainer.Panel1.Controls.Add(this.metroLabel7);
            this.splitContainer.Panel1.Controls.Add(this.tgGpoActivo);
            this.splitContainer.Panel1.Controls.Add(this.lblActivo);
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel20);
            this.splitContainer.Panel1.Controls.Add(this.txtGrupo);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel21);
            this.splitContainer.Panel1.Controls.Add(this.txtDescrip);
            this.splitContainer.Panel1MinSize = 115;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.metroLabel11);
            this.splitContainer.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer.Panel2.Controls.Add(this.txtFind);
            this.splitContainer.Panel2.Controls.Add(this.panel3);
            this.splitContainer.Panel2.Controls.Add(this.gd);
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(961, 614);
            this.splitContainer.SplitterDistance = 115;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 22;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(2, 76);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 25);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "Estado del grupo";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgGpoActivo
            // 
            this.tgGpoActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tgGpoActivo.AutoSize = true;
            this.tgGpoActivo.Checked = true;
            this.tgGpoActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgGpoActivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cagruposBindingSource, "activo", true));
            this.tgGpoActivo.DisplayStatus = false;
            this.tgGpoActivo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.tgGpoActivo.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.tgGpoActivo.Location = new System.Drawing.Point(241, 84);
            this.tgGpoActivo.Name = "tgGpoActivo";
            this.tgGpoActivo.Size = new System.Drawing.Size(50, 17);
            this.tgGpoActivo.TabIndex = 2;
            this.tgGpoActivo.Text = "On";
            this.tgGpoActivo.UseSelectable = true;
            this.tgGpoActivo.CheckedChanged += new System.EventHandler(this.tgGpoActivo_CheckedChanged);
            // 
            // cagruposBindingSource
            // 
            this.cagruposBindingSource.DataSource = typeof(CellTrack.Models.DataBases.cagrupos);
            // 
            // lblActivo
            // 
            this.lblActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActivo.AutoSize = true;
            this.lblActivo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblActivo.Location = new System.Drawing.Point(297, 84);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(3);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(38, 15);
            this.lblActivo.TabIndex = 44;
            this.lblActivo.Text = "Activo";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Location = new System.Drawing.Point(865, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 110);
            this.panel2.TabIndex = 31;
            // 
            // metroLabel20
            // 
            this.metroLabel20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(2, 1);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(170, 25);
            this.metroLabel20.TabIndex = 22;
            this.metroLabel20.Text = "Nombre del Grupo";
            this.metroLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrupo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGrupo.CustomButton.Image = null;
            this.txtGrupo.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtGrupo.CustomButton.Name = "";
            this.txtGrupo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtGrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrupo.CustomButton.TabIndex = 1;
            this.txtGrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrupo.CustomButton.UseSelectable = true;
            this.txtGrupo.CustomButton.Visible = false;
            this.txtGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cagruposBindingSource, "grupo", true));
            this.txtGrupo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGrupo.Lines = new string[0];
            this.txtGrupo.Location = new System.Drawing.Point(2, 32);
            this.txtGrupo.MaxLength = 50;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.PasswordChar = '\0';
            this.txtGrupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrupo.SelectedText = "";
            this.txtGrupo.SelectionLength = 0;
            this.txtGrupo.SelectionStart = 0;
            this.txtGrupo.Size = new System.Drawing.Size(425, 29);
            this.txtGrupo.TabIndex = 0;
            this.txtGrupo.UseSelectable = true;
            this.txtGrupo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrupo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(433, 1);
            this.metroLabel21.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(111, 25);
            this.metroLabel21.TabIndex = 26;
            this.metroLabel21.Text = "Descripción";
            this.metroLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtDescrip.CustomButton.Image = null;
            this.txtDescrip.CustomButton.Location = new System.Drawing.Point(354, 2);
            this.txtDescrip.CustomButton.Name = "";
            this.txtDescrip.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txtDescrip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescrip.CustomButton.TabIndex = 1;
            this.txtDescrip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescrip.CustomButton.UseSelectable = true;
            this.txtDescrip.CustomButton.Visible = false;
            this.txtDescrip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cagruposBindingSource, "descrip", true));
            this.txtDescrip.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescrip.Lines = new string[0];
            this.txtDescrip.Location = new System.Drawing.Point(433, 32);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasswordChar = '\0';
            this.txtDescrip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescrip.SelectedText = "";
            this.txtDescrip.SelectionLength = 0;
            this.txtDescrip.SelectionStart = 0;
            this.txtDescrip.Size = new System.Drawing.Size(426, 74);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.UseSelectable = true;
            this.txtDescrip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescrip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(402, 1);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(99, 15);
            this.metroLabel11.TabIndex = 49;
            this.metroLabel11.Text = "Filtra por [ Grupo ]";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 18);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Filtrar";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtFind.Location = new System.Drawing.Point(71, 17);
            this.txtFind.MaxLength = 30;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.Size = new System.Drawing.Size(430, 29);
            this.txtFind.TabIndex = 47;
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
            this.panel3.Location = new System.Drawing.Point(867, 3);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gd.ColumnHeadersHeight = 30;
            this.gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.descripDataGridViewTextBoxColumn,
            this.fInsDataGridViewTextBoxColumn,
            this.fActDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.causuariosDataGridViewTextBoxColumn});
            this.gd.DataSource = this.cagruposBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gd.DefaultCellStyle = dataGridViewCellStyle2;
            this.gd.EnableHeadersVisualStyles = false;
            this.gd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gd.HighLightPercentage = 0.5F;
            this.gd.Location = new System.Drawing.Point(3, 52);
            this.gd.MultiSelect = false;
            this.gd.Name = "gd";
            this.gd.ReadOnly = true;
            this.gd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(153)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gd.RowHeadersVisible = false;
            this.gd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gd.ShowEditingIcon = false;
            this.gd.Size = new System.Drawing.Size(855, 423);
            this.gd.StandardTab = true;
            this.gd.Style = MetroFramework.MetroColorStyle.Orange;
            this.gd.TabIndex = 6;
            this.gd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gd.UseStyleColors = true;
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
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoDataGridViewTextBoxColumn.Width = 71;
            // 
            // descripDataGridViewTextBoxColumn
            // 
            this.descripDataGridViewTextBoxColumn.DataPropertyName = "descrip";
            this.descripDataGridViewTextBoxColumn.HeaderText = "descrip";
            this.descripDataGridViewTextBoxColumn.Name = "descripDataGridViewTextBoxColumn";
            this.descripDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripDataGridViewTextBoxColumn.Visible = false;
            // 
            // fInsDataGridViewTextBoxColumn
            // 
            this.fInsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fInsDataGridViewTextBoxColumn.DataPropertyName = "fIns";
            this.fInsDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro";
            this.fInsDataGridViewTextBoxColumn.Name = "fInsDataGridViewTextBoxColumn";
            this.fInsDataGridViewTextBoxColumn.ReadOnly = true;
            this.fInsDataGridViewTextBoxColumn.Width = 140;
            // 
            // fActDataGridViewTextBoxColumn
            // 
            this.fActDataGridViewTextBoxColumn.DataPropertyName = "fAct";
            this.fActDataGridViewTextBoxColumn.HeaderText = "fAct";
            this.fActDataGridViewTextBoxColumn.Name = "fActDataGridViewTextBoxColumn";
            this.fActDataGridViewTextBoxColumn.ReadOnly = true;
            this.fActDataGridViewTextBoxColumn.Visible = false;
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
            // usrCtrlGpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.Name = "usrCtrlGpos";
            this.Size = new System.Drawing.Size(961, 614);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cagruposBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle tgGpoActivo;
        private MetroFramework.Controls.MetroLabel lblActivo;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtGrupo;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtDescrip;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnrefresh;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroGrid gd;
        private System.Windows.Forms.BindingSource cagruposBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fInsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causuariosDataGridViewTextBoxColumn;
    }
}
