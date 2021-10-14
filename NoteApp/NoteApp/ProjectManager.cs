using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сервисный класс, предоставляющий методы для сериализации/десериализации класса "Проект"
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Путь к конфигу JSON
        /// </summary>
        private static readonly string configPath = $"{Environment.CurrentDirectory}\\dataConfig.json";

        /// <summary>
        /// Сохранение проекта в файл
        /// </summary>
        /// <param name="project">Проект, содержащий список заметок</param>
        public static void SaveToFile(Project project)
        {
            using (StreamWriter sw = new StreamWriter(configPath))
            using (JsonWriter jr = new JsonTextWriter(sw))
            {
                new JsonSerializer().Serialize(jr, project);
            }
        }

        /// <summary>
        /// Загружает (десериализует) данные из файла JSON
        /// </summary>
        /// <returns>Новый экземпляр класса Project</returns>
        public static Project LoadFrom()
        {
            using (StreamReader sr = new StreamReader(configPath))
            using (JsonReader jr = new JsonTextReader(sr))
            {
                Project project = (Project)new JsonSerializer().Deserialize<Project>(jr);
                return project;
            }
        }
    }
}
