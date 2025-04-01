namespace Lesson9;

internal class Program
{
    public static void Main(string[] args)
    {
        SortUsingArraySort();
    }

    public static void SortUsingArraySort()
    {
        int[] inputData1 = { 10, 20, 9, 7, 6 };

        int[] inputData2 = new int[10];

        for (int i = 0; i < inputData2.Length; i++)
        {
            inputData2[i] = Random.Shared.Next(1, 101);
        }

        Array.Sort(inputData1);
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
        int[] inputData1 = { 10, 20, 9, 7, 6 };

        var result1 = Array.BinarySearch(inputData1, 6);

        Console.WriteLine(result1);

        int[] inputData2 = new int[50000000];

        for (int i = 0; i < inputData2.Length; i++)
        {
            inputData2[i] = Random.Shared.Next(1, 101);
        }

        var isFound = LinearSearch(inputData2, 10);

        Console.WriteLine(isFound ? "Знайшов елемент" : "Не знайшов елемент");
    }

    public static bool LinearSearch(int[] array, int searchedElement)
    {
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
        for (int i = 0; i < length - 1; i++)
        {
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

    public static int BinarySearch(int[] arr, int searchedElement)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == searchedElement)
            {
                return mid;  // Target found, return index

            }
            else if (arr[mid] < searchedElement)
            {
                left = mid + 1;  // Search right half

            } else
            {
                right = mid - 1; // Search left half
            }
        }

        return -1;  // Not found.
    }
}
