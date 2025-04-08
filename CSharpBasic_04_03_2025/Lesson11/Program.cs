namespace Lesson11;

internal class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // 1. Підрахунок кількості слів у рядку
        Console.WriteLine("1. Підрахунок кількості слів у рядку");
        Console.Write("Введіть рядок: ");
        string input1 = Console.ReadLine();
        int wordCount = CountWords(input1);
        Console.WriteLine($"Загальна кількість слів у рядку: {wordCount}");

        // 2. Вилучення підрядка без бібліотечних функцій
        Console.WriteLine();

        Console.WriteLine("2. Вилучення підрядка");
        Console.Write("Введіть рядок: ");
        string input2 = Console.ReadLine();
        Console.Write("Введіть початкову позицію: ");
        int startPos = int.Parse(Console.ReadLine());
        Console.Write("Введіть довжину підрядка: ");
        int length = int.Parse(Console.ReadLine());
        string subStr = ExtractSubstring(input2, startPos, length);
        Console.WriteLine($"Отриманий підрядок: {subStr}");

        // 3. Підрахунок букв, цифр і спецсимволів
        Console.WriteLine();

        Console.WriteLine("3. Підрахунок букв, цифр і спецсимволів");
        Console.Write("Введіть рядок: ");
        string input3 = Console.ReadLine();
        var (letters, digits, special) = CountCharacterTypes(input3);
        Console.WriteLine($"Букви: {letters}");
        Console.WriteLine($"Цифри: {digits}");
        Console.WriteLine($"Спеціальні символи: {special}");

        // 4. Найчастіший символ
        Console.WriteLine();

        Console.WriteLine("4. Найчастіший символ у рядку");
        Console.Write("Введіть рядок: ");
        string input4 = Console.ReadLine();
        FindMostFrequentChar(input4);

        // 5. Пошук кількості входжень підрядка
        Console.WriteLine();
        Console.WriteLine("5. Пошук кількості входжень підрядка");
        Console.Write("Введіть оригінальний рядок: ");
        string original = Console.ReadLine();
        Console.Write("Введіть рядок для пошуку: ");
        string search = Console.ReadLine();
        int count = CountSubstringOccurrences(original, search);
        Console.WriteLine($"Рядок '{search}' зустрічається {count} раз");
    }

    public static int CountWords(string input)
    {
        return input.Split(" ").Length;
    }

    public static string ExtractSubstring(string input, int start, int length)
    {
        string result = string.Empty;

        // start + length - з якого символу починаємо та скільки беремо
        for (int i = start; i < start + length && i < input.Length; i++)
        {
            result += input[i];
        }
        return result;
    }

    public static (int letters, int digits, int special) CountCharacterTypes(string input)
    {
        int letters = 0;
        int digits = 0;
        int special = 0;

        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c))
            {
                continue;
            }

            if (char.IsLetter(c))
            {
                letters++;
            }
            else if (char.IsDigit(c))
            {
                digits++;
            }
            else
            {
                special++;
            }
        }

        // Tuple
        return (letters, digits, special);
    }

    public static void FindMostFrequentChar(string input)
    {
        // Dictionary has unique keys and possible repeated values.
        var frequencies = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c))
            {
                continue;
            }

            if (frequencies.ContainsKey(c))
            {
                frequencies[c]++;
            }
            else
            {
                frequencies[c] = 1;
            }
        }

        foreach (var frequency in frequencies)
        {
            Console.WriteLine($"Char: {frequency.Key} | Count: {frequency.Value}");
        }
    }

    public static int CountSubstringOccurrences(string text, string substring)
    {
        // test test test  14 chars
        // test 4 chars

        int count = 0;
        // 14 - 4 = 10
        for (int i = 0; i <= text.Length - substring.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (text[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }
        return count;
    }

    // Ще одне рішення через LINQ
    public static int CountSubstringOccurrencesWithLinq(string text, string substring)
    {
        if (string.IsNullOrEmpty(substring) || string.IsNullOrEmpty(text) || substring.Length > text.Length)
        {
            return 0;
        }

        return Enumerable.Range(0, text.Length - substring.Length + 1)
                         .Count(i => text.Substring(i, substring.Length) == substring);
    }
}
