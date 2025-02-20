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
    public partial class ctrlAddNewClient : UserControl
    {
        public ctrlAddNewClient()
        {
            InitializeComponent();
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

            clsClient Client = new clsClient();
        private void BtnAddNewClient_Click(object sender, EventArgs e)
        {

            Client.FirstName     = TboxFirstName.Text;
            Client.LastName      = TboxLastName.Text;
            Client.Gender        = TboxGender.Text;
            Client.Email         = TboxEmail.Text;
            Client.Phone         = TboxPhone.Text;
            Client.City          = TboxCity.Text;
            Client.Country       = TboxCountry.Text;
            Client.DateOfBirth   = Convert.ToDateTime(BtnDateOfBirth.Text);
            Client.CreateDate    = Convert.ToDateTime(DateTime.Now);


            if (Client.Save())
            {

                MessageBox.Show($"Client Added Successfully with ID = {Client.ID} ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TboxFirstName.Text     = "";
                TboxLastName.Text      = "";
                TboxGender.Text        = "";
                TboxEmail.Text         = "";
                TboxPhone.Text         = "";
                TboxCity.Text          = "";
                TboxCountry.Text       = "";
                BtnDateOfBirth.Text    = "";
                picImgeClient.Image = null;

            }
            else
            {
                MessageBox.Show($"Feild", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageClients());
        }

        private void picAddImgeClient_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            Client = new clsClient();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                // Process the selected file
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                Client.Image = selectedFilePath;
                picImgeClient.Load(selectedFilePath);
                // ...
            }

        }

        private void picDeleteimageClient_Click(object sender, EventArgs e)
        {
            picImgeClient.Image = null;
            Client.Image = "";
        }
    }
}
