namespace CellTrack.Views.UserControls.Localización
{
    partial class frmSS7
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
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.cmbTargets = new MetroFramework.Controls.MetroComboBox();
            this.bsObjetivos = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.ucDoHealthCheck1 = new CellTrack.Views.UserControls.UCDoHealthCheck();
            this.pnlCountDown = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInfoTarget = new System.Windows.Forms.Panel();
            this.lblV = new MetroFramework.Controls.MetroLabel();
            this.lblBTS = new MetroFramework.Controls.MetroLabel();
            this.lblLAC = new MetroFramework.Controls.MetroLabel();
            this.lblMNC = new MetroFramework.Controls.MetroLabel();
            this.lblMCC = new MetroFramework.Controls.MetroLabel();
            this.lblRadio = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pnlInternet = new MetroFramework.Controls.MetroPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).BeginInit();
            this.pnlCountDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInfoTarget.SuspendLayout();
            this.pnlInternet.SuspendLayout();
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
            this.btnFind.Location = new System.Drawing.Point(736, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(63, 59);
            this.btnFind.TabIndex = 32;
            this.metroToolTip.SetToolTip(this.btnFind, "Buscar");
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.AutoSize = true;
            this.metroButton1.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(399, 5);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(44, 44);
            this.metroButton1.TabIndex = 33;
            this.metroToolTip.SetToolTip(this.metroButton1, "Cancelar");
            this.metroButton1.UseSelectable = true;
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
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Localización [ SS7 ]";
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
            this.splitContainer.Enabled = false;
            this.splitContainer.Location = new System.Drawing.Point(7, 40);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnFind);
            this.splitContainer.Panel1.Controls.Add(this.cmbTargets);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer.Panel1MinSize = 80;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlMain);
            this.splitContainer.Panel2.Controls.Add(this.ucDoHealthCheck1);
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(969, 553);
            this.splitContainer.SplitterDistance = 80;
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
            this.cmbTargets.Location = new System.Drawing.Point(147, 38);
            this.cmbTargets.Name = "cmbTargets";
            this.cmbTargets.Size = new System.Drawing.Size(583, 29);
            this.cmbTargets.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbTargets.TabIndex = 6;
            this.cmbTargets.UseSelectable = true;
            this.cmbTargets.UseStyleColors = true;
            this.cmbTargets.ValueMember = "id";
            this.cmbTargets.DropDown += new System.EventHandler(this.cmbTargets_DropDown);
            // 
            // bsObjetivos
            // 
            this.bsObjetivos.DataSource = typeof(CellTrack.Models.PDUModel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(147, 8);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Objetivo";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.HorizontalScrollbar = true;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(969, 404);
            this.pnlMain.TabIndex = 41;
            this.pnlMain.VerticalScrollbar = true;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // ucDoHealthCheck1
            // 
            this.ucDoHealthCheck1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDoHealthCheck1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucDoHealthCheck1.Location = new System.Drawing.Point(0, 404);
            this.ucDoHealthCheck1.Name = "ucDoHealthCheck1";
            this.ucDoHealthCheck1.Size = new System.Drawing.Size(969, 64);
            this.ucDoHealthCheck1.TabIndex = 0;
            this.ucDoHealthCheck1.UseSelectable = true;
            // 
            // pnlCountDown
            // 
            this.pnlCountDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCountDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCountDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCountDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCountDown.Controls.Add(this.metroButton1);
            this.pnlCountDown.Controls.Add(this.label2);
            this.pnlCountDown.Controls.Add(this.pictureBox1);
            this.pnlCountDown.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlCountDown.Location = new System.Drawing.Point(263, 208);
            this.pnlCountDown.Name = "pnlCountDown";
            this.pnlCountDown.Size = new System.Drawing.Size(448, 260);
            this.pnlCountDown.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 235, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "favor de esperar...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CellTrack.Properties.Resources.loading_gallery;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pnlInfoTarget
            // 
            this.pnlInfoTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfoTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoTarget.Controls.Add(this.lblV);
            this.pnlInfoTarget.Controls.Add(this.lblBTS);
            this.pnlInfoTarget.Controls.Add(this.lblLAC);
            this.pnlInfoTarget.Controls.Add(this.lblMNC);
            this.pnlInfoTarget.Controls.Add(this.lblMCC);
            this.pnlInfoTarget.Controls.Add(this.lblRadio);
            this.pnlInfoTarget.Controls.Add(this.metroLabel10);
            this.pnlInfoTarget.Controls.Add(this.metroLabel9);
            this.pnlInfoTarget.Controls.Add(this.metroLabel6);
            this.pnlInfoTarget.Controls.Add(this.metroLabel4);
            this.pnlInfoTarget.Controls.Add(this.metroLabel15);
            this.pnlInfoTarget.Controls.Add(this.metroLabel2);
            this.pnlInfoTarget.Location = new System.Drawing.Point(13, 446);
            this.pnlInfoTarget.Name = "pnlInfoTarget";
            this.pnlInfoTarget.Size = new System.Drawing.Size(210, 142);
            this.pnlInfoTarget.TabIndex = 36;
            this.pnlInfoTarget.Visible = false;
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblV.Location = new System.Drawing.Point(45, 121);
            this.lblV.Margin = new System.Windows.Forms.Padding(3);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(23, 15);
            this.lblV.TabIndex = 78;
            this.lblV.Text = "No";
            this.lblV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBTS
            // 
            this.lblBTS.AutoSize = true;
            this.lblBTS.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBTS.Location = new System.Drawing.Point(45, 98);
            this.lblBTS.Margin = new System.Windows.Forms.Padding(3);
            this.lblBTS.Name = "lblBTS";
            this.lblBTS.Size = new System.Drawing.Size(23, 15);
            this.lblBTS.TabIndex = 77;
            this.lblBTS.Text = "No";
            this.lblBTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLAC
            // 
            this.lblLAC.AutoSize = true;
            this.lblLAC.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLAC.Location = new System.Drawing.Point(45, 75);
            this.lblLAC.Margin = new System.Windows.Forms.Padding(3);
            this.lblLAC.Name = "lblLAC";
            this.lblLAC.Size = new System.Drawing.Size(23, 15);
            this.lblLAC.TabIndex = 76;
            this.lblLAC.Text = "No";
            this.lblLAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMNC
            // 
            this.lblMNC.AutoSize = true;
            this.lblMNC.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMNC.Location = new System.Drawing.Point(45, 52);
            this.lblMNC.Margin = new System.Windows.Forms.Padding(3);
            this.lblMNC.Name = "lblMNC";
            this.lblMNC.Size = new System.Drawing.Size(23, 15);
            this.lblMNC.TabIndex = 75;
            this.lblMNC.Text = "No";
            this.lblMNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMCC
            // 
            this.lblMCC.AutoSize = true;
            this.lblMCC.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMCC.Location = new System.Drawing.Point(45, 29);
            this.lblMCC.Margin = new System.Windows.Forms.Padding(3);
            this.lblMCC.Name = "lblMCC";
            this.lblMCC.Size = new System.Drawing.Size(23, 15);
            this.lblMCC.TabIndex = 74;
            this.lblMCC.Text = "No";
            this.lblMCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRadio.Location = new System.Drawing.Point(45, 6);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(3);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(23, 15);
            this.lblRadio.TabIndex = 73;
            this.lblRadio.Text = "No";
            this.lblRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(3, 117);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(39, 23);
            this.metroLabel10.TabIndex = 72;
            this.metroLabel10.Text = "V";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(3, 94);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(39, 23);
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = "BTS";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 71);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 23);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "LAC";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 48);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 23);
            this.metroLabel4.TabIndex = 69;
            this.metroLabel4.Text = "MNC";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel15
            // 
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(3, 2);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(39, 23);
            this.metroLabel15.TabIndex = 67;
            this.metroLabel15.Text = "Radio";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 25);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 23);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "MCC";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInternet
            // 
            this.pnlInternet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInternet.AutoSize = true;
            this.pnlInternet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInternet.BackColor = System.Drawing.Color.White;
            this.pnlInternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInternet.Controls.Add(this.label5);
            this.pnlInternet.Controls.Add(this.label4);
            this.pnlInternet.HorizontalScrollbarBarColor = true;
            this.pnlInternet.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInternet.HorizontalScrollbarSize = 10;
            this.pnlInternet.Location = new System.Drawing.Point(78, 181);
            this.pnlInternet.Name = "pnlInternet";
            this.pnlInternet.Size = new System.Drawing.Size(823, 98);
            this.pnlInternet.TabIndex = 46;
            this.pnlInternet.VerticalScrollbarBarColor = true;
            this.pnlInternet.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInternet.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(815, 76);
            this.label5.TabIndex = 3;
            this.label5.Text = "Se requiere tener IP fija...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(674, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Favor de configurar...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSS7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlInternet);
            this.Controls.Add(this.pnlInfoTarget);
            this.Controls.Add(this.pnlCountDown);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmSS7";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).EndInit();
            this.pnlCountDown.ResumeLayout(false);
            this.pnlCountDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInfoTarget.ResumeLayout(false);
            this.pnlInfoTarget.PerformLayout();
            this.pnlInternet.ResumeLayout(false);
            this.pnlInternet.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbTargets;
        private MetroFramework.Controls.MetroButton btnFind;
        private System.Windows.Forms.BindingSource bsObjetivos;
        private System.Windows.Forms.FlowLayoutPanel pnlCountDown;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInfoTarget;
        private MetroFramework.Controls.MetroLabel lblV;
        private MetroFramework.Controls.MetroLabel lblBTS;
        private MetroFramework.Controls.MetroLabel lblLAC;
        private MetroFramework.Controls.MetroLabel lblMNC;
        private MetroFramework.Controls.MetroLabel lblMCC;
        private MetroFramework.Controls.MetroLabel lblRadio;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private UCDoHealthCheck ucDoHealthCheck1;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroPanel pnlInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
