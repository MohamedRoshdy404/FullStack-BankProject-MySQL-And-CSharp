using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsLoginRegisterDataAccessLayer
    {





        public static DataTable GetAllLoginRegister()
        {


            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @"SELECT * FROM LoginRegisters ";



                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dataTable.Load(reader);
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return dataTable;
        }



        public static bool AddNewLoginRegister(DateTime DateLogin, int UserID, string UserName, string Passwored, int Permissions)
        {
            int  rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @" INSERT INTO LoginRegisters (DateLogin , UserID , UserName , Passwored , Permissions)
						VALUES (@DateLogin , @UserID , @UserName , @Passwored , @Permissions  )";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DateLogin", DateLogin);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Passwored", Passwored);
                    command.Parameters.AddWithValue("@Permissions", Permissions);



                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return (rowsAffected > 0) ;
        }





    }
}
