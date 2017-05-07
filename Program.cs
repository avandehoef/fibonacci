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

            Console.WriteLine();

            int datum = DateTime.Now.Hour;

            DateTime nu = DateTime.Now;

            if (datum < 6)
            {
                Console.WriteLine("Goeienacht, het is momenteel " + nu);
            }
            else if (datum < 12)
            {
                Console.WriteLine("Goeiemorgen, het is momenteel " + nu);
            }
            else if (datum < 18)
            {
                Console.WriteLine("Goeiemiddag, het is momenteel " + nu);
            }
            else if (datum < 24)
            {
                Console.WriteLine("Goeienavond, het is momenteel " + nu);
            }

            Console.WriteLine("");            
            Console.WriteLine("");
            Console.WriteLine("Met deze toepassing kan de volgende informatie over Fibonacci getallen worden verkregen:");
            Console.WriteLine("");
            Console.WriteLine("1) Alle Fibonacci getallen onder een bepaald maximum worden weergegeven; ");
            Console.WriteLine("2) Het bij elkaar opgetelde totaal van deze getallen wordt weergeven; ");
            Console.WriteLine("3) Het totaal van zowel de even als de on- even getallen onder het maximum wordt weergegeven;");
            Console.WriteLine("4) Het (totaal/ even / on- even) aantal Fibonacci getallen onder het maximum wordt weergegeven;");
            Console.WriteLine("5) Er wordt aangegeven of het laatste/ hoogste getal in de Fibonacci reeks even of on- even is.");
            Console.WriteLine("");

            Console.WriteLine("Geef eerst het gewenste maximum (> 0) op:");
            Console.WriteLine("");

            string drukOpToets = ("Druk op een toets om door te gaan...");

            string invoer = Console.ReadLine();
            double maximum1;
            bool succesvolleInvoer = double.TryParse(invoer, out maximum1);

            while (true)
            {
                if (invoer.Length != 0 && succesvolleInvoer == true && maximum1 > 0)
                    break;
                Console.WriteLine("Dit is geen geldige invoer; alleen met (positieve) getallen kan een Fibonacci reeks worden gemaakt. ");
                Console.WriteLine("Geef nogmaals een gewenst maximum op (een getal groter dan 0) ");
                invoer = Console.ReadLine();
                succesvolleInvoer = double.TryParse(invoer, out maximum1);
            }
                        
                double aantal = 0;
                double hoogsteFibonacci = 1, zichZelf = 1, startGetal = 0, opgeteld = 0, opgeteldOneven = 0, opgeteldEven = 0, aantalEven = 0, aantalOneven = 0;

                Console.WriteLine("");
                            
                    while (hoogsteFibonacci < maximum1)
                    {

                        Console.WriteLine(hoogsteFibonacci);

                        opgeteld = opgeteld + hoogsteFibonacci;


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
                    Console.WriteLine(drukOpToets);
                    Console.ReadKey();
                    Console.WriteLine("");

                    double laatsteGetalEvenofOneven = (aantalOneven / aantalEven);

                    if
                        (laatsteGetalEvenofOneven % 2 == 0)
                    {
                        Console.WriteLine("5) Het hoogste Fibonacci getal in deze reeks is EVEN");
                    }
                    else
                    {
                        Console.WriteLine("5) Het hoogste Fibonacci getal in deze reeks is ON-EVEN");
                    }

                Console.WriteLine(drukOpToets);
                Console.ReadKey();
                                                      
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Vervolgens kunnen we de waarde van bijvoorbeeld het 5de Fibonacci getal weergeven ");
                Console.WriteLine("");
                Console.WriteLine("Geef het gewenste, \"zoveelste\" getal op:");
            
            string invoer2 = Console.ReadLine();
            double zoveelsteFibonacci;
            bool succesvolleInvoer2 = double.TryParse(invoer2, out zoveelsteFibonacci);

            while (true)
            {
                if (invoer2.Length != 0 && succesvolleInvoer2 && zoveelsteFibonacci > 0)
                    break;
                Console.WriteLine("Dit is geen geldige invoer, geef nogmaals een gewenst nummer op:");
                invoer2 = Console.ReadLine();
                succesvolleInvoer2 = double.TryParse(invoer2, out zoveelsteFibonacci);
            }

            double aantal2 = 1;
                double hoogsteFibonacci2 = 1; double zichZelf2 = 1; double startGetal2 = 0; double opgeteld2 = 0;

                while (aantal2 < zoveelsteFibonacci)
                {
                    opgeteld2 += hoogsteFibonacci2;

                    aantal2++;

                    hoogsteFibonacci2 = startGetal2 + zichZelf2;
                    startGetal2 = zichZelf2;
                    zichZelf2 = hoogsteFibonacci2;
                }

                Console.WriteLine("");
                Console.WriteLine("De waarde van Fibonacci getal nummer " + zoveelsteFibonacci + " is: " + hoogsteFibonacci2);
                Console.WriteLine("");
                       
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Druk op een toets om deze berekening af te sluiten...");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadKey();
            
        }
    }
}
