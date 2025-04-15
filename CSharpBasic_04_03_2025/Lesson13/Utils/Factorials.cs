namespace Lesson13.Utils;

internal static class Factorials
{
    public static int Factorial(int n)
    {
        // n = 5;
        // 1 * 2 * 3 * 4 * 5;

        if (n <= 1)
        {
            return 1;
        }

        int temp = Factorial(n - 1);

        return n * temp;
    }

    /// <summary>
    ///     This method calculates factorial iteratively.
    /// </summary>
    /// <param name="n">Parameter for count of factorial</param>
    /// <returns>Calculated factorial</returns>
    public static int FactorialIteratively(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }

        return result;
    }
}
