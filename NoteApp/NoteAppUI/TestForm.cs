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
    /// Страница для тестов
    /// </summary>
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            TestNote();
            TestProject();
        }

        /// <summary>
        /// Тест-метод на проверку создания заметки. Отображается в label1 и label2
        /// </summary>
        private void TestNote()
        {
            Note note = new Note("title", "this_is_a_description");
            label1.Text = note.Name;
            label2.Text = note.NoteText;
        }

        /// <summary>
        /// Тест-метод на проверку сериализации/десериализации. Отображается в label3 и label4
        /// </summary>
        private void TestProject()
        {
            Project project = new Project();

            project.Notes.Add(new Note());
            project.Notes.Add(new Note("test_title"));
            project.Notes.Add(new Note("test_title1", "test_description"));
            project.Notes.Add(new Note("test_title2", "test_description", NoteCategory.OTHER));

            ProjectManager.SaveToFile(project);
            Project p = ProjectManager.LoadFrom();

            label3.Text = p.Notes[2].Name;
            label4.Text = p.Notes[2].NoteText;
        }
    }
}
