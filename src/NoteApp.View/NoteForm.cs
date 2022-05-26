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
    /// <summary>
    /// Описывает форму окна добавления/редактирования заметки.
    /// </summary>
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Цвет корректного ввода данных.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет ошибочного ввода данных.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Объект типа Note, хранящий в себе данные.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Объект типа Note, являющийся копией основной заметки.
        /// Создан для корректной работы при нажатии кнопки Cancel.
        /// </summary>
        private Note _noteCopy;

        /// <summary>
        /// Если нажата кнопка OK, то форма закрывается без вопроса
        /// "Do you really want to lose all unsaved data?".
        /// </summary>
        private bool _isOKPressed;

        /// <summary>
        /// Текстовая переменная, уведомляющая о наличии ошибок.
        /// </summary>
        private string _noteCopyTitleError = "";

        /// <summary>
        /// Переменная класса, представляющего из себя два словаря типа 
        /// <Enum, String> и <String, Enum>.
        /// </summary>
        private NoteCategoryTools _noteCategoryTools = new NoteCategoryTools();

        /// <summary>
        /// Возвращает или задает значение заметки.
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
        }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            _isOKPressed = false;
        }

        /// <summary>
        /// Обновляет все элементы управления по данным из объекта.
        /// </summary>
        private void UpdateForm()
        {
            ComboBoxNoteCategory.SelectedItem = _noteCategoryTools.CategoriesByEnum[_noteCopy.NoteCategory];
            TextBoxNoteTitle.Text = _noteCopy.Title;
            NoteDateCreate.Value = _noteCopy.CreationTime;
            NoteDateModify.Value = _noteCopy.LastModificationTime;
            TextBoxNoteText.Text = _noteCopy.Text;
        }

        /// <summary>
        /// Проверка формы на наличие ошибок.
        /// </summary>
        /// <returns>Результат наличия ошибки.</returns>
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
        /// Обновляет данные в объекте с элементов пользовательского интерфейса.
        /// </summary>
        private void UpdateNote()
        {
            _noteCopy.NoteCategory = _noteCategoryTools.CategoriesByString
                [ComboBoxNoteCategory.SelectedItem.ToString()];
            _noteCopy.Title = TextBoxNoteTitle.Text;
            _noteCopy.Text = TextBoxNoteText.Text;
        }

        /// <summary>
        /// Кнопка "Отмена".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Кнопка "ОК".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                UpdateNote();
                _note = _noteCopy;
                _isOKPressed = true;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Обработчик события при изменении текста в TextBox названия заметки.
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
        /// Обработка закрытия формы любым способом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isOKPressed)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to lose all" +
                " unsaved data? ", "Warning", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
