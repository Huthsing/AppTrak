using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTrak.Ui
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            Point drawningPoint = new Point(MainForm.Access.Location.X - this.Width + 7, MainForm.Access.Location.Y);
            Location = drawningPoint;
            lbl_Applied.Text = Program.Opportunities.Count(x => x.FollowUpStatus == "Applied").ToString();
            lbl_Contact.Text = Program.Opportunities.Count(x => x.FollowUpStatus == "Contacted").ToString();
            lbl_Interview.Text = Program.Opportunities.Count(x => x.FollowUpStatus == "Interview").ToString();
            lbl_Offer.Text = Program.Opportunities.Count(x => x.FollowUpStatus == "Offer").ToString();
            lbl_Total.Text = Program.Opportunities.Count.ToString();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
