using System;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note("some text", NoteCategory.Different,"some name");
        }

        [Test]
        [TestCase(
            TestName = "Тест геттера времени создания")]
        public void TestTimeCreateGet()
        {
            var testedTime = new DateTime(_note.TimeCreate.Ticks - _note.TimeCreate.Ticks % TimeSpan.TicksPerMinute);
            var time = DateTime.Now;
            var expectedTime = new DateTime(time.Ticks - time.Ticks % TimeSpan.TicksPerMinute);
            Assert.AreEqual(expectedTime, testedTime);
        }

        [Test]
        [TestCase(
            TestName = "Тест геттера времени Изменения")]
        public void TestTimeChangeGet()
        {
            _note.NoteText = "some text";
            var testedTime = new DateTime(_note.TimeChange.Ticks - _note.TimeChange.Ticks % TimeSpan.TicksPerMinute);
            var time = DateTime.Now;
            var expectedTime = new DateTime(time.Ticks - time.Ticks % TimeSpan.TicksPerMinute);
            Assert.AreEqual(expectedTime, testedTime);
        }

        [Test]
        [TestCase("correct name","correct name",
            TestName ="Присовение корректного названия")]
        [TestCase("", "Без названия",
            TestName = "Присовение пустого названия")]
        [TestCase(" correct name ", "correct name",
            TestName = "Присовение корректного названия с пробелами в конце и начале")]
        public void TestNameSet_CorrectValue(string testedValue, string expectedValue)
        {
            _note.Name = testedValue;
            Assert.AreEqual(expectedValue, _note.Name);
        }

        [Test]
        [TestCase("correct namecorrect namecorrect namecorrect namecorrect namecorrect namecorrect namecorrect namecorrect namecorrect namecorrect namecorrect name",
            TestName = "Присовение название длиннее 50 символов")]
        public void TestNameSet_IncorrectValue(string testedValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _note.Name = testedValue; },
                "Error");
        }

        [Test]
        [TestCase("some name",
            TestName = "Тест геттера Name")]
        public void TestNameGet(string expectedValue)
        {
            Assert.AreEqual(expectedValue, _note.Name);
        }

        [Test]
        [TestCase(NoteCategory.Home,NoteCategory.Home,
            TestName = "Тест сеттера NoteCategory")]
        public void TestNoteCategorySet(NoteCategory testedValue, NoteCategory expectedValue)
        {
            _note.NoteCategory = testedValue;
            var testedTime = new DateTime(_note.TimeChange.Ticks - _note.TimeChange.Ticks % TimeSpan.TicksPerMinute);
            var time = DateTime.Now;
            var expectedTime = new DateTime(time.Ticks - time.Ticks % TimeSpan.TicksPerMinute);
            Assert.AreEqual(expectedTime, testedTime);
            Assert.AreEqual(expectedValue, _note.NoteCategory);
        }

        [Test]
        [TestCase(NoteCategory.Different,
            TestName = "Тест Геттера NoteCategory")]
        public void TestNoteCategoryGet(NoteCategory expectedValue)
        {
            Assert.AreEqual(expectedValue, _note.NoteCategory);
        }

        [Test]
        [TestCase("test", "test",
            TestName = "Тест сеттера NoteText")]
        public void TestNoteTextSet(string testedValue, string expectedValue)
        {
            _note.NoteText = testedValue;
            var testedTime = new DateTime(_note.TimeChange.Ticks - _note.TimeChange.Ticks % TimeSpan.TicksPerMinute);
            var time = DateTime.Now;
            var expectedTime = new DateTime(time.Ticks - time.Ticks % TimeSpan.TicksPerMinute);
            Assert.AreEqual(expectedTime, testedTime);
            Assert.AreEqual(expectedValue, _note.NoteText);
        }

        [Test]
        [TestCase("some text",
            TestName = "Тест Геттера NoteText")]
        public void TestNoteTextGet(string expectedValue)
        {
            Assert.AreEqual(expectedValue, _note.NoteText);
        }

        [Test]
        [TestCase("some text", NoteCategory.Different, "some name",
            TestName = "Тест конструктора Note")]
        public void TestNoteConstructor(string expectedText,
            NoteCategory expectedCategory, string expectedName)
        {
            Assert.AreEqual(expectedName, _note.Name);
            Assert.AreEqual(expectedCategory, _note.NoteCategory);
            Assert.AreEqual(expectedText, _note.NoteText);
        }

        [Test]
        [TestCase(
            TestName = "Тест метода clone()")]
        public void TestNoteClone()
        {
            var testedNote = (Note)_note.Clone();
            var expectedNote = _note;
            Assert.AreEqual(expectedNote.Name, testedNote.Name);
            Assert.AreEqual(expectedNote.NoteText, testedNote.NoteText);
            Assert.AreEqual(expectedNote.NoteCategory, testedNote.NoteCategory);
            Assert.AreEqual(expectedNote.TimeChange, testedNote.TimeChange);
            Assert.AreEqual(expectedNote.TimeCreate, testedNote.TimeCreate);
        }
    }
}
