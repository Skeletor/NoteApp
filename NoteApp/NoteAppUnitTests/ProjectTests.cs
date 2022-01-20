using NoteApp;
using NUnit.Framework;
using System.Collections.Generic;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        /// <summary>
        /// Временное поле <see cref="Project"/>
        /// </summary>
        private Project _project;

        /// <summary>
        /// Обновляет проект
        /// </summary>
        public void InitProject()
        {
            _project = new Project();
        }

        [Test(Description = "Тест сеттера Notes")]
        public void SetNotes()
        {
            // Setup
            InitProject();
            var expected = new Project(); 

            // Act
            _project.Notes = expected.Notes;

            // Assert
            Assert.AreEqual(expected.Notes, _project.Notes, "Неверное присвоение списка List<Note>");
        }

        [Test(Description = "Тест геттера Notes")]
        public void GetNotes()
        {
            // Setup
            InitProject();
            var expected = new Project();

            // Act
            _project.Notes = expected.Notes;
            var actual = _project;

            // Assert
            Assert.AreEqual(expected.Notes, actual.Notes, "Возврат неправильного списка List<Note>");
        }
    }
}
