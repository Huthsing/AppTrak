using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTrak.Helpers;

namespace AppTrak.Ui
{
    public partial class CacheFileForm : Form
    {
        public CacheFileForm()
        {
            InitializeComponent();
            Point drawningPoint = new Point(MainForm.Access.Location.X - this.Width + 7, MainForm.Access.Location.Y);
            Location = drawningPoint;
        }

        private void btn_ViewResume_Click(object sender, EventArgs e)
        {
            var opportunity = MainForm.Access.CurrentOpportunity;
            var folder = FileHelper.AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}\{opportunity.Position}";
            if (!Directory.Exists(folder))
            {
                MessageBox.Show(@"The folder for this Resume does not exist.");
                return;
            }
            var file = Directory.GetFiles(folder).FirstOrDefault(x => x.ToLower().Contains("resume_"));
            if (file == null)
            {
                MessageBox.Show(@"Unable to Locate Cached Resume.");
                return;
            }
            Process.Start(file);
        }

        private void btn_ViewCoverLetter_Click(object sender, EventArgs e)
        {
            var opportunity = MainForm.Access.CurrentOpportunity;
            var folder = FileHelper.AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}\{opportunity.Position}";
            if (!Directory.Exists(folder))
            {
                MessageBox.Show(@"The folder for this Cover Letter does not exist.");
                return;
            }
            var file = Directory.GetFiles(folder).FirstOrDefault(x => x.ToLower().Contains("cover_"));
            if (file == null)
            {
                MessageBox.Show(@"Unable to Locate Cached Cover Letter.");
                return;
            }
            Process.Start(file);
        }

        private void btn_ViewCacheWebpage_Click(object sender, EventArgs e)
        {
            var opportunity = MainForm.Access.CurrentOpportunity;
            var folder = FileHelper.AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}\{opportunity.Position}";
            if (!Directory.Exists(folder))
            {
                MessageBox.Show(@"The folder for this Cached Webpage does not exist.");
                return;
            }
            var file = Directory.GetFiles(folder).FirstOrDefault(x => x.ToLower().Contains("web.html"));
            if (file == null)
            {
                MessageBox.Show(@"Unable to Locate Cached Webpage.");
                return;
            }
            Process.Start(file);
        }

        private void btn_ViewWebpageImage_Click(object sender, EventArgs e)
        {
            var opportunity = MainForm.Access.CurrentOpportunity;
            var folder = FileHelper.AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}\{opportunity.Position}";
            if (!Directory.Exists(folder))
            {
                MessageBox.Show(@"The folder for this Cached Webpage Image does not exist.");
                return;
            }
            var file = Directory.GetFiles(folder).FirstOrDefault(x => x.ToLower().Contains("website.jpg"));
            if (file == null)
            {
                MessageBox.Show(@"Unable to Locate Cached Webpage Image.");
                return;
            }
            Process.Start(file);
        }
    }
}
