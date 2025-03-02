using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private LetterCounter _letterCounter;

        // ��������� ����� ������ ������
        [SetUp]
        public void Setup()
        {
            _letterCounter = new LetterCounter();
        }

        [Test]
        public void NoAdjacentDuplicates()
        {
            // ��� ���������� �������� ��������
            Assert.AreEqual(0, _letterCounter.CountAdjacentLetters("������� ������� ������"));
        }

        [Test]
        public void OneAdjacentDuplicate()
        {
            // ���� ���� ���������� �������� ��������: "�����"
            Assert.AreEqual(2, _letterCounter.CountAdjacentLetters("� ����� �����"));
        }

        [Test]
        public void MultipleAdjacentDuplicates()
        {
            // ��������� ���������� �������� ��������: "������ ���� �����"
            // ����: "��", "��", "��", "��"
            Assert.AreEqual(5, _letterCounter.CountAdjacentLetters("������ ���� �����"));
        }

        [Test]
        public void SpacesIgnored()
        {
            // ������� ������������, ���� ���� ���������� �������� ��������: "��"
            Assert.AreEqual(2, _letterCounter.CountAdjacentLetters("����� ��� ������"));
        }

        [Test]
        public void EmptyString()
        {
            // ������ ������, ������� ���������� ��������
            Assert.AreEqual(0, _letterCounter.CountAdjacentLetters(""));
        }


        [Test]
        public void CaseInsensitive()
        {
            // ��������� ������ ������������ �������: "������"
            // ����: "��", "��", "��", "��", "��", "��"
            Assert.AreEqual(6, _letterCounter.CountAdjacentLetters("������"));
        }

        [Test]
        public void MixedCharacters()
        {
            // ��������� �������, ��� "����������"
            // ����: "��", "��", "��", "��", "��", "��", "��", "��", "��", "��"
            Assert.AreEqual(10, _letterCounter.CountAdjacentLetters("����������"));
        }
    }
}
