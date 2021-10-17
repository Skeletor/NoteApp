﻿using System;
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
        private List<Note> notes;

        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
    }
}
