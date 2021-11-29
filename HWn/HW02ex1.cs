﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Double s;
            int n;
                    Console.WriteLine("This Program calculate the perimeter of a regular polygon. \nA regular polygon consist in n-sides in witch the sides are all the same.");
            while (true){
                try
                {
                    Console.Write("Enter side dimension: ");
                    s = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("The total perimeter is: {0}", s * (Convert.ToDouble(n)));
        }
    }
}
