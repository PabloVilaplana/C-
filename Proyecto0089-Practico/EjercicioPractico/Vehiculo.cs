using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    internal class Vehiculo
    {
        public Vehiculo(String nombre)
        {
            nombreVehiculo = nombre;
        }

        private String nombreVehiculo;

        public void arrancarMotor()
        {
            Console.WriteLine("Arranqué el motor");
        }

        public void pararMotor()
        {
            Console.WriteLine("Paré el motor");
        }

        public virtual void conducir()
        {
            Console.WriteLine("Conduzco");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre del vehiculo es: {nombreVehiculo}");
        }



    }

}


