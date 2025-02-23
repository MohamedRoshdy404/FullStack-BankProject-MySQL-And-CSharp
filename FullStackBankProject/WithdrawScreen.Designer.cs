namespace FullStackBankProject
{
    partial class WithdrawScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawScreen));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.TboxEntertheWithdrawAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSerach = new Guna.UI2.WinForms.Guna2Button();
            this.TboxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabAccountDetails = new System.Windows.Forms.Label();
            this.labMainScreenTransactionsWithdraw = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.Animated = true;
            this.BtnBack.AutoRoundedCorners = true;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BorderRadius = 21;
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
            this.BtnBack.Location = new System.Drawing.Point(108, 615);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(180, 45);
            this.BtnBack.TabIndex = 27;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseTransparentBackground = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.BtnWithdraw);
            this.MainPanel.Controls.Add(this.BtnClear);
            this.MainPanel.Controls.Add(this.TboxEntertheWithdrawAmount);
            this.MainPanel.Controls.Add(this.TboxClientID);
            this.MainPanel.Controls.Add(this.TboxAccountBalance);
            this.MainPanel.Controls.Add(this.BtnSerach);
            this.MainPanel.Controls.Add(this.TboxPhone);
            this.MainPanel.Controls.Add(this.TboxCity);
            this.MainPanel.Controls.Add(this.TboxEmail);
            this.MainPanel.Controls.Add(this.TboxCountry);
            this.MainPanel.Controls.Add(this.TboxAccountNumber);
            this.MainPanel.Controls.Add(this.TboxLastName);
            this.MainPanel.Controls.Add(this.TboxFirstName);
            this.MainPanel.Controls.Add(this.PanelHeader);
            this.MainPanel.Location = new System.Drawing.Point(109, 56);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(927, 553);
            this.MainPanel.TabIndex = 26;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnWithdraw.Animated = true;
            this.BtnWithdraw.AutoRoundedCorners = true;
            this.BtnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.BtnWithdraw.BorderRadius = 26;
            this.BtnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnWithdraw.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.BtnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("BtnWithdraw.Image")));
            this.BtnWithdraw.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnWithdraw.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnWithdraw.Location = new System.Drawing.Point(537, 482);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(191, 55);
            this.BtnWithdraw.TabIndex = 36;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseTransparentBackground = true;
            this.BtnWithdraw.Visible = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
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
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.Black;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClear.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnClear.Location = new System.Drawing.Point(200, 482);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(187, 55);
            this.BtnClear.TabIndex = 35;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseTransparentBackground = true;
            this.BtnClear.Visible = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TboxEntertheWithdrawAmount
            // 
            this.TboxEntertheWithdrawAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxEntertheWithdrawAmount.Animated = true;
            this.TboxEntertheWithdrawAmount.BorderRadius = 10;
            this.TboxEntertheWithdrawAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxEntertheWithdrawAmount.DefaultText = "";
            this.TboxEntertheWithdrawAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxEntertheWithdrawAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxEntertheWithdrawAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxEntertheWithdrawAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxEntertheWithdrawAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxEntertheWithdrawAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxEntertheWithdrawAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxEntertheWithdrawAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxEntertheWithdrawAmount.Location = new System.Drawing.Point(155, 427);
            this.TboxEntertheWithdrawAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxEntertheWithdrawAmount.Name = "TboxEntertheWithdrawAmount";
            this.TboxEntertheWithdrawAmount.PasswordChar = '\0';
            this.TboxEntertheWithdrawAmount.PlaceholderText = "Enter the withdraw amount";
            this.TboxEntertheWithdrawAmount.SelectedText = "";
            this.TboxEntertheWithdrawAmount.Size = new System.Drawing.Size(615, 48);
            this.TboxEntertheWithdrawAmount.TabIndex = 34;
            this.TboxEntertheWithdrawAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TboxEntertheWithdrawAmount.Visible = false;
            // 
            // TboxClientID
            // 
            this.TboxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxClientID.Animated = true;
            this.TboxClientID.BorderRadius = 10;
            this.TboxClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxClientID.DefaultText = "";
            this.TboxClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxClientID.Enabled = false;
            this.TboxClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxClientID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxClientID.Location = new System.Drawing.Point(482, 147);
            this.TboxClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxClientID.Name = "TboxClientID";
            this.TboxClientID.PasswordChar = '\0';
            this.TboxClientID.PlaceholderText = "ClientID";
            this.TboxClientID.SelectedText = "";
            this.TboxClientID.Size = new System.Drawing.Size(288, 62);
            this.TboxClientID.TabIndex = 33;
            this.TboxClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxAccountBalance
            // 
            this.TboxAccountBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxAccountBalance.Animated = true;
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
            this.TboxAccountBalance.Location = new System.Drawing.Point(155, 147);
            this.TboxAccountBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxAccountBalance.Name = "TboxAccountBalance";
            this.TboxAccountBalance.PasswordChar = '\0';
            this.TboxAccountBalance.PlaceholderText = "Account Balance";
            this.TboxAccountBalance.SelectedText = "";
            this.TboxAccountBalance.Size = new System.Drawing.Size(288, 62);
            this.TboxAccountBalance.TabIndex = 32;
            this.TboxAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnSerach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnSerach.ForeColor = System.Drawing.Color.Black;
            this.BtnSerach.Image = ((System.Drawing.Image)(resources.GetObject("BtnSerach.Image")));
            this.BtnSerach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSerach.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnSerach.Location = new System.Drawing.Point(537, 77);
            this.BtnSerach.Name = "BtnSerach";
            this.BtnSerach.Size = new System.Drawing.Size(191, 55);
            this.BtnSerach.TabIndex = 31;
            this.BtnSerach.Text = "Serach";
            this.BtnSerach.UseTransparentBackground = true;
            this.BtnSerach.Click += new System.EventHandler(this.BtnSerach_Click);
            // 
            // TboxPhone
            // 
            this.TboxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxPhone.Animated = true;
            this.TboxPhone.BorderRadius = 10;
            this.TboxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxPhone.DefaultText = "";
            this.TboxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxPhone.Enabled = false;
            this.TboxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxPhone.Location = new System.Drawing.Point(482, 287);
            this.TboxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxPhone.Name = "TboxPhone";
            this.TboxPhone.PasswordChar = '\0';
            this.TboxPhone.PlaceholderText = "Phone";
            this.TboxPhone.SelectedText = "";
            this.TboxPhone.Size = new System.Drawing.Size(288, 62);
            this.TboxPhone.TabIndex = 22;
            this.TboxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxCity
            // 
            this.TboxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxCity.Animated = true;
            this.TboxCity.BorderRadius = 10;
            this.TboxCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxCity.DefaultText = "";
            this.TboxCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxCity.Enabled = false;
            this.TboxCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxCity.Location = new System.Drawing.Point(155, 357);
            this.TboxCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxCity.Name = "TboxCity";
            this.TboxCity.PasswordChar = '\0';
            this.TboxCity.PlaceholderText = "City";
            this.TboxCity.SelectedText = "";
            this.TboxCity.Size = new System.Drawing.Size(288, 62);
            this.TboxCity.TabIndex = 21;
            this.TboxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxEmail
            // 
            this.TboxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxEmail.Animated = true;
            this.TboxEmail.BorderRadius = 10;
            this.TboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxEmail.DefaultText = "";
            this.TboxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxEmail.Enabled = false;
            this.TboxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxEmail.Location = new System.Drawing.Point(155, 287);
            this.TboxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxEmail.Name = "TboxEmail";
            this.TboxEmail.PasswordChar = '\0';
            this.TboxEmail.PlaceholderText = "Email";
            this.TboxEmail.SelectedText = "";
            this.TboxEmail.Size = new System.Drawing.Size(288, 62);
            this.TboxEmail.TabIndex = 20;
            this.TboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxCountry
            // 
            this.TboxCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxCountry.Animated = true;
            this.TboxCountry.BorderRadius = 10;
            this.TboxCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxCountry.DefaultText = "";
            this.TboxCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxCountry.Enabled = false;
            this.TboxCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxCountry.Location = new System.Drawing.Point(482, 357);
            this.TboxCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxCountry.Name = "TboxCountry";
            this.TboxCountry.PasswordChar = '\0';
            this.TboxCountry.PlaceholderText = "Country";
            this.TboxCountry.SelectedText = "";
            this.TboxCountry.Size = new System.Drawing.Size(288, 62);
            this.TboxCountry.TabIndex = 19;
            this.TboxCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TboxAccountNumber.Location = new System.Drawing.Point(155, 77);
            this.TboxAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxAccountNumber.Name = "TboxAccountNumber";
            this.TboxAccountNumber.PasswordChar = '\0';
            this.TboxAccountNumber.PlaceholderText = "Account Number";
            this.TboxAccountNumber.SelectedText = "";
            this.TboxAccountNumber.Size = new System.Drawing.Size(288, 62);
            this.TboxAccountNumber.TabIndex = 17;
            this.TboxAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxLastName
            // 
            this.TboxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxLastName.Animated = true;
            this.TboxLastName.BorderRadius = 10;
            this.TboxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxLastName.DefaultText = "";
            this.TboxLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxLastName.Enabled = false;
            this.TboxLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxLastName.Location = new System.Drawing.Point(482, 217);
            this.TboxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxLastName.Name = "TboxLastName";
            this.TboxLastName.PasswordChar = '\0';
            this.TboxLastName.PlaceholderText = "LastName";
            this.TboxLastName.SelectedText = "";
            this.TboxLastName.Size = new System.Drawing.Size(288, 62);
            this.TboxLastName.TabIndex = 16;
            this.TboxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxFirstName
            // 
            this.TboxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxFirstName.Animated = true;
            this.TboxFirstName.BorderRadius = 10;
            this.TboxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxFirstName.DefaultText = "";
            this.TboxFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxFirstName.Enabled = false;
            this.TboxFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxFirstName.Location = new System.Drawing.Point(155, 217);
            this.TboxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxFirstName.Name = "TboxFirstName";
            this.TboxFirstName.PasswordChar = '\0';
            this.TboxFirstName.PlaceholderText = "FirstName";
            this.TboxFirstName.SelectedText = "";
            this.TboxFirstName.Size = new System.Drawing.Size(288, 62);
            this.TboxFirstName.TabIndex = 15;
            this.TboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelHeader.Controls.Add(this.LabAccountDetails);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(925, 47);
            this.PanelHeader.TabIndex = 0;
            // 
            // LabAccountDetails
            // 
            this.LabAccountDetails.AutoSize = true;
            this.LabAccountDetails.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAccountDetails.ForeColor = System.Drawing.Color.DarkGray;
            this.LabAccountDetails.Location = new System.Drawing.Point(16, 12);
            this.LabAccountDetails.Name = "LabAccountDetails";
            this.LabAccountDetails.Size = new System.Drawing.Size(137, 22);
            this.LabAccountDetails.TabIndex = 2;
            this.LabAccountDetails.Text = "Account Details";
            // 
            // labMainScreenTransactionsWithdraw
            // 
            this.labMainScreenTransactionsWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMainScreenTransactionsWithdraw.AutoSize = true;
            this.labMainScreenTransactionsWithdraw.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainScreenTransactionsWithdraw.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labMainScreenTransactionsWithdraw.Location = new System.Drawing.Point(104, 15);
            this.labMainScreenTransactionsWithdraw.Name = "labMainScreenTransactionsWithdraw";
            this.labMainScreenTransactionsWithdraw.Size = new System.Drawing.Size(404, 29);
            this.labMainScreenTransactionsWithdraw.TabIndex = 25;
            this.labMainScreenTransactionsWithdraw.Text = "Screen Transactions > Withdraw";
            // 
            // WithdrawScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.labMainScreenTransactionsWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawScreen";
            this.Text = "WithdrawScreen";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button BtnWithdraw;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
        private Guna.UI2.WinForms.Guna2TextBox TboxEntertheWithdrawAmount;
        private Guna.UI2.WinForms.Guna2TextBox TboxClientID;
        private Guna.UI2.WinForms.Guna2TextBox TboxAccountBalance;
        private Guna.UI2.WinForms.Guna2Button BtnSerach;
        private Guna.UI2.WinForms.Guna2TextBox TboxPhone;
        private Guna.UI2.WinForms.Guna2TextBox TboxCity;
        private Guna.UI2.WinForms.Guna2TextBox TboxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TboxCountry;
        private Guna.UI2.WinForms.Guna2TextBox TboxAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox TboxLastName;
        private Guna.UI2.WinForms.Guna2TextBox TboxFirstName;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabAccountDetails;
        private System.Windows.Forms.Label labMainScreenTransactionsWithdraw;
    }
}