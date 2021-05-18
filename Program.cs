using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Werq
{
    class Program
    {
        private static string nazwaPostaci;

        static void Main(string[] args)
        {
            nazwaPostaci = "Werq";

            ObsługaMenu();

            Console.ReadLine();
            

        }

        static void ObsługaMenu()
        { 
            Console.WriteLine("Wersja prubna");
            Console.ReadKey();
            Console.Clear();

            
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
                nazwaPostaci = Console.ReadLine();
                Console.ReadKey();

                Console.WriteLine("Jaka twoja Postac ma byc ?");
                Console.WriteLine("a. Słaby ale bardzo mądry");
                Console.WriteLine("b. Przeciętnie silny i w miarę mądry");
                Console.WriteLine("c. Bardzo silny ale gupi");
                Console.ReadKey();
                if (status == "a")
                {
                    Console.Clear();
                    Console.Write(nazwaPostaci + "Jest bardzo mądry ale słaby");
                    Console.ReadLine();
                    Console.ReadKey();
                  
                }
                else if (status == "b")
                {
                    Console.Clear();
                    Console.WriteLine(nazwaPostaci + "Jest Przeciętny");
                    Console.ReadLine();
                    Console.ReadKey();

                }
                else if (status == "c")
                {
                    Console.Clear();
                    Console.WriteLine(nazwaPostaci + "Jest Koksem z małym muzgiem");
                    Console.ReadLine();
                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("Początek przygody zaczyna sie Angielskim mieśćie Whitby. Gdzie zaczyna się życie naszego bohatera ");
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








