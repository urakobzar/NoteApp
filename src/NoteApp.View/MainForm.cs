using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект типа Project, хранящий в себе данные обо всех заметках
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.SelectedIndex = 0;
            ClearSelectedNote();
        }

        /// <summary>
        /// Обновляет перечень заметок в ListBox
        /// </summary>
        private void UpdateListBox()
        {
            NotesListBox.Items.Clear();
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                NotesListBox.Items.Add(_project.Notes[i].NoteTitle);
            }
        }

        /// <summary>
        /// Добавляет заметку
        /// </summary>
        private void AddNote()
        {
            string[] testNoteTitle = { "Test1", "Test2", "Test3", "Test4", "Test5" };
            string[] testNoteText = { "Hello", "Bye", "Good morning", "Good afternoon", "Good evening", "Good night" };
            NoteCategoryEnum randomNoteCategoryEnum;
            Random random = new Random();
            string randomNoteTitle;
            string randomNoteText;
            for (int i = 0; i < 5; i++)
            {
                randomNoteCategoryEnum = (NoteCategoryEnum)random.Next(0, 6);
                randomNoteTitle = testNoteTitle[random.Next(0, testNoteTitle.Length - 1)];
                randomNoteText = testNoteText[random.Next(0, testNoteTitle.Length - 1)];
                _project.Notes.Add(new Note(randomNoteTitle, randomNoteCategoryEnum, randomNoteText));
            }
        }
        
        /// <summary>
        /// Удаляет выбранную заметку
        /// </summary>
        /// <param name="index"></param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить заметку: \""
                + NotesListBox.SelectedItem.ToString() + "\"", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
            }
        }

        /// <summary>
        /// Отображает данные выбранной заметки
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedNote(int index)
        {
            TextBoxNoteText.Text = _project.Notes[index].NoteText;
            LabelSelectedCategoryNote.Text = _project.Notes[index].NoteCategory.ToString();
            LabelNoteName.Text = _project.Notes[index].NoteTitle;
            NoteDateCreate.Visible = true;
            NoteDateModify.Visible = true;
            NoteDateCreate.Value = _project.Notes[index].CreationTime;
            NoteDateModify.Value = _project.Notes[index].LastModificationTime;
        }

        /// <summary>
        /// Обработчик события, когда меняется выбранная заметка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedNote(NotesListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Очистка окна,отображающего данные заметки
        /// </summary>
        private void ClearSelectedNote()
        {
            LabelNoteName.Text = "";
            TextBoxNoteText.Text = "";
            LabelSelectedCategoryNote.Text = "";
            NoteDateCreate.Visible = false;
            NoteDateModify.Visible = false;
        }
       
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавить новую заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Редактировать заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Удалить заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Вызвать информационную форму, показывающую версию приложения, автора и т.п.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Добавить новую заметку через пиктограмму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Удалить заметку через пиктограмму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Редактировать заметку через пиктограмму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработка закрытия главного окна любым способом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите закрыть программу?",
                "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
