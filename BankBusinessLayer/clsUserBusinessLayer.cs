using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsUserBusinessLayer
    {

        public string UserName { get; set; }
        public string Password { get; set; }


        public clsUserBusinessLayer()
        {
            this.UserName = "";
            this.Password = "";
            
        }

        private clsUserBusinessLayer(string userName, string password)
        {
            this.UserName=userName;
            this.Password=password;
        }


        public static clsUserBusinessLayer FindUserByUserNameAndPassword( string UserName , string Password)
        {
            
            if (clsUsers.FindUserByUserNameAndPassword(ref UserName , ref Password))
            {
                return new clsUserBusinessLayer(UserName , Password);
            }
            else
            {
                return null;
            }

        }




    }
}
