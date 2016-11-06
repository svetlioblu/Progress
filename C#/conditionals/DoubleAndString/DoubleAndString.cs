using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAndString
{
    class DoubleAndString
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string value=Console.ReadLine();
            if (type == "text")
            {
                Console.WriteLine(value + "*");
            }
            else if (type == "integer")
            {
                Console.WriteLine(int.Parse(value) + 1);

            }
            else if (type == "real")
            {
                Console.WriteLine("{0:0.00}",double.Parse(value) + 1);
            }
        }
    }
}
