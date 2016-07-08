namespace CellTrack.Views.UserControls
{
    partial class ursCtrlReasignarObjetivos
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
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.cmbNotification = new MetroFramework.Controls.MetroComboBox();
            this.bsObjetivos = new System.Windows.Forms.BindingSource(this.components);
            this.bsNotifications = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
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
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.BackgroundImage = global::CellTrack.Properties.Resources._1463558222_Update;
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnrefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnrefresh.Location = new System.Drawing.Point(944, 14);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(35, 36);
            this.btnrefresh.TabIndex = 53;
            this.metroToolTip.SetToolTip(this.btnrefresh, "Recargar lista");
            this.btnrefresh.UseSelectable = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
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
            this.splitContainer.Panel1.Controls.Add(this.cmbNotification);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer.Panel1MinSize = 80;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnrefresh);
            this.splitContainer.Panel2.Controls.Add(this.metroLabel11);
            this.splitContainer.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer.Panel2.Controls.Add(this.txtFind);
            this.splitContainer.Panel2.Controls.Add(this.gdObjetivos);
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(984, 598);
            this.splitContainer.SplitterDistance = 80;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 19;
            // 
            // cmbNotification
            // 
            this.cmbNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNotification.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsObjetivos, "idNotification", true));
            this.cmbNotification.DataSource = this.bsNotifications;
            this.cmbNotification.DisplayMember = "Usuario";
            this.cmbNotification.FormattingEnabled = true;
            this.cmbNotification.ItemHeight = 23;
            this.cmbNotification.Location = new System.Drawing.Point(3, 34);
            this.cmbNotification.Name = "cmbNotification";
            this.cmbNotification.Size = new System.Drawing.Size(976, 29);
            this.cmbNotification.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbNotification.TabIndex = 8;
            this.cmbNotification.UseSelectable = true;
            this.cmbNotification.UseStyleColors = true;
            this.cmbNotification.ValueMember = "id";
            this.cmbNotification.DropDown += new System.EventHandler(this.cmbNotification_DropDown);
            // 
            // bsObjetivos
            // 
            this.bsObjetivos.DataSource = typeof(CellTrack.Models.localizationsModel);
            this.bsObjetivos.CurrentItemChanged += new System.EventHandler(this.bsObjetivos_CurrentItemChanged);
            // 
            // bsNotifications
            // 
            this.bsNotifications.DataSource = typeof(CellTrack.Models.DataBases.vwusernotifications);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 3);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 25);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Notificación";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(363, 3);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(228, 15);
            this.metroLabel11.TabIndex = 52;
            this.metroLabel11.Text = "Filtra por [ Nombre | Objetivo | Notificación ]";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 22);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 51;
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
            this.txtFind.CustomButton.Location = new System.Drawing.Point(492, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(71, 21);
            this.txtFind.MaxLength = 30;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.Size = new System.Drawing.Size(520, 29);
            this.txtFind.TabIndex = 50;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
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
            this.gdObjetivos.Location = new System.Drawing.Point(3, 56);
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
            this.gdObjetivos.Size = new System.Drawing.Size(976, 393);
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
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 82;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            this.asuntoDataGridViewTextBoxColumn.Visible = false;
            this.asuntoDataGridViewTextBoxColumn.Width = 76;
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
            this.notificationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notificationNameDataGridViewTextBoxColumn.DataPropertyName = "NotificationName";
            this.notificationNameDataGridViewTextBoxColumn.HeaderText = "Notificación";
            this.notificationNameDataGridViewTextBoxColumn.Name = "notificationNameDataGridViewTextBoxColumn";
            this.notificationNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.notificationNameDataGridViewTextBoxColumn.Width = 103;
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
            this.agendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.agendaDataGridViewTextBoxColumn.DataPropertyName = "Agenda";
            this.agendaDataGridViewTextBoxColumn.HeaderText = "Agenda";
            this.agendaDataGridViewTextBoxColumn.Name = "agendaDataGridViewTextBoxColumn";
            this.agendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.agendaDataGridViewTextBoxColumn.Visible = false;
            this.agendaDataGridViewTextBoxColumn.Width = 79;
            // 
            // ursCtrlReasignarObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "ursCtrlReasignarObjetivos";
            this.Size = new System.Drawing.Size(984, 598);
            this.Leave += new System.EventHandler(this.ursCtrlReasignarObjetivos_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationsModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbNotification;
        private MetroFramework.Controls.MetroGrid gdObjetivos;
        private System.Windows.Forms.BindingSource bsNotifications;
        private System.Windows.Forms.BindingSource bsObjetivos;
        private System.Windows.Forms.BindingSource localizationsModelBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private MetroFramework.Controls.MetroButton btnrefresh;
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
