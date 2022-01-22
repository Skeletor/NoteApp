using System;
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
        /// Константа для отображения всех категорий
        /// </summary>
        private const string AllCategories = "All";

        /// <summary>
        /// Переменная для хранения всех заметок
        /// </summary>
        private Project Project { get; set; } = ProjectManager.LoadFrom();

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FillComboBox();
            ActivateButtons(!(Project.CurrentNote is null));

            NoteListBox.SelectedItem = Project.CurrentNote;
        }

        /// <summary>
        /// Заполнение некоторых элементов стандартными значениями
        /// </summary>
        private void FillComboBox()
        {
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();

            NoteCategoryComboBox.Items.Add(AllCategories);
            NoteCategoryComboBox.Items.AddRange(categories);
            NoteCategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполняет панель справа данными о заметке
        /// </summary>
        /// <param name="note">Заметка, данные о которой нужно передать</param>
        private void FillNotePanel(Note note)
        {
            TitleLabel.Text = note?.Name;
            NoteTextTextBox.Text = note?.NoteText;
            CreationTimeDisplayer.Text = note?.CreationTime.ToString("g");
            ModifyTimeDisplayer.Text = note?.LastModifyTime.ToString("g");
            CategoryLabel.Text = note?.NoteCategory.ToString();
        }

        /// <summary>
        /// Создание заметки
        /// </summary>
        private void CreateNote()
        {
            var noteForm = new NoteForm()
            {
                NewNote = null
            };

            if (noteForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Project.Notes.Add(noteForm.NewNote);
            NoteListBox.Items.Insert(0, noteForm.NewNote);

            SortNoteList();
            if (NoteCategoryComboBox.SelectedItem.ToString() == AllCategories)
            {
                NoteListBox.SelectedIndex = 0;
            }
            else if (noteForm.NewNote.NoteCategory == (NoteCategory)NoteCategoryComboBox.SelectedItem)
            {
                NoteListBox.SelectedIndex = 0;
            }
            else
            {
                NoteListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Изменение заметки
        /// </summary>
        private void EditNote()
        {
            if (Project.CurrentNote == null)
            {
                CreateNote();
                return;
            }

            var currentNote = Project.CurrentNote;
            var noteBeforeEdit = currentNote.Clone() as Note;

            var noteForm = new NoteForm()
            {
                NewNote = currentNote
            };

            if (noteForm.ShowDialog() != DialogResult.OK || !WasNoteEdited(noteBeforeEdit, currentNote))
            {
                return;
            }

            int noteIndex = currentNote is null
                ? 0
                : NoteListBox.Items.IndexOf(currentNote);

            Project.Notes.RemoveAt(noteIndex);
            Project.Notes.Add(noteForm.NewNote);

            NoteListBox.Items.RemoveAt(noteIndex);
            NoteListBox.Items.Insert(0, noteForm.NewNote);

            SortNoteList();
            NoteListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        private void DeleteNote()
        {
            int noteIndex = NoteListBox.SelectedIndex;

            if (noteIndex == -1)
            {
                MessageBox.Show("No note is chosen to delete", "Removing");
                return;
            }

            if (MessageBox.Show("Delete the selected note?", "Removing", MessageBoxButtons.OKCancel) !=
                DialogResult.OK)
            {
                return;
            }

            NoteListBox.Items.RemoveAt(noteIndex);
            Project.Notes.RemoveAt(noteIndex);

            NoteListBox.SelectedIndex = (noteIndex == 0 && !(NoteListBox.Items.Count == 0))
                ? 0
                : noteIndex - 1;
        }

        /// <summary>
        /// Проверяет, была ли изменена заметка
        /// </summary>
        /// <param name="before">Заметка до изменения</param>
        /// <param name="after">Заметка после изменения</param>
        /// <returns>true, если была изменена, иначе - false</returns>
        private bool WasNoteEdited(Note before, Note after)
        {
            return before.Name != after.Name || before.NoteText != after.NoteText ||
                before.NoteCategory != after.NoteCategory;
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
        /// Сохранить данные в файл
        /// </summary>
        private void SaveData() => ProjectManager.SaveTo(Project);

        /// <summary>
        /// Отображает только те заметки, что совпадают с выбранной в списке категорией
        /// </summary>
        private void SortNoteList()
        {
            NoteListBox.Items.Clear();

            var sortedProject = NoteCategoryComboBox.SelectedItem.ToString() == AllCategories
                ? Project.SortProject(Project) ?? new Project()
                : Project.SortProject(Project, (NoteCategory)NoteCategoryComboBox.SelectedIndex) ?? new Project();

            AddNotesToList(sortedProject);
        }

        /// <summary>
        /// Метод добавления заметок в список
        /// </summary>
        /// <param name="project">Проект, заметки которого нужно добавить</param>
        private void AddNotesToList(Project project)
        {
            foreach (var item in project.Notes)
            {
                NoteListBox.Items.Add(item);
            }
        }

        private void DescriptionTextBox_Enter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(NoteTextTextBox, "In order to edit the note press the \"Edit\" button in the" +
                " lower left corner");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) => CreateNote();

        private void editToolStripMenuItem_Click(object sender, EventArgs e) => EditNote();

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => DeleteNote();

        private void NoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortNoteList();

            if (NoteListBox.Items.Count == 0)
            {
                FillNotePanel(null);
                Project.CurrentNote = null;
            }
            else
            {
                foreach (var item in NoteListBox.Items)
                {
                    if (Project.CurrentNote != null)
                    {
                        if (Project.CurrentNote.Equals(item))
                        {
                            NoteListBox.SelectedItem = item;
                            return;
                        }
                    }
                }

                NoteListBox.SelectedItem = NoteListBox.Items[0];
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => SaveData();

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            if (!AboutForm.IsShown)
            {
                new AboutForm().Show();
            }
        }

        private void NoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project.CurrentNote = NoteListBox.SelectedItem as Note;

            ActivateButtons(!(Project.CurrentNote is null));
            FillNotePanel(Project.CurrentNote);
        }

        private void CreationTimeDisplayer_GotFocus(object sender, EventArgs e) =>
            ActiveControl = NoteListBox;

        private void ModifyTimeDisplayer_GotFocus(object sender, EventArgs e) =>
            CreationTimeDisplayer_GotFocus(sender, e);

        private void CreateButton_Click(object sender, EventArgs e) => CreateNote();

        private void EditButton_Click(object sender, EventArgs e) => EditNote();

        private void DeleteButton_Click(object sender, EventArgs e) => DeleteNote();

        private void ExitMenu_Click(object sender, EventArgs e) => Close();
    }
}
