using System;

namespace Upgift_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt för och efternamn.");
            string helaNamn = Console.ReadLine();
            int mellanslag = helaNamn.IndexOf(" ");

            string förnamn = helaNamn[..mellanslag];
            string efternamn = helaNamn[(mellanslag + 1)..];

            if (förnamn.CompareTo(efternamn) < 0)
                Console.WriteLine("Förnamnet kommet först i bokstavsordning");
            else
                Console.WriteLine("Efternamnet kommer först i bokstavsordning");

            Console.ReadKey();
        }
    }
}