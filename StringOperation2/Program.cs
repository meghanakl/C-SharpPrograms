using System;
class Program
{
    static void Main(string[] args)
    {
        Stringreverse();
    }
    public static void Stringreverse()
    {

        string Str, reversestring = "";
        int Length;
        Console.Write("Enter A String : ");
        Str = Console.ReadLine();
        Length = Str.Length - 1;
        if (Length >= 5)
            Console.WriteLine(" string is bad");
        else if (Length <= 5)
            Console.WriteLine(" String is good");

        Console.ReadLine();
    }
}




