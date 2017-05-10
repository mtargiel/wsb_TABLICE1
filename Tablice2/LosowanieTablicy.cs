using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice2
{
    class LosowanieTablicy
    {
        private Random r = new Random();
        private int[] tablica { get; set; }
        public int [] wylosujLiczby()
        {
            tablica = new int[r.Next(10, 100)];
            Console.WriteLine("Wylosowana wielkość tablicy {0}", tablica.Length);
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = r.Next(-100, 100);
                Console.WriteLine(tablica[i]);
            }
            Array.Sort(tablica);
            return tablica;
        }
    }
}
