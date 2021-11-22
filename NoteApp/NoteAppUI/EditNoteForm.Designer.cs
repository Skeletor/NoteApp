
namespace NoteAppUI
{
    partial class EditNoteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNoteForm));
            this.TitleLabel_ = new System.Windows.Forms.Label();
            this.CategoryLabel_ = new System.Windows.Forms.Label();
            this.CreatedLabel_ = new System.Windows.Forms.Label();
            this.ModifyTimeLabel_ = new System.Windows.Forms.Label();
            this.CategorySelector = new System.Windows.Forms.ComboBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CreationTimeDisplayer = new System.Windows.Forms.TextBox();
            this.ModifyTimeDisplayer = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ChangeColorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TitleLabel_
            // 
            this.TitleLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel_.AutoSize = true;
            this.TitleLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel_.Location = new System.Drawing.Point(12, 15);
            this.TitleLabel_.Name = "TitleLabel_";
            this.TitleLabel_.Size = new System.Drawing.Size(39, 18);
            this.TitleLabel_.TabIndex = 0;
            this.TitleLabel_.Text = "Title:";
            // 
            // CategoryLabel_
            // 
            this.CategoryLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel_.AutoSize = true;
            this.CategoryLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel_.Location = new System.Drawing.Point(12, 43);
            this.CategoryLabel_.Name = "CategoryLabel_";
            this.CategoryLabel_.Size = new System.Drawing.Size(72, 18);
            this.CategoryLabel_.TabIndex = 1;
            this.CategoryLabel_.Text = "Category:";
            // 
            // CreatedLabel_
            // 
            this.CreatedLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedLabel_.AutoSize = true;
            this.CreatedLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel_.Location = new System.Drawing.Point(12, 73);
            this.CreatedLabel_.Name = "CreatedLabel_";
            this.CreatedLabel_.Size = new System.Drawing.Size(64, 18);
            this.CreatedLabel_.TabIndex = 2;
            this.CreatedLabel_.Text = "Created:";
            // 
            // ModifyTimeLabel_
            // 
            this.ModifyTimeLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyTimeLabel_.AutoSize = true;
            this.ModifyTimeLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeLabel_.Location = new System.Drawing.Point(247, 73);
            this.ModifyTimeLabel_.Name = "ModifyTimeLabel_";
            this.ModifyTimeLabel_.Size = new System.Drawing.Size(125, 18);
            this.ModifyTimeLabel_.TabIndex = 3;
            this.ModifyTimeLabel_.Text = "Last Modify Time:";
            // 
            // CategorySelector
            // 
            this.CategorySelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorySelector.FormattingEnabled = true;
            this.CategorySelector.Location = new System.Drawing.Point(91, 42);
            this.CategorySelector.MaximumSize = new System.Drawing.Size(130, 0);
            this.CategorySelector.MinimumSize = new System.Drawing.Size(130, 0);
            this.CategorySelector.Name = "CategorySelector";
            this.CategorySelector.Size = new System.Drawing.Size(130, 24);
            this.CategorySelector.TabIndex = 7;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTextBox.Location = new System.Drawing.Point(91, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(679, 24);
            this.TitleTextBox.TabIndex = 6;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(13, 100);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(757, 310);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // CreationTimeDisplayer
            // 
            this.CreationTimeDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreationTimeDisplayer.Location = new System.Drawing.Point(91, 72);
            this.CreationTimeDisplayer.MaximumSize = new System.Drawing.Size(130, 22);
            this.CreationTimeDisplayer.MinimumSize = new System.Drawing.Size(100, 22);
            this.CreationTimeDisplayer.Name = "CreationTimeDisplayer";
            this.CreationTimeDisplayer.ReadOnly = true;
            this.CreationTimeDisplayer.Size = new System.Drawing.Size(130, 22);
            this.CreationTimeDisplayer.TabIndex = 9;
            // 
            // ModifyTimeDisplayer
            // 
            this.ModifyTimeDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyTimeDisplayer.Location = new System.Drawing.Point(384, 72);
            this.ModifyTimeDisplayer.MaximumSize = new System.Drawing.Size(125, 22);
            this.ModifyTimeDisplayer.MinimumSize = new System.Drawing.Size(100, 22);
            this.ModifyTimeDisplayer.Name = "ModifyTimeDisplayer";
            this.ModifyTimeDisplayer.ReadOnly = true;
            this.ModifyTimeDisplayer.Size = new System.Drawing.Size(125, 22);
            this.ModifyTimeDisplayer.TabIndex = 10;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(12, 416);
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
            this.CancelButton.Location = new System.Drawing.Point(93, 416);
            this.CancelButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.CancelButton.MinimumSize = new System.Drawing.Size(75, 25);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChangeColorTimer
            // 
            this.ChangeColorTimer.Interval = 333;
            this.ChangeColorTimer.Tick += new System.EventHandler(this.ChangeColorTimer_Tick);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ModifyTimeDisplayer);
            this.Controls.Add(this.CreationTimeDisplayer);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CategorySelector);
            this.Controls.Add(this.ModifyTimeLabel_);
            this.Controls.Add(this.CreatedLabel_);
            this.Controls.Add(this.CategoryLabel_);
            this.Controls.Add(this.TitleLabel_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 275);
            this.Name = "EditNoteForm";
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
        private System.Windows.Forms.ComboBox CategorySelector;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox CreationTimeDisplayer;
        private System.Windows.Forms.TextBox ModifyTimeDisplayer;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Timer ChangeColorTimer;
    }
}