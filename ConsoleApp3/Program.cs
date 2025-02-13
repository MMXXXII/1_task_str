using System;

class LetterAnalyzer
{
    public static int CountAdjacentDuplicates(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        text = text.Replace(" ", ""); // Убираем пробелы

        int count = 0;
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == text[i - 1])
                count++;
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine();

        int result = LetterAnalyzer.CountAdjacentDuplicates(input);
        Console.WriteLine($"Количество одинаковых соседних букв: {result}");
    }
}
