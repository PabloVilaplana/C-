using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    internal class Coche : Vehiculo
    {
        public Coche(String nombreCoche) : base(nombreCoche)
        {

        }

        public override void conducir()
        {
            Console.WriteLine("Conduzo por tierra");
        }
    }

}



