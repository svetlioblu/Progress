using System;


namespace printSequence
{
    class Program
    {
        static void Main()
        {
            int member = 2;
            for (int i = 0; i < 10; i++)
            {
                if (member % 2 == 0)
                {
                    Console.WriteLine(member);
                    member++;
                }
                else
                {
                    Console.WriteLine(-member);
                    member++;
                }
            }
        }
    }
}

