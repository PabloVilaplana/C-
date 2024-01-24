internal class Program
{
    private static void Main(string[] args)
    {
        int level = 56;
        string permission = "Admin";
        
        Console.WriteLine(level);
        Console.WriteLine((level > 55 && permission == "Admin") ? "Welcome, Super Admin user." : (level <= 55 && permission == "Admin") ? "Welcome, Admin user." : (level > 20 && permission == "Director") ? "Contact an Admin for access." : (level <= 20 && permission == "Director") ? "You do not have sufficient privileges." : (permission != "Director" || permission != "Admin") ? "You do not have sufficient privileges." : "nothing"); 


        


    }
}