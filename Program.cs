using System;

namespace Primo 
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.Write("Scrivi qualcosa: ");
            string s = Console.ReadLine();

            if ( s == "primo") {
                Console.WriteLine("Hai scritto primo!");
            }

            switch(s) {
                case "primo":
                Console.WriteLine("Hai scritto primo!");
                break;
                default:
                Console.WriteLine("Non hai scritto primo!");
                break;
            }
        }
    }
}