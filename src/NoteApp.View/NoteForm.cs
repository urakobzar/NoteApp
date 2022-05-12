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
        private Note _note;

        /// <summary>
        /// Объект типа Note, являющийся копией основной заметки
        /// Создан для корректной работы при нажатии кнопки Cancel
        /// </summary>
        private Note _noteCopy;

        /// <summary>
        /// Если нажата кнопка OK, то форма закрывается без вопроса
        /// "Are you sure about your decision?"
        /// </summary>
        private bool _isOKPressed;

        /// <summary>
        /// Возвращает или задает значение заметки
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }

        /// <summary>
        /// Текстовая переменная, уведомляющая о наличии ошибок
        /// </summary>
        private string _noteCopyTitleError = "";

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            ComboBoxNoteCategory.DataSource = Enum.GetValues(typeof(NoteCategory));
            _isOKPressed = false;
        }

        /// <summary>
        /// Создает копию текущей заметки и обновляет содержимое формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteForm_Load(object sender, EventArgs e)
        {
            if (_note != null)
            {
                _noteCopy = (Note)_note.Clone();
            }
            else
            {
                _noteCopy = new Note();
            }
            UpdateForm();
        }

        /// <summary>
        /// Обновляет все элементы управления по данным из объекта
        /// </summary>
        private void UpdateForm()
        {
            ComboBoxNoteCategory.SelectedItem = _noteCopy.NoteCategory;
            TextBoxNoteTitle.Text = _noteCopy.Title;
            NoteDateCreate.Value = _noteCopy.CreationTime;
            NoteDateModify.Value = _noteCopy.LastModificationTime;
            TextBoxNoteText.Text = _noteCopy.Text;
        }

        /// <summary>
        /// Проверка формы на наличие ошибок
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_noteCopyTitleError != "")
            {
                MessageBox.Show(_noteCopyTitleError);
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
        private void UpdateNote()
        {
            _noteCopy.NoteCategory = (NoteCategory)ComboBoxNoteCategory.SelectedItem;
            _noteCopy.Title = TextBoxNoteTitle.Text;
            _noteCopy.Text = TextBoxNoteText.Text;
        }

        /// <summary>
        /// Кнопка "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        /// <summary>
        /// Кнопка "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateNote();
            _note = _noteCopy;
            _isOKPressed = true;
            DialogResult = DialogResult.Yes;
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
                _noteCopy.Title = TextBoxNoteTitle.Text;
                _noteCopyTitleError = "";
                TextBoxNoteTitle.BackColor = _correctColor;
            }
            catch (ArgumentException exception)
            {
                _noteCopyTitleError = exception.Message;
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
            if(!_isOKPressed)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure about your decision? ",
                    "A warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
