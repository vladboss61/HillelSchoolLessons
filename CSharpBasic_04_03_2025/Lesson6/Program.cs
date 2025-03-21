using System.Text;

namespace Lesson6;

internal class Program
{
    static void Main(string[] args)
    {
                        //   0       1       2        3      4
        string[] names = { "Vlad", "Tany", "Artem", "Jon", "Doe" };

        //Console.WriteLine(names[0]);
        //Console.WriteLine(names[1]);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //for (int i = 0; i < names.Length; i++)
        //{
        //    var currentName = names[i];

        //    Console.WriteLine(currentName);
        //}

        //int ind = 0;
        //while(ind < names.Length)
        //{
        //    Console.WriteLine(names[ind]);
        //    ind++;
        //}


        Console.OutputEncoding = Encoding.Unicode;

        int index = 0;

        Console.WriteLine(index + " While with go to");
        index++;


        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Не знаю як обробляти парні числа");
                continue;
            }

            Console.WriteLine($"Index: {i}");
        }


        //for (int i = 1; i <= 10; i++)
        //{
        //    for (int j = 1; j <= 10; j++)
        //    {
        //        Console.Write($"{i * j}\t");
        //        break;
        //    }
        //    Console.WriteLine();
        //}

        //goto start;




        //string animalName = "Cow";

        //while(true)
        //{
        //    Console.Write("Try to suggest animal:");
        //    string yourAnimal = Console.ReadLine();

        //    if (yourAnimal == animalName)
        //    {
        //        Console.WriteLine("Wow you win");
        //        break;
        //    }
        //    Console.WriteLine("Try one more time.");
        //}


        //bool isInfiniteLoop = true;

        //while (isInfiniteLoop)
        //{
        //    Console.WriteLine("Infinite");

        //    if (isInfiniteLoop)
        //    {
        //        break;
        //    }
        //}

        //int index = 0;
        //while (true)
        //{
        //    Console.WriteLine($"While index: {index}");
        //    index++;

        //    if (index == 25)
        //    {
        //        break; // вихід з циклу
        //    }
        //}

        //while (index2 <= 25)
        //{
        //    Console.WriteLine($"Index2: {index2}");
        //    index2++;

        //    if (index2 <= 5)
        //    {
        //        Console.WriteLine("End of While");
        //        continue;
        //    }
        //}

        //int index2 = 0;

        //do
        //{
        //    Console.WriteLine("Do While");
        //    index2++; // index2 = index2 + 1;
        //    if (index2 == 5)
        //    {
        //        Console.WriteLine("Finish loop");
        //        break;
        //    }

        //} while (index2 <= 25);


        //for (int i = 0; i < 10; i++)
        //{
        //    // Loop with 10 iterations.
        //    Console.WriteLine($"i: {i}");
        //}

        Console.WriteLine("=====================");

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Vise-Versa i: {i}");
        }
    
        Console.WriteLine("=====================");
    }
}
