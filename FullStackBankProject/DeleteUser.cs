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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());
        }

        private void BtnSerach_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(TboxSearchUserID.Text);


            clsUserBusinessLayer User = clsUserBusinessLayer.FindUserByID(UserID);


            if (User == null)
            {
                MessageBox.Show("Error in the user search process. Please enter the data correctly and provide details of an existing user." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show($"Are you sure you want to delete the User {UserID} ?", "Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (clsUserBusinessLayer.DeleteUser(UserID))
                    {
                        MessageBox.Show($"User Deleted Successfully with ID = {UserID} ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Deletion error: Operation failed. Enter a valid ID to complete the deletion process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("The User deletion process has been canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }




        }
    }
}
