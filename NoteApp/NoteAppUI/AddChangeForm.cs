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
        /// <summary>
        /// Переменная для определения что будет делать форма: изменять(true) или добавлять (false)
        /// </summary>
        private Boolean _changeORAdd;

        /// <summary>
        /// Конструктор для добавления заметки
        /// </summary>
        public AddChangeForm()
        {
            InitializeComponent();
            this.NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(NoteCategory));
            _changeORAdd = false;
        }

        /// <summary>
        /// Конструктор для редактирования заметки
        /// </summary>
        /// <param name="note">
        /// Редактируемая заметка
        /// </param>
        public AddChangeForm(Note note)
        {
            InitializeComponent();
            this.NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(NoteCategory));
            this.NoteNameLabel.Text = "Note name:";
            this.NoteNameTextBox.Text = note.Name;
            this.NoteCategoryLabel.Text = note.NoteCategory.ToString();
            this.NoteTextBox.Text = note.NoteText;
            this.TimeCreatedComboBox.Items.Clear();
            this.TimeCreatedComboBox.Items.Insert(0, note.TimeCreate.ToString());
            this.TimeCreatedComboBox.SelectedIndex = 0;
            this.TimeChangedComboBox.Items.Clear();
            this.TimeChangedComboBox.Items.Insert(0, note.TimeChange.ToString());
            this.TimeChangedComboBox.SelectedIndex = 0;
            Note = note;
            _changeORAdd = true;
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

        /// <summary>
        /// Создание заметки
        /// </summary>
        private void CreateNote()
        {
            var name = this.NoteNameTextBox.Text;
            var text = this.NoteTextBox.Text;
            var noteCategory = this.NoteCategoryComboBox.SelectedIndex;
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

        /// <summary>
        /// Изменение заметки
        /// </summary>
        private void ChangeNote()
        {
            var name = this.NoteNameTextBox.Text;
            var text = this.NoteTextBox.Text;
            var noteCategory = this.NoteCategoryComboBox.SelectedIndex;
            if (name == "")
            {
                Note.NoteCategory = (NoteCategory)noteCategory;
                Note.NoteText = text;
            }
            else
            {
                Note.Name = name;
                Note.NoteCategory = (NoteCategory)noteCategory;
                Note.NoteText = text;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_changeORAdd)
            {
                ChangeNote();
            }
            else
            {
                CreateNote();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Происходит при изменении названия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteNameTextBox.TextLength >= 50)
            {
                var tooltip = new ToolTip();
                NoteNameTextBox.BackColor = Color.Red;
                tooltip.SetToolTip(this.NoteNameTextBox, "Максимальная длина 50 символов");
            }
            else
            {
                NoteNameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Происходит при нажатии клавиши прии ввое имени и запрещает ввод любых символоd кроме baackspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NoteNameTextBox.TextLength >= 50 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
