namespace WinFormsAppCRUDDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddClient = new Button();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            clientsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(856, 27);
            label1.TabIndex = 0;
            label1.Text = "List of Clients";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(13, 52);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(75, 23);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditClient.Location = new Point(692, 52);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(72, 23);
            btnEditClient.TabIndex = 2;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteClient.Location = new Point(773, 52);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(72, 23);
            btnDeleteClient.TabIndex = 3;
            btnDeleteClient.Text = "Delete";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // clientsTable
            // 
            clientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsTable.Location = new Point(13, 81);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.RowHeadersVisible = false;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(856, 357);
            clientsTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(clientsTable);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Clients Manager";
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddClient;
        private Button btnEditClient;
        private Button btnDeleteClient;
        private DataGridView clientsTable;
    }
}
