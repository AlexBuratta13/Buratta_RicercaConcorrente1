using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Buratta_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[100];
            RiempiArray(n);
            Console.WriteLine("Inserisci un numero:");
            int n1 = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => RicercaNumeri(n1, n));
            thread.Start();
            Console.ReadLine();
        }
        public static void RicercaNumeri(int n, int[] array)
        {
            for (int i = 0; i < 100; i++)
            {
                if (n == array[i])
                {
                    Console.WriteLine($"numero Trovato: {array[i]} posizione: {i}");
                }
            }
            Console.WriteLine("Ricerca terminata");
        }
        private static void RiempiArray(int[] numeri)
        {
            Random r = new Random();
            for (int n = 0; n < 100; n++)
            {
                numeri[n] = r.Next(0, 100);
            }
        }
    }
}
