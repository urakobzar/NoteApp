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
        /// Список отображаемых заметок на экране
        /// </summary>
        List <Note> _currentNotes;

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
        /// Поиск индекса в 
        /// </summary>
        /// <param name="index">Индекс элемента по ListBox по _currentNotes</param>
        /// <returns></returns>
        private int FindProjectIndex(int index)
        {
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                if (_project.Notes[i] == _currentNotes[index])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Вывод на экран списка заметок по выбранной категории
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != "All")
            {
                NoteCategory noteCategory = (NoteCategory)Enum.Parse(typeof(NoteCategory), 
                    CategoryComboBox.SelectedItem.ToString());
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);                
            }
        }

        /// <summary>
        /// Обновляет перечень заметок в ListBox
        /// </summary>
        private void UpdateListBox()
        {
            NotesListBox.Items.Clear();
            _currentNotes = _project.SortByModificationTime(_currentNotes);
            for (int i = 0; i < _currentNotes.Count; i++)
            {
                NotesListBox.Items.Add(_currentNotes[i].Title);
            } 
        }

        /// <summary>
        /// Добавление случайно созданных заметок
        /// </summary>
        private void AddRandomNotes()
        {
            string[] testNoteTitle = { "Test1", "Test2", "Test3", "Test4", "Test5" };
            string[] testNoteText = { "Hello", "Bye", "Good morning", "Good afternoon",
                                        "Good evening", "Good night" };
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int enumIndex = random.Next(0, 7);
                int titleIndex = random.Next(0, testNoteTitle.Length - 1);
                int textIndex = random.Next(0, testNoteText.Length - 1);
                NoteCategory randomNoteCategoryEnum = (NoteCategory)enumIndex;
                string randomNoteTitle = testNoteTitle[titleIndex];
                string randomNoteText = testNoteText[textIndex];
                _project.Notes.Add(new Note(randomNoteTitle, randomNoteCategoryEnum,
                    randomNoteText));
            }
        }

        /// <summary>
        /// Добавляет заметку
        /// </summary>
        private void AddNote()
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.Note!=null)
            {
                _project.Notes.Add(noteForm.Note);
            }
        }

        /// <summary>
        /// Удаляет выбранную заметку
        /// </summary>
        /// <param name="index">Текущая выбранная заметка</param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            index = FindProjectIndex(index);
            DialogResult dialogResult = MessageBox.Show("You definitely want to delete the note:\""
                + NotesListBox.SelectedItem.ToString() + "\"", "A warning", 
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
            }
        }

        /// <summary>
        /// Редактирует выбранную заметку
        /// </summary>
        /// <param name="index">Текущая выбранная заметка</param>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            index = FindProjectIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            if (noteForm.Note != null)
            {
                _project.Notes[index] = noteForm.Note;
            }
        }

        /// <summary>
        /// Отображает данные выбранной заметки
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            Note note = _currentNotes[index]; 
            TextBoxNoteText.Text = note.Text;
            LabelSelectedCategoryNote.Text = note.NoteCategory.ToString();
            LabelNoteName.Text = note.Title;
            NoteDateCreate.Visible = true;
            NoteDateModify.Visible = true;
            NoteDateCreate.Value = note.CreationTime;
            NoteDateModify.Value = note.LastModificationTime;
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
            OutputByCategory();
            UpdateListBox();
        }

        /// <summary>
        /// Редактировать заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
            OutputByCategory();
            UpdateSelectedNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Удалить заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
            OutputByCategory();
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
            OutputByCategory();
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
            OutputByCategory();
            UpdateListBox();
        }

        /// <summary>
        /// Редактировать заметку через пиктограмму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
            OutputByCategory();
            UpdateSelectedNote(NotesListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Обработка закрытия главного окна любым способом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close " + 
                "the program?", "A warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Добавляет случайно созданные заметки для тестирования программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRandomNotes();
            OutputByCategory();
            UpdateListBox();
        }

        /// <summary>
        /// Обновляет список заметок с учетом выбранной категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            OutputByCategory();
            UpdateListBox();
        }
    }
}
