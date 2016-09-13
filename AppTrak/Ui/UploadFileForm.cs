using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTrak.Ui
{
    public partial class UploadFileForm : Form
    {
        public UploadFileForm()
        {
            InitializeComponent();
            Point drawningPoint = new Point(MainForm.Access.Location.X - 7, MainForm.Access.Location.Y + MainForm.Access.Height);
            Location = drawningPoint;
            Size drawSizesize = new Size(MainForm.Access.Width + 15, this.Height);
            Size = drawSizesize;
            if (!string.IsNullOrEmpty(MainForm.Access.ResumeLocation))
                txtbx_Resume.Text = MainForm.Access.ResumeLocation;
            if (!string.IsNullOrEmpty(MainForm.Access.CoverLetterLocation))
                txtbx_CoverLetter.Text = MainForm.Access.CoverLetterLocation;
        }

        private void btn_GetResume_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog
            {
                Filter = @"All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() != DialogResult.OK) return;
            MainForm.Access.ResumeLocation = choofdlog.FileName;
            txtbx_Resume.Text = choofdlog.FileName;
        }

        private void btn_GetCoverLetter_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog
            {
                Filter = @"All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() != DialogResult.OK) return;
            MainForm.Access.CoverLetterLocation = choofdlog.FileName;
            txtbx_CoverLetter.Text = choofdlog.FileName;
        }
    }
}
