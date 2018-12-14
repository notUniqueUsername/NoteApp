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
    }
}
