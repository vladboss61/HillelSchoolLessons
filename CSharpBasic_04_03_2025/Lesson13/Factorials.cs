namespace Lesson13;

internal class Factorials
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
