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
            string expected = "Записка1";
            _note.Name = expected;
            string actual = _note.Name;

            Assert.AreEqual(expected, actual, "Возврат неправильного названия Name");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void Test_Name_SetCorrectValue()
        {
            string expected = "Записка1";
            _note.Name = expected;

            Assert.AreEqual(expected, _note.Name, "Неправильное присвоение названия Name");
        }

        [Test(Description = "Негативный тест сеттера Name")]
        public void Test_Name_SetWrongValue()
        {
            string expected = "Записка1Записка1Записка1Записка1Записка1Записка1Записка1";

            Assert.Throws<ArgumentException>(() => {
                _note.Name = expected;
            }, "Должно возникнуть исключение (длина более 50 символов)");

        }

        [Test(Description = "Тест конструктора")]
        public void Test_Constructor()
        {
            string name = "Название";
            string description = "Описание";
            NoteCategory category = NoteCategory.Job;

            Note testNote = new Note(name, description, category);

            Assert.AreEqual(new Note("Название", "Описание", NoteCategory.Job), testNote, "Ошибка в конструкторе Note()");
        }

        [Test(Description = "Тест сеттера NoteCategory")]
        public void Test_SetNoteCategory()
        {
            NoteCategory expected = NoteCategory.Home;
            _note.NoteCategory = expected;

            Assert.AreEqual(expected, _note.NoteCategory, "Неправильное присвоение категории NoteCategory");
        }

        [Test(Description = "Тест геттера NoteCategory")]
        public void Test_GetNoteCategory()
        {
            NoteCategory expected = NoteCategory.Finance;
            _note.NoteCategory = expected;
            NoteCategory actual = _note.NoteCategory;

            Assert.AreEqual(expected, actual, "Возврат неправильной категории NoteCategory");
        }

        [Test(Description = "Тест сеттера NoteText")]
        public void Test_SetNoteText()
        {
            string expected = "Описание";
            _note.NoteText = expected;

            Assert.AreEqual(expected, _note.NoteText, "Неправильное присвоение описания NoteText");
        }

        [Test(Description = "Тест геттера NoteText")]
        public void Test_GetNoteText()
        {
            string expected = "Описание";
            _note.NoteText = expected;
            string actual = _note.NoteText;

            Assert.AreEqual(expected, actual, "Возврат неправильного описания NoteText");
        }

        [Test(Description = "Тест сеттера CreationTime")]
        public void Test_SetCreationTime()
        {
            DateTime expected = DateTime.Now;
            _note.CreationTime = expected;

            Assert.AreEqual(expected, DateTime.Now, "Неправильное присвоение времени CreationTime");
        }

        [Test(Description = "Тест геттера CreationTime")]
        public void Test_GetCreationTime()
        {
            DateTime expected = DateTime.Now;
            _note.CreationTime = expected;
            DateTime actual = _note.CreationTime;

            Assert.AreEqual(expected, actual, "Возврат неправильного времени CreationTime");
        }

        [Test(Description = "Тест сеттера LastModifyTime")]
        public void Test_SetLastModifyTime()
        {
            DateTime expected = DateTime.Now;
            _note.LastModifyTime = expected;
            
            Assert.AreEqual(expected, DateTime.Now, "Неправильное присвоение времени LastModifyTime");
        }

        [Test(Description = "Тест геттера LastModifyTime")]
        public void Test_GetLastModifyTime()
        {
            DateTime expected = DateTime.Now;
            _note.LastModifyTime = expected;
            DateTime actual = _note.LastModifyTime;

            Assert.AreEqual(expected, actual, "Возврат неправильного времени LastModifyTime");
        }

        [Test(Description = "Тест метода Clone")]
        public void Test_Clone()
        {
            Note clonedNote = (Note)_note.Clone();

            Assert.AreEqual(clonedNote, _note, "Неправильное клонирование Clone()");
        }

        [Test(Description = "Позитивный тест метода Equals")]
        public void Test_CorrectEquals()
        {
            Note note1 = new Note();
            Note note2 = new Note();

            bool expected = true;
            bool actual = note1.Equals(note2);

            Assert.AreEqual(expected, actual, "Неверное сравнение двух заметок методом Equals");
        }

        [Test(Description = "Негативный тест метода Equals")]
        public void Test_WrongEquals()
        {
            Note note1 = new Note();
            Note note2 = new Note("Другое название");

            bool expected = false;
            bool actual = note1.Equals(note2);

            Assert.AreEqual(expected, actual, "Неверное сравнение двух заметок методом Equals");
        }

        [Test(Description = "Тест метода ToString")]
        public void Test_ToString()
        {
            string expected = _note.Name;
            string actual = _note.ToString();

            Assert.AreEqual(expected, actual, "Неправильная работа метода ToString");
        }
    }
}
