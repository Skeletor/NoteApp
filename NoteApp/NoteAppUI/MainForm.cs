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
            ActivateButtons(false);

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

        private void CreateNote()
        {
            var noteForm = new NoteForm();

            if (noteForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Project.Notes.Add(noteForm.NewNote);
            NoteListBox.Items.Insert(0, noteForm.NewNote);

            SortNoteList();
            NoteListBox.SelectedIndex = 0;
        }

        private void TimeDisplayerGotFocus()
        {
            CreationTimeDisplayer.GotFocus += CreationTimeDisplayer_GotFocus;
        }

        private void CreationTimeDisplayer_GotFocus(object sender, EventArgs e)
        {
            this.ActiveControl = NoteListBox;
        }

        private void EditNote()
        {
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

            NoteListBox.SelectedIndex = 0;
        }

        private void DeleteNote()
        {
            int noteIndex = NoteListBox.SelectedIndex;

            if (noteIndex != -1)
            {
                if (MessageBox.Show("Delete the selected note?", "Removing", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    NoteListBox.Items.RemoveAt(noteIndex);
                    Project.Notes.RemoveAt(noteIndex);

                    NoteListBox.SelectedIndex = noteIndex == 0 
                        ? 0 
                        : noteIndex - 1;
                }
            }
            else
            {
                MessageBox.Show("No note is chosen to delete", "Removing");
            }
        }

        /// <summary>
        /// Проверяет, была ли изменена заметка
        /// </summary>
        /// <param name="before">Заметка до изменения</param>
        /// <param name="after">Заметка после изменения</param>
        /// <returns></returns>
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

        private void AddNotesToList(Project project)
        {
            foreach (var item in project.Notes)
            {
                NoteListBox.Items.Add(item);
            }
        }
        
        private void DescriptionTextBox_Enter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(NoteTextTextBox, "In order to redact the note press the \"Edit\" button in the" +
                " lower left corner");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) => CreateNote();

        private void editToolStripMenuItem_Click(object sender, EventArgs e) => EditNote();

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => DeleteNote();

        private void NoteCategoryCombobox_SelectedIndexChanged(object sender, EventArgs e) => SortNoteList();

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

        private void CreateButton_Click(object sender, EventArgs e) => CreateNote();

        private void EditButton_Click(object sender, EventArgs e) => EditNote();

        private void DeleteButton_Click(object sender, EventArgs e) => DeleteNote();

        private void ExitMenu_Click(object sender, EventArgs e) => Close();

    }
}
