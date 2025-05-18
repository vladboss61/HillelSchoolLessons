// Copyright 2025 Hillel. All rights reserved.
// This source code file.

namespace Lesson1;

using System;
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
        Console.WriteLine("Case 1:");
        var localizationDaDkSwitch = new LocalizationSwitch(LocalizationStrs.ResourceManager, "da-DK");
        var localizationDeDeSwitch = new LocalizationSwitch(LocalizationStrs.ResourceManager, "de-DE");

        localizationDaDkSwitch.Execute(() => Console.WriteLine(LocalizationStrs.Output));
        localizationDeDeSwitch.Execute(() => Console.WriteLine(LocalizationStrs.Output));

        Console.WriteLine("Case 2:");
        Console.WriteLine(localizationDaDkSwitch.GetString(nameof(LocalizationStrs.Output)));
        Console.WriteLine(localizationDeDeSwitch.GetString(nameof(LocalizationStrs.Output)));

        Console.WriteLine("Case 3:");
        Console.WriteLine(localizationDaDkSwitch.GetString("Nameofapplication")); // case insensitive
        Console.WriteLine(localizationDeDeSwitch.GetString("NameOfApplication"));

        Console.WriteLine("Case 4:");
        Console.WriteLine(localizationDaDkSwitch[nameof(LocalizationStrs.Output)]);
        Console.WriteLine(localizationDeDeSwitch[nameof(LocalizationStrs.Output)]);

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
    ///     SimpleFunction.
    /// </summary>
    private static void SimpleFunction()
    {
        Console.WriteLine("Hello Simple Function/Method");
    }
}
