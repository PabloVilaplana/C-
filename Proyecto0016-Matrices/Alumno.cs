using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Alumno
    {

        public Alumno(String nombre, int nota1, int nota2, int nota3, int nota4, int nota5)
        {
            alumnoNombre = nombre;
            alumnoNota1 = nota1;
            alumnoNota2 = nota2;
            alumnoNota3 = nota3;
            alumnoNota4 = nota4;
            alumnoNota5 = nota5;
        }

        private String alumnoNombre;
        private int alumnoNota1;
        private int alumnoNota2;
        private int alumnoNota3;
        private int alumnoNota4;
        private int alumnoNota5;

        public void getNotas()
        {
            Console.WriteLine($"la Nota 1 es: {alumnoNota1}");
            Console.WriteLine($"la Nota 2 es: {alumnoNota2}");
            Console.WriteLine($"la Nota 3 es: {alumnoNota3}");
            Console.WriteLine($"la Nota 4 es: {alumnoNota4}");
            Console.WriteLine($"la Nota 5 es: {alumnoNota5}");
        }

        public void getGlobal()
        {
            decimal alumnoGlobal = (alumnoNota1 + alumnoNota2 + alumnoNota3 + alumnoNota4 + alumnoNota5) / 5;
            Console.WriteLine($"la Nota Global es: {alumnoGlobal}");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre del Alumno es: {alumnoNombre}");
        }

    }
}
