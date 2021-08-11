using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_3_1
    {
        public static void SwitchCaseDageIUgen(string[] args)
        {
            int dag;

            Console.Write("hvor mange dage inde i ugen er vi?: ");
            dag = Convert.ToInt32(Console.ReadLine());

            switch (dag)
            {
                case 1:
                    Console.WriteLine("Du har tastet 1 så det er mandag idag");
                    break;

                case 2:
                    Console.WriteLine("Du har tastet 2 det vil sige at det er tirsdag idag");
                    break;

                case 3:
                    Console.WriteLine("Der er tastet 3 derfor er det onsdag Idag du er halvejs gennem hverdagene");
                    break;

                case 4:
                    Console.WriteLine("du har tastet 4 og det er torsdag");
                    break;

                case 5:
                    Console.WriteLine("Du har nu tastet 5 og det er fredag idag Godweekend");
                    break;

                case 6:
                    Console.WriteLine("Du har tastet 6 det er lørdag fortsat god weekend");
                    break;

                case 7:
                    Console.WriteLine("du har tastet 7 og det er derfor søndag idag");
                    break;


                default:
                    Console.WriteLine("du har ikke indtastet et relevant tal prøv igen");
                    break;






            }



        }
    }
}
