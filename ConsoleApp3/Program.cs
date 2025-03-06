//Дано предложение. Определить, сколько в нем одинаковых соседних букв. Пробелы не учитывать.

namespace TestProject1
{
    public class LetterCounter
    {
        // Метод для подсчета одинаковых соседних букв в строке
        public Dictionary<char, List<int>> CountAdjacentLetters(string input)
        {
            var letterCounts = new Dictionary<char, List<int>>(); // Создаем словарь для хранения букв и их повторяющихся последовательностей
            input = input.Replace(" ", "").ToLower(); // Убираем пробелы и приводим строку к нижнему регистру

            for (int i = 0; i < input.Length - 1; i++) // Цикл по символам строки, кроме последнего
            {
                if (input[i] == input[i + 1]) // Если текущий символ совпадает со следующим
                {
                    int length = 2; // Начинаем считать последовательность с 2
                    while (i + length < input.Length && input[i] == input[i + length]) // Пока символы одинаковые
                        length++; // Увеличиваем длину последовательности

                    if (!letterCounts.ContainsKey(input[i])) // Если буква отсутствует в словаре
                        letterCounts[input[i]] = new List<int>(); // Добавляем её со списком длин

                    letterCounts[input[i]].Add(length); // Добавляем найденную длину последовательности в словарь
                    i += length - 1; // Пропускаем уже подсчитанные символы
                }
            }

            return letterCounts; // Возвращаем словарь с результатами
        }
    }

    class Program
    {
        static void Main()
        {
            var counter = new LetterCounter(); // Создаем объект класса LetterCounter

            while (true) // Бесконечный цикл для многократного ввода
            {
                Console.Write("Введите предложение (или 'exit' для выхода): "); // Выводим приглашение на ввод
                string input = Console.ReadLine(); // Считываем введенную строку

                if (string.IsNullOrEmpty(input)) // Проверяем, что строка не пустая
                {
                    Console.WriteLine("Введите непустую строку."); // Выводим предупреждение
                    continue; // Переход к следующей итерации цикла
                }

                if (input.ToLower() == "exit") // Если введено 'exit', выходим из цикла
                    break;

                var letterCounts = counter.CountAdjacentLetters(input); // Вызываем метод для подсчета букв

                if (letterCounts.Count == 0) // Если словарь пуст, значит, повторяющихся букв нет
                {
                    Console.WriteLine("Нет одинаковых соседних букв."); // Выводим соответствующее сообщение
                }
                else
                {
                    foreach (var pair in letterCounts) // Перебираем буквы в словаре
                        foreach (var length in pair.Value) // Перебираем длины последовательностей для каждой буквы
                            Console.WriteLine($"Буква {pair.Key} - {length} раза"); // Выводим результат
                }
            }
        }
    }
}

