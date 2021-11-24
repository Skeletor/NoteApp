using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сервисный класс, предоставляющий методы для сериализации/десериализации класса "Project"
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Путь к папке с файлом
        /// </summary>
        private static string FolderPath { get; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\NoteApp\";

        /// <summary>
        /// Название файла
        /// </summary>
        private static string FileName { get; } = "NoteList.json";

        /// <summary>
        /// Сохранение проекта в файл
        /// </summary>
        /// <param name="project">Проект, содержащий список заметок</param>
        public static void SaveTo(Project project)
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }

            using (StreamWriter sw = new StreamWriter(FolderPath + FileName))
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
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if (!File.Exists(FileName))
            {
                return new Project();
            }

            try
            {
                using (StreamReader sr = new StreamReader(FolderPath + FileName))
                {
                    using (JsonReader jr = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        Project project = serializer.Deserialize<Project>(jr);

                        return project ?? new Project();
                    }
                }
            }
            catch (Exception)
            {
                return new Project();
            }
            
        }
    }
}
