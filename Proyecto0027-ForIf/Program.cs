internal class Program
{
    private static void Main(string[] args)
    {
        string nombre = "";
        for (int i = 1; i <= 100; i++)
        {
            nombre = "";
            if (i % 3 == 0) nombre = "Fizz";
            if (i % 5 == 0) nombre = "Buzz";
            if (i % 3 == 0 && i % 5 == 0) nombre = "FizzBuzz";


            Console.WriteLine($"{i} - {nombre}");
        }
    }
}