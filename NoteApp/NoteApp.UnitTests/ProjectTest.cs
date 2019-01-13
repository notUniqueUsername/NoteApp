using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        private Project _project;
        private Note _note;

        [SetUp]
        public void InitProject()
        {
            _note = new Note("some text", NoteCategory.Different, "some name");
            _project = new Project(new List<Note> { _note });
        }

        [Test]
        [TestCase(
            TestName = "Тест Геттера NoteList")]
        public void TestProjectNoteListGet()
        {
            var list = new List<Note> { new Note("some text", NoteCategory.Different, "some name") };
            Assert.AreEqual(list[0].Name, _project.NoteList[0].Name);
            Assert.AreEqual(list[0].NoteCategory, _project.NoteList[0].NoteCategory);
            Assert.AreEqual(list[0].NoteText, _project.NoteList[0].NoteText);
            var testedCreateTime = new DateTime(list[0].TimeCreate.Ticks - list[0].TimeCreate.Ticks % TimeSpan.TicksPerMinute);
            var expectedCreateTime = new DateTime(_project.NoteList[0].TimeCreate.Ticks - _project.NoteList[0].TimeCreate.Ticks % TimeSpan.TicksPerMinute);
            Assert.AreEqual(expectedCreateTime, testedCreateTime);
            var testedChangeTime = new DateTime(list[0].TimeChange.Ticks - list[0].TimeChange.Ticks % TimeSpan.TicksPerMinute);
            var expectedChangeTime = new DateTime(_project.NoteList[0].TimeChange.Ticks - _project.NoteList[0].TimeChange.Ticks % TimeSpan.TicksPerMinute);
            Assert.AreEqual(expectedChangeTime, testedChangeTime);
        }

        [Test]
        [TestCase(
            TestName = "Тест конструктора Project по умолчанию")]
        public void TestProjectDefaultConstructor()
        {
            var testedProject = new Project();
            Assert.AreEqual(0, testedProject.NoteList.Count);
        }

        [Test]
        [TestCase(
            TestName = "Тест конструктора Project")]
        public void TestProjectConstructor()
        {
            Assert.AreEqual(new List<Note> {_note}, _project.NoteList);
        }

        [Test]
        [TestCase(null,
            TestName = "Проверка конструктора на null")]
        public void TestProjectConstructor_IncorrectValue(List<Note> testedValue)
        {
            Assert.Throws<ArgumentNullException>(
                () => { new Project(testedValue); },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Проверка Sort при 0 элементов")]
        public void TestProjectSort_0_elements()
        {
            var project = new Project();
            Assert.Throws<IndexOutOfRangeException>(
                () => { project.SortProject(); },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Тест cортировки Project")]
        public void TestProjectSort()
        {
            var project1 = new Project();
            _project.NoteList.Add(new Note("some text", NoteCategory.Different, "some name"));
            _project.NoteList[1].Name = "test";
            var expectedProject = new Project();
            for (int i = 1; i > -1; i--)
            {
                expectedProject.NoteList.Add(_project.NoteList[i]);
            }
            project1 = new Project(_project.SortProject());
            Assert.AreEqual(expectedProject.NoteList, project1.NoteList);
        }

        [Test]
        [TestCase(
            TestName = "Тест cортировки Project при одном элементе")]
        public void TestProjectSort_1_element()
        {
            var expectedProject = new Project();
            expectedProject = new Project(_project.SortProject());
            Assert.AreEqual(expectedProject.NoteList, _project.NoteList);
        }

    }
}
