
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
            this.SuperSecretHiddenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel_
            // 
            this.TitleLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel_.AutoSize = true;
            this.TitleLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel_.Location = new System.Drawing.Point(15, 17);
            this.TitleLabel_.Name = "TitleLabel_";
            this.TitleLabel_.Size = new System.Drawing.Size(41, 20);
            this.TitleLabel_.TabIndex = 0;
            this.TitleLabel_.Text = "Title:";
            // 
            // CategoryLabel_
            // 
            this.CategoryLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel_.AutoSize = true;
            this.CategoryLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel_.Location = new System.Drawing.Point(15, 46);
            this.CategoryLabel_.Name = "CategoryLabel_";
            this.CategoryLabel_.Size = new System.Drawing.Size(72, 20);
            this.CategoryLabel_.TabIndex = 1;
            this.CategoryLabel_.Text = "Category:";
            // 
            // CreatedLabel_
            // 
            this.CreatedLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedLabel_.AutoSize = true;
            this.CreatedLabel_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel_.Location = new System.Drawing.Point(15, 76);
            this.CreatedLabel_.Name = "CreatedLabel_";
            this.CreatedLabel_.Size = new System.Drawing.Size(64, 20);
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
            this.ModifyTimeLabel_.Location = new System.Drawing.Point(272, 76);
            this.ModifyTimeLabel_.Name = "ModifyTimeLabel_";
            this.ModifyTimeLabel_.Size = new System.Drawing.Size(126, 20);
            this.ModifyTimeLabel_.TabIndex = 3;
            this.ModifyTimeLabel_.Text = "Last Modify Time:";
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(97, 43);
            this.NoteCategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteCategoryComboBox.MaximumSize = new System.Drawing.Size(129, 0);
            this.NoteCategoryComboBox.MinimumSize = new System.Drawing.Size(129, 0);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(129, 24);
            this.NoteCategoryComboBox.TabIndex = 7;
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NoteNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameTextBox.Location = new System.Drawing.Point(97, 12);
            this.NoteNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(671, 24);
            this.NoteNameTextBox.TabIndex = 6;
            this.NoteNameTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTextTextBox.Location = new System.Drawing.Point(13, 106);
            this.NoteTextTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextTextBox.Size = new System.Drawing.Size(755, 297);
            this.NoteTextTextBox.TabIndex = 8;
            // 
            // CreationTimeDisplayer
            // 
            this.CreationTimeDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreationTimeDisplayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationTimeDisplayer.Location = new System.Drawing.Point(97, 74);
            this.CreationTimeDisplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreationTimeDisplayer.MaximumSize = new System.Drawing.Size(129, 22);
            this.CreationTimeDisplayer.MinimumSize = new System.Drawing.Size(129, 22);
            this.CreationTimeDisplayer.Name = "CreationTimeDisplayer";
            this.CreationTimeDisplayer.ReadOnly = true;
            this.CreationTimeDisplayer.Size = new System.Drawing.Size(129, 26);
            this.CreationTimeDisplayer.TabIndex = 9;
            this.CreationTimeDisplayer.GotFocus += new System.EventHandler(CreationTimeDisplayer_GotFocus);
            // 
            // ModifyTimeDisplayer
            // 
            this.ModifyTimeDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyTimeDisplayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeDisplayer.Location = new System.Drawing.Point(413, 74);
            this.ModifyTimeDisplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyTimeDisplayer.MaximumSize = new System.Drawing.Size(129, 22);
            this.ModifyTimeDisplayer.MinimumSize = new System.Drawing.Size(129, 22);
            this.ModifyTimeDisplayer.Name = "ModifyTimeDisplayer";
            this.ModifyTimeDisplayer.ReadOnly = true;
            this.ModifyTimeDisplayer.Size = new System.Drawing.Size(129, 26);
            this.ModifyTimeDisplayer.TabIndex = 10;
            this.ModifyTimeDisplayer.GotFocus += new System.EventHandler(ModifyTimeDisplayer_GotFocus);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(564, 409);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKButton.MaximumSize = new System.Drawing.Size(100, 31);
            this.OKButton.MinimumSize = new System.Drawing.Size(100, 31);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 31);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(669, 409);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.MaximumSize = new System.Drawing.Size(100, 31);
            this.CancelButton.MinimumSize = new System.Drawing.Size(100, 31);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 31);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SuperSecretHiddenLabel
            // 
            this.SuperSecretHiddenLabel.AutoSize = true;
            this.SuperSecretHiddenLabel.Location = new System.Drawing.Point(712, 61);
            this.SuperSecretHiddenLabel.Name = "SuperSecretHiddenLabel";
            this.SuperSecretHiddenLabel.Size = new System.Drawing.Size(0, 17);
            this.SuperSecretHiddenLabel.TabIndex = 13;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.SuperSecretHiddenLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(798, 271);
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
        private System.Windows.Forms.Label SuperSecretHiddenLabel;
    }
}