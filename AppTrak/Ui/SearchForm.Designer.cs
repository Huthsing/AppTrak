namespace AppTrak.Ui
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_JobPosition = new System.Windows.Forms.TextBox();
            this.btn_SearchJobs = new System.Windows.Forms.Button();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_CompanyName = new System.Windows.Forms.TextBox();
            this.chkbx_EnableDateSearch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Position:";
            // 
            // txtbx_JobPosition
            // 
            this.txtbx_JobPosition.Location = new System.Drawing.Point(92, 44);
            this.txtbx_JobPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_JobPosition.Name = "txtbx_JobPosition";
            this.txtbx_JobPosition.Size = new System.Drawing.Size(329, 23);
            this.txtbx_JobPosition.TabIndex = 27;
            // 
            // btn_SearchJobs
            // 
            this.btn_SearchJobs.Location = new System.Drawing.Point(259, 134);
            this.btn_SearchJobs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchJobs.Name = "btn_SearchJobs";
            this.btn_SearchJobs.Size = new System.Drawing.Size(162, 29);
            this.btn_SearchJobs.TabIndex = 24;
            this.btn_SearchJobs.Text = "Search";
            this.btn_SearchJobs.UseVisualStyleBackColor = true;
            this.btn_SearchJobs.Click += new System.EventHandler(this.btn_SearchJobs_Click);
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Location = new System.Drawing.Point(92, 104);
            this.dtp_ToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(329, 23);
            this.dtp_ToDate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "To:";
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Location = new System.Drawing.Point(92, 74);
            this.dtp_FromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(329, 23);
            this.dtp_FromDate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Company:";
            // 
            // txtbx_CompanyName
            // 
            this.txtbx_CompanyName.Location = new System.Drawing.Point(92, 14);
            this.txtbx_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_CompanyName.Name = "txtbx_CompanyName";
            this.txtbx_CompanyName.Size = new System.Drawing.Size(329, 23);
            this.txtbx_CompanyName.TabIndex = 16;
            // 
            // chkbx_EnableDateSearch
            // 
            this.chkbx_EnableDateSearch.AutoSize = true;
            this.chkbx_EnableDateSearch.Location = new System.Drawing.Point(92, 139);
            this.chkbx_EnableDateSearch.Margin = new System.Windows.Forms.Padding(4);
            this.chkbx_EnableDateSearch.Name = "chkbx_EnableDateSearch";
            this.chkbx_EnableDateSearch.Size = new System.Drawing.Size(136, 19);
            this.chkbx_EnableDateSearch.TabIndex = 29;
            this.chkbx_EnableDateSearch.Text = "Enable Date Search";
            this.chkbx_EnableDateSearch.UseVisualStyleBackColor = true;
            this.chkbx_EnableDateSearch.CheckedChanged += new System.EventHandler(this.chkbx_EnableDateSearch_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 179);
            this.Controls.Add(this.chkbx_EnableDateSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbx_JobPosition);
            this.Controls.Add(this.btn_SearchJobs);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_CompanyName);
            this.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search Your Application History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_JobPosition;
        private System.Windows.Forms.Button btn_SearchJobs;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_CompanyName;
        private System.Windows.Forms.CheckBox chkbx_EnableDateSearch;
    }
}