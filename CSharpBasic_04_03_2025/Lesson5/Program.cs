namespace Lesson5;

internal class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        string name ="0asdad";


        //StackOverflowExceptionExample();

        try
        {
            int.Parse(name);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Exception Stack Trace: ");
            Console.WriteLine($"{ex.StackTrace}");
        }
        finally
        {
            Console.WriteLine("Finally is executed.");
        }

        //try
        //{
        //    ThrowExceptionExample();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Catch the exception: {ex.Message}");
        //}
        //finally
        //{
        //    Console.WriteLine("Finally is executed");
        //}
    }

    public static void ThrowExceptionExample()
    {
        // Logic
        //....
        InnerThrowExceptionExample();
    }

    public static void InnerThrowExceptionExample()
    {
        throw new Exception("Business logic problem.");
    }

    public static void StackOverflowExceptionExample()
    {
        int x = 10;
        StackOverflowExceptionExample();
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message) { }
    }
}
