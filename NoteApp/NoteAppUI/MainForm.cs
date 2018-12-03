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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(NoteCategory));
            _project = ProjectManager.LoadFromFile();
            UpdateProject();
            this.NoteListBox.SelectedIndex = 0;
            #if !DEBUG
            this.TestButton.Visible = false;
            #endif
        }

        /// <summary>
        /// Тестирование классов и сериализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestButton_Click(object sender, EventArgs e)
        {
            var note1 = new Note("text", NoteCategory.Different,"test");
            var note2 = new Note("text1", NoteCategory.Home);
            MessageBox.Show(note1.Name+' '+note1.NoteCategory+ ' ' + note1.NoteText+ ' ' + note1.TimeCreate);
            MessageBox.Show(note2.Name + ' ' + note2.NoteCategory + ' ' + note2.NoteText + ' ' + note2.TimeCreate);
            var project1 = new Project();
            project1.AddNote(note1);
            project1.AddNote(note2);
            ProjectManager.SaveToFile(project1);
            var loadProject =  ProjectManager.LoadFromFile();
            foreach (var item in loadProject.NoteList)
            {
                MessageBox.Show(item.Name + ' ' + item.NoteCategory + ' ' + item.NoteText + ' ' + item.TimeCreate);
            }
        }

        /// <summary>
        /// Обновление списка заметок
        /// </summary>
        private void UpdateProject()
        {
            var List = new List<string>();
            foreach (var item in _project.NoteList)
            {
                List.Add(item.Name);
            }
            this.NoteListBox.DataSource = List;
        }

        /// <summary>
        /// Для хранение списка проектов внутри формы
        /// </summary>
        private Project _project;

        /// <summary>
        /// Вызов формы для добавления заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            var addChangeForm = new AddChangeForm();
            addChangeForm.ShowDialog();
            if (addChangeForm.DialogResult == DialogResult.OK)
            {    
                _project.AddNote(addChangeForm.Note);
                UpdateProject();
            }
        }

        /// <summary>
        /// Вызов формы содержащей данные о программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.Show();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NoteNameLabel.Text = _project.NoteList[NoteListBox.SelectedIndex].Name;
            this.NoteCategoryLabel.Text ="Category: " + _project.NoteList[NoteListBox.SelectedIndex].NoteCategory.ToString();
            this.NoteTextBox.Text = _project.NoteList[NoteListBox.SelectedIndex].NoteText;
            this.TimeCreatedComboBox.Items.Clear();
            this.TimeCreatedComboBox.Items.Insert(0, _project.NoteList[NoteListBox.SelectedIndex].TimeCreate.ToString());
            this.TimeCreatedComboBox.SelectedIndex = 0;
            this.TimeChangedComboBox.Items.Clear();
            this.TimeChangedComboBox.Items.Insert(0, _project.NoteList[NoteListBox.SelectedIndex].TimeChange.ToString());
            this.TimeChangedComboBox.SelectedIndex = 0;
        }

        private void ChangePictureBox_Click(object sender, EventArgs e)
        {
            var addChangeForm = new AddChangeForm(_project.NoteList[NoteListBox.SelectedIndex]);
            addChangeForm.ShowDialog();
            if (addChangeForm.DialogResult == DialogResult.OK)
            {
                _project.RemoveNote(NoteListBox.SelectedIndex);
                _project.AddNote(addChangeForm.Note);
                UpdateProject();
            }
            
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выделеную заметку?","Подтверждение",MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                _project.RemoveNote(NoteListBox.SelectedIndex);
                UpdateProject();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
