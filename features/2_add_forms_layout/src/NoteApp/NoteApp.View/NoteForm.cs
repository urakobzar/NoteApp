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
using System.Text.RegularExpressions;


namespace NoteApp.View
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
            ComboBoxNoteCategory.SelectedIndex = 0;
        }

        string globalPath;                                                          //Путь до текстового файла
        string firstName;                                                           //Итоговое название заметки

        public NoteForm(string path)
        {
            InitializeComponent();
            string[] names = path.Split('\\');
            ComboBoxNoteCategory.SelectedItem = names[names.Length - 2];            //Категория заметки
            ComboBoxNoteCategory.Enabled = false;
            TextBoxNoteTitle.Text = names[names.Length - 1].Replace(".txt", "");    //Название заметки
            NoteDateCreate.Value = File.GetCreationTime(path);                      //Дата создания заметки
            NoteDateModify.Value = File.GetLastWriteTime(path);                     //Дата модификации заметки
            TextBoxNoteText.Text = File.ReadAllText(path);                          //Текст заметки
            globalPath = path;                                                      //Путь до текстового файла
            firstName = TextBoxNoteTitle.Text;  
        }

        /// <summary>
        /// Кнопка "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxNoteTitle.Text == "")
            {
                MessageBox.Show("Введите имя заметки");
                return;
            }
            string category = (string)ComboBoxNoteCategory.SelectedItem;
            string name = TextBoxNoteTitle.Text;
            Regex regex = new Regex(@"[<>:/|?*\\]"); 
            if ((regex.Match(name).Success)||(name.Contains("\"")))
            {
                MessageBox.Show("Имя файла не должно содержать следующих знаков: \\ / : * ? \" < > |");
                return;
            }
            try
            {
                string filePath = Directory.GetCurrentDirectory() + "\\AllNotes\\"
                    + category + "\\" + name + ".txt";
                string text = TextBoxNoteText.Text;
                // открываем файл (стираем содержимое файла)
                FileStream fileStream = File.Open(filePath, FileMode.Create);
                // получаем поток
                StreamWriter output = new StreamWriter(fileStream);
                // записываем текст в поток
                output.Write(text);
                // закрываем поток
                output.Close();
                if ((firstName != name) && (globalPath != null))
                {
                    File.Delete(globalPath);
                    globalPath = null;
                }
                Close();
            }
            catch
            {

            }
        }
    }
}
