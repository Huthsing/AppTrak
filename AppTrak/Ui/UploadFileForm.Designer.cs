namespace AppTrak.Ui
{
    partial class UploadFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadFileForm));
            this.btn_GetResume = new System.Windows.Forms.Button();
            this.txtbx_Resume = new System.Windows.Forms.TextBox();
            this.txtbx_CoverLetter = new System.Windows.Forms.TextBox();
            this.btn_GetCoverLetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetResume
            // 
            this.btn_GetResume.Location = new System.Drawing.Point(14, 14);
            this.btn_GetResume.Name = "btn_GetResume";
            this.btn_GetResume.Size = new System.Drawing.Size(87, 27);
            this.btn_GetResume.TabIndex = 0;
            this.btn_GetResume.Text = "Resume";
            this.btn_GetResume.UseVisualStyleBackColor = true;
            this.btn_GetResume.Click += new System.EventHandler(this.btn_GetResume_Click);
            // 
            // txtbx_Resume
            // 
            this.txtbx_Resume.Location = new System.Drawing.Point(108, 16);
            this.txtbx_Resume.Name = "txtbx_Resume";
            this.txtbx_Resume.Size = new System.Drawing.Size(349, 23);
            this.txtbx_Resume.TabIndex = 1;
            // 
            // txtbx_CoverLetter
            // 
            this.txtbx_CoverLetter.Location = new System.Drawing.Point(108, 47);
            this.txtbx_CoverLetter.Name = "txtbx_CoverLetter";
            this.txtbx_CoverLetter.Size = new System.Drawing.Size(349, 23);
            this.txtbx_CoverLetter.TabIndex = 3;
            // 
            // btn_GetCoverLetter
            // 
            this.btn_GetCoverLetter.Location = new System.Drawing.Point(14, 45);
            this.btn_GetCoverLetter.Name = "btn_GetCoverLetter";
            this.btn_GetCoverLetter.Size = new System.Drawing.Size(87, 27);
            this.btn_GetCoverLetter.TabIndex = 2;
            this.btn_GetCoverLetter.Text = "Cover Letter";
            this.btn_GetCoverLetter.UseVisualStyleBackColor = true;
            this.btn_GetCoverLetter.Click += new System.EventHandler(this.btn_GetCoverLetter_Click);
            // 
            // UploadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 82);
            this.Controls.Add(this.txtbx_CoverLetter);
            this.Controls.Add(this.btn_GetCoverLetter);
            this.Controls.Add(this.txtbx_Resume);
            this.Controls.Add(this.btn_GetResume);
            this.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Upload Resume and Cover Letter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetResume;
        private System.Windows.Forms.TextBox txtbx_Resume;
        private System.Windows.Forms.TextBox txtbx_CoverLetter;
        private System.Windows.Forms.Button btn_GetCoverLetter;
    }
}