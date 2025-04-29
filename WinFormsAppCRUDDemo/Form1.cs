using System.Data;
using WinFormsAppCRUDDemo.Repositories;

namespace WinFormsAppCRUDDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadClients();
        }

        private void ReadClients()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Date");

            var repo = new ClientRepository();
            var clients = repo.GetClients();
            foreach (var client in clients)
            {
                var row = dataTable.NewRow();
                row["ID"] = client.id;
                row["Name"] = client.firstName + " " + client.lastName;
                row["Email"] = client.email;
                row["Phone"] = client.phone;
                row["Date"] = client.createdAt;

                dataTable.Rows.Add(row);
            }

            this.clientsTable.DataSource = dataTable;


        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                // update the list of clients
                ReadClients();
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);

            var repo = new ClientRepository();
            var client = repo.GetClient(clientId);

            if (client == null) return;

            CreateEditForm form = new CreateEditForm();
            form.EditClient(client);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                // update the list of clients
                ReadClients();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);

            // show confirmation dialog
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new ClientRepository();
            repo.DeleteClient(clientId);

            // update the list of clients
            ReadClients();
        }
    }
}
