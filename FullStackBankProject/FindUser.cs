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
    public partial class FindUser : Form
    {
        public FindUser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());
        }

        private void picSearchUser_Click(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(TboxFindUser.Text);

            clsUserBusinessLayer User = clsUserBusinessLayer.FindUserByID(UserID);

            if (User != null)
            {

                TboxUserName.Text = User.UserName;
                TboxPassword.Text = User.Password;
                TboxFirstName.Text = User.FirstName;
                TboxLastName.Text = User.LastName;
                TboxEmail.Text = User.Email;
                TboxPhone.Text = User.Phone;
                TboxCreateDate.Text = User.CreateDate.ToString();
                TboxPermissions.Text = User.Permissions.ToString();
            }
            else
            {
                MessageBox.Show("This user does not exist. Please enter an existing user number " , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }




        }
    }
}
