using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private LetterCounter _letterCounter;

        // Настройка перед каждым тестом
        [SetUp]
        public void Setup()
        {
            _letterCounter = new LetterCounter();
        }

        [Test]
        public void NoAdjacentDuplicates()
        {
            // Нет одинаковых соседних символов
            Assert.AreEqual(0, _letterCounter.CountAdjacentLetters("Сегодня хорошая погода"));
        }

        [Test]
        public void OneAdjacentDuplicate()
        {
            // Одна пара одинаковых соседних символов: "пиццу"
            Assert.AreEqual(2, _letterCounter.CountAdjacentLetters("Я люблю пиццу"));
        }

        [Test]
        public void MultipleAdjacentDuplicates()
        {
            // Несколько одинаковых соседних символов: "Мамааа мыла рамуу"
            // пары: "аа", "аа", "уу", "уу"
            Assert.AreEqual(5, _letterCounter.CountAdjacentLetters("Мамааа мыла рамуу"));
        }

        [Test]
        public void SpacesIgnored()
        {
            // Пробелы игнорируются, одна пара одинаковых соседних символов: "ии"
            Assert.AreEqual(2, _letterCounter.CountAdjacentLetters("Вечер был тиихий"));
        }

        [Test]
        public void EmptyString()
        {
            // Пустая строка, никаких одинаковых символов
            Assert.AreEqual(0, _letterCounter.CountAdjacentLetters(""));
        }


        [Test]
        public void CaseInsensitive()
        {
            // Программа должна игнорировать регистр: "АААааа"
            // пары: "аа", "аа", "аа", "аа", "аа", "аа"
            Assert.AreEqual(6, _letterCounter.CountAdjacentLetters("фффааа"));
        }

        [Test]
        public void MixedCharacters()
        {
            // Смешанные символы, как "ПпппПАааАА"
            // пары: "пп", "пп", "аа", "аа", "аа", "аа", "аа", "аа", "аа", "аа"
            Assert.AreEqual(10, _letterCounter.CountAdjacentLetters("ПпппПАааАА"));
        }
    }
}
