using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        private readonly string _path = Environment.CurrentDirectory.ToString() + @"\NoteAppTest.notes";
        private Project _project;
        [SetUp]
        public void InitProject()
        {
            var note = new Note("some text", NoteCategory.Different, "some name");
            _project = new Project(new List<Note> { note });
        }
        [TearDown]
        public void DeleteFile()
        {
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест сериализации")]
        public void TestProjectManagerSaveToFile()
        {
            ProjectManager.SaveToFile(_project,_path);
            Assert.True(File.Exists(_path));
        }


        [Test]
        [TestCase("16.12.2018 21:27:59", "16.12.2018 21:27:59",
            "321312", (NoteCategory)0, "qweqwe", 1,
            TestName = "Тест десериализации если фаил наиден")]
        public void TestProjectManagerLoadFromFile(string timeCreate,string TimeChange,string name,
            NoteCategory noteCategory, string text, int listCount)
        {
            var loadedProject = ProjectManager.LoadFromFile(Environment.CurrentDirectory.ToString() + @"\NoteForTest.notes");
            Assert.AreEqual(listCount, loadedProject.NoteList.Count);
            Assert.AreEqual(name, loadedProject.NoteList[0].Name);
            Assert.AreEqual(noteCategory, loadedProject.NoteList[0].NoteCategory);
            Assert.AreEqual(text, loadedProject.NoteList[0].NoteText);
            Assert.AreEqual(timeCreate, loadedProject.NoteList[0].TimeCreate.ToString());
            Assert.AreEqual(TimeChange, loadedProject.NoteList[0].TimeChange.ToString());
        }


        [Test]
        [TestCase(0,
            TestName = "Тест десериализации если фаил не наиден")]
        public void TestProjectManagerLoadFromFile_FileNotFound(int listCount)
        {
            if (File.Exists(Environment.CurrentDirectory.ToString() + @"\NoteForTest121.notes"))
            {
                File.Delete(Environment.CurrentDirectory.ToString() + @"\NoteForTest121.notes");
            }
            var loadedProject = ProjectManager.LoadFromFile(Environment.CurrentDirectory.ToString() + @"\NoteForTest121.notes");
            Assert.AreEqual(listCount, loadedProject.NoteList.Count);
            File.Delete(Environment.CurrentDirectory.ToString() + @"\NoteForTest121.notes");
        }

        /*[Test]
        [TestCase(
            TestName = "Тест сериализации c путем по умолчанию")]
        public void TestProjectManagerSaveWithDefaultPath()
        {
            ProjectManager.SaveToFile(_project);
            Assert.True(File.Exists(Environment.CurrentDirectory.ToString() + @"\NoteApp.notes"));
        }*/
    }
}
