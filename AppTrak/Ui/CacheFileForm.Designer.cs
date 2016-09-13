namespace AppTrak.Ui
{
    partial class CacheFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacheFileForm));
            this.btn_ViewResume = new System.Windows.Forms.Button();
            this.btn_ViewCoverLetter = new System.Windows.Forms.Button();
            this.btn_ViewCacheWebpage = new System.Windows.Forms.Button();
            this.btn_ViewWebpageImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ViewResume
            // 
            this.btn_ViewResume.Location = new System.Drawing.Point(12, 12);
            this.btn_ViewResume.Name = "btn_ViewResume";
            this.btn_ViewResume.Size = new System.Drawing.Size(239, 30);
            this.btn_ViewResume.TabIndex = 0;
            this.btn_ViewResume.Text = "View Resume";
            this.btn_ViewResume.UseVisualStyleBackColor = true;
            this.btn_ViewResume.Click += new System.EventHandler(this.btn_ViewResume_Click);
            // 
            // btn_ViewCoverLetter
            // 
            this.btn_ViewCoverLetter.Location = new System.Drawing.Point(12, 48);
            this.btn_ViewCoverLetter.Name = "btn_ViewCoverLetter";
            this.btn_ViewCoverLetter.Size = new System.Drawing.Size(239, 30);
            this.btn_ViewCoverLetter.TabIndex = 1;
            this.btn_ViewCoverLetter.Text = "View Cover Letter";
            this.btn_ViewCoverLetter.UseVisualStyleBackColor = true;
            this.btn_ViewCoverLetter.Click += new System.EventHandler(this.btn_ViewCoverLetter_Click);
            // 
            // btn_ViewCacheWebpage
            // 
            this.btn_ViewCacheWebpage.Location = new System.Drawing.Point(12, 84);
            this.btn_ViewCacheWebpage.Name = "btn_ViewCacheWebpage";
            this.btn_ViewCacheWebpage.Size = new System.Drawing.Size(239, 30);
            this.btn_ViewCacheWebpage.TabIndex = 2;
            this.btn_ViewCacheWebpage.Text = "View Webpage";
            this.btn_ViewCacheWebpage.UseVisualStyleBackColor = true;
            this.btn_ViewCacheWebpage.Click += new System.EventHandler(this.btn_ViewCacheWebpage_Click);
            // 
            // btn_ViewWebpageImage
            // 
            this.btn_ViewWebpageImage.Location = new System.Drawing.Point(12, 120);
            this.btn_ViewWebpageImage.Name = "btn_ViewWebpageImage";
            this.btn_ViewWebpageImage.Size = new System.Drawing.Size(239, 30);
            this.btn_ViewWebpageImage.TabIndex = 3;
            this.btn_ViewWebpageImage.Text = "View Webpage Image";
            this.btn_ViewWebpageImage.UseVisualStyleBackColor = true;
            this.btn_ViewWebpageImage.Click += new System.EventHandler(this.btn_ViewWebpageImage_Click);
            // 
            // CacheFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 161);
            this.Controls.Add(this.btn_ViewWebpageImage);
            this.Controls.Add(this.btn_ViewCacheWebpage);
            this.Controls.Add(this.btn_ViewCoverLetter);
            this.Controls.Add(this.btn_ViewResume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CacheFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Opportunity File Viewer";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ViewResume;
        private System.Windows.Forms.Button btn_ViewCoverLetter;
        private System.Windows.Forms.Button btn_ViewCacheWebpage;
        private System.Windows.Forms.Button btn_ViewWebpageImage;
    }
}