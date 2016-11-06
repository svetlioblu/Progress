using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int count = 1;
            string result = "";
            while (count <= input)
            {
                result +=count+" " ;
                count++;
            }
            Console.WriteLine(result);
        }
    }
}
