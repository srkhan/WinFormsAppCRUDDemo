using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsAppCRUDDemo.Models;

namespace WinFormsAppCRUDDemo.Repositories
{
    // Handles database operations for the Client entity.
    public class ClientRepository
    {
        // Connection string to connect to the SQL Server database.
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=winformdb;Integrated Security=True;Trust Server Certificate=True";

        // Retrieves all clients from the database.
        public List<Client> GetClients()
        {
            var clients = new List<Client>(); // List to store retrieved clients.

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Opens the database connection.

                    string sql = "SELECT * FROM clients ORDER BY id DESC"; // SQL query to fetch all clients.
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) // Reads each row from the result set.
                            {
                                // Maps the database row to a Client object.
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.GetString(1);
                                client.lastName = reader.GetString(2);
                                client.email = reader.GetString(3);
                                client.phone = reader.GetString(4);
                                client.address = reader.GetString(5);
                                client.createdAt = reader.GetDateTime(6).ToString();

                                clients.Add(client); // Adds the client to the list.
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Logs any exceptions that occur during the database operation.
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return clients; // Returns the list of clients.
        }

        // Retrieves a single client by ID.
        public Client? GetClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Opens the database connection.
                    string sql = "SELECT * FROM clients WHERE id = @id"; // SQL query to fetch a client by ID.
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id); // Adds the ID parameter to the query.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Reads the result if a client is found.
                            {
                                // Maps the database row to a Client object.
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.GetString(1);
                                client.lastName = reader.GetString(2);
                                client.email = reader.GetString(3);
                                client.phone = reader.GetString(4);
                                client.address = reader.GetString(5);
                                client.createdAt = reader.GetDateTime(6).ToString();

                                return client; // Returns the client.
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Logs any exceptions that occur during the database operation.
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return null; // Returns null if no client is found.
        }

        // Adds a new client to the database.
        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Opens the database connection.
                    string sql = "INSERT INTO clients (firstName, lastName, email, phone, address) VALUES (@firstName, @lastName, @email, @phone, @address)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Adds parameters to the query.
                        command.Parameters.AddWithValue("@firstName", client.firstName);
                        command.Parameters.AddWithValue("@lastName", client.lastName);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);

                        command.ExecuteNonQuery(); // Executes the query.
                    }
                }
            }
            catch (Exception ex)
            {
                // Logs any exceptions that occur during the database operation.
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        // Updates an existing client in the database.
        public void UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Opens the database connection.
                    string sql = "UPDATE clients SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, address = @address WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Adds parameters to the query.
                        command.Parameters.AddWithValue("@id", client.id);
                        command.Parameters.AddWithValue("@firstName", client.firstName);
                        command.Parameters.AddWithValue("@lastName", client.lastName);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);

                        command.ExecuteNonQuery(); // Executes the query.
                    }
                }
            }
            catch (Exception ex)
            {
                // Logs any exceptions that occur during the database operation.
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        // Deletes a client from the database by ID.
        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Opens the database connection.
                    string sql = "DELETE FROM clients WHERE id = @id"; // SQL query to delete a client by ID.
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id); // Adds the ID parameter to the query.

                        command.ExecuteNonQuery(); // Executes the query.
                    }
                }
            }
            catch (Exception ex)
            {
                // Logs any exceptions that occur during the database operation.
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
