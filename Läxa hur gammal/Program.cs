using System;
namespace Läxa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är du född");
            string årtal = Console.ReadLine();
            int x = int.Parse(årtal);

            int ålder = 2023 - x;
            Console.WriteLine("Du är " + ålder + " år gammal");
            Console.ReadKey();


        }
    }
}