using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BankDataAccessLayer
{
    public class ClientDataAccess
    {



        public static DataTable GetAllClients()
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @"SELECT * FROM Clients ";



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





        public static bool FindClientByID(int ID, ref string FirstName, ref string LastName, ref string Gender, ref string Email, ref string Phone, ref string City, ref string Country, ref DateTime DateOfBirth, ref DateTime CreateDate , ref string Image)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "SELECT FirstName, LastName, Gender, Email , Phone , City , Country , DateOfBirth, CreateDate , Image FROM Clients WHERE ClientID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                FirstName = reader["FirstName"]?.ToString() ?? "";
                                LastName = reader["LastName"]?.ToString() ?? "";
                                Gender = reader["Gender"]?.ToString() ?? "";
                                Email = reader["Email"]?.ToString() ?? "Error";
                                Phone = reader["Phone"]?.ToString() ?? "";
                                City = reader["City"]?.ToString() ?? "";
                                Country = reader["Country"]?.ToString() ?? "";
                                DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["DateOfBirth"]) : DateTime.MinValue;
                                CreateDate = reader["CreateDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreateDate"]) : DateTime.MinValue;

                                Image = reader["Image"] != DBNull.Value ? reader["Image"].ToString() : "";


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


        public static int AddNewClient(string FirstName, string LastName, string Gender, string Email, string Phone, string City, string Country, DateTime DateOfBirth, DateTime CreateDate, string Image)
        {
            int ClinetID = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @" INSERT INTO Clients (FirstName , LastName , Gender , Email , Phone ,City , Country , DateOfBirth , CreateDate , Image)
                  VALUES (@FirstName , @LastName , @Gender , @Email , @Phone , @City , @Country, @DateOfBirth, @CreateDate, @Image)
                  SELECT SCOPE_IDENTITY();
                 ";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CreateDate", CreateDate);
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
                            ClinetID = insertedID;
                        }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return ClinetID;
        }



        public static bool UpdateClient(int ID, string FirstName, string LastName, string Gender, string Email, string Phone, string City, string Country, DateTime DateOfBirth, DateTime CreateDate, string Image)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @"
                                    UPDATE Clients 
                                    SET FirstName = @FirstName, 
                                        LastName = @LastName, 
                                        Gender = @Gender, 
                                        Email = @Email, 
                                        Phone = @Phone, 
                                        City = @City, 
                                        Country = @Country, 
                                        DateOfBirth = @DateOfBirth, 
                                        CreateDate = @CreateDate, 
                                        Image = @Image
                                    WHERE ClientID = @ID";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CreateDate", CreateDate);
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





        public static bool DeleteClient( int ClientID)
        {
            int rowsAffeted = 0;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = @" delete Clients where ClientID = @ClientID ";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);



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

            return (rowsAffeted > 0) ;
        }







    }
}
