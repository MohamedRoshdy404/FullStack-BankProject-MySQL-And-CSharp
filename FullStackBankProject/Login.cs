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

namespace FullStackBankProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnExitLoginScreen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string UserName = TboxUserName.Text;
            string Password = TboxPassword.Text;

            clsUserBusinessLayer User = clsUserBusinessLayer.FindUserByUserNameAndPassword(UserName, Password);
            clsLoginRegisterBusinessLayer AddRowLoginRegister = new clsLoginRegisterBusinessLayer();

            AddRowLoginRegister.DateLogin = DateTime.Now;
            AddRowLoginRegister.UserID = User.UserID;
            AddRowLoginRegister.UserName = UserName;
            AddRowLoginRegister.Password = Password;
            AddRowLoginRegister.Permissions = User.Permissions;
            AddRowLoginRegister.Save();


            if (User != null)
            {
                clsGlobal.UserID = User.UserID;
                clsGlobal.UserName = UserName;
                clsGlobal.Password = Password;
                clsGlobal.Image = User.Image;
                clsGlobal.Permissions = User.Permissions;

                Form frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show($"This user does not exist: {UserName} , {Password}", "Oops Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TboxPassword.PasswordChar == '●')
            {
                TboxPassword.PasswordChar = '\0';
            }
            else
            {
                TboxPassword.PasswordChar = '●';

            }
        }
    }
}
