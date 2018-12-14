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
        /// <summary>
        /// Название
        /// </summary>
        private string _name;

        /// <summary>
        /// Категория
        /// </summary>
        private NoteCategory _noteCategory;

        /// <summary>
        /// Текст
        /// </summary>
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
                if (value.Trim().Length <= 50)
                {
                    if (value.Trim() == "")
                    {
                        _name = "Без названия";
                        TimeChange = DateTime.Now;
                    }
                    else
                    {
                        _name = value.Trim();
                        TimeChange = DateTime.Now;
                    }
                }
                else
                {
                    throw new ArgumentException("Название заметки длиннее 50 символов");
                }
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
                _noteText = value.Trim();
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
        public Note(string NoteText, NoteCategory NoteCategory, 
            string Name = "Без названия")
        {
            TimeCreate = DateTime.Now;
            this.Name = Name;
            this.NoteCategory = NoteCategory;
            this.NoteText = NoteText;
        }
        /// <summary>
        /// Копирование, неглубокое т.к. нет вложеных классов
        /// </summary>
        /// <returns>
        /// Возвращается копия обьекта
        /// </returns>
        public object Clone()
        {
            return (Note) this.MemberwiseClone();
        }
    }
}
