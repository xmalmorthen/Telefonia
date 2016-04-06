namespace GSMApplication.Forms
{
    partial class GSMPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSMPI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbOfflineMode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnOffline = new System.Windows.Forms.Button();
            this.gbOnlineMode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOnline = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTarget = new System.Windows.Forms.RadioButton();
            this.rbSharpRandom = new System.Windows.Forms.RadioButton();
            this.rbKeywords = new System.Windows.Forms.RadioButton();
            this.gbReceivers = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbInternetConnection = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbSystemConnected = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbExternalPower = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bWInternetConnection = new System.ComponentModel.BackgroundWorker();
            this.tmWorkers = new System.Windows.Forms.Timer(this.components);
            this.bWSystemConnected = new System.ComponentModel.BackgroundWorker();
            this.bWExternalPower = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbOfflineMode.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbOnlineMode.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbReceivers.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternetConnection)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSystemConnected)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExternalPower)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbOfflineMode, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gbOnlineMode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbReceivers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbOutput, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbOfflineMode
            // 
            this.gbOfflineMode.Controls.Add(this.tableLayoutPanel3);
            this.gbOfflineMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOfflineMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOfflineMode.Location = new System.Drawing.Point(8, 249);
            this.gbOfflineMode.Name = "gbOfflineMode";
            this.gbOfflineMode.Size = new System.Drawing.Size(368, 87);
            this.gbOfflineMode.TabIndex = 11;
            this.gbOfflineMode.TabStop = false;
            this.gbOfflineMode.Text = "Offline Mode";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnAnalyze, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOffline, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(362, 62);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnalyze.AutoSize = true;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Image = global::GSMApplication.Properties.Resources._1459303405_Find01;
            this.btnAnalyze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyze.Location = new System.Drawing.Point(188, 3);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(166, 56);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnOffline
            // 
            this.btnOffline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOffline.AutoSize = true;
            this.btnOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffline.Image = global::GSMApplication.Properties.Resources._1459303253_ic_portable_wifi_off_48px;
            this.btnOffline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffline.Location = new System.Drawing.Point(7, 3);
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Size = new System.Drawing.Size(166, 56);
            this.btnOffline.TabIndex = 4;
            this.btnOffline.Text = "Offline";
            this.btnOffline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOffline.UseVisualStyleBackColor = true;
            this.btnOffline.Click += new System.EventHandler(this.btnOffline_Click);
            // 
            // gbOnlineMode
            // 
            this.gbOnlineMode.Controls.Add(this.tableLayoutPanel2);
            this.gbOnlineMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOnlineMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOnlineMode.Location = new System.Drawing.Point(8, 121);
            this.gbOnlineMode.Name = "gbOnlineMode";
            this.gbOnlineMode.Size = new System.Drawing.Size(368, 122);
            this.gbOnlineMode.TabIndex = 10;
            this.gbOnlineMode.TabStop = false;
            this.gbOnlineMode.Text = "Online Mode";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnOnline, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 97);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnOnline
            // 
            this.btnOnline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOnline.AutoSize = true;
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.Image = ((System.Drawing.Image)(resources.GetObject("btnOnline.Image")));
            this.btnOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnline.Location = new System.Drawing.Point(103, 39);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(156, 56);
            this.btnOnline.TabIndex = 3;
            this.btnOnline.Text = "Online";
            this.btnOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnline.UseVisualStyleBackColor = true;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbTarget);
            this.flowLayoutPanel2.Controls.Add(this.rbSharpRandom);
            this.flowLayoutPanel2.Controls.Add(this.rbKeywords);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(356, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // rbTarget
            // 
            this.rbTarget.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbTarget.AutoSize = true;
            this.rbTarget.Checked = true;
            this.rbTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarget.Location = new System.Drawing.Point(3, 3);
            this.rbTarget.Name = "rbTarget";
            this.rbTarget.Padding = new System.Windows.Forms.Padding(7, 0, 6, 0);
            this.rbTarget.Size = new System.Drawing.Size(85, 24);
            this.rbTarget.TabIndex = 0;
            this.rbTarget.TabStop = true;
            this.rbTarget.Text = "Target";
            this.rbTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTarget.UseVisualStyleBackColor = true;
            // 
            // rbSharpRandom
            // 
            this.rbSharpRandom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSharpRandom.AutoSize = true;
            this.rbSharpRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSharpRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSharpRandom.Location = new System.Drawing.Point(94, 3);
            this.rbSharpRandom.Name = "rbSharpRandom";
            this.rbSharpRandom.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rbSharpRandom.Size = new System.Drawing.Size(146, 24);
            this.rbSharpRandom.TabIndex = 1;
            this.rbSharpRandom.Text = "Sharp Random";
            this.rbSharpRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSharpRandom.UseVisualStyleBackColor = true;
            // 
            // rbKeywords
            // 
            this.rbKeywords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbKeywords.AutoSize = true;
            this.rbKeywords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKeywords.Location = new System.Drawing.Point(246, 3);
            this.rbKeywords.Name = "rbKeywords";
            this.rbKeywords.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rbKeywords.Size = new System.Drawing.Size(106, 24);
            this.rbKeywords.TabIndex = 2;
            this.rbKeywords.Text = "Keywords";
            this.rbKeywords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbKeywords.UseVisualStyleBackColor = true;
            // 
            // gbReceivers
            // 
            this.gbReceivers.Controls.Add(this.flowLayoutPanel1);
            this.gbReceivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReceivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReceivers.Location = new System.Drawing.Point(8, 60);
            this.gbReceivers.Name = "gbReceivers";
            this.gbReceivers.Size = new System.Drawing.Size(368, 55);
            this.gbReceivers.TabIndex = 7;
            this.gbReceivers.TabStop = false;
            this.gbReceivers.Text = "Receivers";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rb4);
            this.flowLayoutPanel1.Controls.Add(this.rb8);
            this.flowLayoutPanel1.Controls.Add(this.rb12);
            this.flowLayoutPanel1.Controls.Add(this.rb16);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rb4
            // 
            this.rb4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb4.AutoSize = true;
            this.rb4.Enabled = false;
            this.rb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(3, 3);
            this.rb4.Name = "rb4";
            this.rb4.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.rb4.Size = new System.Drawing.Size(80, 24);
            this.rb4.TabIndex = 0;
            this.rb4.Text = "4";
            this.rb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb8.AutoSize = true;
            this.rb8.Enabled = false;
            this.rb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8.Location = new System.Drawing.Point(89, 3);
            this.rb8.Name = "rb8";
            this.rb8.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.rb8.Size = new System.Drawing.Size(80, 24);
            this.rb8.TabIndex = 1;
            this.rb8.Text = "8";
            this.rb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            this.rb12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb12.AutoSize = true;
            this.rb12.Enabled = false;
            this.rb12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb12.Location = new System.Drawing.Point(175, 3);
            this.rb12.Name = "rb12";
            this.rb12.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.rb12.Size = new System.Drawing.Size(89, 24);
            this.rb12.TabIndex = 2;
            this.rb12.Text = "12";
            this.rb12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb12.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb16.AutoSize = true;
            this.rb16.Checked = true;
            this.rb16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb16.Location = new System.Drawing.Point(270, 3);
            this.rb16.Name = "rb16";
            this.rb16.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.rb16.Size = new System.Drawing.Size(89, 24);
            this.rb16.TabIndex = 3;
            this.rb16.TabStop = true;
            this.rb16.Tag = "0";
            this.rb16.Text = "16";
            this.rb16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(174, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 26);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "---";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(174, 31);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(36, 26);
            this.lblTitle2.TabIndex = 9;
            this.lblTitle2.Text = "---";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.tableLayoutPanel4);
            this.gbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutput.Location = new System.Drawing.Point(8, 342);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(368, 61);
            this.gbOutput.TabIndex = 12;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnSaveFileDialog, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtOutputPath, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(362, 36);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveFileDialog.AutoSize = true;
            this.btnSaveFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFileDialog.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveFileDialog.Location = new System.Drawing.Point(317, 3);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(42, 30);
            this.btnSaveFileDialog.TabIndex = 5;
            this.btnSaveFileDialog.Text = "...";
            this.btnSaveFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSaveFileDialog, "Open save file dialog");
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputPath.Location = new System.Drawing.Point(3, 3);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(308, 30);
            this.txtOutputPath.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtOutputPath, "Path to output");
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 409);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(368, 71);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.pbInternetConnection);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(182, 30);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // pbInternetConnection
            // 
            this.pbInternetConnection.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbInternetConnection.Location = new System.Drawing.Point(3, 3);
            this.pbInternetConnection.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbInternetConnection.Name = "pbInternetConnection";
            this.pbInternetConnection.Size = new System.Drawing.Size(29, 24);
            this.pbInternetConnection.TabIndex = 5;
            this.pbInternetConnection.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Internet connection";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.pbSystemConnected);
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(188, 3);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(176, 30);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // pbSystemConnected
            // 
            this.pbSystemConnected.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbSystemConnected.Location = new System.Drawing.Point(3, 3);
            this.pbSystemConnected.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbSystemConnected.Name = "pbSystemConnected";
            this.pbSystemConnected.Size = new System.Drawing.Size(29, 24);
            this.pbSystemConnected.TabIndex = 5;
            this.pbSystemConnected.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "System connected";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.pbExternalPower);
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(2, 39);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(149, 30);
            this.flowLayoutPanel6.TabIndex = 2;
            // 
            // pbExternalPower
            // 
            this.pbExternalPower.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbExternalPower.Location = new System.Drawing.Point(3, 3);
            this.pbExternalPower.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbExternalPower.Name = "pbExternalPower";
            this.pbExternalPower.Size = new System.Drawing.Size(29, 24);
            this.pbExternalPower.TabIndex = 5;
            this.pbExternalPower.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "External power";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Output path";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // bWInternetConnection
            // 
            this.bWInternetConnection.WorkerSupportsCancellation = true;
            this.bWInternetConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWInternetConnection_DoWork);
            this.bWInternetConnection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWInternetConnection_RunWorkerCompleted);
            // 
            // tmWorkers
            // 
            this.tmWorkers.Interval = 5000;
            this.tmWorkers.Tick += new System.EventHandler(this.tmWorkers_Tick);
            // 
            // bWSystemConnected
            // 
            this.bWSystemConnected.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWSystemConnected_DoWork);
            this.bWSystemConnected.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWExternalPower
            // 
            this.bWExternalPower.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWExternalPower_DoWork);
            this.bWExternalPower.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWExternalPower_RunWorkerCompleted);
            // 
            // GSMPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 527);
            this.MinimumSize = new System.Drawing.Size(400, 527);
            this.Name = "GSMPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSM Pasive Interceptor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbOfflineMode.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbOnlineMode.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.gbReceivers.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternetConnection)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSystemConnected)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExternalPower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbReceivers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.GroupBox gbOnlineMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbTarget;
        private System.Windows.Forms.RadioButton rbSharpRandom;
        private System.Windows.Forms.RadioButton rbKeywords;
        private System.Windows.Forms.GroupBox gbOfflineMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnOffline;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PictureBox pbInternetConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.PictureBox pbSystemConnected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox pbExternalPower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker bWInternetConnection;
        private System.Windows.Forms.Timer tmWorkers;
        private System.ComponentModel.BackgroundWorker bWSystemConnected;
        private System.ComponentModel.BackgroundWorker bWExternalPower;
    }
}