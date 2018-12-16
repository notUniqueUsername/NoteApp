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
                    this.CreatedTimePicker.CustomFormat = "dd.MM.yyyy - H:m";
                    this.ModifiedTimePicker.CustomFormat = "dd.MM.yyyy - H:m";
                    this.CreatedTimePicker.Value = value.TimeCreate;
                    this.ModifiedTimePicker.Value = value.TimeChange;
                }
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

        /// <summary>
        /// Обработка нажатия кнопки Ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
                CreateNote();

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
                NoteNameTextBox.BackColor = Color.Red;
                tooltip.SetToolTip(this.NoteNameTextBox, "Максимальная длина 50 символов");
            }
            else
            {
                NoteNameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Происходит при нажатии клавиши прии ввое имени и запрещает ввод любых символов кроме backspace
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
