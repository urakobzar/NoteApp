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

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshDisplay();
            CategoryComboBox.SelectedIndex = 0;
            EditNoteToolStripMenuItem.Enabled = false;
            DeleteNoteToolStripMenuItem.Enabled = false;
            EditNoteButton.Enabled = false;
            DeleteNoteButton.Enabled = false;
            NoteDirectoryCreate();
        }

        /// <summary>
        /// Проверка и создание папок, в которых хранятся заметки
        /// </summary>
        private void NoteDirectoryCreate()
        {
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\Documents")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\Documents");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\Finance")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\Finance");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\Health and Sports")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\Health and Sports");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\Home")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\Home");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\Miscs")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\Miscs");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\People")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\People");
            }
            if (!(Directory.Exists(Directory.GetCurrentDirectory() + "\\AllNotes\\Work")))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AllNotes\\Work");
            }
        }

        // Глобальная переменная, отвечает за путь к текстовому файлу
        public static string[] path;

        /// <summary>
        /// Обновление списка заметок
        /// </summary>
        /// <param name="filePath">Путь до файла</param>
        /// <param name="searchOption">Искать только в каталоге или в подкаталогах</param>
        private void RefreshListBox(string filePath, SearchOption searchOption)
        {
            try
            {
                NotesListBox.Items.Clear();
                string resultPath = Directory.GetCurrentDirectory() + "\\AllNotes\\" + filePath;
                string[] fileList = Directory.GetFiles(resultPath, "*.*", searchOption);
                foreach (string file in fileList)
                {
                    string fileName = Path.GetFileName(file).Replace(".txt", "");
                    NotesListBox.Items.Add(fileName);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Обновить дисплей основной формы, чтобы показать новую заметку
        /// </summary>
        private void RefreshDisplay()
        {
            if ((NotesListBox.SelectedItem == null) || (NotesListBox.Items.Count == 0))
            {
                LabelNoteName.Visible = false;
                LabelSelectedCategoryNote.Visible = false;
                NoteDateCreate.Visible = false;
                NoteDateModify.Visible = false;
                TextBoxNoteText.Text = "";
            }
            else
            {
                LabelNoteName.Visible = true;
                LabelSelectedCategoryNote.Visible = true;
                NoteDateCreate.Visible = true;
                NoteDateModify.Visible = true;
            }
        }

        /// <summary>
        /// Выбор новой заметки из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((NotesListBox.SelectedItem == null) || (NotesListBox.Items.Count == 0))
                {
                    EditNoteToolStripMenuItem.Enabled = false;
                    DeleteNoteToolStripMenuItem.Enabled = false;
                    EditNoteButton.Enabled = false;
                    DeleteNoteButton.Enabled = false;
                    return;
                }
                else
                {
                    EditNoteToolStripMenuItem.Enabled = true;
                    DeleteNoteToolStripMenuItem.Enabled = true;
                    EditNoteButton.Enabled = true;
                    DeleteNoteButton.Enabled = true;
                }
                path = Directory.GetFiles(Directory.GetCurrentDirectory() + 
                    "\\AllNotes\\", NotesListBox.SelectedItem.ToString() + ".txt", SearchOption.AllDirectories);
                string fileText = File.ReadAllText(path[0]);
                TextBoxNoteText.Text = fileText;
                string[] names = path[0].Split('\\');
                LabelSelectedCategoryNote.Text = names[names.Length - 2];
                LabelNoteName.Text = NotesListBox.SelectedItem.ToString();
                NoteDateCreate.Value = File.GetCreationTime(path[0]);
                NoteDateModify.Value = File.GetLastWriteTime(path[0]);
            }
            catch
            {

            }
            RefreshDisplay();
        }

        /// <summary>
        /// Изменение Категории заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditNoteToolStripMenuItem.Enabled = false;
            DeleteNoteToolStripMenuItem.Enabled = false;
            EditNoteButton.Enabled = false;
            DeleteNoteButton.Enabled = false;
            try
            {
                if (CategoryComboBox.SelectedIndex == 0)
                {
                    RefreshListBox("", SearchOption.AllDirectories);
                }
                else
                {
                    RefreshListBox(CategoryComboBox.Text + "\\", SearchOption.TopDirectoryOnly);
                }
            }
            catch
            {

            }
            RefreshDisplay();
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
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
            try
            {
                if (CategoryComboBox.SelectedIndex == 0)
                {
                    RefreshListBox("", SearchOption.AllDirectories);
                }
                else
                {
                    RefreshListBox(CategoryComboBox.Text + "\\", SearchOption.TopDirectoryOnly);
                }
            }
            catch
            {

            }
            RefreshDisplay();
        }

        /// <summary>
        /// Редактировать заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm(path[0]);
            noteForm.ShowDialog();
            try
            {
                if (CategoryComboBox.SelectedIndex == 0)
                {
                    RefreshListBox("", SearchOption.AllDirectories);
                }
                else
                {
                    RefreshListBox(CategoryComboBox.Text + "\\", SearchOption.TopDirectoryOnly);
                }
            }
            catch 
            {

            }
            RefreshDisplay();
        }

        /// <summary>
        /// Удалить заметку через меню взаимодействия вверху приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить заметку: \""
                + NotesListBox.SelectedItem.ToString()+"\"", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NotesListBox.Items.Remove(NotesListBox.SelectedItem.ToString());
                File.Delete(path[0]);     
            }
            RefreshDisplay();
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
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
            try
            {
                if (CategoryComboBox.SelectedIndex == 0)
                {
                    RefreshListBox("", SearchOption.AllDirectories);
                }
                else
                {
                    RefreshListBox(CategoryComboBox.Text + "\\", SearchOption.TopDirectoryOnly);
                }
            }
            catch
            {

            }
            RefreshDisplay();
        }

        /// <summary>
        /// Удалить заметку через пиктограмму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить заметку: \""
                + NotesListBox.SelectedItem.ToString() + "\"", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NotesListBox.Items.Remove(NotesListBox.SelectedItem.ToString());
                File.Delete(path[0]);
            }
            RefreshDisplay();
        }

        /// <summary>
        /// Редактировать заметку через пиктограмму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm(path[0]);
            noteForm.ShowDialog();
            try
            {
                if (CategoryComboBox.SelectedIndex == 0)
                {
                    RefreshListBox("", SearchOption.AllDirectories);
                }
                else
                {
                    RefreshListBox(CategoryComboBox.Text + "\\", SearchOption.TopDirectoryOnly);
                }
            }
            catch
            {

            }
            RefreshDisplay();
        }
    }
}
