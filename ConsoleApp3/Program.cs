using System;

namespace TestProject1
{
    // Класс для решения задачи
    public class LetterCounter
    {
        // Функция для подсчета одинаковых соседних букв
        public int CountAdjacentLetters(string input)
        {
            int count = 0;
            input = input.Replace(" ", "").ToLower(); // Преобразуем строку

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    int length = 2; // Начинаем с двух одинаковых символов

                    // Считаем длину последовательности одинаковых символов
                    while (i + length < input.Length && input[i] == input[i + length])
                    {
                        length++;
                    }

                    count += length; // Добавляем количество одинаковых букв
                    i += length - 1; // Переходим к следующей букве после группы одинаковых
                }
            }
            return count;
        }
    }

    // Основной класс для вывода
    class Program
    {
        static void Main()
        {
            // Получаем ввод от пользователя
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            // Если строка пустая, сразу выводим 0 и завершаем
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Количество одинаковых соседних букв: 0");
                return;
            }

            // Создаем объект для подсчета
            var counter = new LetterCounter();
            int count = counter.CountAdjacentLetters(input);

            // Выводим результат
            Console.WriteLine("Количество одинаковых соседних букв: " + count);
        }
    }
}
