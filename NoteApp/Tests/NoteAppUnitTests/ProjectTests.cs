using NoteApp;
using NUnit.Framework;

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

        [Test(Description = "Позитивный тест сеттера Notes")]
        public void Test_Notes_SetCorrectValue()
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
        public void Test_Notes_GetValue()
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

