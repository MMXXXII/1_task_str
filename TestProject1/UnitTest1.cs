using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        private LetterCounter _letterCounter;

        [SetUp]
        public void Setup()
        {
            _letterCounter = new LetterCounter();
        }

        [Test]
        public void Test_RegularInput()
        {
            var result = _letterCounter.CountAdjacentLetters("aabbccdd");
            Assert.AreEqual(4, result.Count);
            Assert.Contains(2, result['a']);
            Assert.Contains(2, result['b']);
            Assert.Contains(2, result['c']);
            Assert.Contains(2, result['d']);
        }

        [Test]
        public void Test_WithoutRepeatingLetters()
        {
            var result = _letterCounter.CountAdjacentLetters("abcdefg");
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_WithSpaces()
        {
            var result = _letterCounter.CountAdjacentLetters("aa bb cc");
            Assert.AreEqual(3, result.Count);
            Assert.Contains(2, result['a']);
            Assert.Contains(2, result['b']);
            Assert.Contains(2, result['c']);
        }

        [Test]
        public void Test_EmptyString()
        {
            var result = _letterCounter.CountAdjacentLetters("");
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_CaseInsensitive()
        {
            var result = _letterCounter.CountAdjacentLetters("AABBaa");
            Assert.AreEqual(2, result.Count);
            Assert.Contains(2, result['a']);
            Assert.Contains(2, result['b']);
            Assert.Contains(2, result['a']);
        }
    }
}
