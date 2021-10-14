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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Test();
        }

        /// <summary>
        /// Тест-метод на проверку создания заметки
        /// </summary>
        private void Test()
        {
            Note note = new Note("title", "this_is_a_description");
            label1.Text = note.Name;
            label2.Text = note.NoteText;
        }
        
    }
}
