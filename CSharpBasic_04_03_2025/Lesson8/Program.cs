using System;

namespace Lesson8;

internal class Program
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    enum Categories
    {
        Electronics,    // 0
        Food,           // 1
        Automotive = 6, // 6
        Arts,           // 7
        BeautyCare,     // 8
        Fashion         // 9
    }

    enum YesNo
    {
        Yes, // 0
        No // 1
    }

    enum WeekDays
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Season season = Season.Autumn;

        short wednesdayOfWerDays = (short)WeekDays.Wednesday;

        //Console.WriteLine(WeekDays.Monday); // Monday
        //Console.WriteLine(WeekDays.Tuesday); // Tuesday
        //Console.WriteLine(WeekDays.Wednesday); // Wednesday
        //Console.WriteLine(WeekDays.Thursday); // Thursday
        //Console.WriteLine(WeekDays.Friday); // Friday
        //Console.WriteLine(WeekDays.Saturday); // Saturday
        //Console.WriteLine(WeekDays.Sunday); // Sunday

        //Season season = Season.Winter;
        //Console.WriteLine($"Integral value of {season} is {(int)season}");
        //Season season2 = (Season)1;

        Console.Write("Виберіть рівень гри: ");
        string lvl = Console.ReadLine();
        Level gameLevel = Enum.Parse<Level>(lvl);

        if (gameLevel == Level.High)
        {
            Console.WriteLine("Ого буде Важко");
        }

        switch (gameLevel)
        {
            case Level.Low:
                Console.WriteLine("Ви граєте на низькому рівні.");
                break;
            case Level.Medium:
                Console.WriteLine("Ви граєте середне.");
                break;
            case Level.High:
                Console.WriteLine("Ви профі, стартуйте гру скоріше вам буде важко.");
                break;
            default:
                break;
        }


        string monday = "Monday";
        string tuesday = "Tuesday";
        string wednesday = "Wednesday";
        string thursday = "Thursday";

        int monday_ = 0;
        int tuesday_ = 1;
        int wednesday_ = 2;
        int thursday_ = 3;

        string[] dayOrWeek = { "Monday", "Tuesday", "Wednesday", "Thursday" };


        // ctrl \ + ctrl .     - quick fix
        // Arrays 
        short[] shorts = new short[10];
        bool[] bools = new bool[10];
        string[] strings = new string[10];
        double[] doubles = new double[10];

        //[0, 0, 0, 0, 0]
        int[] ints1 = new int[5] { 10, 20, 30, 40, 50 };

        //             0    1   2  3   4
        int[] ints2 = [10, 20, 30, 40, 50];
        int ints2Length = ints2.Length; // 5

        //for (int i = 0; i < ints1.Length; i++)
        //{
        //    Console.WriteLine(ints2[i]);
        //}

        //Console.WriteLine();

        //for (int i = ints2.Length - 1; i >= 0; i--)
        //{
        //    Console.WriteLine(ints2[i]);
        //}

        foreach(int num in ints2)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine(ints2[0]);
        Console.WriteLine(ints2.Length);
        Console.WriteLine(ints2[ints2.Length - 1]);

        int temp = ints1[4];
        ints1[0] = temp;
        //ints[1] = 20;
        //ints[2] = 30;

        //int num = ints1[0];

        //Console.WriteLine(num);

        int[] numbers = new int[10]; // Array of 10 elements.

        Console.WriteLine(numbers.Length);

        string[] names = new string[15];

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.WriteLine($"Введіть ім'я ({i + 1}): ");
        //    names[i] = Console.ReadLine();
        //}

        int[][] jaggedArray = new int[3][]
        {
            new int[] { 5, 10, 20, 20 },
            new int[] { 15, 20 },
            new int[] { 25, 30, 10, 20 },
        };

        int number = jaggedArray[0][3];
        number = number * number;
        //...
        jaggedArray[0][3] = number;


        Console.WriteLine(jaggedArray[0][3]);

        int[][][] jagged3DArray = new int[3][][]
        {
            new int[1][]
            {
                new int[]{ 5, 10, 20, }
            },
            new int[2][]
            {
                new int[]{ 5, 10, 20, },
                new int[]{ 5, 10, 20, }
            },
            new int[3][]
            {
                new int[]{ 5, 10, 20, },
                new int[]{ 5, 10, 20, },
                new int[]{ 5, 10, 20, }
            },
        };

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int[] innerArray = jaggedArray[i];
            
            for (int j = 0; j < innerArray.Length; j++)
            {
               Console.Write($" {innerArray[j]} ");

            }
            Console.WriteLine();
        }

        // ініціалізація двовимірного масиву
        int[, ,] array2DDeclaration = new int[4, 2, 5];

        char[] symbols = { 'a', 'b', 'c', 'd' };
        char[] tempSymbols = new char[5];

        for (int i = 0; i < symbols.Length; i++)
        {
            tempSymbols[i] = symbols[i];
        }

        tempSymbols[tempSymbols.Length - 1] = 'e';

        foreach (char c in symbols)
        {
            Console.WriteLine(c);
        }

        DisplayArray(numbers);
    }

    public static void DisplayArray(int[] numbers)
    {
        Console.Write("Array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index: {i} | Value: {numbers[i]}");
        }
    }
}
