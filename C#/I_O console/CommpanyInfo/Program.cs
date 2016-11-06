using System;


namespace CommpanyInfo
{
    class Program
    {
        static void Main()
        {
           
            string cName = Console.ReadLine();
            
            string cAdress = Console.ReadLine();
            
            string nNumber = Console.ReadLine();
           
            string fNumber = Console.ReadLine();
            if (!string.IsNullOrEmpty(fNumber))
            {
                fNumber=fNumber;
            }
            else
            {
                fNumber="(no fax)";

            }


            string wSite = Console.ReadLine();
            string managerFName = Console.ReadLine();
           
            string managerLName = Console.ReadLine();
           
            string managerAge = Console.ReadLine();
           
            string managerPhone = Console.ReadLine();
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", cName, cAdress,nNumber,fNumber,wSite,managerFName,managerLName,managerAge,managerPhone);
        }
    }
}
