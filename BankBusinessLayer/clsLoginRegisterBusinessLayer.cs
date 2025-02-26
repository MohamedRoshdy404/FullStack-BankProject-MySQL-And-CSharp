using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsLoginRegisterBusinessLayer 
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public DateTime DateLogin { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }



        public clsLoginRegisterBusinessLayer()
        {
            this.DateLogin = DateTime.Now;
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permissions = 0;
        }

        

        private clsLoginRegisterBusinessLayer(DateTime DateLogin, int UserID, string UserName, string Passwored, int Permissions)
        {
            this.DateLogin=DateLogin;
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Passwored;
            this.Permissions = Permissions;
        }



        public static DataTable GetAllLoginRegister()
        {
            return clsLoginRegisterDataAccessLayer.GetAllLoginRegister();
        }


        public bool AddNewLoginRegister()
        {
            return clsLoginRegisterDataAccessLayer.AddNewLoginRegister(this.DateLogin , this.UserID ,this.UserName ,this.Password , this.Permissions);
        }



        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewLoginRegister())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default: return false;
            }

        }





    }

}
