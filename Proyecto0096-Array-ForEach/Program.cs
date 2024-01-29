using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
                
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };

            Empleados Ana = new Empleados("Ana", 27);
            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = Ana;

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19},
                new{Nombre="Maria", Edad=49},
                new{Nombre="Diana", Edad=35}
            };
                
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(valores[i]);
            }

            for(int i = 0; i < arrayEmpleados.Length; i++)
            {
                //arrayEmpleados[0].nombre = "Leo Messi";
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }

            
            /*foreach(Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }*/
            
            /*foreach(double variable in valores)
            {
                Console.WriteLine(variable);
            }*/

            foreach(var variable in personas)
            {
                Console.WriteLine(variable);
            }

        }
    }
    



    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return "Nombre del empleado: " + nombre + " Edad: " + edad;
        }

        private String nombre;
        private int edad;

    }
}