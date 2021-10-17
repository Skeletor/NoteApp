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
    public partial class EditNoteForm : Form
    {
        public Note NewNote { get; private set; }

        private Project noteList = ProjectManager.LoadFrom();

        private int noteIndex = -1;

        private readonly string defaultName = "Без названия";

        public EditNoteForm()
        {
            InitializeComponent();
            FillEditForm(null);
        }

        public EditNoteForm(Note note)
        {
            InitializeComponent();
            FillEditForm(note);
        }

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

        private void FillWithDefault()
        {
            object[] categories = { NoteCategory.JOB, NoteCategory.HOME, NoteCategory.HEALTH_AND_SPORT,
            NoteCategory.PEOPLE, NoteCategory.DOCUMENTS, NoteCategory.FINANCE, NoteCategory.OTHER };

            CategorySelector.Items.AddRange(categories);
            CategorySelector.SelectedIndex = 0;

            CreationTimeDisplayer.Text = DateTime.Now.ToString("g");
            ModifyTimeDisplayer.Text = DateTime.Now.ToString("g");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Trim() == "")
            {
                if (MessageBox.Show("Попытка сохранить заметку с пустым именем. Будет сохранено как \"Без названия\"",
                    "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (IsNoteInCollection(NewNote)) // Unaccessible due to deserializer bug
                    {
                        NewNote = ChangeNewNoteAttributes(TitleTextBox.Text, DescriptionTextBox.Text,
                            (NoteCategory)(CategorySelector.SelectedIndex + 1));
                        noteList.Notes.RemoveAt(noteIndex);
                        noteList.Notes.Insert(noteIndex, NewNote);
                    }
                    else
                    {
                        NewNote = new Note();

                        NewNote = ChangeNewNoteAttributes(defaultName, DescriptionTextBox.Text,
                            (NoteCategory)(CategorySelector.SelectedIndex + 1));
                        noteList.Notes.Insert(0, NewNote);
                    }

                    SaveAndClose();
                }
            }
            else
            {
                if (IsNoteInCollection(NewNote)) // Unaccessible due to deserializer bug
                {
                    NewNote = ChangeNewNoteAttributes(TitleTextBox.Text, DescriptionTextBox.Text, 
                        (NoteCategory)(CategorySelector.SelectedIndex + 1));

                    noteList.Notes.RemoveAt(noteIndex);
                    noteList.Notes.Insert(noteIndex, NewNote);
                }
                else
                {
                    NewNote = new Note();

                    NewNote = ChangeNewNoteAttributes(TitleTextBox.Text, DescriptionTextBox.Text,
                        (NoteCategory)(CategorySelector.SelectedIndex + 1));
                    noteList.Notes.Insert(0, NewNote);
                }

                SaveAndClose();
            }
            
        }

        private Note ChangeNewNoteAttributes(string title, string description, NoteCategory category)
        {
            NewNote.Name = title;
            NewNote.NoteText = description;
            NewNote.NoteCategory = category;
            NewNote.LastModifyTime = DateTime.Now;

            return NewNote;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NewNote = null;
            SaveAndClose();
        }

        private void SaveAndClose()
        {
            ProjectManager.SaveToFile(noteList);
            this.Close();
        }

        private bool IsNoteInCollection(Note note)
        {
            foreach (var item in noteList.Notes)
                if (item.Equals(note))
                {
                    noteIndex = noteList.Notes.IndexOf(item);
                    return true;
                }

            return false;
        }
    }
}
