using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            något();


        }

        static void något()
        {
            Console.WriteLine("Skriv in ditt bas tal");
            string bas = Console.ReadLine();
            Console.WriteLine("Skriv in ditt exponent tal");
            string exponent = Console.ReadLine(); 

            int tal1 = int.Parse(bas);
            int tal2 = int.Parse(exponent);

            int tal3 = 1;

            for(int i = 0; i < tal2;i++)
            {
                tal3 = tal1 * tal3;
            }

            Console.WriteLine();
            Console.WriteLine(tal3);
        }        
    }
}
