using System.Text;

namespace Lesson11;

internal class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;


        // 1. Підрахунок кількості слів у рядку
        Console.WriteLine("1. Підрахунок кількості слів у рядку");
        Console.Write("Введіть рядок: ");
        string input1 = Console.ReadLine();
        int wordCount = CountWords(input1);
        Console.WriteLine($"Загальна кількість слів у рядку: {wordCount}");

        // Alternative variant
        //var length = CountWordsManually("test word ph");

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

    public static int CountWordsManually(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int wordLength = 1;
        foreach (char symbol in input)
        {
            if (symbol == ' ')
            {
                wordLength++;
            }
        }

        return wordLength;
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

    /*
     * text.Length = 14
       substring.Length = 4

       Последняя возможная позиция для начала подстроки: 14 - 4 = 10

       Идём по строке text, начиная с позиции i = 0 до i = 10, и на каждой позиции проверяем,
       совпадает ли подстрока длиной 4 символа с "test".

    i   Текущий кусок из text (text[i..i+4])	Совпадение с "test"?	count
    
    0	text[0..4] = "test"	Да  1

    1   "est "   Нет    1
    2   "st t"   Нет    1
    3   "t te"   Нет    1
    4   " tes"   Нет    1
    5   "test"   Да     2
    6   "est "   Нет    2
    7   "st t"   Нет    2
    8   "t te"   Нет    2
    9   " tes"   Нет    2
    10  "test"   Да     3


    text:      t e s t   t e s t   t e s t
    index:     0 1 2 3 4 5 6 7 8 9 10 11 12 13

    i = 0   [t e s t]   t e s t   t e s t   -> match
    i = 1     e s t   [ ] t e s t   t e s t -> no
    i = 2       s t   [ ]   t e s t   t e s -> no
    i = 3         t   [ ]   t e s t   t e s -> no
    i = 4           [ ]   t e s t   t e s t -> no
    i = 5             [t e s t]   t e s t   -> match
    i = 6               e s t   [ ] e s t   -> no
    i = 7                 s t   [ ]   s t   -> no
    i = 8                   t   [ ]   s t   -> no
    i = 9                     [ ]   s t t   -> no
    i = 10                      [t e s t]   -> match

     */
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
