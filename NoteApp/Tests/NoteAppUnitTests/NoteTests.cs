using NoteApp;
using NUnit.Framework;
using System;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class NoteTests
    {
        /// <summary>
        /// Переменная для тестов
        /// </summary>
        private Note _note;

        /// <summary>
        /// Обновление заметки
        /// </summary>
        public void InitNote()
        {
            _note = new Note();
        }

        [Test(Description = "Тест геттера Name")]
        public void Test_Name_GetCorrectValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = "Записка1";
            _note.Name = expected;
            var actual = _note.Name;

            // Assert
            Assert.AreEqual(expected, actual, "Возврат неправильного названия Name");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void Test_Name_SetCorrectValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = "Записка1";
            _note.Name = expected;

            // Assert
            Assert.AreEqual(expected, _note.Name, "Неправильное присвоение названия Name");
        }

        [Test(Description = "Негативный тест сеттера Name")]
        public void Test_Name_SetWrongValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = "123456789 123456789 123456789 123456789 123456789 123456789";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                _note.Name = expected;
            },
            "Должно возникнуть исключение (длина более 50 символов)");
        }

        [Test(Description = "Тест конструктора")]
        public void Test_Constructor()
        {
            // Setup
            InitNote();

            // Act
            var name = "Название";
            var description = "Описание";
            var category = NoteCategory.Job;
            var testNote = new Note(name, description, category);

            // Assert
            Assert.AreEqual(new Note("Название", "Описание", NoteCategory.Job), testNote, "Ошибка в конструкторе Note()");
        }

        [Test(Description = "Тест сеттера NoteCategory")]
        public void Test_NoteCategory_SetCorrectValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = NoteCategory.Home;
            _note.NoteCategory = expected;

            // Assert
            Assert.AreEqual(expected, _note.NoteCategory, "Неправильное присвоение категории NoteCategory");
        }

        [Test(Description = "Тест геттера NoteCategory")]
        public void Test_GetNoteCategory()
        {
            // Setup
            InitNote();

            // Act
            var expected = NoteCategory.Finance;
            _note.NoteCategory = expected;
            var actual = _note.NoteCategory;

            // Assert
            Assert.AreEqual(expected, actual, "Возврат неправильной категории NoteCategory");
        }

        [Test(Description = "Тест сеттера NoteText")]
        public void Test_NoteText_SetCorrectValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = "Описание";
            _note.NoteText = expected;

            // Assert
            Assert.AreEqual(expected, _note.NoteText, "Неправильное присвоение описания NoteText");
        }

        [Test(Description = "Тест геттера NoteText")]
        public void Test_NoteText_GetValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = "Описание";
            _note.NoteText = expected;
            var actual = _note.NoteText;

            // Assert
            Assert.AreEqual(expected, actual, "Возврат неправильного описания NoteText");
        }

        [Test(Description = "Тест сеттера CreationTime")]
        public void Test_CreationTime_SetCorrectValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = DateTime.Now;
            _note.CreationTime = expected;

            // Assert
            Assert.AreEqual(expected, DateTime.Now, "Неправильное присвоение времени CreationTime");
        }

        [Test(Description = "Тест геттера CreationTime")]
        public void Test_CreationTime_GetValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = DateTime.Now;
            _note.CreationTime = expected;
            var actual = _note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual, "Возврат неправильного времени CreationTime");
        }

        [Test(Description = "Тест сеттера LastModifyTime")]
        public void Test_LastModifyTime_SetCorrectValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = DateTime.Now;
            _note.LastModifyTime = expected;

            // Assert
            Assert.AreEqual(expected, DateTime.Now, "Неправильное присвоение времени LastModifyTime");
        }

        [Test(Description = "Тест геттера LastModifyTime")]
        public void Test_LastModifyTime_GetValue()
        {
            // Setup
            InitNote();

            // Act
            var expected = DateTime.Now;
            _note.LastModifyTime = expected;
            var actual = _note.LastModifyTime;

            // Assert
            Assert.AreEqual(expected, actual, "Возврат неправильного времени LastModifyTime");
        }

        [Test(Description = "Тест метода Clone")]
        public void Test_Clone()
        {
            // Setup
            InitNote();

            // Act
            var clonedNote = (Note)_note.Clone();

            // Assert
            Assert.AreEqual(clonedNote, _note, "Неправильное клонирование Clone()");
        }

        [Test(Description = "Тест метода Equals на возврат true")]
        public void Test_CorrectEquals()
        {
            // Setup
            var note1 = new Note();
            var note2 = new Note();

            // Act
            var expected = true;
            var actual = note1.Equals(note2);

            // Assert
            Assert.AreEqual(expected, actual, "Неверное сравнение двух заметок методом Equals");
        }

        [Test(Description = "Тест метода Equals на возврат false")]
        public void Test_WrongEquals()
        {
            // Setup
            var note1 = new Note();
            var note2 = new Note("Другое название");

            // Act
            var expected = false;
            var actual = note1.Equals(note2);

            // Assert
            Assert.AreEqual(expected, actual, "Неверное сравнение двух заметок методом Equals");
        }

        [Test(Description = "Тест метода ToString")]
        public void Test_ToString()
        {
            // Setup
            InitNote();

            // Act
            var expected = _note.Name;
            var actual = _note.ToString();

            // Assert
            Assert.AreEqual(expected, actual, "Неправильная работа метода ToString");
        }
    }
}