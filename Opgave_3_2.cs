using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_3_2
    {
        public static void SwitchCaseTemperatur(string[] args)
        {

            string temp;
            int Ctemp;
            double resultat;
            Console.WriteLine("Tast F for fahrenheit\nTast K for Kelvin\nTast R for Reaumur");
            Console.Write("Indtast hvilken temperatur type du ønsker er bruge: ");
            temp = Console.ReadLine().ToLower();

            switch (temp)
            {
                case "f":
                    Console.WriteLine("Indtast Celsius grader: ");
                    Ctemp = Convert.ToInt32(Console.ReadLine());
                    resultat = (Ctemp * 9 / 5) + 32;
                    Console.WriteLine("Celsius {0} er lig med {1}", Ctemp, resultat);
                    break;

                case "k":
                    Console.WriteLine("Indtast Celsius grader: ");
                    Ctemp = Convert.ToInt32(Console.ReadLine());


                    resultat = Ctemp + 273.15;
                    Console.WriteLine("Celsius {0} er lig med {1}", Ctemp, resultat);
                    break;

                case "r":
                    Console.WriteLine("Indtast Celsius grader: ");
                    Ctemp = Convert.ToInt32(Console.ReadLine());

                    resultat = Ctemp * 0.8;
                    Console.WriteLine("Celsius {0} er lig med {1}", Ctemp, resultat);
                    break;

                default:
                    Console.WriteLine("Du har ikke indtastet en korrekt temperatur type");


            }
            

        }




    }
}
