using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsClient
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
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

        public  clsClient()
        {
            this.ID           = -1;
            this.FirstName    = "";
            this.FirstName    = "";
            this.Gender       = "";
            this.Email        = "";
            this.Phone        = "";
            this.City         = "";
            this.Country      = "";
            this.DateOfBirth  = DateTime.Now;
            this.CreateDate   = DateTime.Now;
            this.Image        = "";
          
    
            Mode = enMode.AddNew;

        }


        private clsClient(int ID, string FirstName, string LastName, string Gender, string Email, string Phone, string City, string Country, DateTime DateOfBirth, DateTime CreateDate , string Image)
        {
            this.ID = ID;
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



        public static DataTable GetAllClients()
        {  
            return ClientDataAccess.GetAllClients();
        }


        public static clsClient Find(int ID)
        {
            string FirstName = "", LastName = "", Gender = ""  , Email = "", Phone = "" , City = "" , Country = "" , Image = "";
           
            DateTime DateOfBirth = DateTime.Now , CreateDate = DateTime.Now;


            if (ClientDataAccess.FindClientByID( ID, ref  FirstName, ref  LastName, ref  Gender, ref  Email, ref  Phone, ref  City, ref  Country, ref  DateOfBirth, ref  CreateDate , ref Image))
            {
                return new clsClient(ID , FirstName, LastName, Gender, Email , Phone , City , Country , DateOfBirth , CreateDate , Image);
            }
            else
            {
                return null;
            }
;

        }

        private bool _AddNewClient()
        {

            this.ID = ClientDataAccess.AddNewClient(this.FirstName, this.LastName, this.Gender, this.Email, this.Phone, this.City, this.Country, this.DateOfBirth, this.CreateDate, this.Image);
            return (this.ID != -1);
        }



        private bool _UpdateClientByID()
        {
           return ClientDataAccess.UpdateClient(this.ID,this.FirstName, this.LastName, this.Gender, this.Email, this.Phone, this.City, this.Country, this.DateOfBirth, this.CreateDate ,this.Image);
            
        }
        
        public static bool DeleteClienID(int ClientID)
        {
            return ClientDataAccess.DeleteClient(ClientID);
            
        }



        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateClientByID();

                default:
                    return false;

            }



        }


    }
}
