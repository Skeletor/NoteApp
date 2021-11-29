
namespace NoteAppUI
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel_ = new System.Windows.Forms.Label();
            this.CategoryLabel_ = new System.Windows.Forms.Label();
            this.CreatedLabel_ = new System.Windows.Forms.Label();
            this.ModifyTimeLabel_ = new System.Windows.Forms.Label();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextTextBox = new System.Windows.Forms.TextBox();
            this.CreationTimeDisplayer = new System.Windows.Forms.TextBox();
            this.ModifyTimeDisplayer = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel_
            // 
            this.TitleLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel_.AutoSize = true;
            this.TitleLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel_.Location = new System.Drawing.Point(11, 14);
            this.TitleLabel_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel_.Name = "TitleLabel_";
            this.TitleLabel_.Size = new System.Drawing.Size(33, 15);
            this.TitleLabel_.TabIndex = 0;
            this.TitleLabel_.Text = "Title:";
            // 
            // CategoryLabel_
            // 
            this.CategoryLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel_.AutoSize = true;
            this.CategoryLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel_.Location = new System.Drawing.Point(11, 37);
            this.CategoryLabel_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel_.Name = "CategoryLabel_";
            this.CategoryLabel_.Size = new System.Drawing.Size(58, 15);
            this.CategoryLabel_.TabIndex = 1;
            this.CategoryLabel_.Text = "Category:";
            // 
            // CreatedLabel_
            // 
            this.CreatedLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedLabel_.AutoSize = true;
            this.CreatedLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel_.Location = new System.Drawing.Point(11, 62);
            this.CreatedLabel_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedLabel_.Name = "CreatedLabel_";
            this.CreatedLabel_.Size = new System.Drawing.Size(51, 15);
            this.CreatedLabel_.TabIndex = 2;
            this.CreatedLabel_.Text = "Created:";
            // 
            // ModifyTimeLabel_
            // 
            this.ModifyTimeLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyTimeLabel_.AutoSize = true;
            this.ModifyTimeLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeLabel_.Location = new System.Drawing.Point(204, 62);
            this.ModifyTimeLabel_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyTimeLabel_.Name = "ModifyTimeLabel_";
            this.ModifyTimeLabel_.Size = new System.Drawing.Size(102, 15);
            this.ModifyTimeLabel_.TabIndex = 3;
            this.ModifyTimeLabel_.Text = "Last Modify Time:";
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(73, 35);
            this.NoteCategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteCategoryComboBox.MaximumSize = new System.Drawing.Size(98, 0);
            this.NoteCategoryComboBox.MinimumSize = new System.Drawing.Size(98, 0);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(98, 21);
            this.NoteCategoryComboBox.TabIndex = 7;
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NoteNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameTextBox.Location = new System.Drawing.Point(73, 10);
            this.NoteNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(504, 21);
            this.NoteNameTextBox.TabIndex = 6;
            this.NoteNameTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTextTextBox.Location = new System.Drawing.Point(10, 86);
            this.NoteTextTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextTextBox.Size = new System.Drawing.Size(567, 242);
            this.NoteTextTextBox.TabIndex = 8;
            // 
            // CreationTimeDisplayer
            // 
            this.CreationTimeDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreationTimeDisplayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationTimeDisplayer.Location = new System.Drawing.Point(73, 60);
            this.CreationTimeDisplayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreationTimeDisplayer.MaximumSize = new System.Drawing.Size(98, 22);
            this.CreationTimeDisplayer.MinimumSize = new System.Drawing.Size(98, 22);
            this.CreationTimeDisplayer.Name = "CreationTimeDisplayer";
            this.CreationTimeDisplayer.ReadOnly = true;
            this.CreationTimeDisplayer.Size = new System.Drawing.Size(98, 22);
            this.CreationTimeDisplayer.TabIndex = 9;
            // 
            // ModifyTimeDisplayer
            // 
            this.ModifyTimeDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyTimeDisplayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeDisplayer.Location = new System.Drawing.Point(310, 60);
            this.ModifyTimeDisplayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyTimeDisplayer.MaximumSize = new System.Drawing.Size(98, 22);
            this.ModifyTimeDisplayer.MinimumSize = new System.Drawing.Size(98, 22);
            this.ModifyTimeDisplayer.Name = "ModifyTimeDisplayer";
            this.ModifyTimeDisplayer.ReadOnly = true;
            this.ModifyTimeDisplayer.Size = new System.Drawing.Size(98, 22);
            this.ModifyTimeDisplayer.TabIndex = 10;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(423, 332);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OKButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.OKButton.MinimumSize = new System.Drawing.Size(75, 25);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 25);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(502, 332);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.CancelButton.MinimumSize = new System.Drawing.Size(75, 25);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 368);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ModifyTimeDisplayer);
            this.Controls.Add(this.CreationTimeDisplayer);
            this.Controls.Add(this.NoteTextTextBox);
            this.Controls.Add(this.NoteNameTextBox);
            this.Controls.Add(this.NoteCategoryComboBox);
            this.Controls.Add(this.ModifyTimeLabel_);
            this.Controls.Add(this.CreatedLabel_);
            this.Controls.Add(this.CategoryLabel_);
            this.Controls.Add(this.TitleLabel_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(603, 229);
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel_;
        private System.Windows.Forms.Label CategoryLabel_;
        private System.Windows.Forms.Label CreatedLabel_;
        private System.Windows.Forms.Label ModifyTimeLabel_;
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.TextBox NoteTextTextBox;
        private System.Windows.Forms.TextBox CreationTimeDisplayer;
        private System.Windows.Forms.TextBox ModifyTimeDisplayer;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}