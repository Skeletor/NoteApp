using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Окно создания/редактирования выбранных заметок
    /// </summary>
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Стандартное название заголовка
        /// </summary>
        private const string DefaultName = "No name";

        /// <summary>
        /// Переменная новой заметки
        /// </summary>
        private Note _newNote;

        /// <summary>
        /// Только что созданная/отредактированная заметка
        /// </summary>
        public Note NewNote
        {
            get => _newNote;
            set => FillNoteForm(_newNote = value);
        }

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполняет данные формы
        /// </summary>
        private void FillNoteForm(Note note)
        {
            FillControlsWithDefault();

            NoteNameTextBox.Text = note?.Name;
            NoteTextTextBox.Text = note?.NoteText;
            CreationTimeDisplayer.Text = note?.CreationTime.ToString("g");
            ModifyTimeDisplayer.Text = note?.LastModifyTime.ToString("g");

            NoteCategoryComboBox.SelectedIndex = note is null
                ? NoteCategoryComboBox.Items.Count - 1
                : (int)note.NoteCategory - 1;
        }

        /// <summary>
        /// Заполнение элементов стандартными значениями
        /// </summary>
        private void FillControlsWithDefault()
        {
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            NoteCategoryComboBox.Items.AddRange(categories);
            NoteCategoryComboBox.SelectedIndex = 0;

            CreationTimeDisplayer.Text = DateTime.Now.ToString("g");
            ModifyTimeDisplayer.Text = DateTime.Now.ToString("g");
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NoteNameTextBox.Text.Trim() == "")
                {
                    if (MessageBox.Show("Trying to save the note with the blank title. Will be saved as " +
                        $"{DefaultName}", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        NewNote = ChangeNewNoteAttributes(DefaultName, NoteTextTextBox.Text,
                              (NoteCategory)(NoteCategoryComboBox.SelectedIndex + 1));
                    }
                }
                else
                {
                    NewNote = ChangeNewNoteAttributes(NoteNameTextBox.Text, NoteTextTextBox.Text,
                          (NoteCategory)(NoteCategoryComboBox.SelectedIndex + 1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Присвоить временной заметке данные из формы
        /// </summary>
        /// <param name="name">Заголовок</param>
        /// <param name="text">Описание</param>
        /// <param name="category">Категория</param>
        /// <returns>Изменённая заметка</returns>
        private Note ChangeNewNoteAttributes(string name, string text, NoteCategory category)
        {
            NewNote.Name = name;
            NewNote.NoteText = text;
            NewNote.NoteCategory = category;
            NewNote.LastModifyTime = DateTime.Now;

            return NewNote;
        }

        /// <summary>
        /// Происходит при нажатии на кнопку "Cancel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            NewNote = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Происходит при изменении текста в заголовке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteNameTextBox.Text.Length > 50)
            {
                Draw();
                NoteNameTextBox.ForeColor = Color.Red;
            }
            else
            {
                Clear();
                NoteNameTextBox.ForeColor = Color.Black;
            }
        }
        
        /// <summary>
        /// Отрисовывает прямоугольник вокруг TitleTextBox
        /// </summary>
        private void Draw()
        {
            using (var graphics = Graphics.FromHwnd(Handle))
            {
                graphics.DrawRectangle(new Pen(Color.Red, 3), NoteNameTextBox.Location.X, NoteNameTextBox.Location.Y,
                    NoteNameTextBox.Width, NoteNameTextBox.Height);
            }
        }

        /// <summary>
        /// Очищает нарисованную область
        /// </summary>
        private void Clear()
        {
            using (var graphics = Graphics.FromHwnd(Handle))
            {
                graphics.Clear(BackColor);
            }
        }

    }
}
