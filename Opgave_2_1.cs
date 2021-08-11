using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_2_1
    {
        public static void IfAlderSkrivTekst(string[] args)
        {
            string X, Z;
            int Y;

            Console.Write("Indtast navn: ");
            X = Console.ReadLine();

            Console.Write("Indtast Alder: ");
            Y = Convert.ToInt32(Console.ReadLine());

            if (Y == 1)
            {
                Z = "Du er lige født";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
            }
            else if (Y >= 2 && Y <= 5)
            {
                Z = "Du kan begynde i børnehave";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
            }
            else if (Y >= 6 && Y <= 16)
            {
                Z = "Du går i skole";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
            }
            else
            {
                    Z = "Nu begynder alvoren";
                    Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
                
            }

        }



    }
}
