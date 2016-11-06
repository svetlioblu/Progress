using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSAofN
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double[] input = new double[number];
            double minimalNumber;
            double maximalNumber;
            double sum = 0;
            double average = 0;


            for (int i = 0; i < number; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }

            minimalNumber = input[0];
            maximalNumber = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (minimalNumber > input[i])
                {
                    minimalNumber = input[i];
                }
                if (maximalNumber < input[i])
                {
                    maximalNumber = input[i];
                }
                sum += input[i];
                average = sum / number;

            }
            Console.WriteLine("min={0:0.00}\nmax={1:0.00}\nsum={2:0.00}\navg={3:0.00}", minimalNumber, maximalNumber, sum, average);
        }
    }
}





