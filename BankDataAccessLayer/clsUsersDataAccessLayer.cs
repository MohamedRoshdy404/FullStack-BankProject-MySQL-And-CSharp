using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BankDataAccessLayer
{
    public class clsUsersDataAccessLayer
    {





        public static DataTable GetAllUsers()
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @"SELECT * FROM Users ";



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





        public static bool FindUserByUserNameAndPassword(string UserName, string Password, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref DateTime CreateDate, ref int Permissions, ref string Image)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "select UserName, Password , FirstName , LastName , Email , Phone , CreateDate , Permissions , Image from Users WHERE Username = @UserName and Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);


                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserName = reader["UserName"]?.ToString() ?? "";
                                Password = reader["Password"]?.ToString() ?? "";
                                FirstName = reader["FirstName"]?.ToString() ?? "";
                                LastName = reader["LastName"]?.ToString() ?? "";
                                Email = reader["Email"]?.ToString() ?? "";
                                Phone = reader["Phone"]?.ToString() ?? "";
                                CreateDate = reader["CreateDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreateDate"]) : DateTime.MinValue;
                                Permissions = (int)reader["Permissions"];
                                if (reader["Image"] != DBNull.Value && !string.IsNullOrEmpty(reader["Image"].ToString()))
                                {
                                    Image = reader["Image"].ToString();
                                }
                                else
                                {
                                    Image = "";
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return isFound;
        }


       


        public static bool FindUserByID(int UserID, ref string UserName, ref string Password, ref string FirstName, ref string LastName, ref string Email, ref string Phone , ref DateTime CreateDate , ref int Permissions , ref string Image)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "select UserName, Password , FirstName , LastName , Email , Phone , CreateDate , Permissions , Image from Users WHERE UserID = @UserID ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserName = reader["UserName"]?.ToString() ?? "";
                                Password = reader["Password"]?.ToString() ?? "";
                                FirstName = reader["FirstName"]?.ToString() ?? "";
                                LastName = reader["LastName"]?.ToString() ?? "";
                                Email = reader["Email"]?.ToString() ?? "";
                                Phone = reader["Phone"]?.ToString() ?? "";
                                CreateDate =reader["CreateDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreateDate"]) : DateTime.MinValue;
                                Permissions = (int) reader["Permissions"];
                                if (reader["Image"] != DBNull.Value && !string.IsNullOrEmpty(reader["Image"].ToString()))
                                {
                                    Image = reader["Image"].ToString();
                                }
                                else
                                {
                                    Image = "";
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return isFound;
        }








        public static int AddNewUser(string UserName, string Password, string FirstName, string LastName, string Email, string Phone, DateTime CreateDate, int Permissions, string Image)
        {
            int UserID = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "INSERT INTO Users (Username , Password , FirstName , LastName , Email , Phone , CreateDate , Permissions , Image )VALUES (@Username , @Password , @FirstName , @LastName , @Email , @Phone , @CreateDate , @Permissions , @Image); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@CreateDate", CreateDate);
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    if (Image != null)

                        command.Parameters.AddWithValue("@Image", Image);
                    else
                        command.Parameters.AddWithValue("@Image", System.DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return UserID;
        }



        public static bool UpdateUser(int UserID , string UserName, string Password, string FirstName, string LastName, string Email, string Phone, DateTime CreateDate, int Permissions, string Image)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {

                string query = "UPDATE Users SET Username = @Username, Password = @Password, FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, CreateDate = @CreateDate, Permissions = @Permissions, Image = @Image WHERE UserID = @UserID;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@CreateDate", CreateDate);
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    if (Image != null)

                        command.Parameters.AddWithValue("@Image", Image);
                    else
                        command.Parameters.AddWithValue("@Image", System.DBNull.Value);

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

            return (rowsAffected > 0);
        }





        public static bool DeleteUser(int UserID)
        {
            int rowsAffeted = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @" delete Users where UserID = @UserID ";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);



                    try
                    {
                        connection.Open();
                        rowsAffeted = command.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return (rowsAffeted > 0);
        }







    }
}
