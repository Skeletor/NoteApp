
namespace NoteAppUI
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
            this.TitleLabel_ = new System.Windows.Forms.Label();
            this.VersionLabel_ = new System.Windows.Forms.Label();
            this.AuthorLabel_ = new System.Windows.Forms.Label();
            this.EmailLabel_ = new System.Windows.Forms.Label();
            this.LinkLabel_ = new System.Windows.Forms.LinkLabel();
            this.GitHubLabel_ = new System.Windows.Forms.Label();
            this.GitHubLinkLabel_ = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel_
            // 
            this.TitleLabel_.AutoSize = true;
            this.TitleLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel_.Location = new System.Drawing.Point(29, 22);
            this.TitleLabel_.Name = "TitleLabel_";
            this.TitleLabel_.Size = new System.Drawing.Size(140, 36);
            this.TitleLabel_.TabIndex = 0;
            this.TitleLabel_.Text = "NoteApp";
            // 
            // VersionLabel_
            // 
            this.VersionLabel_.AutoSize = true;
            this.VersionLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel_.Location = new System.Drawing.Point(30, 58);
            this.VersionLabel_.Name = "VersionLabel_";
            this.VersionLabel_.Size = new System.Drawing.Size(59, 25);
            this.VersionLabel_.TabIndex = 1;
            this.VersionLabel_.Text = "v. 1.5";
            // 
            // AuthorLabel_
            // 
            this.AuthorLabel_.AutoSize = true;
            this.AuthorLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel_.Location = new System.Drawing.Point(30, 104);
            this.AuthorLabel_.Name = "AuthorLabel_";
            this.AuthorLabel_.Size = new System.Drawing.Size(195, 25);
            this.AuthorLabel_.TabIndex = 2;
            this.AuthorLabel_.Text = "Author: Ruslan Belov";
            // 
            // EmailLabel_
            // 
            this.EmailLabel_.AutoSize = true;
            this.EmailLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel_.Location = new System.Drawing.Point(31, 154);
            this.EmailLabel_.Name = "EmailLabel_";
            this.EmailLabel_.Size = new System.Drawing.Size(54, 20);
            this.EmailLabel_.TabIndex = 3;
            this.EmailLabel_.Text = "email:";
            // 
            // LinkLabel_
            // 
            this.LinkLabel_.AutoSize = true;
            this.LinkLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_.Location = new System.Drawing.Point(105, 154);
            this.LinkLabel_.Name = "LinkLabel_";
            this.LinkLabel_.Size = new System.Drawing.Size(179, 20);
            this.LinkLabel_.TabIndex = 4;
            this.LinkLabel_.TabStop = true;
            this.LinkLabel_.Text = "belovruslan15@mail.ru";
            this.LinkLabel_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel__LinkClicked);
            // 
            // GitHubLabel_
            // 
            this.GitHubLabel_.AutoSize = true;
            this.GitHubLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLabel_.Location = new System.Drawing.Point(31, 183);
            this.GitHubLabel_.Name = "GitHubLabel_";
            this.GitHubLabel_.Size = new System.Drawing.Size(67, 20);
            this.GitHubLabel_.TabIndex = 5;
            this.GitHubLabel_.Text = "GitHub:";
            this.GitHubLabel_.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GitHubLinkLabel_
            // 
            this.GitHubLinkLabel_.AutoSize = true;
            this.GitHubLinkLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLinkLabel_.Location = new System.Drawing.Point(105, 183);
            this.GitHubLinkLabel_.Name = "GitHubLinkLabel_";
            this.GitHubLinkLabel_.Size = new System.Drawing.Size(144, 20);
            this.GitHubLinkLabel_.TabIndex = 6;
            this.GitHubLinkLabel_.TabStop = true;
            this.GitHubLinkLabel_.Text = "Skeletor/NoteApp/";
            this.GitHubLinkLabel_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel__LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "2021 Ruslan Belov (c)";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GitHubLinkLabel_);
            this.Controls.Add(this.GitHubLabel_);
            this.Controls.Add(this.LinkLabel_);
            this.Controls.Add(this.EmailLabel_);
            this.Controls.Add(this.AuthorLabel_);
            this.Controls.Add(this.VersionLabel_);
            this.Controls.Add(this.TitleLabel_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel_;
        private System.Windows.Forms.Label VersionLabel_;
        private System.Windows.Forms.Label AuthorLabel_;
        private System.Windows.Forms.Label EmailLabel_;
        private System.Windows.Forms.LinkLabel LinkLabel_;
        private System.Windows.Forms.Label GitHubLabel_;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel_;
        private System.Windows.Forms.Label label1;
    }
}