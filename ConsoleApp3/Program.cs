//Дано предложение. Определить, сколько в нем одинаковых соседних букв. Пробелы не учитывать.


namespace TestProject1 
{
    public class LetterCounter 
    {
        
        public Dictionary<char, List<int>> CountAdjacentLetters(string input) 
        {
            var letterCounts = new Dictionary<char, List<int>>(); // Создание нового словаря для хранения букв и списков длин последовательностей.
            input = input.Replace(" ", "").ToLower(); 

            for (int i = 0; i < input.Length - 1; i++) // Цикл по строке до предпоследнего символа.
            {
                if (input[i] == input[i + 1]) // Проверка, одинаковые ли текущий символ и следующий.
                {
                    int length = 2; // Если одинаковые, начинаем считать длину последовательности (минимум 2, так как уже нашли пару).
                    while (i + length < input.Length && input[i] == input[i + length]) // Пока символы одинаковые и не вышли за пределы строки.
                        length++; // Увеличиваем длину последовательности.

                    if (!letterCounts.ContainsKey(input[i])) // Если такой буквы еще нет в словаре.
                        letterCounts[input[i]] = new List<int>(); // Добавляем её в словарь с пустым списком.

                    letterCounts[input[i]].Add(length); // Добавляем длину найденной последовательности в список для текущей буквы.
                    i += length - 1; // Пропускаем все уже подсчитанные символы, сдвигая индекс.
                }
            }

            return letterCounts; 
        }
    }

    class Program 
    {
        static void Main() 
        {
            Console.WriteLine("Введите предложение:"); 
            string input = Console.ReadLine(); 

            if (string.IsNullOrEmpty(input)) // Проверка, если строка пуста или равна null.
            {
                Console.WriteLine("Нет одинаковых соседних букв."); // Сообщаем, что нет одинаковых соседних букв.
                return; // Выход из метода, если строка пустая.
            }

            var letterCounts = new LetterCounter().CountAdjacentLetters(input); // Вызов метода CountAdjacentLetters для подсчета одинаковых соседних букв.

            if (letterCounts.Count == 0) // Если в словаре нет элементов (то есть одинаковых соседних букв не найдено).
            {
                Console.WriteLine("Нет одинаковых соседних букв."); // Сообщаем, что одинаковых соседних букв нет.
            }
            else
            {
                foreach (var pair in letterCounts) // Проходим по всем парам в словаре.
                    foreach (var length in pair.Value) // Проходим по всем длинам последовательностей для каждой буквы.
                        Console.WriteLine($"{pair.Key} - {length} раза"); // Выводим букву и количество раз, сколько она встретилась подряд.
            }
        }
    }
}
