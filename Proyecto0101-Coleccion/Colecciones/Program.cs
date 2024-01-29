using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            /*int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            for(int i=0; listaNumeros.Length > i; i++)
            {
                numeros.Add(listaNumeros[i]);
            }
            
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            /*Console.WriteLine("Cuantos elementos quieres introducir?");

            int elem = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Elementos Introducidos");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            Console.WriteLine("Introduce elementos en la coleccion(0 para salir)");

            int elem = 1;

            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos Introducidos");

            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }

        }
    }
}