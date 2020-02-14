using NUnit.Framework;

namespace UnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsIsogram_TestWordHasNoDuplicateLetters()
        {
            Assert.AreEqual(true,Isograma_kata.Program.IsIsogram("New"));
            Assert.AreEqual(true, Isograma_kata.Program.IsIsogram("Dermatoglyphics"));
            Assert.AreEqual(true, Isograma_kata.Program.IsIsogram("isogram"));
            Assert.AreEqual(false, Isograma_kata.Program.IsIsogram("moose"));
            Assert.AreEqual(false, Isograma_kata.Program.IsIsogram("isIsogram"));
            Assert.AreEqual(false, Isograma_kata.Program.IsIsogram("aba"));
            Assert.AreEqual(false, Isograma_kata.Program.IsIsogram("moOse"));
            Assert.AreEqual(true, Isograma_kata.Program.IsIsogram("thumbscrewjapingly"));
        }
    }
}