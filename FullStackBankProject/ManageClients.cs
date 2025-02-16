using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullStackBankProject
{
    public partial class ManageClients: Form
    {
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panManageClient;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteClient;
        private Guna.UI2.WinForms.Guna2Button BtnClientList;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateClient;
        private Guna.UI2.WinForms.Guna2Button BtnAddClient;
        private Guna.UI2.WinForms.Guna2Button BtnFindClient;
        private IContainer components;

        public ManageClients()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageClients));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panManageClient = new System.Windows.Forms.Panel();
            this.BtnFindClient = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClientList = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panManageClient
            // 
            this.panManageClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panManageClient.Location = new System.Drawing.Point(0, 0);
            this.panManageClient.Name = "panManageClient";
            this.panManageClient.Size = new System.Drawing.Size(846, 504);
            this.panManageClient.TabIndex = 9;
            this.panManageClient.Paint += new System.Windows.Forms.PaintEventHandler(this.panManageClient_Paint);
            // 
            // BtnFindClient
            // 
            this.BtnFindClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFindClient.Animated = true;
            this.BtnFindClient.BackColor = System.Drawing.Color.Transparent;
            this.BtnFindClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFindClient.BorderRadius = 30;
            this.BtnFindClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFindClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFindClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFindClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFindClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFindClient.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnFindClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnFindClient.ForeColor = System.Drawing.Color.Black;
            this.BtnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindClient.Image")));
            this.BtnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindClient.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnFindClient.IndicateFocus = true;
            this.BtnFindClient.Location = new System.Drawing.Point(66, 123);
            this.BtnFindClient.Name = "BtnFindClient";
            this.BtnFindClient.Size = new System.Drawing.Size(251, 63);
            this.BtnFindClient.TabIndex = 4;
            this.BtnFindClient.Text = "Find Client";
            this.BtnFindClient.UseTransparentBackground = true;
            this.BtnFindClient.Click += new System.EventHandler(this.BtnFindClient_Click);
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddClient.Animated = true;
            this.BtnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddClient.BorderRadius = 30;
            this.BtnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddClient.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnAddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnAddClient.ForeColor = System.Drawing.Color.Black;
            this.BtnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClient.Image")));
            this.BtnAddClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAddClient.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddClient.IndicateFocus = true;
            this.BtnAddClient.Location = new System.Drawing.Point(66, 210);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(251, 63);
            this.BtnAddClient.TabIndex = 5;
            this.BtnAddClient.Text = "Add Client";
            this.BtnAddClient.UseTransparentBackground = true;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // BtnUpdateClient
            // 
            this.BtnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdateClient.Animated = true;
            this.BtnUpdateClient.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdateClient.BorderRadius = 30;
            this.BtnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateClient.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnUpdateClient.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateClient.Image")));
            this.BtnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUpdateClient.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnUpdateClient.IndicateFocus = true;
            this.BtnUpdateClient.Location = new System.Drawing.Point(66, 288);
            this.BtnUpdateClient.Name = "BtnUpdateClient";
            this.BtnUpdateClient.Size = new System.Drawing.Size(251, 63);
            this.BtnUpdateClient.TabIndex = 6;
            this.BtnUpdateClient.Text = "Update Client";
            this.BtnUpdateClient.UseTransparentBackground = true;
            this.BtnUpdateClient.Click += new System.EventHandler(this.BtnUpdateClient_Click);
            // 
            // BtnClientList
            // 
            this.BtnClientList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClientList.Animated = true;
            this.BtnClientList.BackColor = System.Drawing.Color.Transparent;
            this.BtnClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClientList.BorderRadius = 30;
            this.BtnClientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClientList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClientList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClientList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClientList.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnClientList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnClientList.ForeColor = System.Drawing.Color.Black;
            this.BtnClientList.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientList.Image")));
            this.BtnClientList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClientList.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnClientList.IndicateFocus = true;
            this.BtnClientList.Location = new System.Drawing.Point(383, 123);
            this.BtnClientList.Name = "BtnClientList";
            this.BtnClientList.Size = new System.Drawing.Size(251, 63);
            this.BtnClientList.TabIndex = 7;
            this.BtnClientList.Text = "Client List";
            this.BtnClientList.UseTransparentBackground = true;
            this.BtnClientList.Click += new System.EventHandler(this.BtnClientList_Click);
            // 
            // BtnDeleteClient
            // 
            this.BtnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeleteClient.Animated = true;
            this.BtnDeleteClient.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeleteClient.BorderRadius = 30;
            this.BtnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteClient.FillColor = System.Drawing.Color.Gainsboro;
            this.BtnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteClient.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteClient.Image")));
            this.BtnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDeleteClient.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnDeleteClient.IndicateFocus = true;
            this.BtnDeleteClient.Location = new System.Drawing.Point(383, 210);
            this.BtnDeleteClient.Name = "BtnDeleteClient";
            this.BtnDeleteClient.Size = new System.Drawing.Size(251, 63);
            this.BtnDeleteClient.TabIndex = 8;
            this.BtnDeleteClient.Text = "Delete Client";
            this.BtnDeleteClient.UseTransparentBackground = true;
            this.BtnDeleteClient.Click += new System.EventHandler(this.BtnDeleteClient_Click);
            // 
            // ManageClients
            // 
            this.ClientSize = new System.Drawing.Size(846, 504);
            this.Controls.Add(this.BtnDeleteClient);
            this.Controls.Add(this.BtnClientList);
            this.Controls.Add(this.BtnUpdateClient);
            this.Controls.Add(this.BtnAddClient);
            this.Controls.Add(this.BtnFindClient);
            this.Controls.Add(this.panManageClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }


        public void LoadForm(object form)
        {

            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.Show();
            frm.BringToFront();
        }

        private void BtnClientList_Click(object sender, EventArgs e)
        {
            LoadForm(new GetAllClients());
        }
                
        private void panManageClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFindClient_Click(object sender, EventArgs e)
        {
            LoadForm( new FindClient());
        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdateClient());
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            LoadForm(new AddNewClient());
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            LoadForm(new DeleteClient());
        }
    }
}
