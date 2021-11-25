﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Главное окно приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная для хранения всех заметок
        /// </summary>
        private Project Project { get; set; }

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FillWithDefault();
            UpdateNoteList();
            ActivateButtons(false);

            NoteList.SelectedItem = Project.CurrentNote;
        }

        /// <summary>
        /// Заполнение некоторых элементов стандартными значениями
        /// </summary>
        private void FillWithDefault()
        {
            NoteCategorySelector.Items.AddRange(new object[] {
                "All",
                NoteCategory.Job,
                NoteCategory.Home,
                NoteCategory.HealthAndSport,
                NoteCategory.People,
                NoteCategory.Documents,
                NoteCategory.Finance,
                NoteCategory.Other 
            });

            NoteCategorySelector.SelectedIndex = 0;
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "Add"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (EditNoteForm editForm = new EditNoteForm())
            {
                editForm.FormClosing += (s, e1) =>
                {
                    if (editForm.NewNote != null)
                    {
                        NoteList.Items.Insert(0, editForm.NewNote.Name);
                    }

                    UpdateNoteList();
                    SortList();
                    NoteList.SelectedIndex = NoteList.Items.Count > 0 ? 0 : -1;
                };

                editForm.ShowDialog();
            }
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "Edit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            Note noteFromList = NoteList.SelectedItem as Note;

            int noteIndex = noteFromList is null ? 0 : NoteList.Items.IndexOf(noteFromList);

            using (EditNoteForm editForm = new EditNoteForm(noteFromList))
            {
                editForm.FormClosing += (s, e1) =>
                {
                    if (editForm.NewNote != null)
                    {
                        NoteList.Items.Insert(noteIndex, editForm.NewNote);
                    }

                    UpdateNoteList();
                    SortList();
                    NoteList.SelectedIndex = NoteList.Items.Count > 0 ? noteIndex : -1;
                };

                editForm.ShowDialog();
            }
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "Delete"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = NoteList.SelectedIndex;

            if (index != -1)
            {
                if (MessageBox.Show("Delete the selected note?", "Removing", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    NoteList.Items.RemoveAt(index);
                    Project.Notes.RemoveAt(index);
                }

                SaveData();
            }
            else
            {
                MessageBox.Show("No note is chosen to delete", "Removing");
            }
        }

        /// <summary>
        /// Происходит при изменении выбора элемента в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteList.SelectedItem is Note noteFromList)
            {
                ActivateButtons(true);
                FillPanel2(noteFromList);
            }
            else
            {
                ActivateButtons(false);
            }

            Project.CurrentNote = NoteList.SelectedItem as Note;
        }

        /// <summary>
        /// Заполняет панель справа данными о заметке
        /// </summary>
        /// <param name="note">Заметка, данные о которой нужно передать</param>
        private void FillPanel2(Note note)
        {
            TitleLabel.Text = note.Name;
            DescriptionTextBox.Text = note.NoteText;
            CreationTimeDisplayer.Text = note.CreationTime.ToString("g");
            ModifyTimeDisplayer.Text = note.LastModifyTime.ToString("g");
            CategoryLabel.Text = note.NoteCategory.ToString();
        }

        /// <summary>
        /// Обновляет показ списка заметок
        /// </summary>
        private void UpdateNoteList()
        {
            LoadData();
            NoteList.Items.Clear();

            foreach (var item in Project.Notes)
            {
                NoteList.Items.Add(item);
            }
        }
        
        /// <summary>
        /// Задает видимость кнопок "Edit" и "Delete"
        /// </summary>
        /// <param name="state">Если true, делает видимыми кнопки, иначе - скрывает</param>
        private void ActivateButtons(bool state)
        {
            if (EditButton.Enabled != state && DeleteButton.Enabled != state)
            {
                EditButton.Enabled = state;
                DeleteButton.Enabled = state;
            }
        }

        /// <summary>
        /// Загрузить данные с файла
        /// </summary>
        private void LoadData() => Project = ProjectManager.LoadFrom();

        /// <summary>
        /// Сохранить данные в файл
        /// </summary>
        private void SaveData() => ProjectManager.SaveTo(Project);

        /// <summary>
        /// Происходит при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => SaveData();

        /// <summary>
        /// Происходит при изменении выбора элемента категории заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteCategorySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            SortList();
        }

        /// <summary>
        /// Отображает только те заметки, что совпадают с выбранной в списке категорией
        /// </summary>
        private void SortList()
        {
            NoteList.Items.Clear();

            if (NoteCategorySelector.SelectedItem.ToString() == "All")
            {
                var sorted = Project.SortProject(Project);

                foreach (var item in sorted.Notes)
                {
                    NoteList.Items.Add(item);
                }
            }
            else
            {
                var sorted = Project.SortProject(Project, (NoteCategory)NoteCategorySelector.SelectedIndex);

                foreach (var item in sorted.Notes)
                {
                    NoteList.Items.Add(item);
                }
            }
        }
        
        /// <summary>
        /// Происходит при нажатии на кнопку "Exit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenu_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Происходит при нажатии на кнопку "About"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            if (!AboutForm.IsShown)
            {
                new AboutForm().Show();
            }
        }

        /// <summary>
        /// Происходит, когда пользователь пытается нажать на окно описания заметки для ее редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBox_Enter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(DescriptionTextBox, "In order to redact the note press the \"Edit\" button in the" +
                " lower left corner");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) => CreateButton_Click(sender, e);

        private void editToolStripMenuItem_Click(object sender, EventArgs e) => EditButton_Click(sender, e);

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => DeleteButton_Click(sender, e);

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SortList();
        }
    }
}
