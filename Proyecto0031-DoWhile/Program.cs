internal class Program
{
    private static void Main(string[] args)
    {
        string? readResult;
        Console.WriteLine("Enter a string:");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);

        // capture user input in a string variable named readResult

        int numericValue = 0;
        bool validNumber = false;

        validNumber = int.TryParse(readResult, out numericValue);
    }
}