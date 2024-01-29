using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    internal class Avion : Vehiculo
    {
        public Avion(String nombreAvion) : base(nombreAvion)
        {

        }

        public void volar()
        {
            Console.WriteLine("Voy por Aire");
        }

        public override void conducir()
        {
            Console.WriteLine("Conduzo por Aire");
        }
    }
}

    


