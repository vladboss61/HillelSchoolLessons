using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13;
internal class StringHelper
{
    public static string Reverse(string str)
    {
        char[] reversed = new char[str.Length];
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed[i] = str[i];
        }

        return new string(reversed);
    }

    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiou";

        foreach (char c in input.ToLower())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsPalindrome(string inputStr)
    {
        char[] arr = inputStr.ToCharArray();
        Array.Reverse(arr);
        var reversedStr = new string(arr);
        return inputStr == reversedStr;
    }
}
