using NUnit.Framework;
using System.IO;
using NoteApp;
using System;

namespace NoteAppUnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _project;

        [SetUp]
        public void InitProject()
        {
            _project = new Project();
        }

        [Test(Description = "Тест сеттера FolderPath")]
        public void Test_Set_FolderPath()
        {
            var actual = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}" +
                @"\NoteAppTest\";

            ProjectManager.FolderPath = actual;
            
            Assert.AreEqual(actual, ProjectManager.FolderPath, "Неправильное присвоение пути в " +
                nameof(ProjectManager.FolderPath));
        }
        
        [Test(Description = "Тест геттера FolderPath")]
        public void Test_Get_FolderPath()
        {
            var actual = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}" +
                @"\NoteAppTest\";

            ProjectManager.FolderPath = actual;
            var expected = ProjectManager.FolderPath;

            Assert.AreEqual(actual, expected, "Возврат неправильного пути из " +
                nameof(ProjectManager.FolderPath));
        }

        [Test(Description = "Тест сеттера FileName")]
        public void Test_Set_FileName()
        {
            var actual = "testName";
            ProjectManager.FileName = actual;

            Assert.AreEqual(actual, ProjectManager.FileName, "Неправильное присвоение имени в " +
                nameof(ProjectManager.FileName));
        }

        [Test(Description = "Тест геттера FileName")]
        public void Test_Get_FileName()
        {
            var actual = "testname";
            ProjectManager.FileName = actual;
            var expected = ProjectManager.FileName;

            Assert.AreEqual(actual, expected, "Возврат неправильного имени из " +
                nameof(ProjectManager.FileName));
        }

        [Test(Description = "Тест метода SaveTo - проверка на создание каталога")]
        public void Test_SaveTo_FolderPath()
        {
            var testNoteAppPath = 
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\NoteAppTest\";

            ProjectManager.FolderPath = testNoteAppPath;
            ProjectManager.SaveTo(_project);

            Assert.IsTrue(Directory.Exists(testNoteAppPath), "Каталог не был создан");
        }

        [Test(Description = "Тест метода SaveTo - проверка на создание файла")]
        public void Test_SaveTo_FileName()
        {
            var testFileName = "testName.json";
            var testNoteAppPath =
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\NoteAppTest\";

            ProjectManager.FolderPath = testNoteAppPath;
            ProjectManager.FileName = testFileName;
            ProjectManager.SaveTo(_project);

            Assert.IsTrue(File.Exists(testNoteAppPath + testFileName), "Файл не был создан");
        }

        [Test(Description = "Тест метода LoadFrom - проверка на создание каталога")]
        public void Test_LoadFrom_FolderPath()
        {
            var testNoteAppPath =
                $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\NoteAppTest1\";

            ProjectManager.FolderPath = testNoteAppPath;
            ProjectManager.LoadFrom();

            Assert.IsTrue(Directory.Exists(testNoteAppPath), "Каталог не был создан");
        }


    }
}
