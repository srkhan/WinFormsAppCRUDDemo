using System.Data;
using WinFormsAppCRUDDemo.Repositories;

namespace WinFormsAppCRUDDemo
{
    // Represents the main form of the application, which handles the user interface for managing clients.
    public partial class Form1 : Form
    {
        // Constructor for the Form1 class.
        public Form1()
        {
            InitializeComponent(); // Initializes the form's components (UI elements).

            ReadClients(); // Loads and displays the list of clients when the form is opened.
        }

        // Reads the list of clients from the database and displays them in a DataGridView.
        private void ReadClients()
        {
            DataTable dataTable = new DataTable(); // Creates an in-memory table to hold client data.

            // Adds columns to the DataTable to match the client properties.
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Date");

            var repo = new ClientRepository(); // Creates an instance of the repository to interact with the database.
            var clients = repo.GetClients(); // Retrieves the list of clients from the database.

            // Loops through each client and adds their data to the DataTable.
            foreach (var client in clients)
            {
                var row = dataTable.NewRow(); // Creates a new row in the DataTable.
                row["ID"] = client.id; // Sets the ID column.
                row["Name"] = client.firstName + " " + client.lastName; // Combines first and last name for the Name column.
                row["Email"] = client.email; // Sets the Email column.
                row["Phone"] = client.phone; // Sets the Phone column.
                row["Date"] = client.createdAt; // Sets the Date column.

                dataTable.Rows.Add(row); // Adds the row to the DataTable.
            }

            this.clientsTable.DataSource = dataTable; // Binds the DataTable to the DataGridView to display the data.
        }

        // Handles the "Add Client" button click event.
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm(); // Opens the CreateEditForm for adding a new client.
            var result = form.ShowDialog(); // Displays the form as a modal dialog.

            if (result == DialogResult.OK) // Checks if the user clicked "Save" in the form.
            {
                ReadClients(); // Refreshes the client list to include the newly added client.
            }
        }

        // Handles the "Edit Client" button click event.
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            // Gets the ID of the selected client from the DataGridView.
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return; // Exits if no client is selected.

            int clientId = int.Parse(val); // Converts the ID to an integer.

            var repo = new ClientRepository(); // Creates an instance of the repository.
            var client = repo.GetClient(clientId); // Retrieves the selected client from the database.

            if (client == null) return; // Exits if the client is not found.

            CreateEditForm form = new CreateEditForm(); // Opens the CreateEditForm for editing the client.
            form.EditClient(client); // Passes the client data to the form for editing.
            var result = form.ShowDialog(); // Displays the form as a modal dialog.

            if (result == DialogResult.OK) // Checks if the user clicked "Save" in the form.
            {
                ReadClients(); // Refreshes the client list to reflect the changes.
            }
        }

        // Handles the "Delete Client" button click event.
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            // Gets the ID of the selected client from the DataGridView.
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return; // Exits if no client is selected.

            int clientId = int.Parse(val); // Converts the ID to an integer.

            // Displays a confirmation dialog before deleting the client.
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) // Exits if the user clicks "No".
            {
                return;
            }

            var repo = new ClientRepository(); // Creates an instance of the repository.
            repo.DeleteClient(clientId); // Deletes the client from the database.

            ReadClients(); // Refreshes the client list to remove the deleted client.
        }
    }
}
