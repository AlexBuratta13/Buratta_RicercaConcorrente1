using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buratta_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[100];
            RiempiArray(n);
            Console.WriteLine("Inserisci un numero :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(RicercaNumeriAsync(n1, n).Result);
            Console.ReadLine();
        }
        private static async Task<bool> RicercaNumeriAsync(int n, int[] array)
        {
            bool trovato = false;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (n == array[i])
                    {
                        trovato = true;
                    }
                }
            });

            return trovato;
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
