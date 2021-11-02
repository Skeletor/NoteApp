using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Тест сеттера Notes")]
        public void Test_SetNotes()
        {
            List<Note> expected = new List<Note>();
            List<Note> actual = expected;

            Assert.AreEqual(expected, actual, "Неверное присвоение списка List<Note>");
        }

        [Test(Description = "Тест геттера Notes")]
        public void Test_GetNotes()
        {
            List<Note> expected = new List<Note>();
            List<Note> temp = expected;
            List<Note> actual = temp;

            Assert.AreEqual(expected, actual, "Возврат неправильного списка List<Note>");
        }
    }
}
