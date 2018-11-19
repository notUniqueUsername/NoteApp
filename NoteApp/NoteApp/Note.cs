using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок
    /// </summary>
    public class Note : ICloneable
    {
        private string _name;
        private NoteCategory _noteCategory;
        private string _noteText;

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime TimeCreate { private set; get; }

        /// <summary>
        /// Время последнего изменения
        /// </summary>
        public DateTime TimeChange { private set; get; }

        /// <summary>
        /// Название заметки
        /// </summary>
        public string Name
        {
            set
            {
                _name = value;
                TimeChange = DateTime.Now;
            }

            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Категория заметки
        /// </summary>
        public NoteCategory NoteCategory
        {
            set
            {
                _noteCategory = value;
                TimeChange = DateTime.Now;
            }

            get
            {
                return _noteCategory;
            }
        }

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText
        {
            set
            {
                _noteText = value;
                TimeChange = DateTime.Now;
            }

            get
            {
                return _noteText;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="NoteText">
        /// Текст заметки
        /// </param>
        /// <param name="NoteCategory">
        /// Категория заметки
        /// </param>
        /// <param name="Name">
        /// Имя заметки
        /// </param>
        public Note(string NoteText, NoteCategory NoteCategory, string Name = "Без названия")
        {
            TimeCreate = DateTime.Now;
            if (Name.Length <= 50)
            {
                this.Name = Name;
            }
            else
            {
                throw new ArgumentException("Название заметки длиннее 50 символов");
            }
            this.NoteCategory = NoteCategory;
            this.NoteText = NoteText;
        }

        public object Clone()
        {
            return (Note) this.MemberwiseClone();
        }
    }
}
