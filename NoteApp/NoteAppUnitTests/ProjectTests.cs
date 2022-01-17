using NoteApp;
using NUnit.Framework;
using System.Collections.Generic;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        private List<Note> _notes;

        [Test(Description = "Тест сеттера Notes")]
        public void SetNotes()
        {
            // Setup
            var expected = new List<Note>(); 

            // Act
            _notes = expected;

            // Assert
            Assert.AreEqual(expected, _notes, "Неверное присвоение списка List<Note>");
        }

        [Test(Description = "Тест геттера Notes")]
        public void GetNotes()
        {
            // Setup
            var expected = new List<Note>();

            // Act
            _notes = expected;
            var actual = _notes;

            // Assert
            Assert.AreEqual(expected, actual, "Возврат неправильного списка List<Note>");
        }
    }
}
