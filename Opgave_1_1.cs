using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_1_1
    {
        public static void FahrenheitToCelsius(string[] args)
        {
            double Fahrenheit, resultat;

            Console.Write("Indtast decimal tal i fahrenheit: ");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());

            resultat = (Fahrenheit - 32) * 5 / 9;

            Console.Write("temperaturen er {0:0.00} celsius", resultat);


            Console.ReadKey();
        }
    }
}
