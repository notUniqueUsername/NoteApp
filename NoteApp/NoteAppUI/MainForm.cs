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
            var note1 = new Note("text",NoteCategory.Different,"test");
            var note2 = new Note("text1", NoteCategory.Home);
            MessageBox.Show(note1.Name+' '+note1.NoteCategory+ ' ' + note1.NoteText+ ' ' + note1.TimeCreate);
            MessageBox.Show(note2.Name + ' ' + note2.NoteCategory + ' ' + note2.NoteText + ' ' + note2.TimeCreate);
            List<Note> noteList = new List<Note>();
            noteList.Add(note1);
            noteList.Add(note2);
            var project1 = new Project(noteList);
            ProjectManager.SaveToFile(project1);
            var loadProject =  ProjectManager.LoadFromFile();
            foreach (var item in loadProject.NoteList)
            {
                MessageBox.Show(item.Name + ' ' + item.NoteCategory + ' ' + item.NoteText + ' ' + item.TimeCreate);
            }
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            var addChangeForm = new AddChangeForm();
            addChangeForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.Show();
        }
    }
}
