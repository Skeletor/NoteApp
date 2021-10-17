using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Главное окно приложения
    /// </summary>
    public partial class MainForm : Form
    {
        private Project project = ProjectManager.LoadFrom();

        public MainForm()
        {
            InitializeComponent();
            FillWithDefault();
            ActivateButtons(false);

            splitContainer1.Panel2.Hide();
        }

        private void FillWithDefault()
        {
            object[] noteCategory = { NoteCategory.JOB, NoteCategory.HOME, NoteCategory.HEALTH_AND_SPORT,
                NoteCategory.PEOPLE, NoteCategory.DOCUMENTS, NoteCategory.FINANCE, NoteCategory.OTHER };

            NoteCategorySelector.Items.Add("ALL");
            NoteCategorySelector.Items.AddRange(noteCategory);
            NoteCategorySelector.SelectedIndex = 0;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            EditNoteForm editForm = new EditNoteForm();

            editForm.FormClosing += (s, e1) =>
            {
                if (editForm.NewNote != null)
                    NoteList.Items.Insert(0, editForm.NewNote.Name);

                UpdateNoteList();
                NoteList.SelectedIndex = NoteList.Items.Count > 0 ? 0 : -1;
            };

            editForm.ShowDialog();
            //UpdateNoteList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Note noteFromList = NoteList.SelectedItem as Note;

            EditNoteForm editForm = new EditNoteForm(noteFromList);

            editForm.FormClosing += (s, e1) =>
            {
                if (editForm.NewNote != null)
                    NoteList.Items.Insert(0, editForm.NewNote);

                UpdateNoteList();
                NoteList.SelectedIndex = NoteList.Items.Count > 0 ? 0 : -1;
            };

            editForm.ShowDialog();

            //UpdateNoteList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = NoteList.SelectedIndex;

            if (index != -1)
            {
                if (MessageBox.Show("Удалить выбранную заметку?", "Удаление", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    NoteList.Items.RemoveAt(index);
                    project.Notes.RemoveAt(index);
                }

                SaveData();
            }
            else
                MessageBox.Show("Не выбрана заметка для удаления", "Удаление");
        }

        private void NoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteList.SelectedIndex != -1)
            {
                Note noteFromList = NoteList.SelectedItem as Note;
                
                splitContainer1.Panel2.Show();
                ActivateButtons(true);

                TitleLabel.Text = noteFromList.Name;
                DescriptionTextBox.Text = noteFromList.NoteText;
                CreationTimeDisplayer.Text = noteFromList.CreationTime.ToString("g");
                ModifyTimeDisplayer.Text = noteFromList.LastModifyTime.ToString("g");
                CategoryLabel.Text = noteFromList.NoteCategory.ToString();
            }
            else
            {
                splitContainer1.Panel2.Hide();
                ActivateButtons(false);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) => UpdateNoteList();

        private void UpdateNoteList()
        {
            LoadData();
            NoteList.Items.Clear();
            
            foreach (var item in project.Notes)
            {
                NoteList.Items.Add(item);
            }
        }

        private void ActivateButtons(bool state)
        {
            EditButton.Enabled = state;
            DeleteButton.Enabled = state;
        }

        private void LoadData() => project = ProjectManager.LoadFrom();

        private void SaveData() => ProjectManager.SaveToFile(project);

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => SaveData();

        private void NoteCategorySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            NoteList.Items.Clear();

            if (NoteCategorySelector.SelectedItem.ToString() == "ALL")
                foreach (var item in project.Notes)
                    NoteList.Items.Add(item);
            else
                foreach (var item in project.Notes)
                    if (item.NoteCategory == (NoteCategory)NoteCategorySelector.SelectedIndex)
                        NoteList.Items.Add(item);
        }

        private void EditMenu_Click(object sender, EventArgs e) => EditButton_Click(sender, e);

        private void ExitMenu_Click(object sender, EventArgs e) => Close();
    }
}
