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
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            MessageBox.Show(path); 
            string name = textBox2.Text;
            // имя файла
            string filePath = "D:\\"+name+".txt";

            // текст для записи в файл
            string text = textBox1.Text;

            // открываем файл (стираем содержимое файла)
            FileStream fileStream = File.Open(filePath, FileMode.Create);

            // получаем поток
            StreamWriter output = new StreamWriter(fileStream);

            // записываем текст в поток
            output.Write(text);

            // закрываем поток
            output.Close();
            Close();
        }
    }
}
