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
using NoteApp.Model;


namespace NoteApp.View
{
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Цвет корректного ввода данных
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет ошибочного ввода данных
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Объект типа Note, хранящий в себе данные
        /// </summary>
        private Note _note = new Note("MyNoteTitle", NoteCategory.Miscs, "Hello, world!");

        /// <summary>
        /// Текстовая переменная, уведомляющая о наличии ошибок
        /// </summary>
        private string _noteTitleError = "";

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            ComboBoxNoteCategory.DataSource = Enum.GetValues(typeof(NoteCategory));
            UpdateForm();
        }

        /// <summary>
        /// Обновляет все элементы управления по данным из объекта
        /// </summary>
        private void UpdateForm()
        {
            ComboBoxNoteCategory.SelectedItem = _note.NoteCategory;
            TextBoxNoteTitle.Text = _note.Title;
            NoteDateCreate.Value = _note.CreationTime;
            NoteDateModify.Value = _note.LastModificationTime;
            TextBoxNoteText.Text = _note.Text;
        }

        /// <summary>
        /// Проверка формы на наличие ошибок
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_noteTitleError != "")
            {
                MessageBox.Show(_noteTitleError);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Обновляет данные в объекте с элементов пользовательского интерфейса
        /// </summary>
        private void UpdateObject()
        {
            _note.NoteCategory = (NoteCategory)ComboBoxNoteCategory.SelectedItem;
            _note.Title = TextBoxNoteTitle.Text;
            _note.Text = TextBoxNoteText.Text;
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
            CheckFormOnErrors();
            UpdateObject();
        }

        /// <summary>
        /// Обработчик события при изменении текста в TextBox названия заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNoteTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = TextBoxNoteTitle.Text;
                _noteTitleError = "";
                TextBoxNoteTitle.BackColor = _correctColor;
            }
            catch (ArgumentException exception)
            {
                _noteTitleError = exception.Message;
                TextBoxNoteTitle.BackColor = _errorColor;
            }
        }

        /// <summary>
        /// Обработка закрытия формы любым способом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close " +
                "the program?", "A warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
