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
    public partial class DeleteClient : Form
    {
        public DeleteClient()
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



        private void ClearAllTbox()
        {
            TboxFirstName.Text   = "";
            TboxLastName.Text    = "";
            TboxGender.Text      = "";
            TboxEmail.Text       = "";
            TboxPhone.Text       = "";
            TboxCity.Text        = "";
            TboxCountry.Text     = "";
            TboxDateOfBirth.Text = "";
            TboxCreateDate.Text  = "";
            TboxFindCleint.Text  = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageClients());
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(TboxFindCleint.Text, out int ID))
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            clsClient Client = clsClient.Find(ID);

            if (Client != null)
            {
                TboxFirstName.Text = Client.FirstName;
                TboxLastName.Text = Client.LastName;
                TboxGender.Text = Client.Gender.ToString();
                TboxEmail.Text = Client.Email.ToString();
                TboxPhone.Text = Client.Phone.ToString();
                TboxCity.Text = Client.City.ToString();
                TboxCountry.Text = Client.Country.ToString();
                TboxDateOfBirth.Text = Client.DateOfBirth.ToString();
                TboxCreateDate.Text = Client.CreateDate.ToString();

                if (!string.IsNullOrEmpty(Client.Image) && File.Exists(Client.Image))
                {
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
                    // لو مفيش صورة، استخدم صورة افتراضية
                }

            }
            else
            {
                MessageBox.Show("This user does not exist", "Oops Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(TboxFindCleint.Text, out int ID))
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            if (MessageBox.Show($"Are you sure you want to proceed with deleting the client? {ID} ?", "Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsClient.DeleteClienID(ID))
                {
                    MessageBox.Show("The client has been successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picImgeClient.Image = null;
                    ClearAllTbox();
                }
                else
                {
                    MessageBox.Show("The client deletion process has failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The client deletion process has been canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            
        }
    }
}
