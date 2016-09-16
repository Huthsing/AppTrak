using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AppTrak.Helpers;
using AppTrak.Models;
using AppTrak.Properties;

namespace AppTrak.Ui
{
    public partial class MainForm : Form
    {
        public Opportunity CurrentOpportunity = new Opportunity();
        public Contact CurrentContact = new Contact();
        public string ResumeLocation = "";
        public string CoverLetterLocation = "";
        public static MainForm Access;

        public MainForm()
        {
            InitializeComponent();
            FileHelper.CreateFolders();
            FileHelper.Load();
            Access = this;
            //Initialize Datagrids
            try
            {
                dgv_SearchResults.DataSource = Program.Opportunities;
            }
            catch (Exception)
            {
            }
            cmbx_OpportunityStatus.SelectedIndex = 0;
            EnableOpportunities(false);
        }

        #region Interactions

        private void MainForm_Shown(object sender, EventArgs e)
        {
            EnableWebLinks();
            dgv_SearchResults.ClearSelection();
        }

        private void btn_AddResume_Click(object sender, EventArgs e)
        {
            if (btn_AddResume.Text == @"Cached Files")
            {
                var fileForm = new CacheFileForm();
                fileForm.ShowDialog();
            }
            else
            {
                var fileForm = new UploadFileForm();
                fileForm.ShowDialog();
            }
        }

        private void btn_ShowContacts_Click(object sender, EventArgs e)
        {
            var showContacts = new ContactForm();
            showContacts.ShowDialog();
        }

        private void btn_SettingsForm_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_PaypalDonation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=PGECHUZWDZ6CQ");
        }

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        private void btn_ChangeAppearance_Click(object sender, EventArgs e)
        {
            //int h = Screen.PrimaryScreen.WorkingArea.Height;
            //this.ClientSize = new Size(this.Width, h);
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            Process.Start(Settings.Default.DefaultSearchPage);
            while (GetForegroundWindow() == this.Handle)
                Thread.Sleep(100);
            MoveWindow(GetForegroundWindow(), -5, 0, Screen.PrimaryScreen.WorkingArea.Width + 12 - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height + 10, true);
        }

        private void btn_MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_AlwaysOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private Point _mouseStartPoint;

