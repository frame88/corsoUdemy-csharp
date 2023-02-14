// - Nella condizione for, mettere un numero in piu per il termine dell'iterazione
// - Assegnazione del valore matriciale tramite doppio indice, tipo: arr[i ,j] = x;
// - Usare Console.Write se si intende stampare valori in un ciclo senza andare a capo

using System;
namespace Primo 
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[,] arr = new int[5,5];
            int counter = 0;

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    ++counter;
                    arr[i, j] = (j == 0) ? 0: counter;
                }
            }

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}