using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduce elprimer número");

        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Introduce el segundo número");

        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El resultado es " + (num1 + num2));
    }
}