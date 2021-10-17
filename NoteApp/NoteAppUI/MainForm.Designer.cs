using NoteApp;

namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.NoteList = new System.Windows.Forms.ListBox();
            this.NoteCategorySelector = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel_ = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ModifyTimeLabel_ = new System.Windows.Forms.Label();
            this.ModifyTimeDisplayer = new System.Windows.Forms.TextBox();
            this.CreationTimeDisplayer = new System.Windows.Forms.TextBox();
            this.CreatedLabel_ = new System.Windows.Forms.Label();
            this.CategoryLabelStatic_ = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 26);
            this.FileMenu.Text = "File";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(224, 26);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.AboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditMenu
            // 
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(49, 24);
            this.EditMenu.Text = "Edit";
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(64, 24);
            this.AboutMenu.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.CreateButton);
            this.splitContainer1.Panel1.Controls.Add(this.NoteList);
            this.splitContainer1.Panel1.Controls.Add(this.NoteCategorySelector);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.DescriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyTimeLabel_);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyTimeDisplayer);
            this.splitContainer1.Panel2.Controls.Add(this.CreationTimeDisplayer);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel_);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabelStatic_);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1029, 583);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(249, 509);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 30);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(148, 509);
            this.EditButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 30);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(47, 509);
            this.CreateButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(85, 30);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "New";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // NoteList
            // 
            this.NoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteList.FormattingEnabled = true;
            this.NoteList.ItemHeight = 20;
            this.NoteList.Location = new System.Drawing.Point(13, 53);
            this.NoteList.Name = "NoteList";
            this.NoteList.Size = new System.Drawing.Size(384, 424);
            this.NoteList.TabIndex = 2;
            this.NoteList.SelectedIndexChanged += new System.EventHandler(this.NoteList_SelectedIndexChanged);
            // 
            // NoteCategorySelector
            // 
            this.NoteCategorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategorySelector.FormattingEnabled = true;
            this.NoteCategorySelector.Location = new System.Drawing.Point(124, 7);
            this.NoteCategorySelector.MaxDropDownItems = 7;
            this.NoteCategorySelector.Name = "NoteCategorySelector";
            this.NoteCategorySelector.Size = new System.Drawing.Size(212, 24);
            this.NoteCategorySelector.TabIndex = 1;
            this.NoteCategorySelector.SelectedIndexChanged += new System.EventHandler(this.NoteCategorySelector_SelectedIndexChanged);
            // 
            // ShowCategoryLabel_
            // 
            this.ShowCategoryLabel_.AutoSize = true;
            this.ShowCategoryLabel_.Location = new System.Drawing.Point(13, 10);
            this.ShowCategoryLabel_.Name = "ShowCategoryLabel_";
            this.ShowCategoryLabel_.Size = new System.Drawing.Size(107, 17);
            this.ShowCategoryLabel_.TabIndex = 0;
            this.ShowCategoryLabel_.Text = "Show Category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(101, 59);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(0, 17);
            this.CategoryLabel.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(17, 126);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(583, 445);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // ModifyTimeLabel_
            // 
            this.ModifyTimeLabel_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModifyTimeLabel_.AutoSize = true;
            this.ModifyTimeLabel_.Location = new System.Drawing.Point(269, 89);
            this.ModifyTimeLabel_.Name = "ModifyTimeLabel_";
            this.ModifyTimeLabel_.Size = new System.Drawing.Size(119, 17);
            this.ModifyTimeLabel_.TabIndex = 5;
            this.ModifyTimeLabel_.Text = "Last Modify Time:";
            // 
            // ModifyTimeDisplayer
            // 
            this.ModifyTimeDisplayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModifyTimeDisplayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModifyTimeDisplayer.Location = new System.Drawing.Point(394, 86);
            this.ModifyTimeDisplayer.Name = "ModifyTimeDisplayer";
            this.ModifyTimeDisplayer.ReadOnly = true;
            this.ModifyTimeDisplayer.Size = new System.Drawing.Size(130, 22);
            this.ModifyTimeDisplayer.TabIndex = 4;
            this.ModifyTimeDisplayer.Text = "15.10.2021";
            // 
            // CreationTimeDisplayer
            // 
            this.CreationTimeDisplayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreationTimeDisplayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreationTimeDisplayer.Location = new System.Drawing.Point(110, 86);
            this.CreationTimeDisplayer.Name = "CreationTimeDisplayer";
            this.CreationTimeDisplayer.ReadOnly = true;
            this.CreationTimeDisplayer.Size = new System.Drawing.Size(130, 22);
            this.CreationTimeDisplayer.TabIndex = 3;
            this.CreationTimeDisplayer.Text = "15.10.2021";
            // 
            // CreatedLabel_
            // 
            this.CreatedLabel_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreatedLabel_.AutoSize = true;
            this.CreatedLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel_.Location = new System.Drawing.Point(28, 89);
            this.CreatedLabel_.Name = "CreatedLabel_";
            this.CreatedLabel_.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel_.TabIndex = 2;
            this.CreatedLabel_.Text = "Created:";
            // 
            // CategoryLabelStatic_
            // 
            this.CategoryLabelStatic_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryLabelStatic_.AutoSize = true;
            this.CategoryLabelStatic_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabelStatic_.Location = new System.Drawing.Point(28, 59);
            this.CategoryLabelStatic_.Name = "CategoryLabelStatic_";
            this.CategoryLabelStatic_.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabelStatic_.TabIndex = 1;
            this.CategoryLabelStatic_.Text = "Category:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(177, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(224, 35);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "This is a test label";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 280);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ShowCategoryLabel_;
        private System.Windows.Forms.ComboBox NoteCategorySelector;
        private System.Windows.Forms.ListBox NoteList;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabelStatic_;
        private System.Windows.Forms.Label CreatedLabel_;
        private System.Windows.Forms.TextBox CreationTimeDisplayer;
        private System.Windows.Forms.Label ModifyTimeLabel_;
        private System.Windows.Forms.TextBox ModifyTimeDisplayer;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label CategoryLabel;
    }
}

