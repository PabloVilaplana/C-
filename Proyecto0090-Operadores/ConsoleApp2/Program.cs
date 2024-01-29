internal class Program
{
    private static void Main(string[] args)
    {
        double temperatura = 34.9;

        int temperaturaMadrid;

        //conversion explicita
        // casting

        temperaturaMadrid = (int)temperatura;

        //conversion implicita

        int habitantesCiudad = 1000000;

        long habitantesCiudad2018 = habitantesCiudad;

        float pesoMaterial = 5.78F;
    }
}