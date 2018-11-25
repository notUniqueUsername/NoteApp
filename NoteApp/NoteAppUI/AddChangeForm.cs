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
        }

        public AddChangeForm(Note note)
        {
            InitializeComponent();
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

            set
            {
                _note = value;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
