
namespace NoteApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LabelNoteApp = new System.Windows.Forms.Label();
            this.LabelApplicationVersion = new System.Windows.Forms.Label();
            this.LabelApplicationAuthor = new System.Windows.Forms.Label();
            this.LabelFeedbackEmail = new System.Windows.Forms.Label();
            this.LabelGitHub = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LinkLabelFeedbackEmail = new System.Windows.Forms.LinkLabel();
            this.LinkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelNoteApp
            // 
            this.LabelNoteApp.AutoSize = true;
            this.LabelNoteApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteApp.Location = new System.Drawing.Point(12, 9);
            this.LabelNoteApp.Name = "LabelNoteApp";
            this.LabelNoteApp.Size = new System.Drawing.Size(92, 24);
            this.LabelNoteApp.TabIndex = 0;
            this.LabelNoteApp.Text = "NoteApp";
            // 
            // LabelApplicationVersion
            // 
            this.LabelApplicationVersion.AutoSize = true;
            this.LabelApplicationVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelApplicationVersion.Location = new System.Drawing.Point(13, 33);
            this.LabelApplicationVersion.Name = "LabelApplicationVersion";
            this.LabelApplicationVersion.Size = new System.Drawing.Size(55, 17);
            this.LabelApplicationVersion.TabIndex = 1;
            this.LabelApplicationVersion.Text = "v. 1.0.0";
            // 
            // LabelApplicationAuthor
            // 
            this.LabelApplicationAuthor.AutoSize = true;
            this.LabelApplicationAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelApplicationAuthor.Location = new System.Drawing.Point(12, 67);
            this.LabelApplicationAuthor.Name = "LabelApplicationAuthor";
            this.LabelApplicationAuthor.Size = new System.Drawing.Size(132, 17);
            this.LabelApplicationAuthor.TabIndex = 2;
            this.LabelApplicationAuthor.Text = "Author: Yuri Kobzar";
            // 
            // LabelFeedbackEmail
            // 
            this.LabelFeedbackEmail.AutoSize = true;
            this.LabelFeedbackEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFeedbackEmail.Location = new System.Drawing.Point(13, 102);
            this.LabelFeedbackEmail.Name = "LabelFeedbackEmail";
            this.LabelFeedbackEmail.Size = new System.Drawing.Size(134, 17);
            this.LabelFeedbackEmail.TabIndex = 3;
            this.LabelFeedbackEmail.Text = "E-mail for feedback:";
            // 
            // LabelGitHub
            // 
            this.LabelGitHub.AutoSize = true;
            this.LabelGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGitHub.Location = new System.Drawing.Point(13, 129);
            this.LabelGitHub.Name = "LabelGitHub";
            this.LabelGitHub.Size = new System.Drawing.Size(56, 17);
            this.LabelGitHub.TabIndex = 4;
            this.LabelGitHub.Text = "GitHub:";
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCopyright.Location = new System.Drawing.Point(13, 209);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(141, 17);
            this.LabelCopyright.TabIndex = 5;
            this.LabelCopyright.Text = "2022 Yuri Kobzar (C)";
            // 
            // LinkLabelFeedbackEmail
            // 
            this.LinkLabelFeedbackEmail.AutoSize = true;
            this.LinkLabelFeedbackEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabelFeedbackEmail.Location = new System.Drawing.Point(153, 102);
            this.LinkLabelFeedbackEmail.Name = "LinkLabelFeedbackEmail";
            this.LinkLabelFeedbackEmail.Size = new System.Drawing.Size(180, 17);
            this.LinkLabelFeedbackEmail.TabIndex = 6;
            this.LinkLabelFeedbackEmail.TabStop = true;
            this.LinkLabelFeedbackEmail.Text = "urakobzar2001@yandex.ru\r\n";
            // 
            // LinkLabelGitHub
            // 
            this.LinkLabelGitHub.AutoSize = true;
            this.LinkLabelGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabelGitHub.Location = new System.Drawing.Point(75, 129);
            this.LinkLabelGitHub.Name = "LinkLabelGitHub";
            this.LinkLabelGitHub.Size = new System.Drawing.Size(247, 17);
            this.LinkLabelGitHub.TabIndex = 7;
            this.LinkLabelGitHub.TabStop = true;
            this.LinkLabelGitHub.Text = "https://github.com/urakobzar/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(403, 235);
            this.Controls.Add(this.LinkLabelGitHub);
            this.Controls.Add(this.LinkLabelFeedbackEmail);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelGitHub);
            this.Controls.Add(this.LabelFeedbackEmail);
            this.Controls.Add(this.LabelApplicationAuthor);
            this.Controls.Add(this.LabelApplicationVersion);
            this.Controls.Add(this.LabelNoteApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNoteApp;
        private System.Windows.Forms.Label LabelApplicationVersion;
        private System.Windows.Forms.Label LabelApplicationAuthor;
        private System.Windows.Forms.Label LabelFeedbackEmail;
        private System.Windows.Forms.Label LabelGitHub;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.LinkLabel LinkLabelFeedbackEmail;
        private System.Windows.Forms.LinkLabel LinkLabelGitHub;
    }
}