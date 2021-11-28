using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW03ex1
    {
        public static void Main()
        {
            Console.WriteLine("Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.");
            Console.Write(">> ");
            String c = Console.ReadLine();


            switch (c)
            {
                case "1":
                    Console.WriteLine("January");
                    break;
                case "2":
                    Console.WriteLine("February");
                    break;
                case "3":
                    Console.WriteLine("March");
                    break;
                case "4":
                    Console.WriteLine("April");
                    break;
                case "5":
                    Console.WriteLine("May");
                    break;
                case "6":
                    Console.WriteLine("June");
                    break;
                case "7":
                    Console.WriteLine("July");
                    break;
                case "8":
                    Console.WriteLine("August");
                    break;
                case "9":
                    Console.WriteLine("September");
                    break;
                case "10":
                    Console.WriteLine("October");
                    break;
                case "11":
                    Console.WriteLine("November");
                    break;
                case "12":
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Please choose a number from 1 to 12.");
                    break;
            }
        }
    }
}
