namespace WinFormsAppCRUDDemo
{
    partial class CreateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            label1 = new Label();
            lbId = new Label();
            label2 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbPhone = new TextBox();
            label5 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 22);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(432, 27);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Create Client";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 75);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Client ID";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(146, 75);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 15);
            lbId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 112);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(146, 104);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(229, 23);
            tbFirstName.TabIndex = 5;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(146, 150);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(229, 23);
            tbLastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 158);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(146, 196);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(229, 23);
            tbEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 204);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(146, 243);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(229, 23);
            tbPhone.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 251);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Phone";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(146, 295);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(229, 23);
            tbAddress.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 303);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 12;
            label6.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(149, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(tbPhone);
            Controls.Add(label5);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(lbId);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label lbId;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label3;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbPhone;
        private Label label5;
        private TextBox tbAddress;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
    }
}