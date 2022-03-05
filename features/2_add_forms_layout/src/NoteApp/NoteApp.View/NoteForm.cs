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

        string globalPath;
        string firstName;

        public NoteForm(string path)
        {
            InitializeComponent();
            string[] names = path.Split('\\');
            ComboBoxNoteCategory.SelectedItem = names[names.Length - 2];
            ComboBoxNoteCategory.Enabled = false;
            TextBoxNoteTitle.Text = names[names.Length - 1].Replace(".txt", "");
            NoteDateCreate.Value = File.GetCreationTime(path);
            NoteDateModify.Value = File.GetLastWriteTime(path);
            TextBoxNoteText.Text = File.ReadAllText(path);
            globalPath = path;
            firstName = TextBoxNoteTitle.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
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
            if ((firstName!=name)&&(globalPath!=null))
            {
                File.Delete(globalPath);
                globalPath = null;
            }
            Close();
        }
    }
}
