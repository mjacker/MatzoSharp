using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW02ex2
    {
        public static void Main()
        {
            Console.WriteLine("Hacer un programa que transforme de grados a Centrígrados a grados Fahrenheit.\n------------------------------------------------------------------------------------");
            Double c;
            while (true)
            {
                try
                {
                    Console.Write("This program convert celsius to fahrenheit.\n\n  Enter Celsius: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n\n  {0} Celsius to Fahrenheit is: {1}", c, (c * 9 / 5) + 32);
                    break;
                }
                catch (Exception e)
                {
                    // Set the Background color to blue
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nWARNING - Exception capture: \n  {0} \n  The correct format is: 00.0\n  Press Enter and try again.", e.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                }
            }


        }
    }
}
