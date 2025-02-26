using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace FullStackBankProject
{
    public partial class Form1 : Form
    {

        public static Panel myPanel; 

        public Form1()
        {
            InitializeComponent();

            myPanel = mainPanel;
            //Form1.loadForm(new ManageClients());
            loadInfoUser();

            if (!Form1.CheckPermissions(Form1.enMainMenuePermissions.pManageClients))
            {
                BtnManageClients.Enabled = false;
            }

            if (!Form1.CheckPermissions(Form1.enMainMenuePermissions.pManageAccounts))
            {
                BtnManageAccounts.Enabled = false;
            }

            if (!Form1.CheckPermissions(Form1.enMainMenuePermissions.pManageUsers))
            {
                BtnManageUsers.Enabled = false;
            }

            if (!Form1.CheckPermissions(Form1.enMainMenuePermissions.pManageTransactions))
            {
                BtnManageTransactionScreen.Enabled = false;
            }

            if (!Form1.CheckPermissions(Form1.enMainMenuePermissions.pLoginRegister))
            {
                BtnManageLoginRegister.Enabled = false;
            }

        }


        public enum enMainMenuePermissions
        {
            eAll = -1, pManageClients = 1, pManageAccounts = 2, pManageUsers = 4,
            pManageTransactions = 8 , pLoginRegister = 16
        };

        public static bool CheckPermissions(enMainMenuePermissions permissions)
        {
            if ( (enMainMenuePermissions)clsGlobal.Permissions == enMainMenuePermissions.eAll )
                return true;
            if ((permissions & (enMainMenuePermissions)clsGlobal.Permissions) == permissions)
                return true;
            else
                return false;
        }



        public void loadInfoUser()
        {
            if (!string.IsNullOrEmpty(clsGlobal.Image) && File.Exists(clsGlobal.Image))
            {
                try
                {
                    using (FileStream fs = new FileStream(clsGlobal.Image, FileMode.Open, FileAccess.Read))
                    {
                        picLoadImgeUser.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // لو مفيش صورة، استخدم صورة افتراضية
            }

            labINameUser.Text = clsGlobal.UserName.ToUpper();


        }
        

        public static void loadForm(Form form)
        {
            if (form == null)
                return;

            myPanel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            myPanel.Controls.Add(form);
            myPanel.Tag = form;
            form.Show();
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnlistClients_Click(object sender, EventArgs e)
        {
            loadForm(new ManageClients());
        }

        private void labINameUser_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());
        }

        private void picLoadImgeUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frmLogin = new Login();
            frmLogin.ShowDialog();
        }

        private void BtnTransactionScreen_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageTransactions());
        }
    }
}
