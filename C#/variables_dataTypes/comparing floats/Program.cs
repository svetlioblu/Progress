using System;


namespace comparing_floats
{
    class Program
    {
        static void Main()
        {
            float eps = 0.000001f;

            double member1 = double.Parse(Console.ReadLine());

            double member2 = double.Parse(Console.ReadLine());
            float member3 = (float)(member1 - member2);
            
            if (member3 >= eps)
            {
                Console.WriteLine("false");
            }
            if (member3 < eps)
            {
                Console.WriteLine("true");
            }
        }

    }
}

