using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo MiCirculo;

            MiCirculo = new Circulo();

            Console.WriteLine(MiCirculo.calculoArea(5));

            Circulo MiCirculo2 = new Circulo();
    
        Console.WriteLine(MiCirculo2.calculoArea(9));

            Console.WriteLine(MiCirculo2.calculoArea(5));

        }

        class Circulo
        {
            const double pi = 3.1416;

            public double calculoArea(int radio)
            {
                return pi * radio * radio;
            }
        }

    }
}
