using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает заметку
    /// </summary>
    class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _noteTitle = "Без названия";

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategoryEnum _noteCategory;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Время создания
        /// </summary>
        private readonly DateTime _creationTime = DateTime.Now;

        /// <summary>
        /// Время последнего изменения
        /// </summary>
        private DateTime _lastModificationTime;

        /// <summary>
        /// Возвращает или задает название заметки
        /// </summary>
        public string NoteTitle
        {
            get
            {
                return _noteTitle;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"Title must be less than 50 characters." 
                    + $"But was {value.Length}");
                }
                _noteTitle = value;
                LastModificationTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задает категорию заметки
        /// </summary>
        public NoteCategoryEnum NoteCategory
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                _noteCategory = value;
                LastModificationTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задает текст заметки
        /// </summary>
        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
                _noteText = value;
                LastModificationTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задает время создания заметки
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
        }

        /// <summary>
        /// Возвращает или задает время последнего изменения заметки
        /// </summary>
        public DateTime LastModificationTime
        {
            get
            {
                return _lastModificationTime;
            }
            set
            {
                _lastModificationTime = value;
            }
        }

        /// <summary>
        ///  Создает экземпляр <see cref="Note">. 
        /// </summary>
        /// <param name="noteTitle">Название заметки</param>
        /// <param name="noteCategory">Категория заметки</param>
        /// <param name="noteText">Текст заметки</param>
        public Note(string noteTitle, NoteCategoryEnum noteCategory, string noteText)
        {
            NoteTitle = noteTitle;
            NoteCategory = noteCategory;
            NoteText = noteText;
        }

        /// <summary>
        /// Глубокое копирование заметки
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Note(NoteTitle, NoteCategory, NoteText);
        }
    }
}
