using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект", хранящий список всех заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
