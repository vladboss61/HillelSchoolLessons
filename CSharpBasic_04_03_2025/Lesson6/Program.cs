namespace Lesson6;

internal class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            // Loop with 10 iterations.
            Console.WriteLine($"i: {i}");
        }

        Console.WriteLine("=====================");

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Vise-Versa i: {i}");
        }

        Console.WriteLine("=====================");

        int index = 0;
        while (true)
        {
            Console.WriteLine($"While index: {index}");
            index++;

            if (index == 25)
            {
                break; // вихід з циклу
            }
        }
    }
}
