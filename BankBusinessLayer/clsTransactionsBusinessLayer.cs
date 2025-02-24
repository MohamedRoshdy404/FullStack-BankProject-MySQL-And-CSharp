using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsTransactionsBusinessLayer 
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreateDate { get; set; }
        public string Image { get; set; }
        public int AccountBalance { get; set; }

        public clsTransactionsBusinessLayer()
        {
            this.ClientID = -1;
            this.AccountNumber = "";
            this.FirstName = "";
            this.Gender = "";
            this.Email = "";
            this.Phone = "";
            this.City = "";
            this.Country = "";
            this.DateOfBirth = DateTime.Now;
            this.CreateDate = DateTime.Now;
            this.Image = "";
            this.AccountBalance = 0;


            Mode = enMode.AddNew;

        }


        private clsTransactionsBusinessLayer(int ClientID, string FirstName, string LastName, string Gender, string Email, string Phone, string City, string Country, DateTime DateOfBirth, DateTime CreateDate, string Image)
        {
            this.ClientID = ClientID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.City = City;
            this.Country = Country;
            this.DateOfBirth = DateOfBirth;
            this.CreateDate = CreateDate;
            this.Image = Image;
            Mode = enMode.Update;
        }



        private clsTransactionsBusinessLayer(string AccountNumber, int ClientID , string FirstName, string LastName, string Email, string Phone, string City, string Country, string Image, int AccountBalance)
        {

            this.ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.City = City;
            this.Country = Country;
            this.Image = Image;
            this.AccountBalance = AccountBalance;
            Mode = enMode.Update;
        }



        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients();
        }


        public static clsTransactionsBusinessLayer GetAllInfoClient_Account(string AccountNumber)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", City = "", Country = "", Image = "";
            int AccountBalance = 0 , ClientID = -1;


            if (clsTransactionsDataAccessLayer.GetAllInfoClient_Account(AccountNumber,ref ClientID , ref FirstName, ref LastName,ref Email, ref Phone, ref City, ref Country, ref Image , ref AccountBalance))
            {
                return new clsTransactionsBusinessLayer(AccountNumber, ClientID, FirstName, LastName, Email, Phone, City, Country, Image , AccountBalance);
            }
            else
            {
                return null;
            }
;

        }

        public bool UpdateAccountBalance()
        {
            return clsTransactionsDataAccessLayer.UpdateAccountBalance( this.AccountNumber,this.AccountBalance);
        }

    }
}
