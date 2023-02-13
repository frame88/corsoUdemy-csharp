using System;

namespace Primo 
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] x = new int[3] {5, 15, 56};
            
            foreach (int value in x)
                Console.WriteLine(value); 
        }
    }
}