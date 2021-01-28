using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buratta_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static void RicercaNumeri(int n, int[] array)
        {
            for (int i = 0; array.Length < 100; i++)
            {
                if (array[i] == n)
                {
                    Console.WriteLine("il numero è contenuto nell array");
                }
                else
                {
                    Console.WriteLine("il numero non esiste nell' array");
                }
            }
        }
    }
}
