internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");*/

        //string pangram = "The quick brown fox jumps over the lazy dog.";
        /*Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));*/

        /*Console.WriteLine(pangram.Contains("fox") == false);
        Console.WriteLine(!pangram.Contains("fox"));*/


        /*Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));*/

        /*int a = 7;
        int b = 6;
        Console.WriteLine(a != b); // output: True
        string s1 = "Hello";
        string s2 = "Hello";
        Console.WriteLine(s1 != s2); // output: False*/

        int saleAmount = 1001;
        // int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


    }
}