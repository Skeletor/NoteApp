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
        /// <summary>
        /// Хранилище всех заметок
        /// </summary>
        private Project Proj { get; set; }

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FillWithDefault();
            UpdateNoteList();
            ActivateButtons(false);

            splitContainer1.Panel2.Hide();
        }

        /// <summary>
        /// Заполнение некоторых элементов стендартными значениями
        /// </summary>
        private void FillWithDefault()
        {
            object[] noteCategory = { NoteCategory.Job, NoteCategory.Home, NoteCategory.HealthAndSport,
                NoteCategory.People, NoteCategory.Documents, NoteCategory.Finance, NoteCategory.Other };

            NoteCategorySelector.Items.Add("All");
            NoteCategorySelector.Items.AddRange(noteCategory);
            NoteCategorySelector.SelectedIndex = 0;
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "New"
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
                    SortByCategory();
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
            int noteIndex = 0;
            Note noteFromList = NoteList.SelectedItem as Note;

            noteIndex = noteFromList is null ? 0 : NoteList.Items.IndexOf(noteFromList);

            using (EditNoteForm editForm = new EditNoteForm(noteFromList))
            {
                editForm.FormClosing += (s, e1) =>
                {
                    if (editForm.NewNote != null)
                    {
                        NoteList.Items.Insert(noteIndex, editForm.NewNote);
                    }

                    UpdateNoteList();
                    SortByCategory();
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
                if (MessageBox.Show("Удалить выбранную заметку?", "Удаление", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    NoteList.Items.RemoveAt(index);
                    Proj.Notes.RemoveAt(index);
                }

                SaveData();
            }
            else
            {
                MessageBox.Show("Не выбрана заметка для удаления", "Удаление");
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
                splitContainer1.Panel2.Show();
                ActivateButtons(true);
                FillPanel2(noteFromList);
            }
            else
            {
                splitContainer1.Panel2.Hide();
                ActivateButtons(false);
            }
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

            foreach (var item in Proj.Notes)
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
            EditButton.Enabled = state;
            DeleteButton.Enabled = state;
        }

        /// <summary>
        /// Загрузить данные с файла
        /// </summary>
        private void LoadData() => Proj = ProjectManager.LoadFrom();

        /// <summary>
        /// Сохранить данные в файл
        /// </summary>
        private void SaveData() => ProjectManager.SaveTo(Proj);

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
            SortByCategory();
        }

        /// <summary>
        /// Отображает только те заметки, что совпадают с выбранной в списке категорией
        /// </summary>
        private void SortByCategory()
        {
            NoteList.Items.Clear();

            if (NoteCategorySelector.SelectedItem.ToString() == "All")
            {
                foreach (var item in Proj.Notes)
                {
                    NoteList.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in Proj.Notes)
                {
                    if (item.NoteCategory == (NoteCategory)NoteCategorySelector.SelectedIndex)
                    {
                        NoteList.Items.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "Edit" (сверху)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenu_Click(object sender, EventArgs e) => EditButton_Click(sender, e);

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
        /// !!! ТЕСТ-МЕТОД - УДАЛИТЬ ПОСЛЕ ТЕСТОВ !!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Proj = ProjectManager.LoadFrom();
            string defaultName = "Без названия";

            for (int i = 0; i < 201; ++i)
                Proj.Notes.Add(new Note(defaultName + i.ToString()));

            foreach (var item in Proj.Notes)
            {
                NoteList.Items.Add(item);
            }

            SaveData();
        }

        /// <summary>
        /// !!! ТЕСТ-МЕТОД, УДАЛИТЬ ПОСЛЕ ТЕСТОВ !!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Proj.Notes.Clear();
            NoteList.Items.Clear();
            SaveData();
        }

        private void DescriptionTextBox_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(DescriptionTextBox, "Для редактирования заметки нажмите кнопку \"Edit\" в левом нижнем углу");
        }

    }
}
