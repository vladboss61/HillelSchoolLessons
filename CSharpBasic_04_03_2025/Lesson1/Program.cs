// Copyright 2025 Hillel. All rights reserved.
// This source code file.

namespace Lesson1;

using System;
using System.Globalization;
using System.Threading;
using Lesson1.Resources;

/// <summary>
///     Start point.
/// </summary>
internal class Program
{
    /// <summary>
    ///     Main.
    /// </summary>
    /// <param name="args">Args.</param>
    public static void Main(string[] args)
    {
        SwitchCulture("da-DK", () => Console.WriteLine(LocalizationStrs.Output));
        SwitchCulture("de-DE", () => Console.WriteLine(LocalizationStrs.Output));

        Console.WriteLine("Fine.");

        // Comment in CSharp.
        // PascalCase

        // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

        // camelCase

        // int aget = 1033123;

        // double weight1 = 100.10;
        // float weight2 = 100.10;

        // bool isWinter = false;
        // bool isSpring = true;
        string firstName = "Vlad";
        string lastName = "Varvashenko";

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        Console.WriteLine("Hello, World!");
    }

    /// <summary>
    ///     Performs the action and switch culture.
    /// </summary>
    /// <param name="culture">Switched culture.</param>
    /// <param name="action">Action.</param>
    public static void SwitchCulture(string culture, Action action)
    {
        CultureInfo prevCulture = Thread.CurrentThread.CurrentCulture;
        CultureInfo prevUICulture = Thread.CurrentThread.CurrentUICulture;
        CultureInfo currentCulture = new CultureInfo(culture);
        try
        {
            Thread.CurrentThread.CurrentCulture = currentCulture;
            Thread.CurrentThread.CurrentUICulture = currentCulture;

            action();
        }
        finally
        {
            Thread.CurrentThread.CurrentCulture = prevCulture;
            Thread.CurrentThread.CurrentUICulture = prevUICulture;
        }
    }

    /// <summary>
    ///     SimpleFunction.
    /// </summary>
    private static void SimpleFunction()
    {
        Console.WriteLine("Hello Simple Function/Method");
    }
}
