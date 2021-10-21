using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Окно создания/редактирования выбранных заметок
    /// </summary>
    public partial class EditNoteForm : Form
    {
        /// <summary>
        /// Стандартное название заголовка
        /// </summary>
        private readonly string _defaultName = "Без названия";

        /// <summary>
        /// Текущий индекс заметки в списке
        /// </summary>
        private int NoteIndex { get; set; } = -1;

        /// <summary>
        /// Временная переменная, куда помещается только что созданная/отредактированная заметка
        /// </summary>
        public Note NewNote { get; private set; }

        /// <summary>
        /// Список заметок, загружаемый из файла
        /// </summary>
        private Project ListNotes { get; set; } = ProjectManager.LoadFrom();

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        public EditNoteForm()
        {
            InitializeComponent();
            FillEditForm(null);
        }

        /// <summary>
        /// Происходит при создании формы
        /// </summary>
        /// <param name="note">Заметка, данные которой нужно отобразить на форме</param>
        public EditNoteForm(Note note)
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
            object[] categories = { NoteCategory.Job, NoteCategory.Home, NoteCategory.HealthAndSport,
            NoteCategory.People, NoteCategory.Documents, NoteCategory.Finance, NoteCategory.Other };

            CategorySelector.Items.AddRange(categories);
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
                if (MessageBox.Show("Попытка сохранить заметку с пустым именем. Будет сохранено как \"Без названия\"",
                    "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                note.NoteCategory == (NoteCategory)(CategorySelector.SelectedIndex + 1)) return false;

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
            this.Close();
        }

        /// <summary>
        /// Проверяет, есть ли данная заметка в списке заметок
        /// </summary>
        /// <param name="note">Проверяемая заметка</param>
        /// <returns>true, если есть в списке, иначе - false</returns>
        private bool IsNoteInCollection(Note note)
        {
            foreach (var item in ListNotes.Notes.Where(item => item.Equals(note)))
            {
                NoteIndex = ListNotes.Notes.IndexOf(item);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Происходит при изменении текста в заголовке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TitleTextBox.ForeColor = TitleTextBox.Text.Length > 50 ? Color.Red : Color.Black;
        }

        
    }
}
