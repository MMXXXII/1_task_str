using NUnit.Framework;

namespace TestProject3
{
    public class Tests
    {
        [Test]
        public void NoAdjacentDuplicates()
        {
            Assert.AreEqual(0, LetterAnalyzer.CountAdjacentDuplicates("������� ������� ������"));
        }

        [Test]
        public void OneAdjacentDuplicate()
        {
            Assert.AreEqual(1, LetterAnalyzer.CountAdjacentDuplicates("� ����� �����"));
        }

        [Test]
        public void MultipleAdjacentDuplicates()
        {
            Assert.AreEqual(3, LetterAnalyzer.CountAdjacentDuplicates("������ ���� �����"));
        }

        [Test]
        public void SpacesIgnored()
        {
            Assert.AreEqual(1, LetterAnalyzer.CountAdjacentDuplicates("����� ��� ������"));
        }


        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(0, LetterAnalyzer.CountAdjacentDuplicates(""));
        }

        [Test]
        public void NullInput()
        {
            Assert.AreEqual(0, LetterAnalyzer.CountAdjacentDuplicates(null));
        }
    }
}
