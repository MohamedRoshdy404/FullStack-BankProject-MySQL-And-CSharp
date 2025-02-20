namespace FullStackBankProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.labUserName = new System.Windows.Forms.Label();
            this.TboxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnExitLoginScreen = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.chkShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(588, 212);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(121, 25);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "UserName";
            // 
            // TboxUserName
            // 
            this.TboxUserName.Animated = true;
            this.TboxUserName.AutoRoundedCorners = true;
            this.TboxUserName.BorderRadius = 27;
            this.TboxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxUserName.DefaultText = "";
            this.TboxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxUserName.Location = new System.Drawing.Point(593, 252);
            this.TboxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxUserName.Name = "TboxUserName";
            this.TboxUserName.PasswordChar = '\0';
            this.TboxUserName.PlaceholderText = "UserName";
            this.TboxUserName.SelectedText = "";
            this.TboxUserName.Size = new System.Drawing.Size(247, 56);
            this.TboxUserName.TabIndex = 2;
            this.TboxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TboxPassword
            // 
            this.TboxPassword.Animated = true;
            this.TboxPassword.AutoRoundedCorners = true;
            this.TboxPassword.BorderRadius = 27;
            this.TboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxPassword.DefaultText = "";
            this.TboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxPassword.Location = new System.Drawing.Point(593, 370);
            this.TboxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxPassword.Name = "TboxPassword";
            this.TboxPassword.PasswordChar = '●';
            this.TboxPassword.PlaceholderText = "Password";
            this.TboxPassword.SelectedText = "";
            this.TboxPassword.Size = new System.Drawing.Size(247, 56);
            this.TboxPassword.TabIndex = 4;
            this.TboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(588, 330);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(115, 25);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "Password";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(528, 598);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BtnExitLoginScreen
            // 
            this.BtnExitLoginScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitLoginScreen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExitLoginScreen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExitLoginScreen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExitLoginScreen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExitLoginScreen.FillColor = System.Drawing.Color.Transparent;
            this.BtnExitLoginScreen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitLoginScreen.ForeColor = System.Drawing.Color.Black;
            this.BtnExitLoginScreen.Location = new System.Drawing.Point(1036, -1);
            this.BtnExitLoginScreen.Name = "BtnExitLoginScreen";
            this.BtnExitLoginScreen.Size = new System.Drawing.Size(42, 40);
            this.BtnExitLoginScreen.TabIndex = 6;
            this.BtnExitLoginScreen.Text = "X";
            this.BtnExitLoginScreen.Click += new System.EventHandler(this.BtnExitLoginScreen_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Animated = true;
            this.BtnLogin.AutoRoundedCorners = true;
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BorderRadius = 21;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Location = new System.Drawing.Point(593, 450);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(180, 45);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseTransparentBackground = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowPassword.CheckedState.BorderRadius = 0;
            this.chkShowPassword.CheckedState.BorderThickness = 0;
            this.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(823, 461);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(124, 20);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "ShowPassword";
            this.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPassword.UncheckedState.BorderRadius = 0;
            this.chkShowPassword.UncheckedState.BorderThickness = 0;
            this.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1078, 599);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.TboxPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.TboxUserName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.BtnExitLoginScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label labUserName;
        private Guna.UI2.WinForms.Guna2TextBox TboxPassword;
        private System.Windows.Forms.Label labPassword;
        private Guna.UI2.WinForms.Guna2TextBox TboxUserName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnExitLoginScreen;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowPassword;
    }
}