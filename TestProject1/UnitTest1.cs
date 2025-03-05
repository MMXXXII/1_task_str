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
            var result = _letterCounter.CountAdjacentLetters("������� ������� ������");
            Assert.AreEqual(0, result.Count); // ���������, ��� ��� ���������� �������� ����
        }

        [Test]
        public void OneAdjacentDuplicate()
        {
            // ���� ���� ���������� �������� ��������: "�����"
            var result = _letterCounter.CountAdjacentLetters("� ����� �����");
            Assert.AreEqual(1, result['�'].Count); // ���������, ��� ��� '�' ���� ����
        }

        [Test]
        public void MultipleAdjacentDuplicates()
        {
            // ��������� ���������� �������� ��������: "������ ���� �����"
            // ����: "��", "��", "��", "��"
            var result = _letterCounter.CountAdjacentLetters("������ ���� �����");
            Assert.AreEqual(3, result['�'].Count); // ��� ������ ��� '�'
            Assert.AreEqual(2, result['�'].Count); // ��� ������ ��� '�'
        }


        [Test]
        public void SpacesIgnored()
        {
            // ������� ������������, ���� ���� ���������� �������� ��������: "��"
            var result = _letterCounter.CountAdjacentLetters("����� ��� ������");
            Assert.AreEqual(2, result['�'].Count); // ������� 1 ���� ��� '�'
        }

        [Test]
        public void EmptyString()
        {
            // ������ ������, ������� ���������� ��������
            var result = _letterCounter.CountAdjacentLetters("");
            Assert.AreEqual(0, result.Count); // ������ ���, ��������� �������
        }


        [Test]
        public void SingleCharacterString()
        {
            // ������ �� ������ �������, ������� ���������� �������� ��������
            var result = _letterCounter.CountAdjacentLetters("A");
            Assert.AreEqual(0, result.Count); // ������� ���������� �������� ����
        }
    }
}
