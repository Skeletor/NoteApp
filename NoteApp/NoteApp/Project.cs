using System.Collections.Generic;
using System.Linq;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект", хранящий список всех заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Получает или задает список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Получает или задает последнюю выделенную пользователем заметку
        /// </summary>
        public Note CurrentNote { get; set; } = null;

        /// <summary>
        /// Сортирует список заметок по времени изменения (последняя изменённая заметка будет первой в списке)
        /// </summary>
        /// <param name="project">Список заметок для сортировки</param>
        /// <returns>Отсортированный список <see cref="Project"/></returns>
        public static Project SortProject(Project project)
        {
            if (project != null)
            {
                project.Notes = project.Notes?.OrderByDescending(x => x.LastModifyTime).ToList();
            }

            return project;
        }

        /// <summary>
        /// Сортирует список заметок по времени изменения. В список войдут только те заметки, что совпадают
        /// с указанной категорией <see cref="NoteCategory"/>
        /// </summary>
        /// <param name="project">Список заметок для сортировки</param>
        /// <param name="category">Категория, по которой нужно проводить отбор</param>
        /// <returns>Новая копия отсортированного списка <see cref="Project"/></returns>
        public static Project SortProject(Project project, NoteCategory category)
        {
            if (project == null)
            {
                return project;
            }

            Project tempProject = new Project();

            foreach (var item in project.Notes)
            {
                tempProject.Notes.Add((Note)item.Clone());
            }

            tempProject.Notes = tempProject.Notes
                ?.OrderByDescending(x => x.LastModifyTime)
                .Where(x => x.NoteCategory == category).ToList();

            return tempProject;
        }
    }
}
