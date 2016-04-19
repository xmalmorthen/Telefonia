namespace GSMApplication.Forms
{
    partial class FrmSshCnn
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
            this.bWSystemConnected = new System.ComponentModel.BackgroundWorker();
            this.bWExternalPower = new System.ComponentModel.BackgroundWorker();
            this.bWReceivers = new System.ComponentModel.BackgroundWorker();
            this.bWDecipher = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSshCnn = new System.Windows.Forms.ProgressBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bWInitialzingSystem = new System.ComponentModel.BackgroundWorker();
            this.bWConnectionToControllers = new System.ComponentModel.BackgroundWorker();
            this.bWScanningForReceivers = new System.ComponentModel.BackgroundWorker();
            this.bWPoweringOnReceivers = new System.ComponentModel.BackgroundWorker();
            this.bWConnectingToReceivers = new System.ComponentModel.BackgroundWorker();
            this.bWInitializingStack = new System.ComponentModel.BackgroundWorker();
            this.bWLoopMainProc = new System.ComponentModel.BackgroundWorker();
            this.bWDaemonWatcher = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // bWSystemConnected
            // 
            this.bWSystemConnected.WorkerSupportsCancellation = true;
            this.bWSystemConnected.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWSystemConnected_DoWork);
            this.bWSystemConnected.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWExternalPower
            // 
            this.bWExternalPower.WorkerSupportsCancellation = true;
            this.bWExternalPower.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWExternalPower_DoWork);
            this.bWExternalPower.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWReceivers
            // 
            this.bWReceivers.WorkerSupportsCancellation = true;
            this.bWReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWReceivers_DoWork);
            this.bWReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWDecipher
            // 
            this.bWDecipher.WorkerSupportsCancellation = true;
            this.bWDecipher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWDecipher_DoWork);
            this.bWDecipher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GSM Pasive Interceptor";
            // 
            // pbSshCnn
            // 
            this.pbSshCnn.Location = new System.Drawing.Point(12, 43);
            this.pbSshCnn.Name = "pbSshCnn";
            this.pbSshCnn.Size = new System.Drawing.Size(323, 23);
            this.pbSshCnn.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 69);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(95, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Wait to connect ...";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::GSMApplication.Properties.Resources._1459541353_No;
            this.btnCancel.Location = new System.Drawing.Point(307, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(29, 30);
            this.btnCancel.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bWInitialzingSystem
            // 
            this.bWInitialzingSystem.WorkerSupportsCancellation = true;
            this.bWInitialzingSystem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWInitialzingSystem_DoWork);
            this.bWInitialzingSystem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWConnectionToControllers
            // 
            this.bWConnectionToControllers.WorkerSupportsCancellation = true;
            this.bWConnectionToControllers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWConnectionToControllers_DoWork);
            this.bWConnectionToControllers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWScanningForReceivers
            // 
            this.bWScanningForReceivers.WorkerSupportsCancellation = true;
            this.bWScanningForReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWScanningForReceivers_DoWork);
            this.bWScanningForReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWPoweringOnReceivers
            // 
            this.bWPoweringOnReceivers.WorkerSupportsCancellation = true;
            this.bWPoweringOnReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWPoweringOnReceivers_DoWork);
            this.bWPoweringOnReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWConnectingToReceivers
            // 
            this.bWConnectingToReceivers.WorkerSupportsCancellation = true;
            this.bWConnectingToReceivers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWConnectingToReceivers_DoWork);
            this.bWConnectingToReceivers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWInitializingStack
            // 
            this.bWInitializingStack.WorkerSupportsCancellation = true;
            this.bWInitializingStack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWInitializingStack_DoWork);
            this.bWInitializingStack.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWLoopMainProc
            // 
            this.bWLoopMainProc.WorkerSupportsCancellation = true;
            this.bWLoopMainProc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWLoopMainProc_DoWork);
            this.bWLoopMainProc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // bWDaemonWatcher
            // 
            this.bWDaemonWatcher.WorkerSupportsCancellation = true;
            this.bWDaemonWatcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWDaemonWatcher_DoWork);
            this.bWDaemonWatcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSystemConnected_RunWorkerCompleted);
            // 
            // FrmSshCnn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(347, 103);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbSshCnn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSshCnn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSshCnn";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bWSystemConnected;
        private System.ComponentModel.BackgroundWorker bWExternalPower;
        private System.ComponentModel.BackgroundWorker bWReceivers;
        private System.ComponentModel.BackgroundWorker bWDecipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbSshCnn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.ComponentModel.BackgroundWorker bWInitialzingSystem;
        private System.ComponentModel.BackgroundWorker bWConnectionToControllers;
        private System.ComponentModel.BackgroundWorker bWScanningForReceivers;
        private System.ComponentModel.BackgroundWorker bWPoweringOnReceivers;
        private System.ComponentModel.BackgroundWorker bWConnectingToReceivers;
        private System.ComponentModel.BackgroundWorker bWInitializingStack;
        private System.ComponentModel.BackgroundWorker bWLoopMainProc;
        private System.ComponentModel.BackgroundWorker bWDaemonWatcher;
    }
}