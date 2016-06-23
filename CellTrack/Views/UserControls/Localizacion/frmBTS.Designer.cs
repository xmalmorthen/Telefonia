namespace CellTrack.Views.UserControls.Localización
{
    partial class frmBTS
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
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtMNC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMCC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtLAC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCELLID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnClearTargets = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            this.btnFind.Location = new System.Drawing.Point(906, 70);
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
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Localización [ BTS ]";
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
            this.splitContainer.Panel1.Controls.Add(this.txtMNC);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer.Panel1.Controls.Add(this.txtMCC);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer.Panel1.Controls.Add(this.txtLAC);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer.Panel1.Controls.Add(this.txtCELLID);
            this.splitContainer.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer.Panel1.Controls.Add(this.btnFind);
            this.splitContainer.Panel1MinSize = 140;
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.Size = new System.Drawing.Size(972, 553);
            this.splitContainer.SplitterDistance = 140;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 19;
            // 
            // txtMNC
            // 
            this.txtMNC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMNC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtMNC.CustomButton.Image = null;
            this.txtMNC.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtMNC.CustomButton.Name = "";
            this.txtMNC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMNC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMNC.CustomButton.TabIndex = 1;
            this.txtMNC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMNC.CustomButton.UseSelectable = true;
            this.txtMNC.CustomButton.Visible = false;
            this.txtMNC.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMNC.Lines = new string[0];
            this.txtMNC.Location = new System.Drawing.Point(450, 100);
            this.txtMNC.MaxLength = 32767;
            this.txtMNC.Name = "txtMNC";
            this.txtMNC.PasswordChar = '\0';
            this.txtMNC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMNC.SelectedText = "";
            this.txtMNC.SelectionLength = 0;
            this.txtMNC.SelectionStart = 0;
            this.txtMNC.Size = new System.Drawing.Size(441, 29);
            this.txtMNC.TabIndex = 43;
            this.txtMNC.UseSelectable = true;
            this.txtMNC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMNC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCELLID_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(450, 69);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 25);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "MNC";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMCC
            // 
            this.txtMCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMCC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtMCC.CustomButton.Image = null;
            this.txtMCC.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtMCC.CustomButton.Name = "";
            this.txtMCC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMCC.CustomButton.TabIndex = 1;
            this.txtMCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMCC.CustomButton.UseSelectable = true;
            this.txtMCC.CustomButton.Visible = false;
            this.txtMCC.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMCC.Lines = new string[0];
            this.txtMCC.Location = new System.Drawing.Point(3, 100);
            this.txtMCC.MaxLength = 32767;
            this.txtMCC.Name = "txtMCC";
            this.txtMCC.PasswordChar = '\0';
            this.txtMCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMCC.SelectedText = "";
            this.txtMCC.SelectionLength = 0;
            this.txtMCC.SelectionStart = 0;
            this.txtMCC.Size = new System.Drawing.Size(441, 29);
            this.txtMCC.TabIndex = 41;
            this.txtMCC.UseSelectable = true;
            this.txtMCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCELLID_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 69);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "MCC";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLAC
            // 
            this.txtLAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLAC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtLAC.CustomButton.Image = null;
            this.txtLAC.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtLAC.CustomButton.Name = "";
            this.txtLAC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtLAC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLAC.CustomButton.TabIndex = 1;
            this.txtLAC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLAC.CustomButton.UseSelectable = true;
            this.txtLAC.CustomButton.Visible = false;
            this.txtLAC.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLAC.Lines = new string[0];
            this.txtLAC.Location = new System.Drawing.Point(450, 34);
            this.txtLAC.MaxLength = 32767;
            this.txtLAC.Name = "txtLAC";
            this.txtLAC.PasswordChar = '\0';
            this.txtLAC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLAC.SelectedText = "";
            this.txtLAC.SelectionLength = 0;
            this.txtLAC.SelectionStart = 0;
            this.txtLAC.Size = new System.Drawing.Size(441, 29);
            this.txtLAC.TabIndex = 39;
            this.txtLAC.UseSelectable = true;
            this.txtLAC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLAC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCELLID_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(450, 3);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 25);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "LAC";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCELLID
            // 
            this.txtCELLID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCELLID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCELLID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCELLID.CustomButton.Image = null;
            this.txtCELLID.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtCELLID.CustomButton.Name = "";
            this.txtCELLID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCELLID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCELLID.CustomButton.TabIndex = 1;
            this.txtCELLID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCELLID.CustomButton.UseSelectable = true;
            this.txtCELLID.CustomButton.Visible = false;
            this.txtCELLID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCELLID.Lines = new string[0];
            this.txtCELLID.Location = new System.Drawing.Point(3, 34);
            this.txtCELLID.MaxLength = 32767;
            this.txtCELLID.Name = "txtCELLID";
            this.txtCELLID.PasswordChar = '\0';
            this.txtCELLID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCELLID.SelectedText = "";
            this.txtCELLID.SelectionLength = 0;
            this.txtCELLID.SelectionStart = 0;
            this.txtCELLID.Size = new System.Drawing.Size(441, 29);
            this.txtCELLID.TabIndex = 37;
            this.txtCELLID.UseSelectable = true;
            this.txtCELLID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCELLID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCELLID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCELLID_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 3);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "CELLID";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearTargets
            // 
            this.btnClearTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearTargets.AutoSize = true;
            this.btnClearTargets.BackgroundImage = global::CellTrack.Properties.Resources._1464227143_trash;
            this.btnClearTargets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearTargets.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearTargets.Location = new System.Drawing.Point(10, 558);
            this.btnClearTargets.Name = "btnClearTargets";
            this.btnClearTargets.Size = new System.Drawing.Size(30, 30);
            this.btnClearTargets.TabIndex = 33;
            this.metroToolTip.SetToolTip(this.btnClearTargets, "Limpiar mapa");
            this.btnClearTargets.UseSelectable = true;
            this.btnClearTargets.Click += new System.EventHandler(this.btnClearTargets_Click);
            // 
            // frmBTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnClearTargets);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(984, 598);
            this.Name = "frmBTS";
            this.Size = new System.Drawing.Size(982, 596);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnFind;
        private MetroFramework.Controls.MetroTextBox txtMNC;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMCC;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtLAC;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCELLID;
        private MetroFramework.Controls.MetroButton btnClearTargets;
    }
}
