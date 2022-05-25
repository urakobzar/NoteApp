using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    public class NoteCategoryTools
    {
        /// <summary>
        /// Словарь, где ключ - перечисление NoteCategory, значение - строковый эквивалент
        /// </summary>
        public Dictionary<NoteCategory, string> CategoriesByEnum = new Dictionary<NoteCategory, string> 
        {

            { NoteCategory.Documents, "Documents" },

            { NoteCategory.Finance, "Finance" },

            { NoteCategory.HealthAndSports, "Health and Sports" },

            { NoteCategory.Home, "Home" },

            { NoteCategory.People, "People" },

            { NoteCategory.Work, "Work" },

            { NoteCategory.Miscs, "Miscs" }

        };

        /// <summary>
        /// Словарь, где ключ - строковый эквивалент эквивалент, значение - перечисление NoteCategory
        /// </summary>
        public Dictionary<string, NoteCategory> CategoriesByString = new Dictionary<string, NoteCategory>
        {

            { "Documents", NoteCategory.Documents },

            { "Finance", NoteCategory.Finance },

            { "Health and Sports", NoteCategory.HealthAndSports },

            { "Home", NoteCategory.Home },

            { "People", NoteCategory.People },

            { "Work", NoteCategory.Work },

            { "Miscs",NoteCategory.Miscs }

        };

    }
}
