using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс для хранения заметок
    /// </summary>
    public class Project
    {
        public List<Note> NoteList { private set; get; }

        public Project(List<Note> NoteList)
        {
            if (NoteList == null)
            {
                throw new ArgumentNullException("Список заметок не может быть null");
            }
            else
            {
                this.NoteList = NoteList;
            }
            
        }

        public Project()
        {
            this.NoteList = new List<Note>();
        }
        /// <summary>
        /// Метод дляд обавления заметок
        /// </summary>
        /// <param name="note">
        /// заметка
        /// </param>
        public void AddNote(Note note)
        {
            if (NoteList == null)
            {
                throw new ArgumentNullException("Нельзя добавить null(Project.AddNote(null)) в список заметок");
            }
            else
            {
                NoteList.Add(note);
            }
            
        }
        /// <summary>
        /// Удаление заметки по номеру индекса
        /// </summary>
        /// <param name="i">
        /// индекс
        /// </param>
        public void RemoveNote(int i)
        {
            NoteList.RemoveAt(i);
        }
    }
}
