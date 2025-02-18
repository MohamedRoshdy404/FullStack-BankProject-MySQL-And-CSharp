using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsAccountBusinessLayer
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        private int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public int ClientID { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public decimal AccountBalance { get; set; }
        public string Password { get; set; }


        public clsAccountBusinessLayer()
        {
            AccountID = -1;
            AccountNumber = "";
            ClientID = -1;
            AccountCreationDate = DateTime.MinValue;
            AccountBalance = 0;
            Password = "";
            Mode = enMode.AddNew;

        }


        private clsAccountBusinessLayer(string AccountNumber,  int ClientID,  DateTime AccountCreationDate,  Decimal AccountBalance,  string Password)
        {
            this.AccountNumber = AccountNumber;
            this.ClientID = ClientID;
            this.AccountCreationDate = AccountCreationDate;
            this.AccountBalance = AccountBalance;
            this.Password = Password;
            Mode = enMode.Update;
        }


        private clsAccountBusinessLayer(string AccountNumber, int ClientID, Decimal AccountBalance, string Password)
        {
            this.AccountNumber = AccountNumber;
            this.ClientID = ClientID;
            this.AccountBalance = AccountBalance;
            this.Password = Password;
            Mode = enMode.Update;
        }





        public static DataTable GetAllAcoounts()
        {
            return clsAccountsDataAccessLayer.GetAllAcoounts();
        }


        public static clsAccountBusinessLayer FindAccountByAccountNumber(string AccountNumber)
        {
            int ClientID = -1;
            DateTime AccountCreationDate = DateTime.MinValue ;
            decimal AccountBalance = 0 ;
            string Password = "";


            if (clsAccountsDataAccessLayer.FindAccountByAccountNumber( AccountNumber , ref ClientID , ref  AccountCreationDate , ref AccountBalance , ref Password))
            {
                return new clsAccountBusinessLayer(AccountNumber , ClientID , AccountCreationDate , AccountBalance , Password);
            }
            else
            {
                return null;
            }



        }

                
        private bool _AddAccountNumber()
        {
            this.AccountID =  clsAccountsDataAccessLayer.AddAccountNumber(this.AccountNumber,this.ClientID, this.AccountCreationDate, this.AccountBalance, this.Password);
            return (this.AccountID != -1);

        }



        private bool _UpdateAccountNumber()
        { 
            return clsAccountsDataAccessLayer.UpdateAccountNumber(this.AccountNumber, this.ClientID,  this.AccountBalance, this.Password);
        }



        public static bool isExist(string AccountNumber)
        {
            return (clsAccountsDataAccessLayer.isExist(AccountNumber));
        }


                        
        public static bool DeleteAccount(string AccountNumber)
        {
            return (clsAccountsDataAccessLayer.DeleteAccount(AccountNumber));
        }





        public bool Save()
        {

            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddAccountNumber())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateAccountNumber();


                default:
                    return false;

            }


        }







    }

}
