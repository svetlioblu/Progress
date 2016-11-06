using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            byte  radius=2;
            bool isInOrOut = ((Math.Pow(x, 2)-0)) + (Math.Pow(y, 2)-0) <= Math.Pow(radius, 2);
            string result = isInOrOut.ToString();
            double position = Math.Sqrt(((Math.Pow(x, 2) - 0)) + (Math.Pow(y, 2) - 0));
            
           

           if (result == "True")
            {
                Console.WriteLine("yes {0:0.00}", position);
            }else
            {
                Console.WriteLine("no {0:0.00}", position);
            }

        }
    }
}
