using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает категорию заметок
    /// </summary>
    public enum NoteCategory
    {
        /// <summary>
        /// Категория "Документы"
        /// </summary>
        Documents,

        /// <summary>
        /// Категория "Финансы"
        /// </summary>
        Finance,

        /// <summary>
        /// Категория "Здоровье и Спорт"
        /// </summary>
        HealthAndSports,

        /// <summary>
        /// Категория "Дом"
        /// </summary>
        Home,

        /// <summary>
        /// Категория "Люди"
        /// </summary>
        People,

        /// <summary>
        /// Категория "Работа"
        /// </summary>
        Work,

        /// <summary>
        /// Категория "Разное"
        /// </summary>
        Miscs
    }
}
