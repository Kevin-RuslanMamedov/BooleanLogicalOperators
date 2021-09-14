using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda nimi");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string UserPassword = Console.ReadLine();

            if (UserName == "admin" && UserPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Proovi uuesti");
            }


        }
    }
}
