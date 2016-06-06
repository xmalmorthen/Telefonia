namespace CellTrack
{
    partial class frmLogIn
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.txtUsr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPwd = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.tlpProc = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.tlpProc.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::CellTrack.Properties.Resources._1463426130_delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 36);
            this.btnCancel.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackgroundImage = global::CellTrack.Properties.Resources._1463434201_checkmark;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(246, 185);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(35, 36);
            this.btnAccept.TabIndex = 2;
            this.metroToolTip.SetToolTip(this.btnAccept, "Aceptar");
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtUsr
            // 
            this.txtUsr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUsr.CustomButton.Image = null;
            this.txtUsr.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.txtUsr.CustomButton.Name = "";
            this.txtUsr.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsr.CustomButton.TabIndex = 1;
            this.txtUsr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsr.CustomButton.UseSelectable = true;
            this.txtUsr.CustomButton.Visible = false;
            this.txtUsr.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsr.Lines = new string[] {
        "xmalmorthen"};
            this.txtUsr.Location = new System.Drawing.Point(24, 89);
            this.txtUsr.MaxLength = 32767;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.PasswordChar = '\0';
            this.txtUsr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsr.SelectedText = "";
            this.txtUsr.SelectionLength = 0;
            this.txtUsr.SelectionStart = 0;
            this.txtUsr.Size = new System.Drawing.Size(298, 30);
            this.txtUsr.TabIndex = 0;
            this.txtUsr.Text = "xmalmorthen";
            this.txtUsr.UseSelectable = true;
            this.txtUsr.UseStyleColors = true;
            this.txtUsr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 69);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Usuario";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 127);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Contraseña";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPwd.CustomButton.Image = null;
            this.txtPwd.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.txtPwd.CustomButton.Name = "";
            this.txtPwd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPwd.CustomButton.TabIndex = 1;
            this.txtPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPwd.CustomButton.UseSelectable = true;
            this.txtPwd.CustomButton.Visible = false;
            this.txtPwd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPwd.Lines = new string[] {
        "..121212qw"};
            this.txtPwd.Location = new System.Drawing.Point(24, 147);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '?';
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.SelectedText = "";
            this.txtPwd.SelectionLength = 0;
            this.txtPwd.SelectionStart = 0;
            this.txtPwd.Size = new System.Drawing.Size(298, 30);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "..121212qw";
            this.txtPwd.UseSelectable = true;
            this.txtPwd.UseStyleColors = true;
            this.txtPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(3, 3);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinner3.TabIndex = 21;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 50;
            // 
            // tlpProc
            // 
            this.tlpProc.ColumnCount = 2;
            this.tlpProc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProc.Controls.Add(this.metroLabel3, 1, 0);
            this.tlpProc.Controls.Add(this.metroProgressSpinner3, 0, 0);
            this.tlpProc.Location = new System.Drawing.Point(23, 185);
            this.tlpProc.Name = "tlpProc";
            this.tlpProc.RowCount = 1;
            this.tlpProc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProc.Size = new System.Drawing.Size(217, 36);
            this.tlpProc.TabIndex = 22;
            this.tlpProc.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(32, 7);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 15);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Validando usuario ...";
            this.metroLabel3.UseStyleColors = true;
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::CellTrack.Properties.Resources._1463451442_target;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 11, 0, 0);
            this.BackMaxSize = 48;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(337, 228);
            this.Controls.Add(this.tlpProc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmLogIn";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "      CellTrack";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.tlpProc.ResumeLayout(false);
            this.tlpProc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPwd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUsr;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private System.Windows.Forms.TableLayoutPanel tlpProc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

