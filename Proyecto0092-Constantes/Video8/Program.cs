internal class Program
{
    private static void Main(string[] args)
    {
        const double PI = Math.PI;

        Console.WriteLine("Introduce la medida del radio");

        double radio = double.Parse(Console.ReadLine());

        //double area = radio * radio * PI;

        double area = Math.Pow(radio, 2) * PI;

        Console.WriteLine($"El area del circulo es: {area}");
    }
}