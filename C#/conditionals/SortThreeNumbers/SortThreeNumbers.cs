using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
           
            if (a >= b && a >= c)
            {
                Console.Write("{0} ",a);
                if (b >= c && b <= a)
                {
                    Console.Write("{0} ", b);
                    Console.Write("{0} ", c);

                }else if (c >= b && c <= a)
                {
                    Console.Write("{0} ", c);
                    Console.Write("{0} ", b);
                }
            }
            if (b >= a && b >= c)
            {
                Console.Write("{0} ", b);
                if (a >= c && a <= b)
                {
                    Console.Write("{0} ", a);
                    Console.Write("{0} ", c);

                }
                else if (c >= a && c <= b)
                {
                    Console.Write("{0} ", c);
                    Console.Write("{0} ", a);
                }
            }
            if (c >= a && c >= b)
            {
                Console.Write("{0} ", c);
                if (b >= a && b <= c)
                {
                    Console.Write("{0} ", b);
                    Console.Write("{0} ", a);

                }
                else if (a >= b && a <= c)
                {
                    Console.Write("{0} ", a);
                    Console.Write("{0} ", b);
                }
            }

        }
    }
}
