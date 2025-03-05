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
            var result = _letterCounter.CountAdjacentLetters("Сегодня хорошая погода");
            Assert.AreEqual(0, result.Count); // Проверяем, что нет одинаковых соседних букв
        }

        [Test]
        public void OneAdjacentDuplicate()
        {
            // Одна пара одинаковых соседних символов: "пиццу"
            var result = _letterCounter.CountAdjacentLetters("Я люблю пиццу");
            Assert.AreEqual(1, result['ц'].Count); // Проверяем, что для 'ц' одна пара
        }

        [Test]
        public void MultipleAdjacentDuplicates()
        {
            // Несколько одинаковых соседних символов: "Мамааа мыла рамуу"
            // пары: "аа", "аа", "уу", "уу"
            var result = _letterCounter.CountAdjacentLetters("Мамааа мыла рамуу");
            Assert.AreEqual(3, result['а'].Count); // Три случая для 'а'
            Assert.AreEqual(2, result['у'].Count); // Два случая для 'у'
        }


        [Test]
        public void SpacesIgnored()
        {
            // Пробелы игнорируются, одна пара одинаковых соседних символов: "ии"
            var result = _letterCounter.CountAdjacentLetters("Вечер был тиихий");
            Assert.AreEqual(2, result['и'].Count); // Ожидаем 1 пару для 'и'
        }

        [Test]
        public void EmptyString()
        {
            // Пустая строка, никаких одинаковых символов
            var result = _letterCounter.CountAdjacentLetters("");
            Assert.AreEqual(0, result.Count); // Ничего нет, проверяем пустоту
        }


        [Test]
        public void SingleCharacterString()
        {
            // Строка из одного символа, никаких одинаковых соседних символов
            var result = _letterCounter.CountAdjacentLetters("A");
            Assert.AreEqual(0, result.Count); // Никаких одинаковых соседних букв
        }
    }
}
