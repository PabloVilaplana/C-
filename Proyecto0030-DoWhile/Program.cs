internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int ataqueHeroe = random.Next(1, 11);
        int ataqueMonstruo = random.Next(1, 11);

        int vidaHeroe = 10;
        int vidaMonstruo = 10;

        do
        {
            vidaMonstruo = vidaMonstruo - ataqueHeroe;
            Console.WriteLine($"Monster was damaged and lost {ataqueHeroe} health and now has {vidaMonstruo} health.");
            if ( vidaMonstruo <= 0 )
            {
                Console.WriteLine($"Ganó el Heroe");
                break;
            }

            vidaHeroe = vidaHeroe - ataqueMonstruo;
            Console.WriteLine($"Hero was damaged and lost {ataqueMonstruo} health and now has {vidaHeroe} health.");
            if (vidaHeroe <= 0)
            {
                Console.WriteLine($"Ganó el Monstruo");
                break;
            }

        } while (vidaMonstruo > 0 || vidaHeroe > 0 );
    }
}