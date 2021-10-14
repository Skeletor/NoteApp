using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
        private readonly string configPath = $"{Environment.CurrentDirectory}\\NoteApp\\dataConfig.json";

        public void SaveTo(Project project)
        {
            using (StreamWriter sw = new StreamWriter(configPath))
            using (JsonWriter jr = new JsonTextWriter(sw))
            {
                new JsonSerializer().Serialize(jr, project);
            }
        }

        public void LoadFrom()
        {
            using (StreamReader sr = new StreamReader(configPath))
            using (JsonReader jr = new JsonTextReader(sr))
            {
                Note note = (Note)new JsonSerializer().Deserialize<Note>(jr);
            }
        }
    }
}
