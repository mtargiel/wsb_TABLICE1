using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice2
{
    class Program
    {

        static void Main(string[] args)
        {
            LosowanieTablicy losowanieTablicy = new LosowanieTablicy();
            KopiujDodatnie kopiujDane = new KopiujDodatnie(losowanieTablicy.wylosujLiczby());
            Console.ReadLine();
        }


    }
}
