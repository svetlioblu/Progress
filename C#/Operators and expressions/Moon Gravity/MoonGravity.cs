using System;


namespace Moon_Gravity
{
    class MoonGravity
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double moonGravity = (w * 17) / 100;
            Console.WriteLine("{0:0.000}", moonGravity);
            ;

        }
    }
}
