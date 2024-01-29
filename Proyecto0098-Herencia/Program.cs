using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miBabieca = new Caballo("Babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            Ballena miWally = new Ballena("Wally");

            //Juan.getNombre();

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;

            almacenAnimales[1] = miJuan;

            almacenAnimales[2] = miCopito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            miWally.nadar();

            Console.Write($"Numero de patas de Babieca: {miBabieca.numeroPatas()}");

        }
    }

    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }

    class Mamiferos
    {
        
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico Instintivo");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombreSerVivo}");
        }
        


        private String nombreSerVivo;

    }

    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        
        public Caballo (String nombreCaballo) :base(nombreCaballo)
        {

        }
        
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int numeroPatas()
        {
            return 4;
        }

    }

    class Humano : Mamiferos
    {

        public Humano (String nombreHumano) : base(nombreHumano)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar como Gorila");
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int numeroPatas()
        {
            return 2;
        }

    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base (nombreBallena)
        {
            
        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }
}