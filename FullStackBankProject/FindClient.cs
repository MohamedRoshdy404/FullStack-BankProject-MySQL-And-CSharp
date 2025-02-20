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
    public partial class FindClient : Form
    {
        public FindClient()
        {
            InitializeComponent();
            TboxFirstName.ReadOnly = true;
            TboxLastName.ReadOnly = true;
            TboxGender.ReadOnly = true;
            TboxDateOfBirth.ReadOnly = true;
            TboxCountry.ReadOnly =  true;
            TboxEmail.ReadOnly = true;
        }

        private void FindClient_Load(object sender, EventArgs e)
        {

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


        private void picSearchClient_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(TbxFindCleint.Text);

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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageClients());
        }
    }
}
