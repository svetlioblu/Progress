using System;


namespace Interval
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());
            int result = 0;
            
            while (n < m)
            {
                n++;
                if (n % 5 == 0)
                {
                    result++;
                }
               
            }
            Console.WriteLine(result);

        }
    }
}
