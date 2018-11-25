using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class AddChangeForm : Form
    {
        public AddChangeForm()
        {
            InitializeComponent();
            this.NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(NoteCategory));
        }

        public AddChangeForm(Note note)
        {
            InitializeComponent();
            this.NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(NoteCategory));
            this.NoteNameLabel.Text = note.Name;
            this.NoteCategoryLabel.Text = note.NoteCategory.ToString();
        }

        private Note _note;

        public Note Note
        {
            get
            {
                return _note;
            }

            private set
            {
                _note = value;
            }
        }

        private void CreateNote()
        {
            var name = this.NoteNameTextBox.Text;
            var text = this.NoteTextBox.Text;
            var noteCategory = this.NoteCategoryComboBox.SelectedIndex;
            //var noteCategory = (NoteCategory)Enum.Parse(typeof(NoteCategory), this.NoteCategoryComboBox.SelectedText);
            if (name == "")
            {
                var note = new Note(text, (NoteCategory)noteCategory);
                Note = note;
            }
            else
            {
                var note = new Note(text, (NoteCategory)noteCategory, name);
                Note = note;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CreateNote();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
