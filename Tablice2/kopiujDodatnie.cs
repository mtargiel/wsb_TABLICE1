using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice2
{
    class KopiujDodatnie
    {
        private int[] _tablica;

        public int[] tablica
        {
            get { return _tablica; }
            set { _tablica = value; }
        }
        private int licznik1 = 0;
        private int[] tablicaPozytywna;
        public KopiujDodatnie(int[] t)
        {
            tablica = t;
            Array.Sort(tablica);
            Array.Reverse(tablica);
            for (int i = 0; i < _tablica.Length; i++)
            {
                if (_tablica[i] > 0)
                    licznik1++;
                
            }
            Console.WriteLine("Ilość liczb dodatnich: {0}", licznik1);
            tablicaPozytywna = new int[licznik1];
            for (int i = 0; i < tablicaPozytywna.Length; i++)
            {
                if (tablica[i] > 0)
                    tablicaPozytywna[i] = tablica[i];
                Console.WriteLine("Liczba nr {0}: {1}",i+1, tablicaPozytywna[i]);
            }
        }
    }
}
