using System;


namespace ASCII
{
    class Program
    {
        static void Main()
        {


            string unicode = "";
            for(byte i = 33; i <= 126; i++)
            {
                char ascii = (char)i;

                unicode += ascii;
            }
            Console.WriteLine(unicode);
           

        }
    }
}
