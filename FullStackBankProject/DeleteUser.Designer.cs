namespace FullStackBankProject
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.TboxSearchUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSerach = new Guna.UI2.WinForms.Guna2Button();
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
            this.BtnBack.Location = new System.Drawing.Point(222, 415);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(155, 55);
            this.BtnBack.TabIndex = 32;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseTransparentBackground = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TboxSearchUserID
            // 
            this.TboxSearchUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TboxSearchUserID.Animated = true;
            this.TboxSearchUserID.BorderRadius = 10;
            this.TboxSearchUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TboxSearchUserID.DefaultText = "";
            this.TboxSearchUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TboxSearchUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TboxSearchUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxSearchUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TboxSearchUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxSearchUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TboxSearchUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxSearchUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TboxSearchUserID.Location = new System.Drawing.Point(222, 205);
            this.TboxSearchUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxSearchUserID.Name = "TboxSearchUserID";
            this.TboxSearchUserID.PasswordChar = '\0';
            this.TboxSearchUserID.PlaceholderText = "Enter UserID";
            this.TboxSearchUserID.SelectedText = "";
            this.TboxSearchUserID.Size = new System.Drawing.Size(508, 62);
            this.TboxSearchUserID.TabIndex = 31;
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
            this.BtnSerach.Location = new System.Drawing.Point(763, 212);
            this.BtnSerach.Name = "BtnSerach";
            this.BtnSerach.Size = new System.Drawing.Size(155, 55);
            this.BtnSerach.TabIndex = 30;
            this.BtnSerach.Text = "Serach";
            this.BtnSerach.UseTransparentBackground = true;
            this.BtnSerach.Click += new System.EventHandler(this.BtnSerach_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 675);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TboxSearchUserID);
            this.Controls.Add(this.BtnSerach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private Guna.UI2.WinForms.Guna2TextBox TboxSearchUserID;
        private Guna.UI2.WinForms.Guna2Button BtnSerach;
    }
}