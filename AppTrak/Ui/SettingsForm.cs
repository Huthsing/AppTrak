using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTrak.Properties;

namespace AppTrak.Ui
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            Point drawningPoint = new Point(MainForm.Access.Location.X - this.Width + 7, MainForm.Access.Location.Y);
            Location = drawningPoint;
        }

        private void chkbx_UseDefaultResume_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.UseDefaultResume = chkbx_UseDefaultResume.Checked;
            Settings.Default.Save();
        }

        private void chkbx_UseDefaultCoverLetter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.UseDefaultCoverLetter = chkbx_UseDefaultCoverLetter.Checked;
            Settings.Default.Save();
        }

        private void btn_LocateDefaultResume_Click(object sender, EventArgs e)
        {
            var choofdlog = new OpenFileDialog
            {
                Filter = @"All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() != DialogResult.OK) return;
            txtbx_DefaultResumeLocation.Text = choofdlog.FileName;

            Settings.Default.DefaultResumeLocation = choofdlog.FileName;
            Settings.Default.Save();
        }

        private void btn_LocateCoverLetter_Click(object sender, EventArgs e)
        {
            var choofdlog = new OpenFileDialog
            {
                Filter = @"All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() != DialogResult.OK) return;
            txtbx_DefaultCoverLetterLocation.Text = choofdlog.FileName;
            Settings.Default.DefaultCoverLetterLocation = choofdlog.FileName;
            Settings.Default.Save();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            chkbx_UseDefaultResume.Checked = Settings.Default.UseDefaultResume;
            chkbx_UseDefaultCoverLetter.Checked = Settings.Default.UseDefaultCoverLetter;
            txtbx_DefaultResumeLocation.Text = Settings.Default.DefaultResumeLocation;
            txtbx_DefaultCoverLetterLocation.Text = Settings.Default.DefaultCoverLetterLocation;
            txtbx_DefaultSearchPage.Text = Settings.Default.DefaultSearchPage;
            chkbx_BackUpToServer.Checked = Settings.Default.StoreDataOnServer;
            chxbx_SendDataToServer.Checked = Settings.Default.SendAnonymousData;
            txtbx_Password.Text = Settings.Default.Password;
            txtbx_Username.Text = Settings.Default.Username;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.UseDefaultResume = chkbx_UseDefaultResume.Checked;
            Settings.Default.UseDefaultCoverLetter = chkbx_UseDefaultCoverLetter.Checked;
            Settings.Default.DefaultResumeLocation = txtbx_DefaultResumeLocation.Text;
            Settings.Default.DefaultCoverLetterLocation = txtbx_DefaultCoverLetterLocation.Text;
            Settings.Default.DefaultSearchPage = txtbx_DefaultSearchPage.Text;
            Settings.Default.StoreDataOnServer = chkbx_BackUpToServer.Checked;
            Settings.Default.SendAnonymousData = chxbx_SendDataToServer.Checked;
            Settings.Default.Password = txtbx_Password.Text;
            Settings.Default.Username = txtbx_Username.Text;
            Settings.Default.Save();
        }

        private void btn_SearchPage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Settings.Default.DefaultSearchPage) ||
                !Uri.IsWellFormedUriString(Settings.Default.DefaultSearchPage, UriKind.Absolute))
            {
                MessageBox.Show(@"Please enter a valid URL.");
                return;
            }
            Settings.Default.DefaultSearchPage = txtbx_DefaultSearchPage.Text;
            Settings.Default.Save();
        }

        private void chkbx_BackUpToServer_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.StoreDataOnServer = chkbx_BackUpToServer.Checked;
            Settings.Default.Save();
        }

        private void chxbx_SendDataToServer_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.SendAnonymousData = chxbx_SendDataToServer.Checked;
            Settings.Default.Save();
        }
    }
}