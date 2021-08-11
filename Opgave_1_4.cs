using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_1_4
    {
        public static void Regnskab(string[] args)
        {
            double Omsætning, Omkostning, Dækningsbidrag, Fasteomkostninger, Overskud;
            Console.Write("Indtast omsætning: ");
            Omsætning = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast variable omkostninger: ");
            Omkostning = Convert.ToDouble(Console.ReadLine());            

            Console.Write("Indtast Faste omkostninger: ");
            Fasteomkostninger = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Dækningsbidrag = Omsætning - Omkostning;

            Console.WriteLine("Dækningsbidrag: {0}", Dækningsbidrag);

            Overskud = Omsætning - Omkostning - Fasteomkostninger;

            Console.WriteLine("dit overskud er : {0}", Overskud);


        }

    }
}
