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
    public class ProjectSerializer
    {
        Stream stream;

        public string FileName { get; set; }

        public void SaveToFile(Project project)
        {
            if (!(Directory.Exists(Environment.GetFolderPath(SpecialFolder.ApplicationData) 
                + "\\Kobzar\\NoteApp")))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(SpecialFolder.ApplicationData) 
                    + "\\Kobzar\\NoteApp");
                if (!File.Exists(FileName))
                {
                    File.Create(FileName);
                }
            }
            JsonSerializer serializer = new JsonSerializer();
            using (stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter myWriter = new StreamWriter(stream);
                using (JsonWriter writer = new JsonTextWriter(myWriter))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }

        public Project LoadFromFile()
        {
            Project project = null;
            if (!(Directory.Exists(Environment.GetFolderPath(SpecialFolder.ApplicationData)
                + "\\Kobzar\\NoteApp")))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(SpecialFolder.ApplicationData)
                    + "\\Kobzar\\NoteApp");
                if (!File.Exists(FileName))
                {
                    File.Create(FileName);
                }
            }
            JsonSerializer serializer = new JsonSerializer();
            using (stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                StreamReader myReader = new StreamReader(stream);
                using (JsonReader reader = new JsonTextReader(myReader))
                {
                    project = (Project)serializer.Deserialize(reader);
                }
            }      

            if (project == null)
            {
                project = new Project();
            }
            return project;
        }

        public ProjectSerializer()
        {
            FileName = Environment.GetFolderPath(SpecialFolder.ApplicationData)
                    + "\\Kobzar\\NoteApp\\userdata.json";
        }
    }
}
