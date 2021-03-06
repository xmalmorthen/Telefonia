﻿namespace GSMApplication.Forms
{
    partial class StatusWindow
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbInitialzingSystem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbConnectionToControllers = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbScanningForReceivers = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPoweringOnReceivers = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbConnectingToReceivers = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.pB = new System.Windows.Forms.ProgressBar();
            this.bWInitialzingSystem = new System.ComponentModel.BackgroundWorker();
            this.bWConnectionToControllers = new System.ComponentModel.BackgroundWorker();
            this.bWScanningForReceivers = new System.ComponentModel.BackgroundWorker();
            this.bWPoweringOnReceivers = new System.ComponentModel.BackgroundWorker();
            this.bWConnectingToReceivers = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInitialzingSystem)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionToControllers)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanningForReceivers)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoweringOnReceivers)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectingToReceivers)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.pB);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(167, 211);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.pbInitialzingSystem);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(2, 147);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(120, 30);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // pbInitialzingSystem
            // 
            this.pbInitialzingSystem.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbInitialzingSystem.Location = new System.Drawing.Point(3, 3);
            this.pbInitialzingSystem.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbInitialzingSystem.Name = "pbInitialzingSystem";
            this.pbInitialzingSystem.Size = new System.Drawing.Size(29, 24);
            this.pbInitialzingSystem.TabIndex = 5;
            this.pbInitialzingSystem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 9, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Initialzing system";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.pbConnectionToControllers);
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(2, 39);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(159, 30);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // pbConnectionToControllers
            // 
            this.pbConnectionToControllers.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbConnectionToControllers.Location = new System.Drawing.Point(3, 3);
            this.pbConnectionToControllers.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbConnectionToControllers.Name = "pbConnectionToControllers";
            this.pbConnectionToControllers.Size = new System.Drawing.Size(29, 24);
            this.pbConnectionToControllers.TabIndex = 5;
            this.pbConnectionToControllers.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 9, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Connection to controllers";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.pbScanningForReceivers);
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(148, 30);
            this.flowLayoutPanel6.TabIndex = 2;
            // 
            // pbScanningForReceivers
            // 
            this.pbScanningForReceivers.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbScanningForReceivers.Location = new System.Drawing.Point(3, 3);
            this.pbScanningForReceivers.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbScanningForReceivers.Name = "pbScanningForReceivers";
            this.pbScanningForReceivers.Size = new System.Drawing.Size(29, 24);
            this.pbScanningForReceivers.TabIndex = 5;
            this.pbScanningForReceivers.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 9, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scanning for receivers";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.pbPoweringOnReceivers);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 75);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(147, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pbPoweringOnReceivers
            // 
            this.pbPoweringOnReceivers.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbPoweringOnReceivers.Location = new System.Drawing.Point(3, 3);
            this.pbPoweringOnReceivers.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbPoweringOnReceivers.Name = "pbPoweringOnReceivers";
            this.pbPoweringOnReceivers.Size = new System.Drawing.Size(29, 24);
            this.pbPoweringOnReceivers.TabIndex = 5;
            this.pbPoweringOnReceivers.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 9, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Powering on receivers";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.pbConnectingToReceivers);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 111);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(154, 30);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pbConnectingToReceivers
            // 
            this.pbConnectingToReceivers.Image = global::GSMApplication.Properties.Resources._1459304445_101_Warning;
            this.pbConnectingToReceivers.Location = new System.Drawing.Point(3, 3);
            this.pbConnectingToReceivers.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbConnectingToReceivers.Name = "pbConnectingToReceivers";
            this.pbConnectingToReceivers.Size = new System.Drawing.Size(29, 24);
            this.pbConnectingToReceivers.TabIndex = 5;
            this.pbConnectingToReceivers.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 9, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Connecting to receivers";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(160, 111);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel8.TabIndex = 6;
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(3, 183);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(160, 23);
            this.pB.TabIndex = 7;
            // 
            // bWInitialzingSystem
            // 
            this.bWInitialzingSystem.WorkerSupportsCancellation = true;
            this.bWInitialzingSystem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWInitialzingSystem_DoWork);
            this.bWInitialzingSystem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWInitialzingSystem_RunWorkerCompleted);
            // 
            // bWConnectionToControllers
            // 
            this.bWConnectionToControllers.WorkerSupportsCancellation = true;
            this.bWConnectionToControllers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWConnectionToControllers_DoWork);
            this.bWConnectionToControllers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWConnectionToControllers_RunWorkerCompleted);
            // 
            // bWScanningForReceivers
            // 
            this.bWScanningForReceivers.WorkerSupportsCancellation = true;
            this.bWScanningForReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWScanningForReceivers_DoWork);
            this.bWScanningForReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWScanningForReceivers_RunWorkerCompleted);
            // 
            // bWPoweringOnReceivers
            // 
            this.bWPoweringOnReceivers.WorkerSupportsCancellation = true;
            this.bWPoweringOnReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWPoweringOnReceivers_DoWork);
            this.bWPoweringOnReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWPoweringOnReceivers_RunWorkerCompleted);
            // 
            // bWConnectingToReceivers
            // 
            this.bWConnectingToReceivers.WorkerSupportsCancellation = true;
            this.bWConnectingToReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWConnectingToReceivers_DoWork);
            this.bWConnectingToReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWConnectingToReceivers_RunWorkerCompleted);
            // 
            // StatusWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 211);
            this.Controls.Add(this.flowLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatusWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Initializing";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatusWindow_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StatusWindow_Paint);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInitialzingSystem)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionToControllers)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanningForReceivers)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoweringOnReceivers)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectingToReceivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        public System.Windows.Forms.PictureBox pbInitialzingSystem;
        public System.Windows.Forms.PictureBox pbConnectionToControllers;
        public System.Windows.Forms.PictureBox pbScanningForReceivers;
        public System.Windows.Forms.PictureBox pbPoweringOnReceivers;
        public System.Windows.Forms.PictureBox pbConnectingToReceivers;
        private System.ComponentModel.BackgroundWorker bWInitialzingSystem;
        private System.ComponentModel.BackgroundWorker bWConnectionToControllers;
        private System.ComponentModel.BackgroundWorker bWScanningForReceivers;
        private System.ComponentModel.BackgroundWorker bWPoweringOnReceivers;
        private System.ComponentModel.BackgroundWorker bWConnectingToReceivers;
        private System.Windows.Forms.ProgressBar pB;
    }
}