using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTrak.Models;

namespace AppTrak.Ui
{
    public partial class ContactForm : Form
    {
        public ContactForm Access;
        public ContactForm()
        {
            InitializeComponent();
            Access = this;
            dgv_Contacts.DataSource = MainForm.Access.CurrentOpportunity?.Contacts;
            Point drawningPoint = new Point(MainForm.Access.Location.X - 7, MainForm.Access.Location.Y + MainForm.Access.Height);
            Location = drawningPoint;
            Size drawSizesize = new Size(MainForm.Access.Width + 15, this.Height);
            Size = drawSizesize;
        }
        #region Contacts

        private void btn_SaveContact_Click(object sender, EventArgs e)
        {
            if (btn_SaveContact.Text == @"Edit")
            {
                btn_SaveContact.Text = @"Save";
                btn_NewContact.Enabled = false;
                MainForm.Access.DeleteOpportunityButton(false);
                EnableContacts(true);
                return;
            }
            //todo: Make this a bit more graceful of an exit 
            if (string.IsNullOrEmpty(txtbx_ContactName.Text))
                return;
            if (string.IsNullOrEmpty(txtbx_ContactPosition.Text))
                return;
            var newOp = new Contact
            {
                ContactName = txtbx_ContactName.Text,
                ContactPosition = txtbx_ContactPosition.Text,
                ContactPhone = txtbx_ContactPhoneNumber.Text,
                ContactEmail = txtbx_ContactEmail.Text
            };
            var selectedContact =
                Program.Opportunities.FirstOrDefault(x => x.Equals(MainForm.Access.CurrentOpportunity))?
                    .Contacts.FirstOrDefault(x => x.Equals(MainForm.Access.CurrentContact));
            if (selectedContact != null)
            {
                selectedContact.ContactName = txtbx_ContactName.Text;
                selectedContact.ContactPosition = txtbx_ContactPosition.Text;
                selectedContact.ContactPhone = txtbx_ContactPhoneNumber.Text;
                selectedContact.ContactEmail = txtbx_ContactEmail.Text;
            }
            else
            {
                MainForm.Access.CurrentOpportunity.Contacts.Add(newOp);
            }
            dgv_Contacts.DataSource = null;
            dgv_Contacts.DataSource = MainForm.Access.CurrentOpportunity.Contacts;
            ClearContact();
            EnableContacts(false);
            MainForm.Access.AddResumeButton(false);
            btn_NewContact.Enabled = true;
            btn_SaveContact.Enabled = false;
            MainForm.Access.DeleteOpportunityButton(true);
            Program.Opportunities.Save();
        }

        private void btn_DeleteContact_Click(object sender, EventArgs e)
        {
            var item =
                Program.Opportunities.FirstOrDefault(x => x.Contacts.FirstOrDefault(y => y == MainForm.Access.CurrentContact) != null);
            item?.Contacts.Remove(MainForm.Access.CurrentContact);
            MainForm.Access.CurrentOpportunity?.Contacts.Remove(MainForm.Access.CurrentContact);
            dgv_Contacts.DataSource = null;
            dgv_Contacts.DataSource = MainForm.Access.CurrentOpportunity?.Contacts;
            ClearContact();
            Program.Opportunities.Save();
            dgv_Contacts.ClearSelection();
        }

        private void btn_NewContact_Click(object sender, EventArgs e)
        {
            MainForm.Access.CurrentContact = new Contact
            {
                ContactName = "",
                ContactPosition = "",
                ContactPhone = "",
                ContactEmail = ""
            };
            btn_SaveContact.Text = @"Save";
            btn_SaveContact.Enabled = true;
            btn_DeleteContact.Enabled = false;
            ClearContact();
            EnableContacts(true);
            dgv_Contacts.ClearSelection();
        }

        private void dgv_Contacts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_SaveContact.Text = @"Edit";
            btn_SaveContact.Enabled = true;
            btn_DeleteContact.Enabled = true;
            var selectedRow = dgv_Contacts.SelectedRows[0];
            txtbx_ContactName.Text = selectedRow.Cells[0].Value.ToString();
            txtbx_ContactPosition.Text = selectedRow.Cells[1].Value.ToString();
            txtbx_ContactPhoneNumber.Text = selectedRow.Cells[2].Value.ToString();
            txtbx_ContactEmail.Text = selectedRow.Cells[3].Value.ToString();
            MainForm.Access.CurrentContact = new Contact
            {
                ContactName = txtbx_ContactName.Text,
                ContactPosition = txtbx_ContactPosition.Text,
                ContactPhone = txtbx_ContactPhoneNumber.Text,
                ContactEmail = txtbx_ContactEmail.Text
            };
        }

        #endregion Contacts

        public void EnableContacts(bool fieldsEnabled)
        {
            txtbx_ContactName.ReadOnly = !fieldsEnabled;
            txtbx_ContactPosition.ReadOnly = !fieldsEnabled;
            txtbx_ContactPhoneNumber.ReadOnly = !fieldsEnabled;
            txtbx_ContactEmail.ReadOnly = !fieldsEnabled;

            txtbx_ContactName.Enabled = fieldsEnabled;
            txtbx_ContactPosition.Enabled = fieldsEnabled;
            txtbx_ContactPhoneNumber.Enabled = fieldsEnabled;
            txtbx_ContactEmail.Enabled = fieldsEnabled;
        }

        public void ClearContact()
        {
            txtbx_ContactName.Text = "";
            txtbx_ContactPosition.Text = "";
            txtbx_ContactPhoneNumber.Text = "";
            txtbx_ContactEmail.Text = "";
        }
    }
}
