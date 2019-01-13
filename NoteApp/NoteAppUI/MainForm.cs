﻿using System;
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
            var listDataForComboBox = new List<string>();
            listDataForComboBox.Add("All");
            listDataForComboBox.AddRange(Enum.GetNames(typeof(NoteCategory)));
            this.NoteCategoryComboBox.DataSource = listDataForComboBox;

            _project = ProjectManager.LoadFromFile();
            _displayedProject = _project;
            var currentNote = _project.CurrentNote;
            UpdateDisplayedProject();
            #if !DEBUG
                testToolStripMenuItem.Visible = false;
            #endif
            int selectedIndex = 0;
            if (currentNote != null)
            {
                selectedIndex = _project.NoteList.FindIndex(note => note.TimeCreate == currentNote.TimeCreate);
            }
            

            if (this.NoteListBox.Items.Count != 0)
            {
                this.NoteListBox.SelectedIndex = selectedIndex;
            }

        }

        /// <summary>
        /// Тестирование есть только в дебаге
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestButton_Click(object sender, EventArgs e)
        {
            _displayedProject = new Project(_project.SortProject());
            UpdateDisplayedProject();
        }

        /// <summary>
        /// Обновление списка отображаемых заметок
        /// </summary>
        private void UpdateDisplayedProject()
        {
            var List = new List<string>();
            foreach (var item in _displayedProject.NoteList)
            {
                List.Add(item.Name);
            }
            this.NoteListBox.DataSource = List;
        }

        /// <summary>
        /// Для хранение списка заметок внутри формы
        /// </summary>
        private Project _project;

        /// <summary>
        /// Для хранения отображаемых заметок
        /// </summary>
        private Project _displayedProject;

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
                _project.NoteList.Insert(0,addChangeForm.Note);
                _displayedProject = _project;
                UpdateDisplayedProject();
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
        /// <summary>
        /// Обработка смены фокуса заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoteNameLabel.Text = _project.NoteList[NoteListBox.SelectedIndex].Name;
            NoteCategoryLabel.Text ="Category: " + _project.NoteList[NoteListBox.SelectedIndex].NoteCategory.ToString();
            NoteTextBox.Text = _project.NoteList[NoteListBox.SelectedIndex].NoteText;
            CreatedTimePicker.CustomFormat = "dd.MM.yyyy - H:m";
            ModifiedTimePicker.CustomFormat = "dd.MM.yyyy - H:m";
            CreatedTimePicker.Value = _project.NoteList[NoteListBox.SelectedIndex].TimeCreate;
            ModifiedTimePicker.Value = _project.NoteList[NoteListBox.SelectedIndex].TimeChange;

            _project.CurrentNote = _project.NoteList[NoteListBox.SelectedIndex];
        }
        /// <summary>
        /// Обработка вызова изменения заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change_Click(object sender, EventArgs e)
        {
            var addChangeForm = new AddChangeForm
            {
                Note = _project.NoteList[NoteListBox.SelectedIndex]
            };
            if (addChangeForm.ShowDialog() == DialogResult.OK)
            {
                _project.NoteList.RemoveAt(NoteListBox.SelectedIndex);
                _project.NoteList.Insert(0,addChangeForm.Note);
                _displayedProject = _project;
                UpdateDisplayedProject();
            }
            
        }
        /// <summary>
        /// Обработка удаления заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выделеную заметку?","Подтверждение",MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                _project.NoteList.RemoveAt(NoteListBox.SelectedIndex);
                _displayedProject = _project;
                UpdateDisplayedProject();
            }
        }

        /// <summary>
        /// Обработка Exit из ToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Сохранение заметок при закрытии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainClose(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project);
        }

        private void NoteCategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedValue = NoteCategoryComboBox.SelectedValue.ToString();
            if (selectedValue == "All")
            {
                _displayedProject = _project;
                this.UpdateDisplayedProject();
            }
            else
            {
                Enum.TryParse(selectedValue, out NoteCategory noteCategory);
                _displayedProject = new Project(_project.SortProject(noteCategory));
                this.UpdateDisplayedProject();
            }

        }

        private void PictureBoxSort_Click(object sender, EventArgs e)
        {
            _displayedProject = new Project(_project.SortProject());
            UpdateDisplayedProject();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Remove_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                AboutToolStripMenuItem_Click(sender,e);
            }
        }
    }
}
