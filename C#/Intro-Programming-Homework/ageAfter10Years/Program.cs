using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            string input = Console.ReadLine();

            DateTime currentTime = DateTime.Parse("03.05.2016");
            DateTime birthDate = Convert.ToDateTime(input);

            TimeSpan age; // calculate time span in days

            if (currentTime > birthDate)
                age = currentTime - birthDate;
            else
                age = birthDate - currentTime;

            int ageInYears = (int)Math.Floor(age.Days / 365.25);// calculate years

            Console.WriteLine(ageInYears);
            Console.WriteLine(ageInYears + 10);
        }
    }
}