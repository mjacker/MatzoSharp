using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Menu
    {
        public void PrintM(String n)
        {
            Console.Clear();

            if (n == "0")
            {
                Console.WriteLine("\tHOMEWORKS\n-------------------------\n");
            }
            else
            {
                Console.WriteLine("\tHOMEWORK " + n + " - EXERCICES\n-------------------------\n");
            }

            switch (n)
            {
                case "0":
                    Console.WriteLine("" +
                        "1) Homework 1 - Print your name.\n" +
                        "2) Homework 2 - Basic calculation. \n" +
                        "3) Homework 3 - Using switch cases.\n" +
                        "4) Homework 4 - Using for cases.\n" +
                        "5) Homework 5 - Methods.\n" +
                        "6) Homework 6 - Matrix of Arrays.\n" + 
                        "7) Homework 7 - Bank account.\n" +
                        "0) Exit.");
                    break;
                case "1":
                    Console.WriteLine("1) Project where you can print your name. \n0) Back.");
                    break;
                case "2":
                    Console.WriteLine("1) Perimeter of a poligon. \n2) Convert celsius to fahrenheit.\n0) Back");
                    break;
                case "3":
                    Console.WriteLine("1) Input a number (1-12), then recieve a month name. \n2) Input a number, check odd or even. \n3) Parking Software. \n0) Back.");
                    break;
                case "4":
                    Console.WriteLine("1) Compute a number to a exponent (negavite or positive). \n2) Numeros primos. \n0) Back.");
                    break;
                case "5":
                    Console.WriteLine("1) Degrees to radians. \n2) Figures areas. (circle, triangle, square). \n0) Back.");
                    break;
                case "6":
                    Console.WriteLine("1) Compute average, min, max Student's notes program. \n0) Back.");
                    break;
                case "7":
                    Console.WriteLine("1) Bank accont. \n0) Back.");
                    break;
            }
        }

        public String ChooseOption()
        {
            Console.Write(">> ");
            String r = Console.ReadLine();
            return r;
        }
    }
}
