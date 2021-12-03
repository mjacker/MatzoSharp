using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace HWn
{
    class HW02ex1
    {
        public static void Main()
        {
            // Exercice:
            Console.WriteLine("Hacer un programa que calcule el perímetro de cualquier poligono regular");
            Console.WriteLine("------------------------------------------------------------------------");

            // Program:
            // Aditional configuration for zone time.
            System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            Double s;
            int n;
                    Console.WriteLine("This Program calculate the perimeter of a regular polygon. \nA regular polygon consist in n-sides in witch the sides are all the same.");
            while (true){
                try
                {
                    Console.Write("Enter side dimension: ");
                    s = Convert.ToDouble(Console.ReadLine()); //2.2  //2,2
                    break;
                }
                catch (FormatException) {Console.WriteLine("\nInvalid format, please enter try again.");}
            }
            while (true){ 
                    try
                    {
                        Console.Write("Enter n-sides: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException) {Console.WriteLine("\nInvalid format, please enter an integer number.");}
            }
            Console.WriteLine("The total perimeter is: {0}", s * Convert.ToDouble(n));


            // Aditional Info: Culture info
            CultureInfo culture1 = CultureInfo.CurrentCulture;
            CultureInfo culture2 = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine("\n\n-------------------------------------\n");
            Console.WriteLine("The current culture is {0}", culture1.Name);
            Console.WriteLine("The two CultureInfo objects are equal: {0}",
                              culture1 == culture2);

        }
    }
}
