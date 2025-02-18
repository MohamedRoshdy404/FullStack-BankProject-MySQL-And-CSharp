using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullStackBankProject
{
    public partial class UpdateAccountNumber : Form
    {
        public UpdateAccountNumber()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }
        //clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(TboxAccountNumber.Text);

        public void ClearAllTboxAccNumber()
        {
            TboxAccountNumber.Text = "";
            TboxClientID.Text = "";
            TboxAccountBalance.Text = "";
            TboxPasswordAccountNumber.Text = "";

        }

        private void BtnUpdateAccountNumber_Click(object sender, EventArgs e)
        {
            /*
                TboxAccountNumber.Text لسة محتاج اهندل ال 
                عشان دا المفروض معرف فريد بمسك منو الاكونت
                لكن في نفس الوقت عشان لو عايز بعدين احدث ال  AccountNumber
                محتاج اعمل فنكشن بترجع ال 
                AccountID
                AccountNumber مش ال 
                لان لو حبيت اغير ونا لسة علي الوضع دا لما اجي اخزن قيمة ال
                Account.AccountNumber =  TboxAccountNumber.Text
                Account.AccountNumber هيروح يبعت البيانات لحد ما يوصل للداتابيز للكويري يبحث عن ال
                اللي مبعوت في الاوبجيت الحالي هيدور عليه في الداتابيز مش هيلاقيه عشان انا غيرت القديم بالجديد لما علمت كدة
                Account.AccountNumber =  TboxAccountNumber.Text
             */
            clsAccountBusinessLayer Account =  clsAccountBusinessLayer.FindAccountByAccountNumber(TboxAccountNumber.Text);

           
            Account.Password = TboxPasswordAccountNumber.Text;
            Account.AccountBalance = Convert.ToDecimal(TboxAccountBalance.Text);
            Account.ClientID = Convert.ToInt32(TboxClientID.Text);

            if ((clsAccountBusinessLayer.isExist(TboxAccountNumber.Text)))
            {

                MessageBox.Show("Dooooooooone");

                if (Account.Save())
                {
                    MessageBox.Show("Account updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account update failed.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("The addition process has failed. Make sure that the account number already exists and that the client number associated with this account also exists.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            





        }

        public void BtnSerach_Click(object sender, EventArgs e)
        {
            clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(TboxAccountNumber.Text);

            if (Account != null)
            {
                TboxPasswordAccountNumber.Text = Account.Password;
                TboxAccountBalance.Text = Account.AccountBalance.ToString();
                TboxClientID.Text = Account.ClientID.ToString();
                BtnSerach.Visible = false;
            }
            else
            {
                MessageBox.Show("The account does not exist. Please enter an existing account number.", "Error The account data retrieval process failed" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }




        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllTboxAccNumber();
            BtnSerach.Visible = true;
        }
    }
}
