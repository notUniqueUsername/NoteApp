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
        private DateTime _timeChange;
        private DateTime _timeCreate;

        public object Clone()
        {
            return 1;
        }
    }
}
