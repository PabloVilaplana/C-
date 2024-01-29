namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //rellenando o agregando elemento a la cola
            foreach (int numero in new int[5] {2,4,6,8,10 })
            {
                numeros.Enqueue(numero);
            }

            //recorriendo la cola
            Console.WriteLine("Recorriendo el Queue");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminando elementos del Queue
            Console.WriteLine("Eliminando Elementos");

            numeros.Dequeue();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}