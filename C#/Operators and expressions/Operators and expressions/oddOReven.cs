using System;

namespace Operators_and_expressions
{
    class oddOReven
    {
        static void Main()
        {
            sbyte input = sbyte.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("even " + input);
            }
            else
            {
                Console.WriteLine("odd " + input);
            }

        }
    }
}
