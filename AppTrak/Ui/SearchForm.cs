using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppTrak.Models;

namespace AppTrak.Ui
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            DateSearchEnabler(false);
            Point drawningPoint = new Point(MainForm.Access.Location.X - 7, MainForm.Access.Location.Y + MainForm.Access.Height);
            Location = drawningPoint;
            Size drawSizesize = new Size(MainForm.Access.Width + 15, this.Height);
            Size = drawSizesize;
        }

        private void btn_SearchJobs_Click(object sender, EventArgs e)
        {
            List<Opportunity> opps = new List<Opportunity>();
            foreach (var ops in Program.Opportunities)
            {
                if (chkbx_EnableDateSearch.Checked && (ops.ApplicationDate < dtp_FromDate.Value.Date ||
                    ops.ApplicationDate > dtp_ToDate.Value.Date))
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(txtbx_CompanyName.Text) && ops.CompanyName.ToLower().Contains(txtbx_CompanyName.Text.ToLower()) ||
                    !string.IsNullOrEmpty(txtbx_JobPosition.Text) && ops.Position.ToLower().Contains(txtbx_JobPosition.Text.ToLower()) ||
                    chkbx_EnableDateSearch.Checked && string.IsNullOrEmpty(txtbx_CompanyName.Text) && string.IsNullOrEmpty(txtbx_JobPosition.Text))
                {
                    opps.Add(ops);
                }
            }
            //if (opps.Count < 1)
            //{
            //    MessageBox.Show("Something went wrong.");
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show(opps.Count.ToString());
            //}
            MainForm.Access.UpdateSearch(opps);
        }
        
        private void chkbx_EnableDateSearch_CheckedChanged(object sender, EventArgs e)
        {
            DateSearchEnabler(chkbx_EnableDateSearch.Checked);
        }

        private void DateSearchEnabler(bool enableSearch)
        {
            dtp_ToDate.Enabled = enableSearch;
            dtp_FromDate.Enabled = enableSearch;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Access.UpdateSearch(Program.Opportunities);
            MainForm.Access.EnableWebLinks();
            MainForm.Access.SearchFormShown = false;
        }
    }
}
