namespace AppTrak.Ui
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtbx_CompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbx_OpportunityInformation = new System.Windows.Forms.GroupBox();
            this.btn_ShowContacts = new System.Windows.Forms.Button();
            this.btn_AddResume = new System.Windows.Forms.Button();
            this.btn_NewOpportunity = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_JobPosition = new System.Windows.Forms.TextBox();
            this.btn_SaveJob = new System.Windows.Forms.Button();
            this.dtp_DateApplied = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_WebUrl = new System.Windows.Forms.TextBox();
            this.btn_SearchJobs = new System.Windows.Forms.Button();
            this.grpbx_OpportunitySearch = new System.Windows.Forms.GroupBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.btn_DeleteOpportunity = new System.Windows.Forms.Button();
            this.btn_SettingsForm = new System.Windows.Forms.Button();
            this.pnl_TitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AlwaysOnTop = new System.Windows.Forms.Button();
            this.btn_MinimizeForm = new System.Windows.Forms.Button();
            this.btn_ChangeAppearance = new System.Windows.Forms.Button();
            this.btn_CloseForm = new System.Windows.Forms.Button();
            this.lbl_TitleBarName = new System.Windows.Forms.Label();
            this.btn_PaypalDonation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbx_OpportunityStatus = new System.Windows.Forms.ComboBox();
            this.grpbx_OpportunityInformation.SuspendLayout();
            this.grpbx_OpportunitySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.pnl_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_CompanyName
            // 
            this.txtbx_CompanyName.Location = new System.Drawing.Point(97, 15);
            this.txtbx_CompanyName.Name = "txtbx_CompanyName";
            this.txtbx_CompanyName.Size = new System.Drawing.Size(357, 23);
            this.txtbx_CompanyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company:";
            // 
            // grpbx_OpportunityInformation
            // 
            this.grpbx_OpportunityInformation.Controls.Add(this.cmbx_OpportunityStatus);
            this.grpbx_OpportunityInformation.Controls.Add(this.label5);
            this.grpbx_OpportunityInformation.Controls.Add(this.btn_ShowContacts);
            this.grpbx_OpportunityInformation.Controls.Add(this.btn_AddResume);
            this.grpbx_OpportunityInformation.Controls.Add(this.btn_NewOpportunity);
            this.grpbx_OpportunityInformation.Controls.Add(this.label8);
            this.grpbx_OpportunityInformation.Controls.Add(this.txtbx_JobPosition);
            this.grpbx_OpportunityInformation.Controls.Add(this.btn_SaveJob);
            this.grpbx_OpportunityInformation.Controls.Add(this.dtp_DateApplied);
            this.grpbx_OpportunityInformation.Controls.Add(this.label3);
            this.grpbx_OpportunityInformation.Controls.Add(this.label2);
            this.grpbx_OpportunityInformation.Controls.Add(this.txtbx_WebUrl);
            this.grpbx_OpportunityInformation.Controls.Add(this.label1);
            this.grpbx_OpportunityInformation.Controls.Add(this.txtbx_CompanyName);
            this.grpbx_OpportunityInformation.Location = new System.Drawing.Point(2, 31);
            this.grpbx_OpportunityInformation.Name = "grpbx_OpportunityInformation";
            this.grpbx_OpportunityInformation.Size = new System.Drawing.Size(464, 178);
            this.grpbx_OpportunityInformation.TabIndex = 3;
            this.grpbx_OpportunityInformation.TabStop = false;
            this.grpbx_OpportunityInformation.Text = "Job Information";
            // 
            // btn_ShowContacts
            // 
            this.btn_ShowContacts.Enabled = false;
            this.btn_ShowContacts.Location = new System.Drawing.Point(234, 148);
            this.btn_ShowContacts.Name = "btn_ShowContacts";
            this.btn_ShowContacts.Size = new System.Drawing.Size(107, 23);
            this.btn_ShowContacts.TabIndex = 17;
            this.btn_ShowContacts.Text = "Contacts";
            this.btn_ShowContacts.UseVisualStyleBackColor = true;
            this.btn_ShowContacts.Click += new System.EventHandler(this.btn_ShowContacts_Click);
            // 
            // btn_AddResume
            // 
            this.btn_AddResume.Enabled = false;
            this.btn_AddResume.Location = new System.Drawing.Point(347, 148);
            this.btn_AddResume.Name = "btn_AddResume";
            this.btn_AddResume.Size = new System.Drawing.Size(107, 23);
            this.btn_AddResume.TabIndex = 16;
            this.btn_AddResume.Text = "Add Resume";
            this.btn_AddResume.UseVisualStyleBackColor = true;
            this.btn_AddResume.Click += new System.EventHandler(this.btn_AddResume_Click);
            // 
            // btn_NewOpportunity
            // 
            this.btn_NewOpportunity.Location = new System.Drawing.Point(8, 148);
            this.btn_NewOpportunity.Name = "btn_NewOpportunity";
            this.btn_NewOpportunity.Size = new System.Drawing.Size(107, 23);
            this.btn_NewOpportunity.TabIndex = 13;
            this.btn_NewOpportunity.Text = "Create New";
            this.btn_NewOpportunity.UseVisualStyleBackColor = true;
            this.btn_NewOpportunity.Click += new System.EventHandler(this.btn_NewOpportunity_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Position:";
            // 
            // txtbx_JobPosition
            // 
            this.txtbx_JobPosition.Location = new System.Drawing.Point(97, 75);
            this.txtbx_JobPosition.Name = "txtbx_JobPosition";
            this.txtbx_JobPosition.Size = new System.Drawing.Size(357, 23);
            this.txtbx_JobPosition.TabIndex = 14;
            // 
            // btn_SaveJob
            // 
            this.btn_SaveJob.Enabled = false;
            this.btn_SaveJob.Location = new System.Drawing.Point(121, 148);
            this.btn_SaveJob.Name = "btn_SaveJob";
            this.btn_SaveJob.Size = new System.Drawing.Size(107, 23);
            this.btn_SaveJob.TabIndex = 13;
            this.btn_SaveJob.Text = "Save";
            this.btn_SaveJob.UseVisualStyleBackColor = true;
            this.btn_SaveJob.Click += new System.EventHandler(this.btn_SaveJob_Click);
            // 
            // dtp_DateApplied
            // 
            this.dtp_DateApplied.Location = new System.Drawing.Point(97, 119);
            this.dtp_DateApplied.Name = "dtp_DateApplied";
            this.dtp_DateApplied.Size = new System.Drawing.Size(202, 23);
            this.dtp_DateApplied.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Applied:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Web Link:";
            // 
            // txtbx_WebUrl
            // 
            this.txtbx_WebUrl.Location = new System.Drawing.Point(97, 45);
            this.txtbx_WebUrl.Name = "txtbx_WebUrl";
            this.txtbx_WebUrl.Size = new System.Drawing.Size(357, 23);
            this.txtbx_WebUrl.TabIndex = 4;
            // 
            // btn_SearchJobs
            // 
            this.btn_SearchJobs.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_SearchJobs.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_SearchJobs.Location = new System.Drawing.Point(169, 433);
            this.btn_SearchJobs.Name = "btn_SearchJobs";
            this.btn_SearchJobs.Size = new System.Drawing.Size(136, 25);
            this.btn_SearchJobs.TabIndex = 12;
            this.btn_SearchJobs.Text = "Search ";
            this.btn_SearchJobs.UseVisualStyleBackColor = true;
            this.btn_SearchJobs.Click += new System.EventHandler(this.btn_SearchJobs_Click);
            // 
            // grpbx_OpportunitySearch
            // 
            this.grpbx_OpportunitySearch.Controls.Add(this.dgv_SearchResults);
            this.grpbx_OpportunitySearch.Controls.Add(this.btn_DeleteOpportunity);
            this.grpbx_OpportunitySearch.Location = new System.Drawing.Point(5, 215);
            this.grpbx_OpportunitySearch.Name = "grpbx_OpportunitySearch";
            this.grpbx_OpportunitySearch.Size = new System.Drawing.Size(461, 218);
            this.grpbx_OpportunitySearch.TabIndex = 4;
            this.grpbx_OpportunitySearch.TabStop = false;
            this.grpbx_OpportunitySearch.Text = "Click to Select Opportunity";
            // 
            // dgv_SearchResults
            // 
            this.dgv_SearchResults.AllowUserToAddRows = false;
            this.dgv_SearchResults.AllowUserToDeleteRows = false;
            this.dgv_SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_SearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResults.Location = new System.Drawing.Point(3, 19);
            this.dgv_SearchResults.MultiSelect = false;
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SearchResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SearchResults.RowHeadersVisible = false;
            this.dgv_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchResults.Size = new System.Drawing.Size(455, 170);
            this.dgv_SearchResults.TabIndex = 0;
            this.dgv_SearchResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SearchResults_CellMouseClick);
            // 
            // btn_DeleteOpportunity
            // 
            this.btn_DeleteOpportunity.Enabled = false;
            this.btn_DeleteOpportunity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteOpportunity.ForeColor = System.Drawing.Color.Red;
            this.btn_DeleteOpportunity.Location = new System.Drawing.Point(3, 189);
            this.btn_DeleteOpportunity.Name = "btn_DeleteOpportunity";
            this.btn_DeleteOpportunity.Size = new System.Drawing.Size(455, 25);
            this.btn_DeleteOpportunity.TabIndex = 14;
            this.btn_DeleteOpportunity.Text = "Remove Selected Opportunity";
            this.btn_DeleteOpportunity.UseVisualStyleBackColor = true;
            this.btn_DeleteOpportunity.Click += new System.EventHandler(this.btn_DeleteOpportunity_Click);
            // 
            // btn_SettingsForm
            // 
            this.btn_SettingsForm.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_SettingsForm.ForeColor = System.Drawing.Color.Black;
            this.btn_SettingsForm.Location = new System.Drawing.Point(8, 433);
            this.btn_SettingsForm.Name = "btn_SettingsForm";
            this.btn_SettingsForm.Size = new System.Drawing.Size(136, 25);
            this.btn_SettingsForm.TabIndex = 14;
            this.btn_SettingsForm.Text = "Settings";
            this.btn_SettingsForm.UseVisualStyleBackColor = true;
            this.btn_SettingsForm.Click += new System.EventHandler(this.btn_SettingsForm_Click);
            // 
            // pnl_TitleBar
            // 
            this.pnl_TitleBar.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_TitleBar.Controls.Add(this.pictureBox1);
            this.pnl_TitleBar.Controls.Add(this.btn_AlwaysOnTop);
            this.pnl_TitleBar.Controls.Add(this.btn_MinimizeForm);
            this.pnl_TitleBar.Controls.Add(this.btn_ChangeAppearance);
            this.pnl_TitleBar.Controls.Add(this.btn_CloseForm);
            this.pnl_TitleBar.Controls.Add(this.lbl_TitleBarName);
            this.pnl_TitleBar.Location = new System.Drawing.Point(-2, -1);
            this.pnl_TitleBar.Name = "pnl_TitleBar";
            this.pnl_TitleBar.Size = new System.Drawing.Size(475, 30);
            this.pnl_TitleBar.TabIndex = 1;
            this.pnl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseDown);
            this.pnl_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTrak.Properties.Resources.grizzly_bear_paw_print_white;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AlwaysOnTop
            // 
            this.btn_AlwaysOnTop.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_AlwaysOnTop.Location = new System.Drawing.Point(350, 2);
            this.btn_AlwaysOnTop.Name = "btn_AlwaysOnTop";
            this.btn_AlwaysOnTop.Size = new System.Drawing.Size(25, 25);
            this.btn_AlwaysOnTop.TabIndex = 20;
            this.btn_AlwaysOnTop.Text = "I";
            this.btn_AlwaysOnTop.UseVisualStyleBackColor = true;
            this.btn_AlwaysOnTop.Click += new System.EventHandler(this.btn_AlwaysOnTop_Click);
            // 
            // btn_MinimizeForm
            // 
            this.btn_MinimizeForm.Location = new System.Drawing.Point(381, 2);
            this.btn_MinimizeForm.Name = "btn_MinimizeForm";
            this.btn_MinimizeForm.Size = new System.Drawing.Size(25, 25);
            this.btn_MinimizeForm.TabIndex = 19;
            this.btn_MinimizeForm.Text = "_";
            this.btn_MinimizeForm.UseVisualStyleBackColor = true;
            this.btn_MinimizeForm.Click += new System.EventHandler(this.btn_MinimizeForm_Click);
            // 
            // btn_ChangeAppearance
            // 
            this.btn_ChangeAppearance.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_ChangeAppearance.Location = new System.Drawing.Point(412, 2);
            this.btn_ChangeAppearance.Name = "btn_ChangeAppearance";
            this.btn_ChangeAppearance.Size = new System.Drawing.Size(25, 25);
            this.btn_ChangeAppearance.TabIndex = 18;
            this.btn_ChangeAppearance.Text = "¨";
            this.btn_ChangeAppearance.UseVisualStyleBackColor = true;
            this.btn_ChangeAppearance.Click += new System.EventHandler(this.btn_ChangeAppearance_Click);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_CloseForm.Location = new System.Drawing.Point(443, 2);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(25, 25);
            this.btn_CloseForm.TabIndex = 17;
            this.btn_CloseForm.Text = "ý";
            this.btn_CloseForm.UseVisualStyleBackColor = true;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // lbl_TitleBarName
            // 
            this.lbl_TitleBarName.AutoSize = true;
            this.lbl_TitleBarName.Font = new System.Drawing.Font("Constantia", 12.75F);
            this.lbl_TitleBarName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TitleBarName.Location = new System.Drawing.Point(32, 5);
            this.lbl_TitleBarName.Name = "lbl_TitleBarName";
            this.lbl_TitleBarName.Size = new System.Drawing.Size(275, 21);
            this.lbl_TitleBarName.TabIndex = 1;
            this.lbl_TitleBarName.Text = "AppTrak - The Opportunity Tracker";
            this.lbl_TitleBarName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBarName_MouseDown);
            this.lbl_TitleBarName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBarName_MouseMove);
            // 
            // btn_PaypalDonation
            // 
            this.btn_PaypalDonation.Image = ((System.Drawing.Image)(resources.GetObject("btn_PaypalDonation.Image")));
            this.btn_PaypalDonation.Location = new System.Drawing.Point(327, 434);
            this.btn_PaypalDonation.Name = "btn_PaypalDonation";
            this.btn_PaypalDonation.Size = new System.Drawing.Size(136, 25);
            this.btn_PaypalDonation.TabIndex = 15;
            this.btn_PaypalDonation.UseVisualStyleBackColor = true;
            this.btn_PaypalDonation.Click += new System.EventHandler(this.btn_PaypalDonation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Status:";
            // 
            // cmbx_OpportunityStatus
            // 
            this.cmbx_OpportunityStatus.FormattingEnabled = true;
            this.cmbx_OpportunityStatus.Items.AddRange(new object[] {
            "Applied",
            "Contacted",
            "Interview",
            "Offer"});
            this.cmbx_OpportunityStatus.Location = new System.Drawing.Point(305, 119);
            this.cmbx_OpportunityStatus.Name = "cmbx_OpportunityStatus";
            this.cmbx_OpportunityStatus.Size = new System.Drawing.Size(149, 23);
            this.cmbx_OpportunityStatus.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(472, 462);
            this.Controls.Add(this.btn_PaypalDonation);
            this.Controls.Add(this.pnl_TitleBar);
            this.Controls.Add(this.btn_SettingsForm);
            this.Controls.Add(this.grpbx_OpportunitySearch);
            this.Controls.Add(this.grpbx_OpportunityInformation);
            this.Controls.Add(this.btn_SearchJobs);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppTrak - The Application Tracker";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.grpbx_OpportunityInformation.ResumeLayout(false);
            this.grpbx_OpportunityInformation.PerformLayout();
            this.grpbx_OpportunitySearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.pnl_TitleBar.ResumeLayout(false);
            this.pnl_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbx_OpportunityInformation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_JobPosition;
        private System.Windows.Forms.Button btn_SaveJob;
        private System.Windows.Forms.Button btn_SearchJobs;
        private System.Windows.Forms.DateTimePicker dtp_DateApplied;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_WebUrl;
        private System.Windows.Forms.GroupBox grpbx_OpportunitySearch;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
        private System.Windows.Forms.Button btn_NewOpportunity;
        private System.Windows.Forms.Button btn_DeleteOpportunity;
        private System.Windows.Forms.Button btn_AddResume;
        private System.Windows.Forms.Button btn_SettingsForm;
        private System.Windows.Forms.Panel pnl_TitleBar;
        private System.Windows.Forms.Button btn_MinimizeForm;
        private System.Windows.Forms.Button btn_ChangeAppearance;
        private System.Windows.Forms.Button btn_CloseForm;
        private System.Windows.Forms.Label lbl_TitleBarName;
        private System.Windows.Forms.Button btn_AlwaysOnTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_PaypalDonation;
        private System.Windows.Forms.Button btn_ShowContacts;
        private System.Windows.Forms.ComboBox cmbx_OpportunityStatus;
        private System.Windows.Forms.Label label5;
    }
}

