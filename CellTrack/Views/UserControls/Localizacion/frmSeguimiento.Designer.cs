namespace CellTrack.Views.UserControls.Localización
{
    partial class frmSeguimiento
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
            this.btnReport = new MetroFramework.Controls.MetroButton();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dtPeriodoA = new MetroFramework.Controls.MetroDateTime();
            this.dtPeriodoDe = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbTargets = new MetroFramework.Controls.MetroComboBox();
            this.bsObjetivos = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).BeginInit();
            this.pnlInfoTarget.SuspendLayout();
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
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.AutoSize = true;
            this.btnFind.BackgroundImage = global::CellTrack.Properties.Resources._1463451359_zoom;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFind.Location = new System.Drawing.Point(906, 68);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(63, 59);
            this.btnFind.TabIndex = 32;
            this.metroToolTip.SetToolTip(this.btnFind, "Buscar");
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.BackgroundImage = global::CellTrack.Properties.Resources._1465680503_clipboard_past;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReport.Location = new System.Drawing.Point(12, 189);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(63, 59);
            this.btnReport.TabIndex = 45;
            this.metroToolTip.SetToolTip(this.btnReport, "Generar Reporte");
            this.btnReport.UseSelectable = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Localización [ Seguimiento ]";
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
            this.splitContainer.Panel1.Controls.Add(this.dtPeriodoA);
            this.splitContainer.Panel1.Controls.Add(this.dtPeriodoDe);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel8);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel5);
            this.splitContainer.Panel1.Controls.Add(this.cmbTargets);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer.Panel1.Controls.Add(this.btnFind);
            this.splitContainer.Panel1MinSize = 140;
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(972, 553);
            this.splitContainer.SplitterDistance = 140;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 19;
            // 
            // dtPeriodoA
            // 
            this.dtPeriodoA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtPeriodoA.Location = new System.Drawing.Point(485, 98);
            this.dtPeriodoA.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPeriodoA.Name = "dtPeriodoA";
            this.dtPeriodoA.Size = new System.Drawing.Size(415, 29);
            this.dtPeriodoA.TabIndex = 43;
            // 
            // dtPeriodoDe
            // 
            this.dtPeriodoDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtPeriodoDe.Location = new System.Drawing.Point(33, 98);
            this.dtPeriodoDe.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPeriodoDe.Name = "dtPeriodoDe";
            this.dtPeriodoDe.Size = new System.Drawing.Size(415, 29);
            this.dtPeriodoDe.TabIndex = 42;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(3, 68);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 25);
            this.metroLabel8.TabIndex = 41;
            this.metroLabel8.Text = "Periodo";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(463, 108);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(16, 19);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "a";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(3, 108);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(24, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "de";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTargets
            // 
            this.cmbTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.pnlInfoTarget.Controls.Add(this.metroLabel1);
            this.pnlInfoTarget.Location = new System.Drawing.Point(13, 446);
            this.pnlInfoTarget.Name = "pnlInfoTarget";
            this.pnlInfoTarget.Size = new System.Drawing.Size(210, 142);
            this.pnlInfoTarget.TabIndex = 35;
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
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 25);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 23);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "MCC";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pnlInfoTarget);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmSeguimiento";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsObjetivos)).EndInit();
            this.pnlInfoTarget.ResumeLayout(false);
            this.pnlInfoTarget.PerformLayout();
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
        private MetroFramework.Controls.MetroComboBox cmbTargets;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource bsObjetivos;
        private MetroFramework.Controls.MetroButton btnFind;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dtPeriodoA;
        private MetroFramework.Controls.MetroDateTime dtPeriodoDe;
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnReport;
    }
}
