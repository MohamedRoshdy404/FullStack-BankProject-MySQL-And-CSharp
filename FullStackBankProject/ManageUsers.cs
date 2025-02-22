using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FullStackBankProject
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void BtnFindUser_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new FindUser());
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new AddNewUser());
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new UpdateUser());
        }

        private void BtnUserList_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new GetAllUsers());
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new DeleteUser());
        }
    }
}
