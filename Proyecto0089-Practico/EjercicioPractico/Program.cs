using System;
using EjercicioPractico;

namespace ProyectoPracticoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche Coche1 = new Coche("Etios");
            Avion Avion1 = new Avion("Jet");

            Vehiculo[] almacenVehiculos = new Vehiculo[2];

            almacenVehiculos[0] = Coche1;

            almacenVehiculos[1] = Avion1;

            for (int i = 0; i < 2; i++)
            {
                almacenVehiculos[i].getNombre();
                almacenVehiculos[i].arrancarMotor();
                almacenVehiculos[i].pararMotor();
                almacenVehiculos[i].conducir();

            }

        }
    }

}