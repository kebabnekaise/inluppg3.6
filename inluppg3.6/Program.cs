using System;

namespace inluppg3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt namn");

            string input = Console.ReadLine();
            int spaceIndex = input.IndexOf(' ');
            string fornamn = input[..spaceIndex];
            string efternamn = input[(spaceIndex+1)..];

            if (fornamn.CompareTo(efternamn) == -1)
            {
                Console.WriteLine("Förnamnet kommer före i alfabetisk ordning");
            }
            else if (fornamn.CompareTo(efternamn) == 1)
            {
                Console.WriteLine("Förnamnet kommer efter i alfabetisk ordning");
            }




        }
    }
}