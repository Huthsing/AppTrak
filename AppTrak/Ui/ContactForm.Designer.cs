namespace AppTrak.Ui
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.grpbx_ContactInformation = new System.Windows.Forms.GroupBox();
            this.btn_NewContact = new System.Windows.Forms.Button();
            this.btn_DeleteContact = new System.Windows.Forms.Button();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txtbx_ContactPhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_SaveContact = new System.Windows.Forms.Button();
            this.dgv_Contacts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_ContactPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_ContactName = new System.Windows.Forms.TextBox();
            this.txtbx_ContactEmail = new System.Windows.Forms.TextBox();
            this.grpbx_ContactInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contacts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbx_ContactInformation
            // 
            this.grpbx_ContactInformation.Controls.Add(this.btn_NewContact);
            this.grpbx_ContactInformation.Controls.Add(this.btn_DeleteContact);
            this.grpbx_ContactInformation.Controls.Add(this.lbl_Phone);
            this.grpbx_ContactInformation.Controls.Add(this.txtbx_ContactPhoneNumber);
            this.grpbx_ContactInformation.Controls.Add(this.btn_SaveContact);
            this.grpbx_ContactInformation.Controls.Add(this.dgv_Contacts);
            this.grpbx_ContactInformation.Controls.Add(this.label7);
            this.grpbx_ContactInformation.Controls.Add(this.txtbx_ContactPosition);
            this.grpbx_ContactInformation.Controls.Add(this.label6);
            this.grpbx_ContactInformation.Controls.Add(this.label5);
            this.grpbx_ContactInformation.Controls.Add(this.txtbx_ContactName);
            this.grpbx_ContactInformation.Controls.Add(this.txtbx_ContactEmail);
            this.grpbx_ContactInformation.Location = new System.Drawing.Point(3, 2);
            this.grpbx_ContactInformation.Name = "grpbx_ContactInformation";
            this.grpbx_ContactInformation.Size = new System.Drawing.Size(464, 367);
            this.grpbx_ContactInformation.TabIndex = 12;
            this.grpbx_ContactInformation.TabStop = false;
            this.grpbx_ContactInformation.Text = "Contact Information";
            // 
            // btn_NewContact
            // 
            this.btn_NewContact.Location = new System.Drawing.Point(69, 135);
            this.btn_NewContact.Name = "btn_NewContact";
            this.btn_NewContact.Size = new System.Drawing.Size(54, 35);
            this.btn_NewContact.TabIndex = 14;
            this.btn_NewContact.Text = "New";
            this.btn_NewContact.UseVisualStyleBackColor = true;
            this.btn_NewContact.Click += new System.EventHandler(this.btn_NewContact_Click);
            // 
            // btn_DeleteContact
            // 
            this.btn_DeleteContact.Enabled = false;
            this.btn_DeleteContact.ForeColor = System.Drawing.Color.Red;
            this.btn_DeleteContact.Location = new System.Drawing.Point(184, 135);
            this.btn_DeleteContact.Name = "btn_DeleteContact";
            this.btn_DeleteContact.Size = new System.Drawing.Size(54, 35);
            this.btn_DeleteContact.TabIndex = 13;
            this.btn_DeleteContact.Text = "Delete";
            this.btn_DeleteContact.UseVisualStyleBackColor = true;
            this.btn_DeleteContact.Click += new System.EventHandler(this.btn_DeleteContact_Click);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(14, 78);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_Phone.TabIndex = 12;
            this.lbl_Phone.Text = "Phone:";
            // 
            // txtbx_ContactPhoneNumber
            // 
            this.txtbx_ContactPhoneNumber.Enabled = false;
            this.txtbx_ContactPhoneNumber.Location = new System.Drawing.Point(69, 75);
            this.txtbx_ContactPhoneNumber.Name = "txtbx_ContactPhoneNumber";
            this.txtbx_ContactPhoneNumber.Size = new System.Drawing.Size(385, 20);
            this.txtbx_ContactPhoneNumber.TabIndex = 11;
            // 
            // btn_SaveContact
            // 
            this.btn_SaveContact.Enabled = false;
            this.btn_SaveContact.Location = new System.Drawing.Point(126, 135);
            this.btn_SaveContact.Name = "btn_SaveContact";
            this.btn_SaveContact.Size = new System.Drawing.Size(54, 35);
            this.btn_SaveContact.TabIndex = 10;
            this.btn_SaveContact.Text = "Save";
            this.btn_SaveContact.UseVisualStyleBackColor = true;
            this.btn_SaveContact.Click += new System.EventHandler(this.btn_SaveContact_Click);
            // 
            // dgv_Contacts
            // 
            this.dgv_Contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Contacts.Location = new System.Drawing.Point(3, 176);
            this.dgv_Contacts.MultiSelect = false;
            this.dgv_Contacts.Name = "dgv_Contacts";
            this.dgv_Contacts.ReadOnly = true;
            this.dgv_Contacts.RowHeadersVisible = false;
            this.dgv_Contacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Contacts.Size = new System.Drawing.Size(455, 185);
            this.dgv_Contacts.TabIndex = 9;
            this.dgv_Contacts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Contacts_CellMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Position:";
            // 
            // txtbx_ContactPosition
            // 
            this.txtbx_ContactPosition.Enabled = false;
            this.txtbx_ContactPosition.Location = new System.Drawing.Point(69, 45);
            this.txtbx_ContactPosition.Name = "txtbx_ContactPosition";
            this.txtbx_ContactPosition.Size = new System.Drawing.Size(385, 20);
            this.txtbx_ContactPosition.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name:";
            // 
            // txtbx_ContactName
            // 
            this.txtbx_ContactName.Enabled = false;
            this.txtbx_ContactName.Location = new System.Drawing.Point(69, 15);
            this.txtbx_ContactName.Name = "txtbx_ContactName";
            this.txtbx_ContactName.Size = new System.Drawing.Size(385, 20);
            this.txtbx_ContactName.TabIndex = 3;
            // 
            // txtbx_ContactEmail
            // 
            this.txtbx_ContactEmail.Enabled = false;
            this.txtbx_ContactEmail.Location = new System.Drawing.Point(69, 105);
            this.txtbx_ContactEmail.Name = "txtbx_ContactEmail";
            this.txtbx_ContactEmail.Size = new System.Drawing.Size(385, 20);
            this.txtbx_ContactEmail.TabIndex = 5;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 372);
            this.Controls.Add(this.grpbx_ContactInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AppTrak - Contact Form";
            this.TopMost = true;
            this.grpbx_ContactInformation.ResumeLayout(false);
            this.grpbx_ContactInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_ContactInformation;
        private System.Windows.Forms.Button btn_NewContact;
        private System.Windows.Forms.Button btn_DeleteContact;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txtbx_ContactPhoneNumber;
        private System.Windows.Forms.Button btn_SaveContact;
        private System.Windows.Forms.DataGridView dgv_Contacts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_ContactPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_ContactName;
        private System.Windows.Forms.TextBox txtbx_ContactEmail;
    }
}