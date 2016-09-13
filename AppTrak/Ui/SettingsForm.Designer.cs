namespace AppTrak.Ui
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.chkbx_UseDefaultResume = new System.Windows.Forms.CheckBox();
            this.txtbx_DefaultResumeLocation = new System.Windows.Forms.TextBox();
            this.btn_LocateDefaultResume = new System.Windows.Forms.Button();
            this.btn_LocateCoverLetter = new System.Windows.Forms.Button();
            this.txtbx_DefaultCoverLetterLocation = new System.Windows.Forms.TextBox();
            this.chkbx_UseDefaultCoverLetter = new System.Windows.Forms.CheckBox();
            this.txtbx_DefaultSearchPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SearchPage = new System.Windows.Forms.Button();
            this.chxbx_SendDataToServer = new System.Windows.Forms.CheckBox();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbx_BackUpToServer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbx_UseDefaultResume
            // 
            this.chkbx_UseDefaultResume.AutoSize = true;
            this.chkbx_UseDefaultResume.Location = new System.Drawing.Point(12, 71);
            this.chkbx_UseDefaultResume.Name = "chkbx_UseDefaultResume";
            this.chkbx_UseDefaultResume.Size = new System.Drawing.Size(130, 17);
            this.chkbx_UseDefaultResume.TabIndex = 0;
            this.chkbx_UseDefaultResume.Text = "Use Default Resume?";
            this.chkbx_UseDefaultResume.UseVisualStyleBackColor = true;
            this.chkbx_UseDefaultResume.CheckedChanged += new System.EventHandler(this.chkbx_UseDefaultResume_CheckedChanged);
            // 
            // txtbx_DefaultResumeLocation
            // 
            this.txtbx_DefaultResumeLocation.Enabled = false;
            this.txtbx_DefaultResumeLocation.Location = new System.Drawing.Point(12, 94);
            this.txtbx_DefaultResumeLocation.Name = "txtbx_DefaultResumeLocation";
            this.txtbx_DefaultResumeLocation.Size = new System.Drawing.Size(296, 20);
            this.txtbx_DefaultResumeLocation.TabIndex = 1;
            // 
            // btn_LocateDefaultResume
            // 
            this.btn_LocateDefaultResume.Location = new System.Drawing.Point(314, 91);
            this.btn_LocateDefaultResume.Name = "btn_LocateDefaultResume";
            this.btn_LocateDefaultResume.Size = new System.Drawing.Size(75, 23);
            this.btn_LocateDefaultResume.TabIndex = 2;
            this.btn_LocateDefaultResume.Text = "Resume";
            this.btn_LocateDefaultResume.UseVisualStyleBackColor = true;
            this.btn_LocateDefaultResume.Click += new System.EventHandler(this.btn_LocateDefaultResume_Click);
            // 
            // btn_LocateCoverLetter
            // 
            this.btn_LocateCoverLetter.Location = new System.Drawing.Point(314, 140);
            this.btn_LocateCoverLetter.Name = "btn_LocateCoverLetter";
            this.btn_LocateCoverLetter.Size = new System.Drawing.Size(75, 23);
            this.btn_LocateCoverLetter.TabIndex = 5;
            this.btn_LocateCoverLetter.Text = "Cover Letter";
            this.btn_LocateCoverLetter.UseVisualStyleBackColor = true;
            this.btn_LocateCoverLetter.Click += new System.EventHandler(this.btn_LocateCoverLetter_Click);
            // 
            // txtbx_DefaultCoverLetterLocation
            // 
            this.txtbx_DefaultCoverLetterLocation.Enabled = false;
            this.txtbx_DefaultCoverLetterLocation.Location = new System.Drawing.Point(12, 143);
            this.txtbx_DefaultCoverLetterLocation.Name = "txtbx_DefaultCoverLetterLocation";
            this.txtbx_DefaultCoverLetterLocation.Size = new System.Drawing.Size(296, 20);
            this.txtbx_DefaultCoverLetterLocation.TabIndex = 4;
            // 
            // chkbx_UseDefaultCoverLetter
            // 
            this.chkbx_UseDefaultCoverLetter.AutoSize = true;
            this.chkbx_UseDefaultCoverLetter.Location = new System.Drawing.Point(12, 120);
            this.chkbx_UseDefaultCoverLetter.Name = "chkbx_UseDefaultCoverLetter";
            this.chkbx_UseDefaultCoverLetter.Size = new System.Drawing.Size(149, 17);
            this.chkbx_UseDefaultCoverLetter.TabIndex = 3;
            this.chkbx_UseDefaultCoverLetter.Text = "Use Default Cover Letter?";
            this.chkbx_UseDefaultCoverLetter.UseVisualStyleBackColor = true;
            this.chkbx_UseDefaultCoverLetter.CheckedChanged += new System.EventHandler(this.chkbx_UseDefaultCoverLetter_CheckedChanged);
            // 
            // txtbx_DefaultSearchPage
            // 
            this.txtbx_DefaultSearchPage.Location = new System.Drawing.Point(12, 192);
            this.txtbx_DefaultSearchPage.Name = "txtbx_DefaultSearchPage";
            this.txtbx_DefaultSearchPage.Size = new System.Drawing.Size(296, 20);
            this.txtbx_DefaultSearchPage.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Default Search Page";
            // 
            // btn_SearchPage
            // 
            this.btn_SearchPage.Location = new System.Drawing.Point(314, 189);
            this.btn_SearchPage.Name = "btn_SearchPage";
            this.btn_SearchPage.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchPage.TabIndex = 9;
            this.btn_SearchPage.Text = "Save Page";
            this.btn_SearchPage.UseVisualStyleBackColor = true;
            this.btn_SearchPage.Click += new System.EventHandler(this.btn_SearchPage_Click);
            // 
            // chxbx_SendDataToServer
            // 
            this.chxbx_SendDataToServer.AutoSize = true;
            this.chxbx_SendDataToServer.Location = new System.Drawing.Point(211, 48);
            this.chxbx_SendDataToServer.Name = "chxbx_SendDataToServer";
            this.chxbx_SendDataToServer.Size = new System.Drawing.Size(147, 17);
            this.chxbx_SendDataToServer.TabIndex = 10;
            this.chxbx_SendDataToServer.Text = "Store Anonymouse Data?";
            this.chxbx_SendDataToServer.UseVisualStyleBackColor = true;
            this.chxbx_SendDataToServer.CheckedChanged += new System.EventHandler(this.chxbx_SendDataToServer_CheckedChanged);
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Location = new System.Drawing.Point(12, 22);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(178, 20);
            this.txtbx_Username.TabIndex = 11;
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Location = new System.Drawing.Point(211, 22);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(178, 20);
            this.txtbx_Password.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // chkbx_BackUpToServer
            // 
            this.chkbx_BackUpToServer.AutoSize = true;
            this.chkbx_BackUpToServer.Location = new System.Drawing.Point(12, 48);
            this.chkbx_BackUpToServer.Name = "chkbx_BackUpToServer";
            this.chkbx_BackUpToServer.Size = new System.Drawing.Size(175, 17);
            this.chkbx_BackUpToServer.TabIndex = 15;
            this.chkbx_BackUpToServer.Text = "Back Up Information to Server?";
            this.chkbx_BackUpToServer.UseVisualStyleBackColor = true;
            this.chkbx_BackUpToServer.CheckedChanged += new System.EventHandler(this.chkbx_BackUpToServer_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 224);
            this.Controls.Add(this.chkbx_BackUpToServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.chxbx_SendDataToServer);
            this.Controls.Add(this.btn_SearchPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_DefaultSearchPage);
            this.Controls.Add(this.btn_LocateCoverLetter);
            this.Controls.Add(this.txtbx_DefaultCoverLetterLocation);
            this.Controls.Add(this.chkbx_UseDefaultCoverLetter);
            this.Controls.Add(this.btn_LocateDefaultResume);
            this.Controls.Add(this.txtbx_DefaultResumeLocation);
            this.Controls.Add(this.chkbx_UseDefaultResume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simple Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbx_UseDefaultResume;
        private System.Windows.Forms.TextBox txtbx_DefaultResumeLocation;
        private System.Windows.Forms.Button btn_LocateDefaultResume;
        private System.Windows.Forms.Button btn_LocateCoverLetter;
        private System.Windows.Forms.TextBox txtbx_DefaultCoverLetterLocation;
        private System.Windows.Forms.CheckBox chkbx_UseDefaultCoverLetter;
        private System.Windows.Forms.TextBox txtbx_DefaultSearchPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SearchPage;
        private System.Windows.Forms.CheckBox chxbx_SendDataToServer;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbx_BackUpToServer;
    }
}