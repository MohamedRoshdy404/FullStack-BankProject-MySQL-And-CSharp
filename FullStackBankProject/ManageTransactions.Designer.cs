namespace FullStackBankProject
{
    partial class ManageTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTransactions));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.BtnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTotalBalances = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTransferLog = new Guna.UI2.WinForms.Guna2Button();
            this.labMainScreenTransactions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeposit.Animated = true;
            this.BtnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeposit.BorderRadius = 10;
            this.BtnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeposit.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnDeposit.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.BtnDeposit.ForeColor = System.Drawing.Color.Black;
            this.BtnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeposit.Image")));
            this.BtnDeposit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDeposit.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnDeposit.IndicateFocus = true;
            this.BtnDeposit.Location = new System.Drawing.Point(120, 100);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(234, 103);
            this.BtnDeposit.TabIndex = 4;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseTransparentBackground = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnWithdraw.Animated = true;
            this.BtnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.BtnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnWithdraw.BorderRadius = 10;
            this.BtnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnWithdraw.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnWithdraw.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.BtnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.BtnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("BtnWithdraw.Image")));
            this.BtnWithdraw.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnWithdraw.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnWithdraw.IndicateFocus = true;
            this.BtnWithdraw.Location = new System.Drawing.Point(422, 100);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(234, 103);
            this.BtnWithdraw.TabIndex = 5;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseTransparentBackground = true;
            // 
            // BtnTotalBalances
            // 
            this.BtnTotalBalances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTotalBalances.Animated = true;
            this.BtnTotalBalances.BackColor = System.Drawing.Color.Transparent;
            this.BtnTotalBalances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTotalBalances.BorderRadius = 10;
            this.BtnTotalBalances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTotalBalances.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTotalBalances.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTotalBalances.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTotalBalances.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTotalBalances.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnTotalBalances.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.BtnTotalBalances.ForeColor = System.Drawing.Color.Black;
            this.BtnTotalBalances.Image = ((System.Drawing.Image)(resources.GetObject("BtnTotalBalances.Image")));
            this.BtnTotalBalances.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTotalBalances.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnTotalBalances.IndicateFocus = true;
            this.BtnTotalBalances.Location = new System.Drawing.Point(120, 220);
            this.BtnTotalBalances.Name = "BtnTotalBalances";
            this.BtnTotalBalances.Size = new System.Drawing.Size(837, 103);
            this.BtnTotalBalances.TabIndex = 7;
            this.BtnTotalBalances.Text = "TotalBalances";
            this.BtnTotalBalances.UseTransparentBackground = true;
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTransfer.Animated = true;
            this.BtnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.BtnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTransfer.BorderRadius = 10;
            this.BtnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTransfer.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnTransfer.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.BtnTransfer.ForeColor = System.Drawing.Color.Black;
            this.BtnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransfer.Image")));
            this.BtnTransfer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTransfer.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnTransfer.IndicateFocus = true;
            this.BtnTransfer.Location = new System.Drawing.Point(724, 100);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(234, 103);
            this.BtnTransfer.TabIndex = 6;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.UseTransparentBackground = true;
            // 
            // BtnTransferLog
            // 
            this.BtnTransferLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTransferLog.Animated = true;
            this.BtnTransferLog.BackColor = System.Drawing.Color.Transparent;
            this.BtnTransferLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTransferLog.BorderRadius = 10;
            this.BtnTransferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransferLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransferLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransferLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTransferLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTransferLog.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnTransferLog.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.BtnTransferLog.ForeColor = System.Drawing.Color.Black;
            this.BtnTransferLog.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransferLog.Image")));
            this.BtnTransferLog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTransferLog.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnTransferLog.IndicateFocus = true;
            this.BtnTransferLog.Location = new System.Drawing.Point(120, 340);
            this.BtnTransferLog.Name = "BtnTransferLog";
            this.BtnTransferLog.Size = new System.Drawing.Size(837, 103);
            this.BtnTransferLog.TabIndex = 8;
            this.BtnTransferLog.Text = "Transfer Log";
            this.BtnTransferLog.UseTransparentBackground = true;
            // 
            // labMainScreenTransactions
            // 
            this.labMainScreenTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMainScreenTransactions.AutoSize = true;
            this.labMainScreenTransactions.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainScreenTransactions.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labMainScreenTransactions.Location = new System.Drawing.Point(120, 40);
            this.labMainScreenTransactions.Name = "labMainScreenTransactions";
            this.labMainScreenTransactions.Size = new System.Drawing.Size(317, 29);
            this.labMainScreenTransactions.TabIndex = 16;
            this.labMainScreenTransactions.Text = "Main Screen Transactions";
            // 
            // ManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.labMainScreenTransactions);
            this.Controls.Add(this.BtnTransferLog);
            this.Controls.Add(this.BtnTotalBalances);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageTransactions";
            this.Text = "ManageTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button BtnWithdraw;
        private Guna.UI2.WinForms.Guna2Button BtnDeposit;
        private Guna.UI2.WinForms.Guna2Button BtnTotalBalances;
        private Guna.UI2.WinForms.Guna2Button BtnTransfer;
        private Guna.UI2.WinForms.Guna2Button BtnTransferLog;
        private System.Windows.Forms.Label labMainScreenTransactions;
    }
}