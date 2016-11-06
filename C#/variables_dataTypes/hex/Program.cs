using System;


namespace hex
{
    class Program
    {
        static void Main()
        {
            int hex = 0x254;
            char hexSymbol = (char)42;
            bool fmale = false;
            string hello = "Hello";
            string world = "World";
            object concatination = hello + " " + world;
            string allInOne = (string)concatination;

            Console.WriteLine(hex);
            Console.WriteLine(hexSymbol);
            Console.WriteLine(fmale);
            Console.WriteLine(allInOne);


        }
    }
}
