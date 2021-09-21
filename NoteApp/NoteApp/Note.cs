using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note : ICloneable
    {
        private string _name;
        private NoteCategory _noteCategory;
        private string _noteText;
        private DateTime _creationTime;
        private DateTime _lastModifyTime;

        public Note(string name = "Без названия", string noteText = "", NoteCategory noteCategory = NoteCategory.OTHER)
        {
            this.Name = name;
            this.NoteText = noteText;
            this.NoteCategory = noteCategory;
            this.CreationTime = DateTime.Now;
            this.LastModifyTime = CreationTime;
        }

        public string Name 
        {
            get { return this._name; } 
            set 
            { 
                if (value.Length <= 50)
                    this._name = value; 
            }
        }

        public NoteCategory NoteCategory
        { 
            get { return this._noteCategory; }
            set { this._noteCategory = value; }
        }

        public string NoteText
        {
            get { return this._noteText; }
            set { this._noteText = value; }
        }

        public DateTime CreationTime
        {
            get { return this._creationTime; }
            private set { this._creationTime = value; }
        }
        
        public DateTime LastModifyTime
        {
            get { return this._lastModifyTime; }
            private set { this._lastModifyTime = value; }
        }

        
        public object Clone() // TODO
        {
            throw new NotImplementedException();
        }
    }
}
