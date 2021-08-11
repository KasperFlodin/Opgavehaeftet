using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_2_2
    {
        public static void IfAlderSkrivTekstUdviget(string[] args)
        {
            string X, Z;
            int Y;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Indtast navn: ");
            X = Console.ReadLine();

            Console.Write("Indtast Alder: ");
            Y = Convert.ToInt32(Console.ReadLine());

            if (Y == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Z = "Du er lige født";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
            }
            else if (Y >= 2 && Y <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Z = "Du kan begynde i børnehave";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
            }
            else if (Y >= 6 && Y <= 16)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Z = "Du går i skole";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Z = "Nu begynder alvoren";
                Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", X, Y, Z);

            }

        }




    }
}
