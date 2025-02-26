using BankBusinessLayer;
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

        private void ClearAllTbox()
        {
            TboxUserName.Text = "";
            TboxPassword.Text = "";
            TboxFirstName.Text = "";
            TboxLastName.Text = "";
            TboxEmail.Text = "";
            TboxPhone.Text = "";
            TboxCreateDate.Text =  "";
            TboxPermissions.Text ="";
            TboxSearchUserID.Text = "";
        }
        private void BtnSerach_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(TboxSearchUserID.Text);

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


                if (!string.IsNullOrEmpty(User.Image) && File.Exists(User.Image))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(User.Image, FileMode.Open, FileAccess.Read))
                        {
                            picImgeUser.Image = Image.FromStream(fs);
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




            }
            else
            {
                MessageBox.Show("This user does not exist. Please enter an existing user number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(TboxSearchUserID.Text);

            if (MessageBox.Show($"Are you sure you want to delete the User {UserID} ?", "Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsUserBusinessLayer.DeleteUser(UserID))
                {
                    MessageBox.Show($"User Deleted Successfully with ID = {UserID} ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picImgeUser.Image = null;
                    ClearAllTbox();
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

        private void TboxSearchUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
