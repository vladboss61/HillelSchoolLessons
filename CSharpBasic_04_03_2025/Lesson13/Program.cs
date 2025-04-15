using System.Text;
using Lesson13.Utils;

namespace Lesson13;

internal class Program
{
    static void Main(string[] args)
    {
        MathHelp.InnerClass.Update();

        int a = 10;
        int b = 20;

        MathHelp.Swap(ref a, ref b);

        // Generics execution Swap func.
        //char ca = 'x';
        //char cb = 'y';

        //MathHelp.Swap(ref ca, ref cb);

        //string str1 = "left";
        //string str2 = "right";

        //MathHelp.Swap(ref str1, ref str2);

        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        //string[] strings = new string[];
        //int[] ints = new int[];
        //List<int>

        // Generics -> <string>, <int>, <whatever>
        List<string> strings = new List<string>();

        FillList(strings);

        foreach (string str in strings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();

        strings.Remove("Task 2");

        foreach (string str in strings)
        {
            Console.WriteLine(str);
        }

        strings.Clear();

        Console.WriteLine(StringHelper.Reverse("Hello"));

        Console.WriteLine();
        
        bool isPalindrome = StringHelper.IsPalindrome("Hello");

        if (isPalindrome)
        {
            Console.WriteLine("Так це паліндром");
        }
        else
        {
            Console.WriteLine("Ні це не паліндром");
        }

        Console.WriteLine();

        int sum2 = MathHelp.Sum(new int[] { 2, 4, 6, 8 });
        int sum1 = MathHelp.Sum(2, 4, 6, 8);

        Console.WriteLine($"Sum1: {sum1} ");
        Console.WriteLine($"Sum1: {sum2} ");

        string input = "PrOgramming";
        int countVowels = StringHelper.CountVowels(input);

        Console.WriteLine($"Голосні літери в слові {input} - {countVowels}");
    }

    public static void FillList(List<string> strings)
    {
        //strings.AddRange(new string[] { "Task 1" , "Task 2", "Task 3" });

        strings.Add("Task 1");
        strings.Add("Task 2");
        strings.Add("Task 3");

        string byIndex0 = strings[0]; // "Task 1"
    }
}
