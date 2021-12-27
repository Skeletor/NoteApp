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
            var expected = new List<Note>();
            var actual = expected;

            Assert.AreEqual(expected, actual, "Неверное присвоение списка List<Note>");
        }

        [Test(Description = "Тест геттера Notes")]
        public void Test_GetNotes()
        {
            var expected = new List<Note>();
            var temp = expected;
            var actual = temp;

            Assert.AreEqual(expected, actual, "Возврат неправильного списка List<Note>");
        }
    }
}
