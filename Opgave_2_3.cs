using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavehæftet
{
    class Opgave_2_3
    {
        public static void IfElseAlderKarakter(string[] args)
        {
            int alder, karakter;

            Console.Write("Indtast alder: ");
            alder = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast Karakter: ");
            karakter = Convert.ToInt32(Console.ReadLine());
            
            if (alder >= 18 && alder <= 24)
            {
                if (karakter >= 1 && karakter <= 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("alder: {0} - karakter: {1}", alder, karakter);
                }
                else if (karakter >= 5 && karakter <= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("alder: {0} - karakter: {1}", alder, karakter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("alder: {0} - karakter: {1}", alder, karakter);
                }


            }
            else if (alder >= 25 && alder <= 29)
            {
                if (karakter >= 1 && karakter <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("alder: {0} - karakter: {1}", alder, karakter);
                }
                else if (karakter >= 6 && karakter <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("alder {0} - karakter: {1}", alder, karakter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("alder {0} - karakter: {1}", alder, karakter);
                }

            }

        }
    }
}
