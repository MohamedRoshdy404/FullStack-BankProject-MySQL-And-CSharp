using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsTransactionsDataAccessLayer
    {

        public static bool GetAllInfoClient_Account(string AccountNumber, ref int ClientID , ref string FirstName, ref string LastName,  ref string Email, ref string Phone, ref string City, ref string Country,  ref string Image , ref int AccountBalance)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "select  Clients.ClientID, Clients.FirstName, Clients.LastName, Clients.Email, Clients.Phone, Clients.City, Clients.Country, Clients.Image , Accounts.AccountBalance FROM Clients INNER JOIN                      Accounts ON Accounts.ClientID = Clients.ClientID  where AccountNumber = @AccountNumber ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ClientID = Convert.ToInt32(reader["ClientID"]);
                                FirstName = reader["FirstName"]?.ToString() ?? "";
                                LastName = reader["LastName"]?.ToString() ?? "";
                                Email = reader["Email"]?.ToString() ?? "Error";
                                Phone = reader["Phone"]?.ToString() ?? "";
                                City = reader["City"]?.ToString() ?? "";
                                Country = reader["Country"]?.ToString() ?? "";
                                Image = reader["Image"] != DBNull.Value ? reader["Image"].ToString() : "";
                                AccountBalance = Convert.ToInt32(reader["AccountBalance"]);
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

    }
}
