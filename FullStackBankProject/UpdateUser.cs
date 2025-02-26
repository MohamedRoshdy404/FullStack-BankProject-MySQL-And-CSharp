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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());
        }
        clsUserBusinessLayer User;
        private string selectedFilePath = "";
        private void picSearchClient_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(TbxFindUser.Text);
             User = clsUserBusinessLayer.FindUserByID(UserID);

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


                chboxFullPermissions.Checked = (User.Permissions & Convert.ToInt32(chboxFullPermissions.Tag)) == Convert.ToInt32(chboxFullPermissions.Tag);
                chboxPmanageClient.Checked = (User.Permissions & Convert.ToInt32(chboxPmanageClient.Tag)) == Convert.ToInt32(chboxPmanageClient.Tag);
                chboxPmanageAccounts.Checked = (User.Permissions & Convert.ToInt32(chboxPmanageAccounts.Tag)) == Convert.ToInt32(chboxPmanageAccounts.Tag);
                chboxPmanageUser.Checked = (User.Permissions & Convert.ToInt32(chboxPmanageUser.Tag)) == Convert.ToInt32(chboxPmanageUser.Tag);
                chboxPmanageTransaction.Checked = (User.Permissions & Convert.ToInt32(chboxPmanageTransaction.Tag)) == Convert.ToInt32(chboxPmanageTransaction.Tag);
                chboxPmanageLoginRegister.Checked = (User.Permissions & Convert.ToInt32(chboxPmanageLoginRegister.Tag)) == Convert.ToInt32(chboxPmanageLoginRegister.Tag);





                if (!string.IsNullOrEmpty(User.Image) && File.Exists(User.Image))
                {
                    picDeleteimageUser.Visible = true;
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
                    picImgeUser.Image = null;
                    picDeleteimageUser.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("This User does not exist", "Oops Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        private void picAddImgeUser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // string selectedFilePath = openFileDialog1.FileName;
                selectedFilePath = openFileDialog1.FileName;
                User.Image = selectedFilePath;

                try
                {
                    using (FileStream fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                    {
                        picImgeUser.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {

             User.UserName =  TboxUserName.Text ;
             User.Password =  TboxPassword.Text ;
             User.FirstName =  TboxFirstName.Text;
             User.LastName = TboxLastName.Text ;
             User.Email =  TboxEmail.Text ;
             User.Phone =  TboxPhone.Text  ;
            //User.CreateDate =  DateTime.TryParse(TboxCreateDate.Text, out DateTime dob) ? dob : DateTime.MinValue;
            //User.Permissions =  Convert.ToInt32(TboxPermissions.Text);



            if (chboxFullPermissions.Checked)
            {
                User.Permissions = Convert.ToInt32(chboxFullPermissions.Tag);
            }


            if (chboxPmanageClient.Checked)
            {
                User.Permissions  += Convert.ToInt32(chboxPmanageClient.Tag);
            }

            if (chboxPmanageAccounts.Checked)
            {
                User.Permissions += Convert.ToInt32(chboxPmanageAccounts.Tag);
            }

            if (chboxPmanageUser.Checked)
            {
                User.Permissions += Convert.ToInt32(chboxPmanageUser.Tag);
            }

            if (chboxPmanageTransaction.Checked)
            {
                User.Permissions += Convert.ToInt32(chboxPmanageTransaction.Tag);
            }


            if (chboxPmanageLoginRegister.Checked)
            {
                User.Permissions += Convert.ToInt32(chboxPmanageLoginRegister.Tag);
            }

            if (chBoxClearP.Checked)
            {
                User.Permissions = Convert.ToInt32(chBoxClearP.Tag);
            }


            if (User.Save())
            {
                MessageBox.Show("User updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User update failed.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void picDeleteimageUser_Click(object sender, EventArgs e)
        {
            if (picImgeUser.Image == null)
            {
                MessageBox.Show("You do not have a photo to delete. Please upload a photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            picImgeUser.Image = null;
            User.Image = "";
        }

        private void chboxPmanageClient_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chboxPmanageAccounts_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
