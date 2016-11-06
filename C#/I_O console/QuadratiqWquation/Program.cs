using System;


namespace QuadratiqEquation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double determinant = b * b - 4 * a * c;
            double root1, root2;

            if (determinant > 0)
            {
                root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                root2 = (-b - Math.Sqrt(determinant)) / (2 * a);
                if (root1 > root2)
                {
                    double temp;
                    temp = root1;
                    root1 = root2;
                    root2 = temp;

                }

                Console.WriteLine("{0:0.00}\n{1:0.00}", root1, root2);

            }
            else if (determinant == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("{0:0.00}", root1);

            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
