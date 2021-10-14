using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Заметки", хранящий информацию о каждой заметке.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Имя заметки. Взаимодействует с Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Категория заметки. Взаимодействует с NoteCategory
        /// </summary>
        private NoteCategory _noteCategory;

        /// <summary>
        /// Текст заметки. Взаимодействует с NoteText
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Время создания заметки. Взаимодействует с CreationTime
        /// </summary>
        private DateTime _creationTime;

        /// <summary>
        /// Время последнего изменения заметки. Взаимодействует с LastModifyTime
        /// </summary>
        private DateTime _lastModifyTime;

        /// <summary>
        /// Конструктор, вызываемый при создании экземпляра класса "Заметки"
        /// </summary>
        /// <param name="name">Входящий параметр, определяющий заголовок заметки (необяз.)</param>
        /// <param name="noteText">Входящий параметр, определяющий текст заметки (необяз.)</param>
        /// <param name="noteCategory">Входящий параметр, определяющий категорию заметки (необяз.)</param>
        public Note(string name = "Без названия", string noteText = "", NoteCategory noteCategory = NoteCategory.OTHER)
        {
            this.Name = name;
            this.NoteText = noteText;
            this.NoteCategory = noteCategory;
            this._creationTime = DateTime.Now;
            this.LastModifyTime = CreationTime;
        }

        /// <summary>
        /// Заголовок заметки. Выбрасывает исключение при попытке установить длину заголовка >50
        /// </summary>
        public string Name 
        {
            get { return this._name; } 
            set 
            {
                if (value.Length <= 50) this._name = value;
                else throw new ArgumentException($"Введенное значение больше 50 символов! ({value})");
            }
        }

        /// <summary>
        /// Категория заметки
        /// </summary>
        public NoteCategory NoteCategory
        { 
            get { return this._noteCategory; }
            set { this._noteCategory = value; }
        }

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText
        {
            get { return this._noteText; }
            set { this._noteText = value; }
        }

        /// <summary>
        /// Время создания заметки
        /// </summary>
        public DateTime CreationTime { get { return this._creationTime; } }
        
        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        public DateTime LastModifyTime
        {
            get { return this._lastModifyTime; }
            private set { this._lastModifyTime = value; }
        }

        /// <summary>
        /// Метод, осуществляющий создание копии выбранной заметки
        /// </summary>
        /// <returns>Новый экземпляр заметки с идентичными параметрами</returns>
        public object Clone()
        {
            return new Note
            {
                Name = this.Name,
                NoteText = this.NoteText,
                _creationTime = this.CreationTime,
                LastModifyTime = this.LastModifyTime,
                NoteCategory = this.NoteCategory
            };
        }
    }
}
