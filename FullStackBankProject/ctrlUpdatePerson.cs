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
    public partial class ctrlUpdateClient : UserControl
    {
        public ctrlUpdateClient()
        {
            InitializeComponent();
        }

        clsClient Client;

        public string selectedFilePath = "";
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

        private void picSearchClient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbxFindCleint.Text, out int ID))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             Client = clsClient.Find(ID);
            if (Client != null)
            {
                TboxFirstName.Text = Client.FirstName ?? "";
                TboxLastName.Text = Client.LastName ?? "";
                TboxGender.Text = Client.Gender.ToString();
                TboxEmail.Text = Client.Email ?? "";
                TboxPhone.Text = Client.Phone ?? "";
                TboxCity.Text = Client.City ?? "";
                TboxCountry.Text = Client.Country ?? "";
                BtnDateOfBirth.Text = Client.DateOfBirth.ToString();
                TboxCreateDate.Text = Client.CreateDate.ToString();

                if (!string.IsNullOrEmpty(Client.Image) && File.Exists(Client.Image))
                {
                    picDeleteimageClient.Visible = true;
                    try
                    {
                        using (FileStream fs = new FileStream(Client.Image, FileMode.Open, FileAccess.Read))
                        {
                            picImgeClient.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ في تحميل الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    picDeleteimageClient.Visible = false;
                }



            }
            else
            {
                MessageBox.Show("This user does not exist", "Oops Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void picAddImgeClient_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // string selectedFilePath = openFileDialog1.FileName;
                selectedFilePath = openFileDialog1.FileName;
                Client.Image = selectedFilePath;

                try
                {
                    using (FileStream fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                    {
                        picImgeClient.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            


        }

        private void picDeleteimageClient_Click(object sender, EventArgs e)
        {
            if (picImgeClient.Image == null)
            {
                MessageBox.Show("You do not have a photo to delete. Please upload a photo" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
            }
            picImgeClient.Image = null;
            Client.Image = "";
        }


        private void BtnclientUpdatetingSave_Click(object sender, EventArgs e)
        {

            if (Client != null)
            {
                Client.FirstName = TboxFirstName.Text ?? "";
                Client.LastName = TboxLastName.Text ?? "";
                Client.Gender = TboxGender.Text ?? "";
                Client.Email = TboxEmail.Text ?? "";
                Client.Phone = TboxPhone.Text ?? "";
                Client.City = TboxCity.Text ?? "";
                Client.Country = TboxCountry.Text ?? "";
                Client.DateOfBirth = DateTime.TryParse(BtnDateOfBirth.Text, out DateTime dob) ? dob : DateTime.MinValue;
                Client.CreateDate = DateTime.TryParse(TboxCreateDate.Text, out DateTime createDate) ? createDate : DateTime.Now;
                Client.Image = selectedFilePath;

                if (Client.Save())
                {
                    MessageBox.Show("Client updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Client update failed.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageClients());
        }




    }
}
