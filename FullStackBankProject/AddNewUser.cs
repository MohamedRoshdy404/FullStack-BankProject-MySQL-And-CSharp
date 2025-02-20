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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());
        }

         clsUserBusinessLayer User = new clsUserBusinessLayer();
        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {

            User.UserName        = TboxUserName.Text;
            User.Password        = TboxPassword.Text;
            User.FirstName       = TboxFirstName.Text;
            User.LastName        = TboxLastName.Text;
            User.Email           = TboxEmail.Text;
            User.Phone           = TboxPhone.Text;
            User.CreateDate      = DateTime.Now;
            User.Permissions     = -1;

            if (User.Save())
            {

                MessageBox.Show($"User Added Successfully with ID = {User.UserID} ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TboxUserName.Text    = "";
                TboxPassword.Text    = "";
                TboxFirstName.Text   = "";
                TboxLastName.Text    = "";
                TboxEmail.Text       = "";
                TboxPhone.Text       = "";

            }
            else
            {
                MessageBox.Show($"The process of adding a new client has failed. Please repeat the process correctly again.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }









    }
}
