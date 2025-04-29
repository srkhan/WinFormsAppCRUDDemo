using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCRUDDemo.Models
{
    // This is a sample demo project created to demonstrate how to use WinForms with a SQL Server database.
    // This namespace contains the Client class, which represents a client entity in the application.
    // Represents a client entity with properties that map to the database table columns.
    public class Client
    {
        // Unique identifier for the client.
        public int id;

        // The first name of the client.
        public string firstName = "";

        // The last name of the client.
        public string lastName = "";

        // The email address of the client.
        public string email = "";

        // The phone number of the client.
        public string phone = "";

        // The address of the client.
        public string address = "";

        // The date and time when the client was created.
        public string createdAt = "";
    }

}
