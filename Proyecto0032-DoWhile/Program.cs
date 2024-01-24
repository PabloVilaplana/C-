internal class Program
{
    private static void Main(string[] args)
    {
        string? readResult;
        Console.WriteLine("Ingrese un numero del 5 al 10");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);

        // capture user input in a string variable named readResult

        int numericValue = 0;
        bool validNumber = false;

        validNumber = int.TryParse(readResult, out numericValue);

        if (validNumber == false || numericValue <= 4 || numericValue >= 11)
        {
            do
            {
                Console.WriteLine("Ingresaste un Caracter no valido, ingresa otra vez");
                do
                {
                    readResult = Console.ReadLine();
                } while (readResult == null);

                numericValue = 0;
                validNumber = false;

                validNumber = int.TryParse(readResult, out numericValue);
            } while (validNumber == false || numericValue <= 4 || numericValue >= 11);
        }

        Console.WriteLine($"Su numero es {numericValue}");

    }
}