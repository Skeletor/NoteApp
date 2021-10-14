using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект", хранящий список всех заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок. Взаимодействует с Notes
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }
    }
}
