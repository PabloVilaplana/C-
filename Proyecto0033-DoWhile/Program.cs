internal class Program
{
    private static void Main(string[] args)
    {
        
        string? readResult;
        Console.WriteLine("Ingrese un rol: Administrador, Director o Usuario");
        do
        {
            readResult = Console.ReadLine();
            readResult = readResult.Trim().ToLower();
            if (readResult != "administrador" && readResult != "director" && readResult != "usuario")
            {
                Console.WriteLine("Ingrese un rol valido");
            }
        } while (readResult != "administrador" && readResult != "director" && readResult != "usuario");

        
        Console.WriteLine($"Su Rol es {readResult}");
    }
}