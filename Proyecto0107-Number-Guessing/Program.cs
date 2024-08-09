namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            int respuestaNumero = 0;

            Random r = new Random();
            int numero = r .Next(100);

            do
            {
                Console.WriteLine("Quieres jugar a: -Adivina el Numero- ? \n Di que Si");

                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();

                if (respuesta != "si")
                {
                    Console.WriteLine("Que lastima...");
                }

            } while (respuesta != "si");

            Console.WriteLine("Excelente! Adivina un numero del 1 al 100, simplemente dime que numero crees que sea:");
            do
            {
                respuesta = Console.ReadLine();

                if (EsNumeroValido(respuesta, out respuestaNumero))
                {
                    
                    if (numero == respuestaNumero)
                    {
                        break;
                    }
                    else
                    {
                        if (numero > respuestaNumero)
                        {
                            Console.WriteLine("El numero debe ser más alto");
                        }
                        if (numero < respuestaNumero)
                        {
                            Console.WriteLine("El numero debe ser más bajo");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido. Por favor, ingrese un número entre 1 y 100.");
                }

                

            } while (respuestaNumero != numero);

            Console.WriteLine($"Has ganado el juego! la respuesta era: {numero} ");
            

        }

        static bool EsNumeroValido(string respuesta, out int respuestaNumero)
        {
            respuestaNumero = 0;
            try
            {
                // Intentar convertir la entrada a un número entero
                if (int.TryParse(respuesta, out respuestaNumero))
                {
                    // Verificar si el número es mayor que cero
                    if (respuestaNumero > 0 && respuestaNumero < 101)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato incorrecto. Por favor, ingrese un número entero válido.");
                return false;
            }

        }

    }
    



}