using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine().Replace(" ", ""); // Убираем пробелы

        int count = 0;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
                count++;
        }

        Console.WriteLine($"Количество одинаковых соседних букв: {count}");
    }
}
