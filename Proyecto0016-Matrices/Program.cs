using System;
using Colegio;

namespace Colegio
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int nota1 = random.Next(1, 100);
            int nota2 = random.Next(1, 100);
            int nota3 = random.Next(1, 100);
            int nota4 = random.Next(1, 100);
            int nota5 = random.Next(1, 100);
            Alumno Alumno1 = new Alumno(studentNames[0], nota1, nota2, nota3, nota4, nota5);
            Alumno1.getNombre();
            Alumno1.getNotas();
            Alumno1.getGlobal();
            Console.WriteLine("\n");


            nota1 = random.Next(1, 100);
            nota2 = random.Next(1, 100);
            nota3 = random.Next(1, 100);
            nota4 = random.Next(1, 100);
            nota5 = random.Next(1, 100);
            Alumno Alumno2 = new Alumno(studentNames[1], nota1, nota2, nota3, nota4, nota5);
            Alumno2.getNombre();
            Alumno2.getNotas();
            Alumno2.getGlobal();
            Console.WriteLine("\n");


            nota1 = random.Next(1, 100);
            nota2 = random.Next(1, 100);
            nota3 = random.Next(1, 100);
            nota4 = random.Next(1, 100);
            nota5 = random.Next(1, 100);
            Alumno Alumno3 = new Alumno(studentNames[2], nota1, nota2, nota3, nota4, nota5);
            Alumno3.getNombre();
            Alumno3.getNotas();
            Alumno3.getGlobal();
            Console.WriteLine("\n");


            nota1 = random.Next(1, 100);
            nota2 = random.Next(1, 100);
            nota3 = random.Next(1, 100);
            nota4 = random.Next(1, 100);
            nota5 = random.Next(1, 100);
            Alumno Alumno4 = new Alumno(studentNames[3], nota1, nota2, nota3, nota4, nota5);
            Alumno4.getNombre();
            Alumno4.getNotas();
            Alumno4.getGlobal();
            Console.WriteLine("\n");

        }
    }

}