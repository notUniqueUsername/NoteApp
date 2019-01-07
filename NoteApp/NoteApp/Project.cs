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

        /// <summary>
        /// Реализация Qsort
        /// </summary>
        /// <param name="noteList">
        /// сортируемый лист
        /// </param>
        /// <param name="i">
        /// индекс первого элемента
        /// </param>
        /// <param name="j">
        /// индекс последнего элемента
        /// </param>
        /// <returns></returns>
        private List<Note> QuickSort(List<Note> noteList, int i, int j)
        {
            if (i < j)
            {
                int q = Partition(noteList, i, j);
                noteList = QuickSort(noteList, i, q);
                noteList = QuickSort(noteList, q + 1, j);
            }
            return noteList;
        }
        /// <summary>
        /// Разделение списка на 2 части
        /// </summary>
        /// <param name="noteList"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private int Partition(List<Note> noteList, int p, int r)
        {
            DateTime x = noteList[p].TimeChange;
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                do
                {
                    j--;
                }
                while (noteList[j].TimeChange < x);
                do
                {
                    i++;
                }
                while (noteList[i].TimeChange > x);
                if (i < j)
                {
                    Note tmp = noteList[i];
                    noteList[i] = noteList[j];
                    noteList[j] = tmp;
                }
                else
                {
                    return j;
                }
            }
        }


        public void SortProject()
        {
            if (NoteList.Count == 0)
            {
                throw new IndexOutOfRangeException("Проект не содержит заметок");
            }
            if (NoteList.Count > 1)
            {
                NoteList = QuickSort(NoteList,0 , NoteList.Count -1 );
            }
        }

        public List<Note> SortProject(NoteCategory noteCategory)
        {
            List<Note> resultList = new List<Note>();
            foreach (var note in NoteList)
            {
                if (note.NoteCategory == noteCategory)
                {
                    resultList.Add(note);
                }
            }
            if (resultList.Count > 0)
            {
                resultList = QuickSort(NoteList, 0, NoteList.Count - 1);
            }
            return resultList;
        }

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
