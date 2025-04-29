using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppCRUDDemo.Models;
using WinFormsAppCRUDDemo.Repositories;

namespace WinFormsAppCRUDDemo
{
    // Represents the form for creating or editing a client.
    public partial class CreateEditForm : Form
    {
        // Constructor for the CreateEditForm class.
        public CreateEditForm()
        {
            InitializeComponent(); // Initializes the form's components (UI elements).

            this.DialogResult = DialogResult.Cancel; // Sets the default dialog result to "Cancel".
        }

        private int clientId = 0; // Stores the ID of the client being edited (0 for new clients).

        // Populates the form fields with the data of the client being edited.
        public void EditClient(Client client)
        {
            this.Text = "Edit Client"; // Sets the form's title.
            this.lbTitle.Text = "Edit Client"; // Sets the label's text to indicate editing mode.

            // Fills the form fields with the client's data.
            this.lbId.Text = "" + client.id;
            this.tbFirstName.Text = client.firstName;
            this.tbLastName.Text = client.lastName;
            this.tbEmail.Text = client.email;
            this.tbPhone.Text = client.phone;
            this.tbAddress.Text = client.address;
            this.clientId = client.id; // Stores the client's ID for updating.
        }

        // Handles the "Save" button click event.
        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client(); // Creates a new Client object.
            client.id = this.clientId; // Sets the client's ID (0 for new clients).
            client.firstName = this.tbFirstName.Text; // Gets the first name from the text box.
            client.lastName = this.tbLastName.Text; // Gets the last name from the text box.
            client.email = this.tbEmail.Text; // Gets the email from the text box.
            client.phone = this.tbPhone.Text; // Gets the phone number from the text box.
            client.address = this.tbAddress.Text; // Gets the address from the text box.

            var repo = new ClientRepository(); // Creates an instance of the repository.
            if (this.clientId == 0) // Checks if this is a new client.
            {
                repo.CreateClient(client); // Adds the new client to the database.
            }
            else
            {
                repo.UpdateClient(client); // Updates the existing client in the database.
            }

            this.DialogResult = DialogResult.OK; // Sets the dialog result to "OK" to indicate success.
        }

        // Handles the "Cancel" button click event.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Sets the dialog result to "Cancel" to close the form without saving.
        }
    }
}
