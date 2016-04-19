namespace GSMApplication.Forms
{
    partial class GSMPIOffline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSMPIOffline));
            this.gbHoras = new System.Windows.Forms.GroupBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBHoras = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.gBCantidad = new System.Windows.Forms.GroupBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCantidad = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gBIndefinido = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pBIndefinido = new System.Windows.Forms.ProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.rBCantidad = new System.Windows.Forms.RadioButton();
            this.rBHoras = new System.Windows.Forms.RadioButton();
            this.rbIndefinido = new System.Windows.Forms.RadioButton();
            this.gbHoras.SuspendLayout();
            this.gBCantidad.SuspendLayout();
            this.gBIndefinido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHoras
            // 
            this.gbHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHoras.Controls.Add(this.lblMinutos);
            this.gbHoras.Controls.Add(this.label2);
            this.gbHoras.Controls.Add(this.pBHoras);
            this.gbHoras.Controls.Add(this.label1);
            this.gbHoras.Controls.Add(this.txtHoras);
            this.gbHoras.Enabled = false;
            this.gbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoras.Location = new System.Drawing.Point(12, 83);
            this.gbHoras.Name = "gbHoras";
            this.gbHoras.Size = new System.Drawing.Size(290, 67);
            this.gbHoras.TabIndex = 0;
            this.gbHoras.TabStop = false;
            this.gbHoras.Text = "     Por horas";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.Red;
            this.lblMinutos.Location = new System.Drawing.Point(151, 46);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(14, 13);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutos transcurridos";
            // 
            // pBHoras
            // 
            this.pBHoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBHoras.Location = new System.Drawing.Point(52, 19);
            this.pBHoras.Name = "pBHoras";
            this.pBHoras.Size = new System.Drawing.Size(232, 23);
            this.pBHoras.TabIndex = 2;
            this.toolTip.SetToolTip(this.pBHoras, "Progreso de lecturas");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.ForeColor = System.Drawing.Color.Red;
            this.txtHoras.Location = new System.Drawing.Point(9, 32);
            this.txtHoras.MaxLength = 2;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(37, 26);
            this.txtHoras.TabIndex = 0;
            this.txtHoras.Text = "1";
            this.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gBCantidad
            // 
            this.gBCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gBCantidad.Controls.Add(this.lblcantidad);
            this.gBCantidad.Controls.Add(this.label5);
            this.gBCantidad.Controls.Add(this.pbCantidad);
            this.gBCantidad.Controls.Add(this.label6);
            this.gBCantidad.Controls.Add(this.txtCantidad);
            this.gBCantidad.Enabled = false;
            this.gBCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCantidad.Location = new System.Drawing.Point(12, 156);
            this.gBCantidad.Name = "gBCantidad";
            this.gBCantidad.Size = new System.Drawing.Size(290, 66);
            this.gBCantidad.TabIndex = 1;
            this.gBCantidad.TabStop = false;
            this.gBCantidad.Text = "     Por cantidad";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.Red;
            this.lblcantidad.Location = new System.Drawing.Point(178, 46);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(14, 13);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lecturas hechas";
            // 
            // pbCantidad
            // 
            this.pbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCantidad.Location = new System.Drawing.Point(99, 19);
            this.pbCantidad.Name = "pbCantidad";
            this.pbCantidad.Size = new System.Drawing.Size(185, 23);
            this.pbCantidad.TabIndex = 7;
            this.toolTip.SetToolTip(this.pbCantidad, "Progreso de lecturas");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Red;
            this.txtCantidad.Location = new System.Drawing.Point(9, 32);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(84, 26);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gBIndefinido
            // 
            this.gBIndefinido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gBIndefinido.Controls.Add(this.label3);
            this.gBIndefinido.Controls.Add(this.label4);
            this.gBIndefinido.Controls.Add(this.lblHoras);
            this.gBIndefinido.Controls.Add(this.label8);
            this.gBIndefinido.Controls.Add(this.pBIndefinido);
            this.gBIndefinido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBIndefinido.Location = new System.Drawing.Point(12, 10);
            this.gBIndefinido.Name = "gBIndefinido";
            this.gBIndefinido.Size = new System.Drawing.Size(290, 67);
            this.gBIndefinido.TabIndex = 3;
            this.gBIndefinido.TabStop = false;
            this.gBIndefinido.Text = "     Indefinido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(233, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lecturas hechas";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Red;
            this.lblHoras.Location = new System.Drawing.Point(99, 46);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(14, 13);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Horas transcurridas";
            // 
            // pBIndefinido
            // 
            this.pBIndefinido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBIndefinido.Location = new System.Drawing.Point(9, 19);
            this.pBIndefinido.Name = "pBIndefinido";
            this.pBIndefinido.Size = new System.Drawing.Size(275, 23);
            this.pBIndefinido.TabIndex = 2;
            this.toolTip.SetToolTip(this.pBIndefinido, "Progreso de lectura");
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::GSMApplication.Properties.Resources._1459549408_icon_close_circled;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(242, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 56);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.btnCancel, "Cancelar escaneo");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.AutoSize = true;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.Location = new System.Drawing.Point(89, 226);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(147, 56);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.btnScan, "Iniciar escaneo");
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // rBCantidad
            // 
            this.rBCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rBCantidad.AutoSize = true;
            this.rBCantidad.Location = new System.Drawing.Point(21, 156);
            this.rBCantidad.Name = "rBCantidad";
            this.rBCantidad.Size = new System.Drawing.Size(14, 13);
            this.rBCantidad.TabIndex = 6;
            this.rBCantidad.TabStop = true;
            this.rBCantidad.UseVisualStyleBackColor = true;
            this.rBCantidad.CheckedChanged += new System.EventHandler(this.rbIndefinido_CheckedChanged);
            // 
            // rBHoras
            // 
            this.rBHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rBHoras.AutoSize = true;
            this.rBHoras.Location = new System.Drawing.Point(21, 83);
            this.rBHoras.Name = "rBHoras";
            this.rBHoras.Size = new System.Drawing.Size(14, 13);
            this.rBHoras.TabIndex = 7;
            this.rBHoras.TabStop = true;
            this.rBHoras.UseVisualStyleBackColor = true;
            this.rBHoras.CheckedChanged += new System.EventHandler(this.rbIndefinido_CheckedChanged);
            // 
            // rbIndefinido
            // 
            this.rbIndefinido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbIndefinido.AutoSize = true;
            this.rbIndefinido.Checked = true;
            this.rbIndefinido.Location = new System.Drawing.Point(21, 10);
            this.rbIndefinido.Name = "rbIndefinido";
            this.rbIndefinido.Size = new System.Drawing.Size(14, 13);
            this.rbIndefinido.TabIndex = 8;
            this.rbIndefinido.TabStop = true;
            this.rbIndefinido.UseVisualStyleBackColor = true;
            this.rbIndefinido.CheckedChanged += new System.EventHandler(this.rbIndefinido_CheckedChanged);
            // 
            // GSMPIOffline
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(318, 291);
            this.Controls.Add(this.rbIndefinido);
            this.Controls.Add(this.rBHoras);
            this.Controls.Add(this.rBCantidad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.gBIndefinido);
            this.Controls.Add(this.gbHoras);
            this.Controls.Add(this.gBCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(334, 330);
            this.MinimumSize = new System.Drawing.Size(334, 330);
            this.Name = "GSMPIOffline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSMPI Offline";
            this.TopMost = true;
            this.gbHoras.ResumeLayout(false);
            this.gbHoras.PerformLayout();
            this.gBCantidad.ResumeLayout(false);
            this.gBCantidad.PerformLayout();
            this.gBIndefinido.ResumeLayout(false);
            this.gBIndefinido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pBHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.GroupBox gBCantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox gBIndefinido;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pBIndefinido;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBCantidad;
        private System.Windows.Forms.RadioButton rBHoras;
        private System.Windows.Forms.RadioButton rbIndefinido;
    }
}