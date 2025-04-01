using System.Diagnostics;

namespace Lesson9;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] inputData1 = { 10, 20, 9, 7, 6, 3, 30, 30, 30 };

        //O1Complexity();
        //BubbleSort(inputData1);
        //SortUsingArraySort();
        //bool result = LinearSearch(inputData1, 7);
        //Console.WriteLine(result ? "Ми знайшли еелемент" : "Немає елементу");

        //Array.Sort(inputData1);
        //bool result = BinarySearch(inputData1, 11);
        //Console.WriteLine(result ? "Ми знайшли еелемент" : "Немає елементу");

        //1 2 3 4 5
        //2 3 5 7 5
        //1 2 3 1 5
        //1 2 3 4 5
        //1 2 3 4 5

        SearchUsingArraySearch();
    }

    public static void O1Complexity()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int[] inputData1 = { 10, 20, 9, 7, 6, 3, 30, 30, 30 };
        var firstElement = inputData1[1];
        stopwatch.Stop();

        Console.WriteLine(firstElement);
        Console.WriteLine(stopwatch.ElapsedTicks);
    }

    public static void SortUsingArraySort()
    {
        int[] inputData1 = { 10, 20, 9, 7, 6 };

        int[] inputData2 = new int[10];

        // O(n)
        for (int i = 0; i < inputData2.Length; i++)
        {
            inputData2[i] = Random.Shared.Next(1, 101);
        }

        // Quick Sort / Heap Sort behind the screen.
        Array.Sort(inputData1);
        
        // Quick Sort / Heap Sort behind the screen.
        Array.Sort(inputData2);

        for (int i = 0; i < inputData1.Length; i++)
        {
            Console.WriteLine(inputData1[i]);
        }

        Console.WriteLine();
        for (int i = 0; i < inputData2.Length; i++)
        {
            Console.WriteLine(inputData2[i]);
        }
    }

    public static void SearchUsingArraySearch()
    {
        int[] inputData1 = { 10, 20, 9, 7, 6, 3 };

        Array.Sort(inputData1);

        var result1 = Array.BinarySearch(inputData1, 11);

        Console.WriteLine(result1);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int[] inputData2 = new int[99999999];

        for (int i = 0; i < inputData2.Length; i++)
        {
            inputData2[i] = Random.Shared.Next(1, 101);
        }

        var isFound = LinearSearch(inputData2, 10);
        Console.WriteLine(isFound ? "Знайшов елемент" : "Не знайшов елемент");
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedTicks);

        Array.Sort(inputData2);

        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        var resultBinary = BinarySearch(inputData2 , 12);
        Console.WriteLine(resultBinary ? "Знайшов елемент Binary" : "Не знайшов елемент Binary");
        stopwatch2.Stop();
        Console.WriteLine(stopwatch2.ElapsedTicks);
    }

    public static bool LinearSearch(int[] array, int searchedElement)
    {
        // O(n)
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchedElement)
            {
                return true;
            }
        }

        return false;
    }

    public static void BubbleSort(int[] array)
    {
        // O(n^2) complexity (two loops)
        int length = array.Length;
        // тут length - 1 так само тому що  в кінці буде завжи найбільший елемент та нема сенсу його порівнювати.
        for (int i = 0; i < length - 1; i++)
        {
            // length - i - 1 - в кінці масиву буде завжди набільший елемент після першого проходу,
            // після другого в кінці буде два найбільші елементи і так далі.
            for (int j = 0; j < length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static bool BinarySearch(int[] arr, int searchedElement)
    {
        int left = 0, right = arr.Length - 1;

        // O(log(n))
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == searchedElement)
            {
                return true;  // Target found, return index

            }
            else if (arr[mid] < searchedElement)
            {
                left = mid + 1;  // Search right half

            }
            else
            {
                right = mid - 1; // Search left half
            }
        }

        return false;  // Not found.
    }
}
