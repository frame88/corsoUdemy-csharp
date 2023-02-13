using System;

namespace Conversione 
{
    class Program
    {
        static void Main(string[] args)
        {   
            int temperatura = 20;

            if (temperatura > 25){
                Console.WriteLine($"fa caldo");
            } else if (temperatura < 15) {
                Console.WriteLine($"Freddo");        
            } else {
                Console.WriteLine("Si sta bene");        
            }
        }
    }
}