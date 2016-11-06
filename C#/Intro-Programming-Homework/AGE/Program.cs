using System;


namespace AGE
{
    class Program
    {
        static void Main()
        {
            string myBirthdayDate = Console.ReadLine();
            var year = DateTime.Parse(myBirthdayDate).Year;
            var currentDate = DateTime.Now.Date.ToShortDateString();
            var currentYear = DateTime.Parse(currentDate).Year;



            Console.WriteLine(currentYear - year);
            
            Console.WriteLine(currentYear - year+10);

        }
    }
}
