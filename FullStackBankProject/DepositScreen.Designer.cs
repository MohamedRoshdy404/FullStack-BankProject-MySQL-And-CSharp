namespace FullStackBankProject
{
    partial class DepositScreen
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.labMainScreenTransactions = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabAccountDetails = new System.Windows.Forms.Label();
            this.TboxCreateDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxDateOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxFirstName = new Guna.UI2.WinForms.Guna2TextBox();
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
            // labMainScreenTransactions
            // 
            this.labMainScreenTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMainScreenTransactions.AutoSize = true;
            this.labMainScreenTransactions.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainScreenTransactions.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labMainScreenTransactions.Location = new System.Drawing.Point(120, 40);
            this.labMainScreenTransactions.Name = "labMainScreenTransactions";
            this.labMainScreenTransactions.Size = new System.Drawing.Size(317, 29);
            this.labMainScreenTransactions.TabIndex = 17;
            this.labMainScreenTransactions.Text = "Main Screen Transactions";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.TboxCreateDate);
            this.MainPanel.Controls.Add(this.TboxPhone);
            this.MainPanel.Controls.Add(this.TboxCity);
            this.MainPanel.Controls.Add(this.TboxEmail);
            this.MainPanel.Controls.Add(this.TboxCountry);
            this.MainPanel.Controls.Add(this.TboxDateOfBirth);
            this.MainPanel.Controls.Add(this.TboxGender);
            this.MainPanel.Controls.Add(this.TboxLastName);
            this.MainPanel.Controls.Add(this.TboxFirstName);
            this.MainPanel.Controls.Add(this.PanelHeader);
            this.MainPanel.Location = new System.Drawing.Point(125, 91);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(927, 493);
            this.MainPanel.TabIndex = 18;
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
            // TboxCreateDate
            // 
            this.TboxCreateDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxCreateDate.Animated = true;
            this.TboxCreateDate.BorderRadius = 10;
            this.TboxCreateDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxCreateDate.DefaultText = "";
            this.TboxCreateDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxCreateDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxCreateDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxCreateDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxCreateDate.Enabled = false;
            this.TboxCreateDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxCreateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxCreateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxCreateDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxCreateDate.Location = new System.Drawing.Point(155, 354);
            this.TboxCreateDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxCreateDate.Name = "TboxCreateDate";
            this.TboxCreateDate.PasswordChar = '\0';
            this.TboxCreateDate.PlaceholderText = "CreateDate";
            this.TboxCreateDate.SelectedText = "";
            this.TboxCreateDate.Size = new System.Drawing.Size(288, 62);
            this.TboxCreateDate.TabIndex = 23;
            this.TboxCreateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TboxPhone.Location = new System.Drawing.Point(155, 214);
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
            this.TboxCity.Location = new System.Drawing.Point(482, 214);
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
            this.TboxEmail.Location = new System.Drawing.Point(482, 144);
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
            this.TboxCountry.Location = new System.Drawing.Point(155, 284);
            this.TboxCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxCountry.Name = "TboxCountry";
            this.TboxCountry.PasswordChar = '\0';
            this.TboxCountry.PlaceholderText = "Country";
            this.TboxCountry.SelectedText = "";
            this.TboxCountry.Size = new System.Drawing.Size(288, 62);
            this.TboxCountry.TabIndex = 19;
            this.TboxCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxDateOfBirth
            // 
            this.TboxDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxDateOfBirth.Animated = true;
            this.TboxDateOfBirth.BorderRadius = 10;
            this.TboxDateOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxDateOfBirth.DefaultText = "";
            this.TboxDateOfBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxDateOfBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxDateOfBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxDateOfBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxDateOfBirth.Enabled = false;
            this.TboxDateOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxDateOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxDateOfBirth.Location = new System.Drawing.Point(482, 284);
            this.TboxDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxDateOfBirth.Name = "TboxDateOfBirth";
            this.TboxDateOfBirth.PasswordChar = '\0';
            this.TboxDateOfBirth.PlaceholderText = "DateOfBirth";
            this.TboxDateOfBirth.SelectedText = "";
            this.TboxDateOfBirth.Size = new System.Drawing.Size(288, 62);
            this.TboxDateOfBirth.TabIndex = 18;
            this.TboxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxGender
            // 
            this.TboxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxGender.Animated = true;
            this.TboxGender.BorderRadius = 10;
            this.TboxGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxGender.DefaultText = "";
            this.TboxGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxGender.Enabled = false;
            this.TboxGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxGender.Location = new System.Drawing.Point(155, 144);
            this.TboxGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxGender.Name = "TboxGender";
            this.TboxGender.PasswordChar = '\0';
            this.TboxGender.PlaceholderText = "Gender";
            this.TboxGender.SelectedText = "";
            this.TboxGender.Size = new System.Drawing.Size(288, 62);
            this.TboxGender.TabIndex = 17;
            this.TboxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TboxLastName.Location = new System.Drawing.Point(482, 74);
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
            this.TboxFirstName.Location = new System.Drawing.Point(155, 74);
            this.TboxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxFirstName.Name = "TboxFirstName";
            this.TboxFirstName.PasswordChar = '\0';
            this.TboxFirstName.PlaceholderText = "FirstName";
            this.TboxFirstName.SelectedText = "";
            this.TboxFirstName.Size = new System.Drawing.Size(288, 62);
            this.TboxFirstName.TabIndex = 15;
            this.TboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DepositScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.labMainScreenTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepositScreen";
            this.Text = "DepositScreen";
            this.MainPanel.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label labMainScreenTransactions;
        private System.Windows.Forms.Label LabAccountDetails;
        private Guna.UI2.WinForms.Guna2TextBox TboxCreateDate;
        private Guna.UI2.WinForms.Guna2TextBox TboxPhone;
        private Guna.UI2.WinForms.Guna2TextBox TboxCity;
        private Guna.UI2.WinForms.Guna2TextBox TboxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TboxCountry;
        private Guna.UI2.WinForms.Guna2TextBox TboxDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox TboxGender;
        private Guna.UI2.WinForms.Guna2TextBox TboxLastName;
        private Guna.UI2.WinForms.Guna2TextBox TboxFirstName;
    }
}