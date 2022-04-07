using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает проект
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех заметок, созданных в приложении
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        public Project()
        {

        }
    }

}
