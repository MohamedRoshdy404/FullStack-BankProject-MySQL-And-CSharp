using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsAccountsDataAccessLayer
    {




        public static bool FindAccountByAccountNumber(string AccountNumber, ref int ClientID, ref DateTime AccountCreationDate, ref Decimal AccountBalance, ref string Password)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "SELECT ClientID, AccountCreationDate, AccountBalance , Password FROM Accounts WHERE AccountNumber = @AccountNumber";

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

                                ClientID = (int)reader["ClientID"];
                                AccountCreationDate = (DateTime)reader["AccountCreationDate"];
                                AccountBalance = (decimal)reader["AccountBalance"];
                                Password = (string)reader["Password"];
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






        public static bool isExist(string AccountNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "select isExist = 1  from Accounts where AccountNumber = @AccountNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
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






        public static int AddAccountNumber(string AccountNumber,  int ClientID,  DateTime AccountCreationDate,  Decimal AccountBalance,  string Password)
        {
            int rowsAffected  = -1;

            using (SqlConnection connection = new SqlConnection(clsSettingsConnectoinStrinng.connectionString))
            {
                string query = "INSERT INTO Accounts (AccountNumber , ClientID , AccountCreationDate , AccountBalance , Password) VALUES (@AccountNumber , @ClientID , @AccountCreationDate , @AccountBalance , @Password); SELECT SCOPE_IDENTITY(); ";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@AccountCreationDate", AccountCreationDate);
                    command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        {
                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            {
                                rowsAffected = insertedID;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return rowsAffected ;
        }









    }
}
