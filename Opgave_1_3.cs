using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_1_3
    {
        public static void Valutaomregning(string[] args)
        {
            int euro;
            double udregning, valuta;

            Console.Write("Indtastning af beløb i euro: ");
            euro = Convert.ToInt32(Console.ReadLine());

            valuta = 7.50;

            udregning = euro * valuta;

            Console.WriteLine("Beløbet er ialt {0} danske kroner.", udregning);

        }

    }
}
