using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 110;
            Console.WindowHeight = 34;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Met deze toepassing kan de volgende informatie over Fibonacci getallen worden verkregen:");
            Console.WriteLine("");
            Console.WriteLine("1) Alle Fibonacci getallen onder een bepaald maximum worden weergegeven; ");
            Console.WriteLine("2) Het bij elkaar opgetelde totaal van deze getallen wordt weergeven; ");
            Console.WriteLine("3) Het totaal van zowel de even als de on- even getallen onder het maximum wordt weergegeven;");
            Console.WriteLine("4) Het (totaal/ even / on- even) aantal Fibonacci getallen onder het maximum wordt weergegeven.");
            Console.WriteLine("");
            Console.WriteLine("Geef eerst het gewenste maximum op:");
            Console.WriteLine("");

            string drukOpToets = ("Druk op een toets om door te gaan...");
            int aantal = 0, aantalEven = 0, aantalOneven = 0;
            double maximum1 = Double.Parse(Console.ReadLine());
            double hoogsteFibonacci = 1, zichZelf = 1, startGetal = 0, opgeteld = 0, opgeteldOneven = 0, opgeteldEven = 0;
            Console.WriteLine("");

            while (hoogsteFibonacci < maximum1)
            {
               
                Console.WriteLine(hoogsteFibonacci);

                opgeteld += hoogsteFibonacci;


                if (hoogsteFibonacci % 2 == 0)
                {
                    opgeteldEven += hoogsteFibonacci;
                    aantalEven++;
                }
                else
                {
                    opgeteldOneven += hoogsteFibonacci;
                    aantalOneven++;
                }
                    aantal++;
                
                hoogsteFibonacci = startGetal + zichZelf;
                startGetal = zichZelf;
                zichZelf = hoogsteFibonacci;
                
            }
            Console.WriteLine("");
            Console.WriteLine("1) Dit zijn alle Fibonacci getallen onder het opgegeven maximum van: " + maximum1);
            Console.WriteLine(drukOpToets);
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("2) Het opgetelde totaal van alle Fibonacci getallen onder het maximum van " + maximum1 + " is: " + opgeteld);
            Console.WriteLine(drukOpToets);
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("3a) Het opgetelde totaal van alle even Fibonacci getallen onder het maximum van " + maximum1 + " is: " + opgeteldEven);
            Console.WriteLine("3b) Het opgetelde totaal van alle on-even Fibonacci getallen onder het maximum van " + maximum1 + " is: " + opgeteldOneven);
            Console.WriteLine(drukOpToets);
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("4a) Het aantal Fibonacci getallen onder het maximum van " + maximum1 + " is: " + aantal);
            Console.WriteLine("4b) Het aantal even Fibonacci getallen onder het maximum van " + maximum1 + " is: " + aantalEven);
            Console.WriteLine("4c) Het aantal on- even Fibonacci getallen onder het maximum van " + maximum1 + " is: " + aantalOneven);
            Console.WriteLine("");
            Console.WriteLine("Druk op een toets om deze berekening af te sluiten...");
            Console.ReadKey();
            

            
        }
    }
}
