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
        /// Объект типа Note, хранящий в себе данные
        /// </summary>
        private Note _object = new Note("MyNoteTitle",NoteCategoryEnum.Miscs,"Hello, world!");

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
            ComboBoxNoteCategory.DataSource = Enum.GetValues(typeof(NoteCategoryEnum));
            UpdateForm();
        }

        /// <summary>
        /// Обновляет все элементы управления по данным из объекта
        /// </summary>
        private void UpdateForm()
        {
            ComboBoxNoteCategory.SelectedItem = _object.NoteCategory;
            TextBoxNoteTitle.Text = _object.NoteTitle;   
            NoteDateCreate.Value = _object.CreationTime;
            NoteDateModify.Value = _object.LastModificationTime;
            TextBoxNoteText.Text = _object.NoteText;
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
            _object.NoteCategory = (NoteCategoryEnum)ComboBoxNoteCategory.SelectedItem;
            _object.NoteTitle = TextBoxNoteTitle.Text;
            _object.NoteText = TextBoxNoteText.Text;
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
                _object.NoteTitle = TextBoxNoteTitle.Text;
                _noteTitleError = "";
                TextBoxNoteTitle.BackColor = Color.White;
            }
            catch (ArgumentException exeption)
            {
                _noteTitleError = exeption.Message;
                TextBoxNoteTitle.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработка закрытия формы любым способом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите закрыть окно?",
                "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
