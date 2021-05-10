using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Werq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wersja prubna");
            Console.ReadKey();
            Console.Clear();

            string NazwaPostaci;
            Console.WriteLine("Witaj");
            Console.WriteLine("1. Nowa Gra");
            Console.WriteLine("2. Wczytaj Zapis");
            Console.WriteLine("3. Naura");

            string opcja = Console.ReadLine();
            string status = Console.ReadLine();

            if (opcja == "1")
            {
                Console.Clear();
                Console.Write("Imię  Postaci to: ");
                NazwaPostaci = Console.ReadLine();
                Console.ReadKey();

                Console.WriteLine("Jaka twoja Postac ma byc ?");
                Console.WriteLine("a. Słaby ale bardzo mądry");
                Console.WriteLine("b. Przeciętnie silny i w miarę mądry");
                Console.WriteLine("c. Bardzo silny ale gupi");
                Console.ReadKey();
                if (status == "a")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.Write(NazwaPostaci + "_Jest bardzo mądry ale słaby");
                    Console.ReadKey();
                    

                }
                else if (status == "b")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine(NazwaPostaci + "_Jest Przeciętny");
                    Console.ReadKey();
                    
                }
                else if(status == "c")
                {
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine(NazwaPostaci + "_Jest Koksem z małym muzgiem");
                    Console.ReadKey();

                }
            }
            else if (opcja == "2")
            {
                Console.Clear();
                Console.Write("Wybierz zapis:");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dzęks za test");
            }

            Console.ReadLine();

           
        }
    }
}








