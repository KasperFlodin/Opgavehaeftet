using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_1_2
    {
        public static void CelsiusToOtherTemp(string[] args)
        {
            double Fahrenheit, Celsius, Kelvin, Reaumur;

            Console.Write("Indtast Celsius temperaturen: ");
            Celsius = Convert.ToInt32(Console.ReadLine());


            Fahrenheit = ((Celsius*9)/5)+32;
            Kelvin = (Celsius + 273.15);
            Reaumur = (Celsius * 0.8);



            Console.WriteLine("temperaturen er {0:0.00} fahrenheit, {1:0.00} Kelvin og temperaturen er {2:0.00} Reaumur ", Fahrenheit, Kelvin, Reaumur);


            Console.ReadKey();
        }
    }
}
