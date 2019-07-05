
using System;

namespace C_Sharp_Classes

{
    class Program
    {
        static void Main(string[] args)

        {
            Car theCar = new Car();
            theCar.Name = "benz";
            theCar.year = 2015;
            theCar.LicenceNumber = " karb000";
            theCar.color = " black";

            Console.WriteLine(theCar.Name);
            Console.WriteLine(theCar.year);
            Console.WriteLine(theCar.LicenceNumber);
            Console.WriteLine(theCar.color);
            Console.ReadLine();


        }

    }
}