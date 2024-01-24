internal class Program
{
    private static void Main(string[] args)
    {
        string[] values = { "12,3", "45", "ABC", "11", "DEF" };
        string valor = "";
        double valornumerico = 0;

        string mensaje = "";
        double total = 0;

        for (int i = 0; i < values.Length; i++)
        {
            valor = values[i];

            if (double.TryParse(valor, out valornumerico))
            {
                total = total + valornumerico;
            }
            else
            {
                mensaje += valor;
            }
        }

        Console.WriteLine($"Message: {mensaje}");
        Console.WriteLine($"Total: {total}");
    }
}