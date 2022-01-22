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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel_ = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NoteTextTextBox = new System.Windows.Forms.TextBox();
            this.ModifyTimeLabel_ = new System.Windows.Forms.Label();
            this.ModifyTimeDisplayer = new System.Windows.Forms.TextBox();
            this.CreationTimeDisplayer = new System.Windows.Forms.TextBox();
            this.CreatedLabel_ = new System.Windows.Forms.Label();
            this.CategoryLabelStatic_ = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
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
            this.FileMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(43, 26);
            this.FileMenu.Text = "File";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(113, 26);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1061, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.EditMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(46, 26);
            this.EditMenu.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.newToolStripMenuItem.Text = "Add";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(61, 26);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.CreateButton);
            this.splitContainer1.Panel1.Controls.Add(this.NoteListBox);
            this.splitContainer1.Panel1.Controls.Add(this.NoteCategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTextTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyTimeLabel_);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyTimeDisplayer);
            this.splitContainer1.Panel2.Controls.Add(this.CreationTimeDisplayer);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel_);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabelStatic_);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 625);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 1;
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.IntegralHeight = false;
            this.NoteListBox.ItemHeight = 20;
            this.NoteListBox.Location = new System.Drawing.Point(15, 34);
            this.NoteListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(351, 528);
            this.NoteListBox.TabIndex = 2;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteList_SelectedIndexChanged);
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(137, 4);
            this.NoteCategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteCategoryComboBox.MaxDropDownItems = 7;
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(229, 24);
            this.NoteCategoryComboBox.TabIndex = 1;
            this.NoteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.NoteCategoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel_
            // 
            this.ShowCategoryLabel_.AutoSize = true;
            this.ShowCategoryLabel_.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCategoryLabel_.Location = new System.Drawing.Point(15, 7);
            this.ShowCategoryLabel_.Name = "ShowCategoryLabel_";
            this.ShowCategoryLabel_.Size = new System.Drawing.Size(105, 19);
            this.ShowCategoryLabel_.TabIndex = 0;
            this.ShowCategoryLabel_.Text = "Show Category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(87, 57);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(0, 19);
            this.CategoryLabel.TabIndex = 7;
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NoteTextTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTextTextBox.Location = new System.Drawing.Point(3, 126);
            this.NoteTextTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.ReadOnly = true;
            this.NoteTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextTextBox.Size = new System.Drawing.Size(673, 485);
            this.NoteTextTextBox.TabIndex = 6;
            this.NoteTextTextBox.Enter += new System.EventHandler(this.DescriptionTextBox_Enter);
            // 
            // ModifyTimeLabel_
            // 
            this.ModifyTimeLabel_.AutoSize = true;
            this.ModifyTimeLabel_.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeLabel_.Location = new System.Drawing.Point(247, 86);
            this.ModifyTimeLabel_.Name = "ModifyTimeLabel_";
            this.ModifyTimeLabel_.Size = new System.Drawing.Size(117, 19);
            this.ModifyTimeLabel_.TabIndex = 5;
            this.ModifyTimeLabel_.Text = "Last Modify Time:";
            // 
            // ModifyTimeDisplayer
            // 
            this.ModifyTimeDisplayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModifyTimeDisplayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeDisplayer.Location = new System.Drawing.Point(379, 82);
            this.ModifyTimeDisplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyTimeDisplayer.Name = "ModifyTimeDisplayer";
            this.ModifyTimeDisplayer.ReadOnly = true;
            this.ModifyTimeDisplayer.Size = new System.Drawing.Size(129, 26);
            this.ModifyTimeDisplayer.TabIndex = 4;
            this.ModifyTimeDisplayer.GotFocus += new System.EventHandler(this.ModifyTimeDisplayer_GotFocus);
            // 
            // CreationTimeDisplayer
            // 
            this.CreationTimeDisplayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreationTimeDisplayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationTimeDisplayer.Location = new System.Drawing.Point(75, 82);
            this.CreationTimeDisplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreationTimeDisplayer.Name = "CreationTimeDisplayer";
            this.CreationTimeDisplayer.ReadOnly = true;
            this.CreationTimeDisplayer.Size = new System.Drawing.Size(129, 26);
            this.CreationTimeDisplayer.TabIndex = 3;
            this.CreationTimeDisplayer.GotFocus += new System.EventHandler(this.CreationTimeDisplayer_GotFocus);
            // 
            // CreatedLabel_
            // 
            this.CreatedLabel_.AutoSize = true;
            this.CreatedLabel_.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel_.Location = new System.Drawing.Point(3, 86);
            this.CreatedLabel_.Name = "CreatedLabel_";
            this.CreatedLabel_.Size = new System.Drawing.Size(60, 19);
            this.CreatedLabel_.TabIndex = 2;
            this.CreatedLabel_.Text = "Created:";
            // 
            // CategoryLabelStatic_
            // 
            this.CategoryLabelStatic_.AutoSize = true;
            this.CategoryLabelStatic_.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabelStatic_.Location = new System.Drawing.Point(3, 57);
            this.CategoryLabelStatic_.Name = "CategoryLabelStatic_";
            this.CategoryLabelStatic_.Size = new System.Drawing.Size(68, 19);
            this.CategoryLabelStatic_.TabIndex = 1;
            this.CategoryLabelStatic_.Text = "Category:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(3, 7);
            this.TitleLabel.MaximumSize = new System.Drawing.Size(589, 46);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(589, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 4000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 100;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.icons8_delete_480;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(116, 569);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(45, 46);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(45, 46);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(45, 46);
            this.DeleteButton.TabIndex = 5;
            this.toolTip.SetToolTip(this.DeleteButton, "Delete");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackgroundImage = global::NoteAppUI.Properties.Resources.icons8_edit_500;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(65, 569);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.MaximumSize = new System.Drawing.Size(45, 46);
            this.EditButton.MinimumSize = new System.Drawing.Size(45, 46);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(45, 46);
            this.EditButton.TabIndex = 4;
            this.toolTip.SetToolTip(this.EditButton, "Edit");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.BackgroundImage = global::NoteAppUI.Properties.Resources.icons8_note_50;
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(15, 569);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.MaximumSize = new System.Drawing.Size(45, 46);
            this.CreateButton.MinimumSize = new System.Drawing.Size(45, 46);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(45, 46);
            this.CreateButton.TabIndex = 3;
            this.toolTip.SetToolTip(this.CreateButton, "Add");
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 654);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(997, 294);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabelStatic_;
        private System.Windows.Forms.Label CreatedLabel_;
        private System.Windows.Forms.TextBox CreationTimeDisplayer;
        private System.Windows.Forms.Label ModifyTimeLabel_;
        private System.Windows.Forms.TextBox ModifyTimeDisplayer;
        private System.Windows.Forms.TextBox NoteTextTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

