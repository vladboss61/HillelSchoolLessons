using System;
using System.Text;

namespace Lesson10;

internal class Program
{
    public static string Null()
    {
        return null;
    }

    static void Main(string[] args)
    {
        PadLeftAndRightExample();

        double temperature = 25.5;
        string formattedTemperature = temperature.ToString("N2");
        // formattedTemperature = "25.50"
        Console.WriteLine(formattedTemperature);

        double temperature1 = 25.5;
        // formattedTemperature = "25.50"
        Console.WriteLine("{0:N2}", temperature);

        double price = 19.99;
        string formattedPrice = string.Format("The price is {0:C}", price);
        // formattedPrice = "The price is $19.99"
        Console.WriteLine(formattedPrice);

        int age = 30;
        string jName = "John";
        string formattedString = string.Format("My name is {0} and I am {1} years old.", jName, age);
        // formattedString = "My name is John and I am 30 years old."
        Console.WriteLine(formattedString);
        StringBuilderExample();

        string original = "Hello, world!";
        string modified = original.Insert(7, "beautiful ");
        Console.WriteLine("Modified: {0}", modified);

        int index = original.IndexOf("world");
        Console.WriteLine("Index of 'world': {0}", index);

        // 8. Видалення заданої кількості символів з рядка
        string trimmed = original.Remove(5, 7);
        Console.WriteLine("Trimmed: {0}", trimmed);

        bool @true = true;
        string strBool = @true.ToString();
        Console.WriteLine(strBool);

        int number = 10;
        Console.WriteLine(number.ToString());

        SubstringExample();

        string separator = "|";

        string hello1 = "Hello" + " | "+ "World";
        string hello2 = "Hello | World";
        string hello3 = $"Hello {separator} World";
        string hello4 = string.Concat("Hello", " | ", "World");
        string hello5 = string.Format("Hello {0} World", separator);
        Console.WriteLine("Hello {0} World", separator);

        CompareStringsExample();

        char[] ArrayChar = { 'H', 'e', 'l', 'l', 'o' };
        string s3 = new string(ArrayChar, 2, 3); // Починаючи з індексу 2, взяти 3 символи
        
        Console.WriteLine($"s3 = {s3}");

        TrimExample();

        string nullString1 = Null();
        string nullString2 = null;

        //nullString1.StartsWith("example");

        //string emptyString1 = "example 123123123123 example";
        //string emptyString2 = string.Empty;

        //var result1 = emptyString1.StartsWith("example");
        //var result2 = emptyString1.EndsWith("example");

        //Console.WriteLine(emptyString1 == emptyString2);

        char[] chars = { 'h', 'e', 'l', 'l', 'o' };
        string str1 = new string(chars);
        string str2 = "Hello World!";

        Console.WriteLine(str1);

        Console.WriteLine(str2);
        Console.WriteLine(str1 == str2);

        string name = "Vlad";
        string lastName = "Varvashenko";

        string fullName = string.Concat(name, lastName);

        string newName = name.Replace('l', '-');
        Console.WriteLine(name);
        Console.WriteLine(newName);

        string nameAndLastName = name + lastName;
        Console.WriteLine(nameAndLastName);

        //  \\, \t, \n - non printable characters,
        string oldPath = @$"c:\t\Program Files\Microsoft {10} Visual \ Studio 8.0";

        Console.WriteLine(oldPath);

        CompareStringsExample();
    }


    public static void PadLeftAndRightExample()
    {
        string example = "Lorem";

        char ch = example[1];

        string upperExample = example.ToUpper();
        string lowerExample = example.ToLower();

        string padLeftStr = example.PadLeft(12, '_');
        Console.WriteLine(padLeftStr);

        string padRightStr = example.PadRight(12, '_');
        Console.WriteLine(padRightStr);
    }

    public static void SplitExample()
    {
        string example = "Lorem Ipsum is simply dummy text. of the printing. and typesetting the industry.";
        string[] result1 = example.Split(new char[] { ' ' });
        string[] result2 = example.Split('.');
        string[] result3 = example.Split(" ");

        string[] result4 = example.Split("the");
    }

    public static void ReplaceExample()
    {
        string example = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        var result1 = example.Replace("Lorem", "new value");
        var result2 = example.Replace("lorem", "new value", StringComparison.OrdinalIgnoreCase);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }

    public static void SubstringExample()
    {
        string example = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";

        string result = example.Substring(3, 10);
        Console.WriteLine(result);
    }

    public static void TrimExample()
    {
        string example = "\nLorem Ipsum is simply dummy text of the printing and typesetting industry.\t\n\n    ";
        Console.WriteLine(example);
        var trimmedStr = example.TrimStart();
        Console.WriteLine(trimmedStr);
    }

    public static void CompareStringsExample()
    {
        string left = "OnE";
        string right = "one";
        bool areEqual = left == right;

        Console.WriteLine(areEqual);

        bool areEqualWithIgnoreCase = string.Equals(left, right, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(areEqualWithIgnoreCase);
    }

    public static void StringBuilderExample()
    {
        StringBuilder stringBuilder = new StringBuilder("Hello World!");
        Console.WriteLine(stringBuilder.ToString());

        stringBuilder.AppendLine();
        stringBuilder.AppendLine("New text appended with string builder");
        stringBuilder.AppendLine("New text appended with string builder");

        // The same.
        //stringBuilder
        //    .AppendLine()
        //    .AppendLine("New text appended with string builder")
        //    .AppendLine("New text appended with string builder");

        stringBuilder.Replace("text", "----");

        Console.WriteLine(stringBuilder.ToString());

        stringBuilder.Clear();
        Console.WriteLine("=======================");

        stringBuilder.Append("New String");

        Console.WriteLine(stringBuilder.ToString());
    }
}
