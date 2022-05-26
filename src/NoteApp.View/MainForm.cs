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
    /// <summary>
    /// Описывает основную форму приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект типа Project, хранящий в себе данные обо всех заметках.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Список отображаемых заметок на экране.
        /// </summary>
        private List<Note> _currentNotes;

        /// <summary>
        /// Переменная класса, представляющего из себя два словаря типа 
        /// <Enum, String> и <String, Enum>.
        /// </summary>
        private NoteCategoryTools _noteCategoryTools = new NoteCategoryTools();

        /// <summary>
        /// Показывать все заметки без учета категории.
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// Экземпляр класс ProjectSerializer для сереализации.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            _project = _projectSerializer.LoadFromFile();
            InitializeComponent();
            CategoryComboBox.SelectedIndex = 0;
            ClearSelectedNote();
        }

        /// <summary>
        /// Поиск индекса в списке заметок по индексу заметки из текущей категории.
        /// </summary>
        /// <param name="index">Индекс элемента по ListBox по _currentNotes.</param>
        /// <returns>Возвращает индекс заметки из всего списка заметок.</returns>
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
        /// Вывод на экран списка заметок по выбранной категории.
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != _allCategory)
            {
                NoteCategory noteCategory = _noteCategoryTools.CategoriesByString
                    [CategoryComboBox.SelectedItem.ToString()]; 
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }

        /// <summary>
        /// Обновляет перечень заметок в ListBox.
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
        /// Добавление случайно созданных заметок.
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
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Добавляет заметку.
        /// </summary>
        private void AddNote()
        {
            NoteForm noteForm = new NoteForm();
            noteForm.Note = null;
            noteForm.ShowDialog();
            if (noteForm.Note != null)
            {
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                UpdateListBox();
                NotesListBox.SelectedIndex = 0;
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Редактирует выбранную заметку.
        /// </summary>
        /// <param name="index">Текущая выбранная заметка.</param>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _currentNotes[index];
            index = FindProjectIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (note != _project.Notes[index])
            {
                currentIndex = 0;
                OutputByCategory();
                UpdateSelectedNote(NotesListBox.SelectedIndex);
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
            NotesListBox.SelectedIndex = currentIndex;
        }

        /// <summary>
        /// Удаляет выбранную заметку.
        /// </summary>
        /// <param name="index">Текущая выбранная заметка.</param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _project.Notes[index];
            index = FindProjectIndex(index);
            DialogResult dialogResult = MessageBox.Show("Do you want to remove the note:\""
                + NotesListBox.SelectedItem.ToString() + "?\"", "Warning",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
                OutputByCategory();
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
            NotesListBox.SelectedIndex = currentIndex;
        }

        /// <summary>
        /// Отображает данные выбранной заметки.
        /// </summary>
        /// <param name="index">Индекс выбранной заметки.</param>
        private void UpdateSelectedNote(int index)
        {
            if ((index == -1) || (_currentNotes.Count == 0))
            {
                ClearSelectedNote();
                return;
            }
            Note note = _currentNotes[index];
            TextBoxNoteText.Text = note.Text;
            LabelSelectedCategoryNote.Text = _noteCategoryTools.CategoriesByEnum[note.NoteCategory];
            LabelNoteName.Text = note.Title;
            NoteDateCreate.Visible = true;
            NoteDateModify.Visible = true;
            NoteDateCreate.Value = note.CreationTime;
            NoteDateModify.Value = note.LastModificationTime;
        }

        /// <summary>
        /// Обработчик события, когда меняется выбранная заметка.
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
        /// Очистка окна,отображающего данные заметки.
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
        /// Кнопка в верхней меню для закрытия приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавить новую заметку через меню взаимодействия вверху приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактировать заметку через меню взаимодействия вверху приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
        }

        /// <summary>
        /// Удалить заметку через меню взаимодействия вверху приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
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
        /// Добавить новую заметку через пиктограмму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактировать заметку через пиктограмму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote(NotesListBox.SelectedIndex);
        }

        /// <summary>
        /// Удалить заметку через пиктограмму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NotesListBox.SelectedIndex);
        }

        /// <summary>
        /// Обновляет список заметок с учетом выбранной категории.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            OutputByCategory();
            UpdateListBox();
        }

        /// <summary>
        /// Обработка закрытия главного окна любым способом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close " +
                "the program?", "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                _projectSerializer.SaveToFile(_project);
                e.Cancel = true;
            }
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Добавляет случайно созданные заметки для тестирования программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRandomNotes();
            OutputByCategory();
            UpdateListBox();
        }
    }
}
