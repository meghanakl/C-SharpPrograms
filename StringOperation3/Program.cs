using System;
class Program
{
    static void Main(string[] args)
    {
        Stringreverse();
    }
    public static void Stringreverse()
    {

        string Str = "";
        int Length;
        Console.Write("Enter A String : ");
        Str = Console.ReadLine();
        Length = Str.Length;
        if (Length == 5)
        {
            Console.WriteLine(" string is average");
        }
        else if (Length < 5)
        {
            Console.WriteLine(" string is bad");
        }
        else
        {
            Console.WriteLine(" String is good");
        }
        if (Str.Contains("a"))
        {
            Console.WriteLine(" String contain a");
        }
        else
        {
            Console.WriteLine(" String  does not contain a");
        }

        Console.ReadLine();

    }
}
s