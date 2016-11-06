using System;


namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int b = 0;

            for (int divider = 2; input > divider; divider++)
            {
                if (input % divider == 0)
                {
                    Console.WriteLine("false");
                    break;
                    
                }
                b++;
               
            }
            if (b == input - 2)
            {
                Console.WriteLine("true");
            }
            if (input <= 1)
            {
                Console.WriteLine("false");
            }
        }
    }
}