        private void pnl_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseStartPoint = e.Location;
            }
        }

        private void pnl_TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Get the difference between the two points
                int xDiff = _mouseStartPoint.X - e.Location.X;
                int yDiff = _mouseStartPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void lbl_TitleBarName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseStartPoint = e.Location;
            }
        }

        private void lbl_TitleBarName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Get the difference between the two points
                int xDiff = _mouseStartPoint.X - e.Location.X;
                int yDiff = _mouseStartPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        #region Opportunities

        private void btn_NewOpportunity_Click(object sender, EventArgs e)
        {
            EnableOpportunities(true);
            ClearOpportunities();
            btn_AddResume.Text = @"Add Resume";
            btn_AddResume.Enabled = false;
            btn_SaveJob.Text = @"Save";
            btn_SaveJob.Enabled = true;
            btn_AddResume.Enabled = true;
            btn_DeleteOpportunity.Enabled = false;
            btn_ShowContacts.Enabled = true;
            CurrentOpportunity = new Opportunity
            {
                CompanyName = "",
                WebLink = "",
                Position = "",
                ApplicationDate = DateTime.Today,
                FollowUpStatus = "Applied",
                Contacts = new List<Contact>()
            };

            if (Settings.Default.UseDefaultResume)
            {
                if (!File.Exists(Settings.Default.DefaultResumeLocation))
                    MessageBox.Show(@"Unable locate Default Resume.");
                else
                    ResumeLocation = Settings.Default.DefaultResumeLocation;
            }

            if (Settings.Default.UseDefaultCoverLetter)
            {
                if (!File.Exists(Settings.Default.DefaultCoverLetterLocation))
                    MessageBox.Show(@"Unable locate Default Cover Letter.");
                else
                    CoverLetterLocation = Settings.Default.DefaultCoverLetterLocation;
            }

            dgv_SearchResults.ClearSelection();
        }

        private void btn_SaveJob_Click(object sender, EventArgs e)
        {
            if (txtbx_CompanyName.ReadOnly)
            {
                btn_SaveJob.Text = @"Save";
                EnableOpportunities(true);
                btn_DeleteOpportunity.Enabled = false;
                return;
            }
            //todo: Make this a bit more graceful of an exit.
            if (string.IsNullOrEmpty(txtbx_CompanyName.Text))
                return;
            if (string.IsNullOrEmpty(txtbx_WebUrl.Text) ||
                !Uri.IsWellFormedUriString(txtbx_WebUrl.Text, UriKind.Absolute))
                return;
            if (string.IsNullOrEmpty(txtbx_JobPosition.Text))
                return;
            //Check to see if this is an existing Opprotunity that we need to update or a new Opportunity to add
            var updateSelected = Program.Opportunities.FirstOrDefault(x => x.Equals(CurrentOpportunity));
            if (updateSelected != null)
            {
                updateSelected.CompanyName = txtbx_CompanyName.Text;
                updateSelected.WebLink = txtbx_WebUrl.Text;
                updateSelected.Position = txtbx_JobPosition.Text;
                updateSelected.ApplicationDate = dtp_DateApplied.Value.Date;
                updateSelected.FollowUpStatus = cmbx_OpportunityStatus.Text;
                updateSelected.Contacts = CurrentOpportunity.Contacts;
            }
            else
            {
                CurrentOpportunity.CompanyName = txtbx_CompanyName.Text;
                CurrentOpportunity.WebLink = txtbx_WebUrl.Text;
                CurrentOpportunity.Position = txtbx_JobPosition.Text;
                CurrentOpportunity.ApplicationDate = dtp_DateApplied.Value.Date;
                CurrentOpportunity.FollowUpStatus = cmbx_OpportunityStatus.Text;
                Program.Opportunities.Add(CurrentOpportunity);
            }
            FileHelper.CreateBackUp(CurrentOpportunity, ResumeLocation, CoverLetterLocation);
            //Null out and replace the DataSource
            dgv_SearchResults.DataSource = null;
            dgv_SearchResults.DataSource = Program.Opportunities;
            //Make the Weblinks Clickable
            EnableWebLinks();
            EnableOpportunities(false);
            btn_ShowContacts.Enabled = false;
            btn_DeleteOpportunity.Enabled = true;
            btn_AddResume.Text = @"Add Resume";
            btn_AddResume.Enabled = false;
            //ClearOpportunities();
            //ClearContact();
            //dgv_Contacts.DataSource = null;
            btn_SaveJob.Enabled = false;
            Program.Opportunities.Save();
            CoverLetterLocation = "";
            ResumeLocation = "";
        }

        public bool SearchFormShown = false;
        private SearchForm _searchForm; 

        private void btn_SearchJobs_Click(object sender, EventArgs e)
        {
            if (!SearchFormShown)
            {
                _searchForm = new SearchForm();
                _searchForm.Show();
                SearchFormShown = true;
            }
            else
            {
                _searchForm.TopMost = true;
                _searchForm.TopMost = false;
            }
        }

        private void btn_DeleteOpportunity_Click(object sender, EventArgs e)
        {
            ClearOpportunities();
            Program.Opportunities.Remove(CurrentOpportunity);
            dgv_SearchResults.DataSource = null;
            dgv_SearchResults.DataSource = Program.Opportunities;
            Program.Opportunities.Save();
            dgv_SearchResults.ClearSelection();
            btn_SaveJob.Text = @"Save";
            btn_AddResume.Text = @"Add Resume";
            btn_AddResume.Enabled = false;
        }

        private void dgv_SearchResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Start a webpage for the user if the user clicks the link
            var url = dgv_SearchResults.SelectedRows[0].Cells[1].Value.ToString();
            if (e.ColumnIndex == 1 && Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                Process.Start(url);
            }
            //Set the fields for the current selected row.

            btn_SaveJob.Text = @"Edit";
            btn_ShowContacts.Enabled = true;
            btn_SaveJob.Enabled = true;
            btn_DeleteOpportunity.Enabled = true;
            EnableOpportunities(false);
            var selectedRow = dgv_SearchResults.SelectedRows[0];
            txtbx_CompanyName.Text = selectedRow.Cells[@"CompanyName"].Value.ToString();
            txtbx_WebUrl.Text = selectedRow.Cells[@"WebLink"].Value.ToString();
            txtbx_JobPosition.Text = selectedRow.Cells[@"Position"].Value.ToString();
            DateTime date;
            if (DateTime.TryParse(selectedRow.Cells[@"ApplicationDate"].Value.ToString(), out date))
                dtp_DateApplied.Value = date;
            cmbx_OpportunityStatus.SelectedIndex = cmbx_OpportunityStatus.Items.IndexOf(selectedRow.Cells[@"FollowUpStatus"].Value.ToString());
            //cmbx_OpportunityStatus.Text = selectedRow.Cells[4].Value.ToString();
            CurrentOpportunity = Program.Opportunities.FirstOrDefault(x => x.CompanyName == txtbx_CompanyName.Text &&
                                                                           x.CompanyName == txtbx_CompanyName.Text &&
                                                                           x.WebLink == txtbx_WebUrl.Text &&
                                                                           x.Position == txtbx_JobPosition.Text);
            btn_AddResume.Text = @"Cached Files";
            btn_AddResume.Enabled = true;
        }

        #endregion Opportunities

        #endregion Interactions

        #region Accessors
        
        public void UpdateSearch(List<Opportunity> searchList)
        {
            if (dgv_SearchResults.InvokeRequired)
            {
                dgv_SearchResults.Invoke(new Action(() => UpdateSearch(searchList)));
                return;
            }
            dgv_SearchResults.DataSource = null;
            dgv_SearchResults.DataSource = searchList;
            EnableWebLinks();
        }
        
        public void DeleteOpportunityButton(bool enable)
        {
            if (btn_DeleteOpportunity.InvokeRequired)
            {
                btn_DeleteOpportunity.Invoke(new Action(() => DeleteOpportunityButton(enable)));
                return;
            }
            btn_DeleteOpportunity.Enabled = enable;
        }

        public void AddResumeButton(bool enable)
        {
            if (btn_AddResume.InvokeRequired)
            {
                btn_AddResume.Invoke(new Action(() => AddResumeButton(enable)));
                return;
            }
            btn_AddResume.Enabled = enable;
        }

        public Point ThisLocation => this.Location;
        public Size ThisSize => this.Size;

        #endregion Accessors

        #region Methods

        public void EnableWebLinks()
        {
            foreach (DataGridViewRow r in dgv_SearchResults.Rows)
            {
                if (Uri.IsWellFormedUriString(r.Cells["WebLink"].Value.ToString(), UriKind.Absolute))
                {
                    r.Cells["WebLink"] = new DataGridViewLinkCell();
                    // Note that if I want a different link colour for example it must go here
                    DataGridViewLinkCell c = (DataGridViewLinkCell) r.Cells["WebLink"];
                    c.LinkColor = Color.Green;
                }
            }
        }

        public void EnableOpportunities(bool fieldsEnabled)
        {
            txtbx_CompanyName.ReadOnly = !fieldsEnabled;
            txtbx_WebUrl.ReadOnly = !fieldsEnabled;
            txtbx_JobPosition.ReadOnly = !fieldsEnabled;
            dtp_DateApplied.Enabled = fieldsEnabled;
            cmbx_OpportunityStatus.Enabled = fieldsEnabled;
        }

        public void ClearOpportunities()
        {
            txtbx_CompanyName.Text = "";
            txtbx_WebUrl.Text = "";
            txtbx_JobPosition.Text = "";
            dtp_DateApplied.Value = DateTime.Today;
            cmbx_OpportunityStatus.SelectedIndex = 0;
        }

        #endregion Methods

        private void btn_ShowStats_Click(object sender, EventArgs e)
        {
            var statsForm = new StatsForm();
            statsForm.ShowDialog();
        }
    }
}