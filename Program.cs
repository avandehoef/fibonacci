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
            Console.WriteLine("Met deze toepassing kan de volgende informatie verkregen worden:");
            Console.WriteLine("");
            Console.WriteLine("1) Alle Fibonacci getallen onder een bepaald maximum worden weergegeven; ");
            Console.WriteLine("2) Het bij elkaar opgetelde totaal van deze getallen wordt weergeven; ");
            Console.WriteLine("3) Het totaal van zowel de 3a) even als de 3b) on- even getallen onder het maximum wordt weergegeven;");
            Console.WriteLine("4) Het totaal aantal Fibonacci getallen onder het maximum wordt weergegeven.");
            Console.WriteLine("");
            Console.WriteLine("Geef eerst het gewenste maximum op:");
            Console.WriteLine("");

            int aantal = 0;
            double maximum1 = Double.Parse(Console.ReadLine());
            double hoogsteFibonacci = 1, zichZelf = 1, startGetal = 0, opgeteld = 0, opgeteldOneven = 0, opgeteldEven = 0;
            Console.WriteLine("");

            while (hoogsteFibonacci < maximum1)
            {
               
                Console.WriteLine(hoogsteFibonacci);

                opgeteld += hoogsteFibonacci;
                

                if (hoogsteFibonacci % 2 == 0)
                    opgeteldEven += hoogsteFibonacci;
                else
                    opgeteldOneven += hoogsteFibonacci;
                    aantal++;
                
                hoogsteFibonacci = startGetal + zichZelf;
                startGetal = zichZelf;
                zichZelf = hoogsteFibonacci;
                
            }
            Console.WriteLine("");
            Console.WriteLine("1) Dit zijn alle Fibonacci getallen onder het opgegeven maximum van: " + maximum1);
            Console.WriteLine("Druk op een toets...");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("2) Het opgetelde totaal van alle Fibonacci getallen onder het maximum van " + maximum1 + " is: " + opgeteld);
            Console.WriteLine("Druk op een toets...");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("3a) Het opgetelde totaal van alle even Fibonacci getallen onder het maximum van " + maximum1 + " is: " + opgeteldEven);
            Console.WriteLine("3b) Het opgetelde totaal van alle on-even Fibonacci getallen onder het maximum van " + maximum1 + " is: " + opgeteldOneven);
            Console.WriteLine("Druk op een toets...");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("4) Het aantal Fibonacci getallen onder het maximum van " + maximum1 + " is: " + aantal);
            Console.WriteLine("");
            Console.WriteLine("Druk op een toets om deze berekening af te sluiten...");
            Console.ReadKey();
            

            
        }
    }
}
