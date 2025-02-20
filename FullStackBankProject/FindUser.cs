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



               

                MessageBox.Show("المسار المسترجع: " + User.Image);


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
                    //picImgeUser.Image = Properties.Resources.; // استبدلها بصورة افتراضية من Resources
                    MessageBox.Show("asfafafasf");
                }




            }
            else
            {
                MessageBox.Show("This user does not exist. Please enter an existing user number " , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }




        }
    }
}
