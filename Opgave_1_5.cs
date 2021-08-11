using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_1_5
    {

        public static void RegnskabUdviget(string[] args)
        {
            double Omsætning, Omkostning, Dækningsbidrag, Fasteomkostninger, Overskud, Dækningsgrad, Overskudsgrad;
            Console.Write("Indtast omsætning: ");
            Omsætning = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast variable omkostninger: ");
            Omkostning = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast Faste omkostninger: ");
            Fasteomkostninger = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Dækningsbidrag = Omsætning - Omkostning;
            Dækningsgrad = (Dækningsbidrag / Omsætning)*100; 

            Console.WriteLine("Dækningsbidrag: {0}", Dækningsbidrag);
            Console.WriteLine("Dækningsgrad: {0}", Dækningsgrad);


            Overskud = Omsætning - Omkostning - Fasteomkostninger;
            Overskudsgrad = Overskud / Omsætning;

            Console.WriteLine("dit overskud er : {0}", Overskud);
            Console.WriteLine("din overskudsgrad er : {0}", Overskudsgrad);


        }

    }
}
