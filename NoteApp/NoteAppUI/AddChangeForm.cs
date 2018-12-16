using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class AddChangeForm : Form
    {


        /// <summary>
        /// Конструктор для добавления заметки
        /// </summary>
        public AddChangeForm()
        {
            InitializeComponent();
            this.NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(NoteCategory));
            this.CreatedTimePicker.CustomFormat = "dd.MM.yyyy - H:mm";
            this.ModifiedTimePicker.CustomFormat = "dd.MM.yyyy - H:mm";
            this.CreatedTimePicker.Value = DateTime.Now;
            this.ModifiedTimePicker.Value = DateTime.Now;
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
                if (value != null)
                {
                    this.NoteNameLabel.Text = "Note name:";
                    this.NoteNameTextBox.Text = value.Name;
                    this.NoteCategoryLabel.Text = value.NoteCategory.ToString();
                    this.NoteTextBox.Text = value.NoteText;
                    this.CreatedTimePicker.Value = value.TimeCreate;
                    this.ModifiedTimePicker.Value = value.TimeChange;
                }
                _note = value;
            }
        }

        /// <summary>
        /// Изменение или создание заметки
        /// </summary>
        private void ChangeORCreateNote()
        {
            var name = this.NoteNameTextBox.Text;
            var text = this.NoteTextBox.Text;
            var noteCategory = this.NoteCategoryComboBox.SelectedIndex;
            if (name == "")
            {
                if (Note != null)
                {
                    Note.NoteCategory = (NoteCategory)noteCategory;
                    Note.NoteText = text;
                }
                else
                {
                    var note = new Note(text, (NoteCategory)noteCategory);
                    Note = note;
                }
            }
            else
            {
                if (Note !=null)
                {
                    Note.Name = name;
                    Note.NoteCategory = (NoteCategory)noteCategory;
                    Note.NoteText = text;
                }
                else
                {
                    var note = new Note(text, (NoteCategory)noteCategory, name);
                    Note = note;
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки Ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
                ChangeORCreateNote();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Обработка нажатия кнопки Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                tooltip.SetToolTip(this.NoteNameTextBox, "Максимальная длина 50 символов");
            }
        }

        /// <summary>
        /// Происходит при нажатии клавиши при вводе имени и запрещает ввод любых символов кроме backspace
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
