using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleNumbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i <= input; i++)
            {
                if(!(i%3==0 || i%7==0))
                {
                    result += i+" ";
                }
               
            }
            Console.WriteLine(result);
        }
    }
}
