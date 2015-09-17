namespace WYBC
{
    partial class frmHome
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpAccounts = new System.Windows.Forms.GroupBox();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.grpFlagging = new System.Windows.Forms.GroupBox();
            this.grpLogs = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.grpSpeed = new System.Windows.Forms.GroupBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.grpAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(702, 63);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "W3 Youtube Booster Client";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(763, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpAccounts
            // 
            this.grpAccounts.Controls.Add(this.btnAddAccounts);
            this.grpAccounts.Controls.Add(this.txtAccount);
            this.grpAccounts.Location = new System.Drawing.Point(23, 75);
            this.grpAccounts.Name = "grpAccounts";
            this.grpAccounts.Size = new System.Drawing.Size(252, 165);
            this.grpAccounts.TabIndex = 5;
            this.grpAccounts.TabStop = false;
            this.grpAccounts.Text = "Accounts :";
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.Location = new System.Drawing.Point(146, 19);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(75, 20);
            this.btnAddAccounts.TabIndex = 1;
            this.btnAddAccounts.Text = "Add";
            this.btnAddAccounts.UseVisualStyleBackColor = true;
            this.btnAddAccounts.Click += new System.EventHandler(this.btnAddAccounts_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(6, 19);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(134, 20);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.Text = "username:password";
            // 
            // grpFlagging
            // 
            this.grpFlagging.Location = new System.Drawing.Point(281, 75);
            this.grpFlagging.Name = "grpFlagging";
            this.grpFlagging.Size = new System.Drawing.Size(252, 165);
            this.grpFlagging.TabIndex = 6;
            this.grpFlagging.TabStop = false;
            this.grpFlagging.Text = "Flagging :";
            // 
            // grpLogs
            // 
            this.grpLogs.Location = new System.Drawing.Point(23, 378);
            this.grpLogs.Name = "grpLogs";
            this.grpLogs.Size = new System.Drawing.Size(849, 158);
            this.grpLogs.TabIndex = 7;
            this.grpLogs.TabStop = false;
            this.grpLogs.Text = "Logs :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(763, 144);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 60);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(763, 210);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 60);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpStatistics
            // 
            this.grpStatistics.Location = new System.Drawing.Point(23, 274);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(252, 85);
            this.grpStatistics.TabIndex = 6;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics :";
            // 
            // grpSpeed
            // 
            this.grpSpeed.Location = new System.Drawing.Point(281, 274);
            this.grpSpeed.Name = "grpSpeed";
            this.grpSpeed.Size = new System.Drawing.Size(252, 85);
            this.grpSpeed.TabIndex = 7;
            this.grpSpeed.TabStop = false;
            this.grpSpeed.Text = "Speed :";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(763, 78);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(100, 60);
            this.btnSwitch.TabIndex = 10;
            this.btnSwitch.Text = "uSwitch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.grpSpeed);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpLogs);
            this.Controls.Add(this.grpFlagging);
            this.Controls.Add(this.grpAccounts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W3 Booster Client";
            this.grpAccounts.ResumeLayout(false);
            this.grpAccounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpAccounts;
        private System.Windows.Forms.GroupBox grpFlagging;
        private System.Windows.Forms.GroupBox grpLogs;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.GroupBox grpSpeed;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.Button btnSwitch;
    }
}