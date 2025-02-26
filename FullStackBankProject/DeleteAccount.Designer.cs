namespace FullStackBankProject
{
    partial class DeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccount));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnSerach = new Guna.UI2.WinForms.Guna2Button();
            this.TboxAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.labDeleteAccount = new System.Windows.Forms.Label();
            this.TboxClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxAccountCreationDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxPasswordAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnSerach
            // 
            this.BtnSerach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSerach.Animated = true;
            this.BtnSerach.AutoRoundedCorners = true;
            this.BtnSerach.BackColor = System.Drawing.Color.Transparent;
            this.BtnSerach.BorderRadius = 26;
            this.BtnSerach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSerach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSerach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSerach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSerach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSerach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSerach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSerach.ForeColor = System.Drawing.Color.Black;
            this.BtnSerach.Image = ((System.Drawing.Image)(resources.GetObject("BtnSerach.Image")));
            this.BtnSerach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSerach.Location = new System.Drawing.Point(738, 150);
            this.BtnSerach.Name = "BtnSerach";
            this.BtnSerach.Size = new System.Drawing.Size(155, 55);
            this.BtnSerach.TabIndex = 14;
            this.BtnSerach.Text = "Serach";
            this.BtnSerach.UseTransparentBackground = true;
            this.BtnSerach.Click += new System.EventHandler(this.BtnSerach_Click);
            // 
            // TboxAccountNumber
            // 
            this.TboxAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxAccountNumber.Animated = true;
            this.TboxAccountNumber.BorderRadius = 10;
            this.TboxAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxAccountNumber.DefaultText = "";
            this.TboxAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxAccountNumber.Location = new System.Drawing.Point(197, 143);
            this.TboxAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxAccountNumber.Name = "TboxAccountNumber";
            this.TboxAccountNumber.PasswordChar = '\0';
            this.TboxAccountNumber.PlaceholderText = "Account Number";
            this.TboxAccountNumber.SelectedText = "";
            this.TboxAccountNumber.Size = new System.Drawing.Size(508, 62);
            this.TboxAccountNumber.TabIndex = 16;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.Animated = true;
            this.BtnBack.AutoRoundedCorners = true;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BorderRadius = 26;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.Black;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBack.Location = new System.Drawing.Point(197, 524);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(155, 55);
            this.BtnBack.TabIndex = 29;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseTransparentBackground = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // labDeleteAccount
            // 
            this.labDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDeleteAccount.AutoSize = true;
            this.labDeleteAccount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDeleteAccount.Location = new System.Drawing.Point(192, 83);
            this.labDeleteAccount.Name = "labDeleteAccount";
            this.labDeleteAccount.Size = new System.Drawing.Size(194, 29);
            this.labDeleteAccount.TabIndex = 30;
            this.labDeleteAccount.Text = "Delete Account";
            // 
            // TboxClientID
            // 
            this.TboxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxClientID.BorderRadius = 10;
            this.TboxClientID.BorderThickness = 0;
            this.TboxClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxClientID.DefaultText = "";
            this.TboxClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxClientID.Enabled = false;
            this.TboxClientID.FillColor = System.Drawing.Color.DarkGray;
            this.TboxClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxClientID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxClientID.Location = new System.Drawing.Point(197, 423);
            this.TboxClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxClientID.Name = "TboxClientID";
            this.TboxClientID.PasswordChar = '\0';
            this.TboxClientID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TboxClientID.PlaceholderText = "Client ID";
            this.TboxClientID.SelectedText = "";
            this.TboxClientID.Size = new System.Drawing.Size(508, 62);
            this.TboxClientID.TabIndex = 34;
            // 
            // TboxAccountCreationDate
            // 
            this.TboxAccountCreationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxAccountCreationDate.BorderRadius = 10;
            this.TboxAccountCreationDate.BorderThickness = 0;
            this.TboxAccountCreationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxAccountCreationDate.DefaultText = "";
            this.TboxAccountCreationDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxAccountCreationDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxAccountCreationDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxAccountCreationDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxAccountCreationDate.Enabled = false;
            this.TboxAccountCreationDate.FillColor = System.Drawing.Color.DarkGray;
            this.TboxAccountCreationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxAccountCreationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxAccountCreationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxAccountCreationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxAccountCreationDate.Location = new System.Drawing.Point(197, 353);
            this.TboxAccountCreationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxAccountCreationDate.Name = "TboxAccountCreationDate";
            this.TboxAccountCreationDate.PasswordChar = '\0';
            this.TboxAccountCreationDate.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TboxAccountCreationDate.PlaceholderText = "Account creation date";
            this.TboxAccountCreationDate.ReadOnly = true;
            this.TboxAccountCreationDate.SelectedText = "";
            this.TboxAccountCreationDate.Size = new System.Drawing.Size(508, 62);
            this.TboxAccountCreationDate.TabIndex = 33;
            // 
            // TboxAccountBalance
            // 
            this.TboxAccountBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxAccountBalance.BorderRadius = 10;
            this.TboxAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxAccountBalance.DefaultText = "";
            this.TboxAccountBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxAccountBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxAccountBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxAccountBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxAccountBalance.Enabled = false;
            this.TboxAccountBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxAccountBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxAccountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxAccountBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxAccountBalance.Location = new System.Drawing.Point(197, 283);
            this.TboxAccountBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxAccountBalance.Name = "TboxAccountBalance";
            this.TboxAccountBalance.PasswordChar = '\0';
            this.TboxAccountBalance.PlaceholderText = "Account Balance";
            this.TboxAccountBalance.SelectedText = "";
            this.TboxAccountBalance.Size = new System.Drawing.Size(508, 62);
            this.TboxAccountBalance.TabIndex = 32;
            // 
            // TboxPasswordAccountNumber
            // 
            this.TboxPasswordAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxPasswordAccountNumber.BorderRadius = 10;
            this.TboxPasswordAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxPasswordAccountNumber.DefaultText = "";
            this.TboxPasswordAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxPasswordAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxPasswordAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxPasswordAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxPasswordAccountNumber.Enabled = false;
            this.TboxPasswordAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxPasswordAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxPasswordAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxPasswordAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxPasswordAccountNumber.Location = new System.Drawing.Point(197, 213);
            this.TboxPasswordAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxPasswordAccountNumber.Name = "TboxPasswordAccountNumber";
            this.TboxPasswordAccountNumber.PasswordChar = '\0';
            this.TboxPasswordAccountNumber.PlaceholderText = "Password";
            this.TboxPasswordAccountNumber.SelectedText = "";
            this.TboxPasswordAccountNumber.Size = new System.Drawing.Size(508, 62);
            this.TboxPasswordAccountNumber.TabIndex = 31;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDelete.Animated = true;
            this.BtnDelete.AutoRoundedCorners = true;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BorderRadius = 26;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDelete.Location = new System.Drawing.Point(525, 524);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(180, 55);
            this.BtnDelete.TabIndex = 96;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseTransparentBackground = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClear.Animated = true;
            this.BtnClear.AutoRoundedCorners = true;
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.BorderRadius = 26;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.Black;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClear.Location = new System.Drawing.Point(361, 524);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(155, 55);
            this.BtnClear.TabIndex = 97;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseTransparentBackground = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TboxClientID);
            this.Controls.Add(this.TboxAccountCreationDate);
            this.Controls.Add(this.TboxAccountBalance);
            this.Controls.Add(this.TboxPasswordAccountNumber);
            this.Controls.Add(this.labDeleteAccount);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TboxAccountNumber);
            this.Controls.Add(this.BtnSerach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button BtnSerach;
        private Guna.UI2.WinForms.Guna2TextBox TboxAccountNumber;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private System.Windows.Forms.Label labDeleteAccount;
        private Guna.UI2.WinForms.Guna2TextBox TboxClientID;
        private Guna.UI2.WinForms.Guna2TextBox TboxAccountCreationDate;
        private Guna.UI2.WinForms.Guna2TextBox TboxAccountBalance;
        private Guna.UI2.WinForms.Guna2TextBox TboxPasswordAccountNumber;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
    }
}