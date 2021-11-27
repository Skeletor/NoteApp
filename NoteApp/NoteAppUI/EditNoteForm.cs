using System;
using System.Drawing;
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
        private readonly string _defaultName = "Без названия";

        /// <summary>
        /// Цвет для отрисовки прямоугольника вокруг заголовка заметки
        /// </summary>
        private readonly MyColorClass _drawColor = new MyColorClass();

        /// <summary>
        /// Текущий индекс заметки в списке
        /// </summary>
        private int NoteIndex { get; set; } = -1;

        /// <summary>
        /// Список заметок, загружаемых из файла
        /// </summary>
        private Project ListNotes { get; set; } = ProjectManager.LoadFrom();

        /// <summary>
        /// Только что созданная/отредактированная заметка
        /// </summary>
        public Note NewNote { get; private set; }

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            FillEditForm(null);
        }

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        /// <param name="note">Заметка, данные которой нужно отобразить на форме</param>
        public NoteForm(Note note)
        {
            InitializeComponent();
            FillEditForm(note);
        }

        /// <summary>
        /// Заполняет данные формы
        /// </summary>
        /// <param name="note">Если null, заполняет стандартным значением</param>
        private void FillEditForm(Note note)
        {
            FillWithDefault();

            if (note != null)
            {
                TitleTextBox.Text = note.Name;
                DescriptionTextBox.Text = note.NoteText;
                CategorySelector.SelectedIndex = (int)note.NoteCategory - 1;
                CreationTimeDisplayer.Text = note.CreationTime.ToString("g");
                ModifyTimeDisplayer.Text = note.LastModifyTime.ToString("g");

                NewNote = note;
            }
        }

        /// <summary>
        /// Заполнение элементов стандартными значениями
        /// </summary>
        private void FillWithDefault()
        {
            CategorySelector.Items.AddRange(new object[] {
                NoteCategory.Job,
                NoteCategory.Home,
                NoteCategory.HealthAndSport,
                NoteCategory.People,
                NoteCategory.Documents,
                NoteCategory.Finance,
                NoteCategory.Other
            });

            CategorySelector.SelectedIndex = 0;

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
            if (TitleTextBox.Text.Trim() == "")
            {
                if (MessageBox.Show("Trying to save the note with the blank title. Will be saved as " +
                    "\"Без названия\"", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (IsNoteInCollection(NewNote))
                    {
                        if (!WasNoteEdited(NewNote))
                        {
                            SaveAndClose();
                        }
                        else
                        {
                            NewNote = ChangeNewNoteAttributes(TitleTextBox.Text, DescriptionTextBox.Text,
                                (NoteCategory)(CategorySelector.SelectedIndex + 1));

                            ListNotes.Notes.RemoveAt(NoteIndex);
                            ListNotes.Notes.Insert(NoteIndex, NewNote);
                        }
                    }
                    else
                    {
                        NewNote = new Note();

                        NewNote = ChangeNewNoteAttributes(_defaultName, DescriptionTextBox.Text,
                            (NoteCategory)(CategorySelector.SelectedIndex + 1));

                        ListNotes.Notes.Insert(0, NewNote);
                    }

                    SaveAndClose();
                }
            }
            else
            {
                try
                {
                    if (IsNoteInCollection(NewNote))
                    {
                        if (!WasNoteEdited(NewNote))
                        {
                            SaveAndClose();
                        }
                        else
                        {
                            NewNote = ChangeNewNoteAttributes(TitleTextBox.Text, DescriptionTextBox.Text,
                                (NoteCategory)(CategorySelector.SelectedIndex + 1));

                            ListNotes.Notes.RemoveAt(NoteIndex);
                            ListNotes.Notes.Insert(NoteIndex, NewNote);
                        }
                    }
                    else
                    {
                        NewNote = new Note();

                        NewNote = ChangeNewNoteAttributes(TitleTextBox.Text, DescriptionTextBox.Text,
                            (NoteCategory)(CategorySelector.SelectedIndex + 1));

                        ListNotes.Notes.Insert(0, NewNote);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                SaveAndClose();
            }

        }

        /// <summary>
        /// Проверяет, была ли изменена заметка
        /// </summary>
        /// <param name="note">Заметка, которая проверяется</param>
        /// <returns>true, если было изменение, иначе - false</returns>
        private bool WasNoteEdited(Note note)
        {
            if (note.Name == TitleTextBox.Text && note.NoteText == DescriptionTextBox.Text &&
                note.NoteCategory == (NoteCategory)(CategorySelector.SelectedIndex + 1))
            { 
                return false; 
            }

            return true;
        }

        /// <summary>
        /// Присвоить временной заметке данные из формы
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="description">Описание</param>
        /// <param name="category">Категория</param>
        /// <returns>Изменённая заметка</returns>
        private Note ChangeNewNoteAttributes(string title, string description, NoteCategory category)
        {
            NewNote.Name = title;
            NewNote.NoteText = description;
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
            SaveAndClose();
        }

        /// <summary>
        /// Сохраняет список заметок в файл и закрывает форму
        /// </summary>
        private void SaveAndClose()
        {
            ProjectManager.SaveTo(ListNotes);
            Close();
        }

        /// <summary>
        /// Проверяет, есть ли данная заметка в списке заметок
        /// </summary>
        /// <param name="note">Проверяемая заметка</param>
        /// <returns>true, если есть в списке, иначе - false</returns>
        private bool IsNoteInCollection(Note note)
        {
            foreach (var item in ListNotes.Notes)
            {
                if (item.Equals(note))
                {
                    NoteIndex = ListNotes.Notes.IndexOf(item);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Происходит при изменении текста в заголовке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e) => 
            DoRainbow(TitleTextBox.Text.Length > 50);
        
        /// <summary>
        /// Начинает отрисовку прямоугольника вокруг TitleTextBox
        /// </summary>
        private void Draw()
        {
            Color Color = new Color();

            switch (_drawColor.CurrentColor)
            {
                case MyColorClass.Colors.Red:
                    Color = Color.Red;
                    break;

                case MyColorClass.Colors.Orange:
                    Color = Color.Orange;
                    break;

                case MyColorClass.Colors.Yellow:
                    Color = Color.Yellow;
                    break;

                case MyColorClass.Colors.Green:
                    Color = Color.Green;
                    break;

                case MyColorClass.Colors.LightBlue:
                    Color = Color.LightBlue;
                    break;

                case MyColorClass.Colors.Blue:
                    Color = Color.Blue;
                    break;

                case MyColorClass.Colors.Violet:
                    Color = Color.Violet;
                    break;
            }

            using (Graphics g = Graphics.FromHwnd(Handle))
            {
                g.DrawRectangle(new Pen(Color, 3), TitleTextBox.Location.X, TitleTextBox.Location.Y,
                    TitleTextBox.Width, TitleTextBox.Height);
            }

            _drawColor.ColorNext();
        }

        /// <summary>
        /// Очищает нарисованную область
        /// </summary>
        private void Clear()
        {
            using (Graphics g = Graphics.FromHwnd(Handle))
            {
                g.Clear(BackColor);
            }
        }

        /// <summary>
        /// Происходит через каждый Tick таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColorTimer_Tick(object sender, EventArgs e) => Draw();

        /// <summary>
        /// Обертка для методов <see cref="Draw()"/> и <see cref="Clear()"/> 
        /// </summary>
        /// <param name="state">Если true, вызывает метод <see cref="Draw()"/>.
        /// Иначе - метод <see cref="Clear()"/></param>
        private void DoRainbow(bool state)
        {
            if (state)
            {
                ChangeColorTimer.Enabled = true;
                Draw();
                TitleTextBox.ForeColor = Color.Red;
            }
            else
            {
                ChangeColorTimer.Enabled = false;
                Clear();
                TitleTextBox.ForeColor = Color.Black;
            }
        }
    }
}
