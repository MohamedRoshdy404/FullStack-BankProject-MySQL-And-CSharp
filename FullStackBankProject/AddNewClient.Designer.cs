namespace FullStackBankProject
{
    partial class AddNewClient
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
            this.MainPanAddNewClient = new System.Windows.Forms.Panel();
            this.ctrlAddNewClient1 = new FullStackBankProject.ctrlAddNewClient();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MainPanAddNewClient
            // 
            this.MainPanAddNewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanAddNewClient.Location = new System.Drawing.Point(0, 0);
            this.MainPanAddNewClient.Name = "MainPanAddNewClient";
            this.MainPanAddNewClient.Size = new System.Drawing.Size(1128, 621);
            this.MainPanAddNewClient.TabIndex = 0;
            // 
            // ctrlAddNewClient1
            // 
            this.ctrlAddNewClient1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAddNewClient1.Name = "ctrlAddNewClient1";
            this.ctrlAddNewClient1.Size = new System.Drawing.Size(859, 632);
            this.ctrlAddNewClient1.TabIndex = 1;
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 621);
            this.Controls.Add(this.ctrlAddNewClient1);
            this.Controls.Add(this.MainPanAddNewClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewClient";
            this.Text = "AddNewClient";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel MainPanAddNewClient;
        private ctrlAddNewClient ctrlAddNewClient1;
    }
}