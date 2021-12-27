using NoteApp;
using NUnit.Framework;
using System;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note();
        }

        [Test(Description = "Тест геттера Name")]
        public void Test_Name_GetCorrectValue()
        {
            var expected = "Записка1";
            _note.Name = expected;
            var actual = _note.Name;

            Assert.AreEqual(expected, actual, "Возврат неправильного названия Name");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void Test_Name_SetCorrectValue()
        {
            var expected = "Записка1";
            _note.Name = expected;

            Assert.AreEqual(expected, _note.Name, "Неправильное присвоение названия Name");
        }

        [Test(Description = "Негативный тест сеттера Name")]
        public void Test_Name_SetWrongValue()
        {
            var expected = "Записка1Записка1Записка1Записка1Записка1Записка1Записка1";

            Assert.Throws<ArgumentException>(() => {
                _note.Name = expected;
            }, "Должно возникнуть исключение (длина более 50 символов)");

        }

        [Test(Description = "Тест конструктора")]
        public void Test_Constructor()
        {
            var name = "Название";
            var description = "Описание";
            var category = NoteCategory.Job;

            var testNote = new Note(name, description, category);

            Assert.AreEqual(new Note("Название", "Описание", NoteCategory.Job), testNote, "Ошибка в конструкторе Note()");
        }

        [Test(Description = "Тест сеттера NoteCategory")]
        public void Test_SetNoteCategory()
        {
            var expected = NoteCategory.Home;
            _note.NoteCategory = expected;

            Assert.AreEqual(expected, _note.NoteCategory, "Неправильное присвоение категории NoteCategory");
        }

        [Test(Description = "Тест геттера NoteCategory")]
        public void Test_GetNoteCategory()
        {
            var expected = NoteCategory.Finance;
            _note.NoteCategory = expected;
            var actual = _note.NoteCategory;

            Assert.AreEqual(expected, actual, "Возврат неправильной категории NoteCategory");
        }

        [Test(Description = "Тест сеттера NoteText")]
        public void Test_SetNoteText()
        {
            var expected = "Описание";
            _note.NoteText = expected;

            Assert.AreEqual(expected, _note.NoteText, "Неправильное присвоение описания NoteText");
        }

        [Test(Description = "Тест геттера NoteText")]
        public void Test_GetNoteText()
        {
            var expected = "Описание";
            _note.NoteText = expected;
            var actual = _note.NoteText;

            Assert.AreEqual(expected, actual, "Возврат неправильного описания NoteText");
        }

        [Test(Description = "Тест сеттера CreationTime")]
        public void Test_SetCreationTime()
        {
            var expected = DateTime.Now;
            _note.CreationTime = expected;

            Assert.AreEqual(expected, DateTime.Now, "Неправильное присвоение времени CreationTime");
        }

        [Test(Description = "Тест геттера CreationTime")]
        public void Test_GetCreationTime()
        {
            var expected = DateTime.Now;
            _note.CreationTime = expected;
            var actual = _note.CreationTime;

            Assert.AreEqual(expected, actual, "Возврат неправильного времени CreationTime");
        }

        [Test(Description = "Тест сеттера LastModifyTime")]
        public void Test_SetLastModifyTime()
        {
            var expected = DateTime.Now;
            _note.LastModifyTime = expected;
            
            Assert.AreEqual(expected, DateTime.Now, "Неправильное присвоение времени LastModifyTime");
        }

        [Test(Description = "Тест геттера LastModifyTime")]
        public void Test_GetLastModifyTime()
        {
            var expected = DateTime.Now;
            _note.LastModifyTime = expected;
            var actual = _note.LastModifyTime;

            Assert.AreEqual(expected, actual, "Возврат неправильного времени LastModifyTime");
        }

        [Test(Description = "Тест метода Clone")]
        public void Test_Clone()
        {
            var clonedNote = (Note)_note.Clone();

            Assert.AreEqual(clonedNote, _note, "Неправильное клонирование Clone()");
        }

        [Test(Description = "Тест метода Equals на возврат true")]
        public void Test_CorrectEquals()
        {
            var note1 = new Note();
            var note2 = new Note();

            var expected = true;
            var actual = note1.Equals(note2);

            Assert.AreEqual(expected, actual, "Неверное сравнение двух заметок методом Equals");
        }

        [Test(Description = "Тест метода Equals на возврат false")]
        public void Test_WrongEquals()
        {
            var note1 = new Note();
            var note2 = new Note("Другое название");

            var expected = false;
            var actual = note1.Equals(note2);

            Assert.AreEqual(expected, actual, "Неверное сравнение двух заметок методом Equals");
        }

        [Test(Description = "Тест метода ToString")]
        public void Test_ToString()
        {
            var expected = _note.Name;
            var actual = _note.ToString();

            Assert.AreEqual(expected, actual, "Неправильная работа метода ToString");
        }
    }
}
