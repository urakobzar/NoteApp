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
            EditNoteToolStripMenuItem1.Enabled = false;
            DeleteNoteToolStripMenuItem1.Enabled = false;
        }

        public static string[] path;

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
            finally
            {

            }
        }

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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNoteToolStripMenuItem1_Click(object sender, EventArgs e)
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
            finally
            {

            }
            RefreshDisplay();
        }

        private void editNoteToolStripMenuItem1_Click(object sender, EventArgs e)
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
            finally
            {

            }
            RefreshDisplay();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((NotesListBox.SelectedItem == null) || (NotesListBox.Items.Count == 0))
                {
                    EditNoteToolStripMenuItem1.Enabled = false;
                    DeleteNoteToolStripMenuItem1.Enabled = false;
                    return;
                }
                else
                {
                    EditNoteToolStripMenuItem1.Enabled = true;
                    DeleteNoteToolStripMenuItem1.Enabled = true;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditNoteToolStripMenuItem1.Enabled = false;
            DeleteNoteToolStripMenuItem1.Enabled = false;
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
            finally
            {

            }
            RefreshDisplay();
        }

        private void deleteNoteToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
