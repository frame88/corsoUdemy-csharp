using System;

namespace Conversione 
{
    class Program
    {
        static void Main(string[] args)
        {   
            //valori ammessi sono i bool, string, tutti gli int, enumerazioni
            int myvar = 10;

            switch(myvar) {
                case10: 
                    Console.WriteLine("Valore 10");
                    break;
                case20: 
                    Console.WriteLine("Valore 20");
                    break;
                case30: 
                    Console.WriteLine("Valore 30");
                    break;
                default: 
                    Console.WriteLine("Un altro valore!");
                    break;
            }

        }
    }
}