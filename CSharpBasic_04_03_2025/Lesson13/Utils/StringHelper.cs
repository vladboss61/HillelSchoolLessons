using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Utils;

internal static class StringHelper
{
    public static string Reverse(string str)
    {
        // First
        string reversed1 = new string(str.Reverse().ToArray());

        // Second
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        string reversed2 = new string(chars);

        // Third
        string reversed3 = string.Empty; // ""
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed3 += str[i];
        }

        return reversed3;
    }

    public static int CountVowels(string input)
    {
        // Anna -> ToLower() -> anna

        int count = 0;
        string vowels = "aeiou";
        string lowerCaseInput = input.ToLower();

        foreach (char c in lowerCaseInput)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    public static bool IsPalindrome(string inputStr)
    {
        char[] chars = inputStr.ToCharArray();

        Array.Reverse(chars);

        string reversedStr = new string(chars);
        return inputStr == reversedStr;
    }
}
