using System;


namespace changeValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
            if (a < b)
            {
                c = b;

                b = a;
                a = c;

            }
            Console.WriteLine($"{a},{b}");
        }
    }
}
