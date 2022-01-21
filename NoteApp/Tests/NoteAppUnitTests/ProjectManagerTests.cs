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
        public string SetPath() => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + 
            @"\TestData\";

        /// <summary>
        /// Задание имени файла
        /// </summary>
        /// <returns></returns>
        public string SetTestFileName() => "testname.json";

        [Test(Description = "Тест сеттера FolderPath")]
        public void Set_FolderPath()
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
        public void Get_FolderPath()
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

        [Test(Description = "Тест сеттера FileName")]
        public void Set_FileName()
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
        public void Get_FileName()
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
        public void SaveTo_FolderExists_ReturnsTrue()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            // Act
            if (Directory.Exists(ProjectManager.FolderPath))
            {
                Directory.Delete(ProjectManager.FolderPath, true);
            }

            ProjectManager.SaveTo(_project);

            // Assert
            var directoryExists = Directory.Exists(ProjectManager.FolderPath);
            Assert.IsTrue(directoryExists, "Каталог не был создан");
        }

        [Test(Description = "Тест метода SaveTo - проверка на создание файла")]
        public void SaveTo_FileExists_ReturnsTrue()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            // Act
            if (File.Exists(ProjectManager.FolderPath + ProjectManager.FileName))
            {
                File.Delete(ProjectManager.FolderPath + ProjectManager.FileName);
            }

            ProjectManager.SaveTo(_project);

            // Assert
            var fileExists = File.Exists(ProjectManager.FolderPath + ProjectManager.FileName);
            Assert.IsTrue(fileExists, "Файл не был создан");
        }

        [Test(Description = "Тест метода SaveTo - проверка на правильность сохранения")]
        public void SaveTo_CorrectSave()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            // Act
            ProjectManager.SaveTo(_project);
            ProjectManager.FileName = "anotherTestFile.json";
            var expected = new Project();
            ProjectManager.SaveTo(expected);

            // Assert
            var expectedText = File.ReadAllText(ProjectManager.FolderPath + ProjectManager.FileName);
            var actualText = File.ReadAllText(ProjectManager.FolderPath + SetTestFileName());
            Assert.AreEqual(expectedText, actualText, "Неверное сохранение");
        }

        [Test(Description = "Тест метода LoadFrom - проверка на создание каталога")]
        public void LoadFrom_FolderExists_ReturnsTrue()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            // Act
            if (Directory.Exists(ProjectManager.FolderPath))
            {
                Directory.Delete(ProjectManager.FolderPath, true);
            }

            ProjectManager.LoadFrom();

            // Assert
            var directoryExists = Directory.Exists(ProjectManager.FolderPath);
            Assert.IsTrue(directoryExists, "Каталог не был создан");
        }

        [Test(Description = "Тест метода LoadFrom - проверка на правильность загрузки")]
        public void LoadFrom_CorrectLoad()
        {
            // Setup
            InitProject();
            ProjectManager.FolderPath = SetPath();
            ProjectManager.FileName = SetTestFileName();

            // Act
            ProjectManager.SaveTo(_project);
            var actualProject = ProjectManager.LoadFrom();

            // Assert
            Assert.NotNull(actualProject, "Проект не существует");
            Assert.AreEqual(_project.Notes.Count, actualProject.Notes.Count, "Не совпадает кол-во заметок");

            for (int i = 0; i < _project.Notes.Count; ++i)
            {
                var expected = _project.Notes[i];
                var actual = actualProject.Notes[i];

                Assert.AreEqual(expected.Name, actual.Name, "Имена не совпадают");
                Assert.AreEqual(expected.NoteText, actual.NoteText, "Тексты не совпадают");
                Assert.AreEqual(expected.NoteCategory, actual.NoteCategory, "Категории не совпадают");
                Assert.AreEqual(expected.CreationTime, actual.CreationTime, "Времена создания не совпадают");
                Assert.AreEqual(expected.LastModifyTime, actual.LastModifyTime, "Времена последнего изменения не совпадают");
            }
        }
    }
}