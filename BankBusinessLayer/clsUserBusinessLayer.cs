using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;
using System.Security.Policy;
using System.Data;

namespace BankBusinessLayer
{
    public class clsUserBusinessLayer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public int Permissions { get; set; }
        public string Image { get; set; }


        public clsUserBusinessLayer()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.CreateDate = DateTime.Now;
            this.Permissions = 0;
            this.Image = "";
            Mode = enMode.AddNew;
        }

        private clsUserBusinessLayer(int UserID , string UserName, string Password, string FirstName, string LastName, string Email, string Phone, DateTime CreateDate, int Permissions , string Image)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.CreateDate = CreateDate;
            this.Permissions = Permissions;
            this.Image = Image;
            Mode = enMode.Update;
        }


        // Users by username and password
        private clsUserBusinessLayer(string UserName, string Password, string FirstName, string LastName, string Email, string Phone, DateTime CreateDate, int Permissions, string Image)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.CreateDate = CreateDate;
            this.Permissions = Permissions;
            this.Image = Image;
            Mode = enMode.Update;
        }


        //private clsUserBusinessLayer( string UserName, string Password)
        //{
        //    this.UserName = UserName;
        //    this.Password = Password;
        //}




        public static DataTable GetAllUser()
        {
            return clsUsersDataAccessLayer.GetAllUsers();
        }

        public static clsUserBusinessLayer FindUserByID( int UserID )
        {

            string UserName = "", Password = "", FirstName = "", LastName = "", Email = "", Phone = "" , Image = "";
            DateTime CreateDate = DateTime.Now;
            int Permissions = 0;


            if (clsUsersDataAccessLayer.FindUserByID(UserID , ref  UserName, ref  Password, ref  FirstName, ref  LastName, ref  Email, ref  Phone, ref  CreateDate, ref  Permissions , ref Image))
            {
                return new clsUserBusinessLayer(UserID ,UserName , Password , FirstName , LastName , Email , Phone , CreateDate , Permissions , Image);
            }
            else
            {
                return null;
            }

        }        
        
        
        
        
        public static clsUserBusinessLayer FindUserByUserNameAndPassword( string UserName,  string Password)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", Image = "";
            DateTime CreateDate = DateTime.Now;
            int Permissions = 0;

            if (clsUsersDataAccessLayer.FindUserByUserNameAndPassword( UserName,  Password, ref  FirstName, ref  LastName, ref  Email, ref  Phone, ref  CreateDate, ref  Permissions, ref  Image))
            {
                return new clsUserBusinessLayer(UserName , Password , FirstName , LastName , Email , Phone , CreateDate , Permissions , Image);
            }
            else
            {
                return null;
            }

        }


                
        private bool _AddNewUser()
        {

            this.UserID = clsUsersDataAccessLayer.AddNewUser(this.UserName , this.Password, this.FirstName , this.LastName , this.Email , this.Phone , this.CreateDate , this.Permissions , this.Image);

            return (this.UserID != -1);

        }


        private bool _UpdateUser()
        {

            return clsUsersDataAccessLayer.UpdateUser( this.UserID, this.UserName, this.Password, this.FirstName, this.LastName, this.Email, this.Phone, this.CreateDate, this.Permissions, this.Image);
        }


                
        public static bool DeleteUser(int UserID)
        {
            return clsUsersDataAccessLayer.DeleteUser(UserID);
        }







        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                return _UpdateUser();

                default:
                    return false;
            }

        }













    }
}
