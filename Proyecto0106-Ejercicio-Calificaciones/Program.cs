
class Program
{
    static void Main(string[] args)
    {
        int numeroAlumnos = 0;
        double nota = 0;

        do
        {
            // Solicitar el número de alumnos
            Console.Write("Ingrese el número de alumnos: ");
            string input = Console.ReadLine();

            // Verificar si el valor ingresado es un número válido y mayor que cero
            if (EsNumeroValido(input, out numeroAlumnos))
            {
                Console.WriteLine($"Número de alumnos ingresado: {numeroAlumnos}");
                break;
            }
            else
            {
                Console.WriteLine("El valor ingresado no es válido. Por favor, ingrese un número mayor que cero.");
            }
        } while (true);

        // Crear un array para almacenar información de los alumnos
        Alumno[] alumnos = new Alumno[numeroAlumnos];

        // Solicitar información de cada alumno
        for (int i = 0; i < numeroAlumnos; i++)
        {
            Console.Write($"Ingrese el nombre del alumno {i + 1}: ");
            string nombre = Console.ReadLine();

            // Solicitar las notas
            
            do
            {
                Console.Write($"Ingrese la nota para el alumno {nombre}: ");
                string inputNota = Console.ReadLine();

                if (double.TryParse(inputNota, out nota) && nota >= 0 && nota <= 10)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un número válido en el rango de 0 a 10.");
                }
            } while (true);
            

            // Crear un objeto Alumno y agregarlo al array
            alumnos[i] = new Alumno(nombre, nota);
        }

        // Mostrar la información de los alumnos
        string nombreMayor = "";
        double notaMayor = 0;
        Console.WriteLine("Información de los alumnos:");
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($"Nombre: {alumno.Nombre}");
            Console.WriteLine($"Notas: {string.Join(", ", alumno.Notas)}");
            Console.WriteLine();

            //Revisar quien tiene mejor nota
            for (int i = 0;i < numeroAlumnos;i++)
            {
                if (notaMayor < alumno.Notas)
                {
                    nombreMayor = alumno.Nombre;
                    notaMayor = alumno.Notas;
                }
                
            }
        }

        //Mostrar quien tiene la mejor nota
        Console.WriteLine($"El Alumno con mayor promedio es el alumno {nombreMayor} con una calificación de: {notaMayor}");
        

    }

    static bool EsNumeroValido(string input, out int numero)
    {
        numero = 0;
        try
        {
            // Intentar convertir la entrada a un número entero
            if (int.TryParse(input, out numero))
            {
                // Verificar si el número es mayor que cero
                if (numero > 0)
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
        catch (OverflowException)
        {
            Console.WriteLine("El número ingresado es demasiado grande o demasiado pequeño para ser representado como un entero.");
            return false;
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("No se puede convertir la entrada a un número entero.");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
            return false;
        }
    }


    class Alumno
    {
        public string Nombre { get; }
        public double Notas { get; }

        public Alumno(string nombre, double nota)
        {
            Nombre = nombre;
            Notas = nota;
        }
    }

}

    



