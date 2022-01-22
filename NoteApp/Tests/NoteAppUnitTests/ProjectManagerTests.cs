using NUnit.Framework;
using System.IO;
using NoteApp;
using System;
using System.Reflection;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        /// <summary>
        /// Переменная для тестов
        /// </summary>
        private Project _project;

        /// <summary>
        /// "Конструктор" для поля _project
        /// </summary>
        public void InitProject() => _project = new Project();

        /// <summary>
        /// Задание пути к папке с тестами для <see cref="ProjectManager"/>
        /// </summary>
        public string SetPath() => Environment.CurrentDirectory + @"\TestData\";

        /// <summary>
        /// Задание имени файла
        /// </summary>
        /// <returns></returns>
        public string SetTestFileName() => "testname.json";

        /// <summary>
        /// Тестовый файл с рабочими данными
        /// </summary>
        /// <returns></returns>
        public string GoodFileName() => "GoodData.json";

        [Test(Description = "Позитивный тест сеттера FolderPath")]
        public void Test_Set_CorrectFolderPath()
        {
            // Setup
            InitProject();
            var actual = SetPath();

            // Act
            ProjectManager.FolderPath = actual;

            // Assert
            Assert.AreEqual(actual, ProjectManager.FolderPath, "Неправильное присвоение пути в " +
                nameof(ProjectManager.FolderPath));
        }

        [Test(Description = "Тест геттера FolderPath")]
        public void Test_Get_CorrectFolderPath()
        {
            // Setup
            InitProject();
            var actual = SetPath();

            // Act
            ProjectManager.FolderPath = actual;
            var expected = ProjectManager.FolderPath;

            // Assert
            Assert.AreEqual(actual, expected, "Возврат неправильного пути из " +
                nameof(ProjectManager.FolderPath));
        }

        [Test(Description = "Позитивный тест сеттера FileName")]
        public void Test_Set_CorrectFileName()
        {
            // Setup
            InitProject();
            var actual = SetTestFileName();

            // Act
            ProjectManager.FileName = actual;

            // Assert
            Assert.AreEqual(actual, ProjectManager.FileName, "Неправильное присвоение имени в " +
                nameof(ProjectManager.FileName));
        }

        [Test(Description = "Тест геттера FileName")]
        public void Test_Get_CorrectFileName()
        {
            // Setup
            InitProject();
            var actual = SetTestFileName();

            // Act
            ProjectManager.FileName = actual;
            var expected = ProjectManager.FileName;

            // Assert
            Assert.AreEqual(actual, expected, "Возврат неправильного имени из " +
                nameof(ProjectManager.FileName));
        }

        [Test(Description = "Тест метода SaveTo - проверка на создание каталога")]
        public void Test_SaveTo_IsFolderCreated()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            if (Directory.Exists(ProjectManager.FolderPath))
            {
                Directory.Delete(ProjectManager.FolderPath, true);
            }

            // Act
            ProjectManager.SaveTo(_project);

            // Assert
            var directoryExists = Directory.Exists(ProjectManager.FolderPath);
            Assert.IsTrue(directoryExists, "Каталог не был создан");
        }

        [Test(Description = "Тест метода SaveTo - проверка на создание файла")]
        public void Test_SaveTo_IsFileCreated()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            if (File.Exists(ProjectManager.FolderPath + ProjectManager.FileName))
            {
                File.Delete(ProjectManager.FolderPath + ProjectManager.FileName);
            }

            // Act
            ProjectManager.SaveTo(_project);

            // Assert
            var fileExists = File.Exists(ProjectManager.FolderPath + ProjectManager.FileName);
            Assert.IsTrue(fileExists, "Файл не был создан");
        }

        [Test(Description = "Тест метода SaveTo - проверка на правильность сохранения")]
        public void Test_SaveTo_CorrectProject_SavedCorrectly()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            // Act
            ProjectManager.SaveTo(_project);

            // Assert
            var expectedText = File.ReadAllText(ProjectManager.FolderPath + ProjectManager.FileName);
            var actualText = File.ReadAllText(ProjectManager.FolderPath + GoodFileName());
            Assert.AreEqual(expectedText, actualText, "Неверное сохранение");
        }

        [Test(Description = "Тест метода LoadFrom - проверка на правильность загрузки")]
        public void Test_LoadFrom_CorrectProject_CorrectLoad()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();
            ProjectManager.SaveTo(_project);

            // Act
            var actualProject = ProjectManager.LoadFrom();

            // Assert
            Assert.NotNull(actualProject, "Проект не существует");
            Assert.AreEqual(_project.Notes.Count, actualProject.Notes.Count, "Не совпадает кол-во заметок");

            for (int i = 0; i < _project.Notes.Count; ++i)
            {
                var expected = _project.Notes[i];
                var actual = actualProject.Notes[i];

                Assert.AreEqual(expected, actual, "Несовпадение заметок");
            }
        }

        [Test(Description = "Тест метода LoadFrom - проверка на загрузку несуществующего файла")]
        public void Test_LoadFrom_LoadFromFictionalFile_ReturnsEmptyProject()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = "fictionalfilename.json";

            // Act
            var actual = ProjectManager.LoadFrom();

            // Assert
            Assert.IsNotNull(actual, "Нулевой проект");
            Assert.AreEqual(actual.Notes.Count, 0, "Количество заметок не 0");
        }
    }
}