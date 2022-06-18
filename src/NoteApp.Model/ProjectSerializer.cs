using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Environment;
using Newtonsoft.Json;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает сереализацию заметки.
    /// </summary>
    public class ProjectSerializer
    {
        /// <summary>
        /// Путь до файла userdata.json.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Сохраняет данные из экземпляра класса в userdata.json.
        /// </summary>
        /// <param name="project">Сохраняемый экземляр класса Project.</param>
        public void SaveToFile(Project project)
        {
            CreateDirectory();
            JsonSerializer serializer = new JsonSerializer();
            using (var stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter myWriter = new StreamWriter(stream);
                using (JsonWriter writer = new JsonTextWriter(myWriter))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }

        /// <summary>
        /// Загружает данные их userdata.json в экземпляр класса Project.
        /// </summary>
        /// <returns>Инициализированный экземпляр класса Project.</returns>
        public Project LoadFromFile()
        {
            Project project = null;
            CreateDirectory();
            try
            {
            JsonSerializer serializer = new JsonSerializer();
                using (var stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                    StreamReader myReader = new StreamReader(stream);
                using (JsonReader reader = new JsonTextReader(myReader))
                {
                        project = (Project)serializer.Deserialize(reader, typeof(Project));
                    }
                }
                }
            catch
            {
                project = new Project();
            }      
            if (project==null)
            {
                project = new Project();
            }
            return project;
        }

        /// <summary>
        /// Создает пустой экземпляр <see cref="ProjectSerializer">. 
        /// </summary>
        public ProjectSerializer()
        {
            FileName = GetFolderPath(SpecialFolder.ApplicationData)
                    + "\\Kobzar\\NoteApp\\userdata.json";
        }

        /// <summary>
        /// Проверка существования директории и её создание в негативном случае
        /// </summary>
        private void CreateDirectory()
        {
            if (!(Directory.Exists(GetFolderPath(SpecialFolder.ApplicationData)
                + "\\Kobzar\\NoteApp")))
            {
                Directory.CreateDirectory(GetFolderPath(SpecialFolder.ApplicationData)
                    + "\\Kobzar\\NoteApp");
                if (!File.Exists(FileName))
                {
                    File.Create(FileName);
                }
            }
        }
    }
}
