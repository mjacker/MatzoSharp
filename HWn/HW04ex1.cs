using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW04ex1
    {
        public static void Main()
        {
            Console.WriteLine("Hacer un Programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.");

            Double bas; 
            int exp;
            Console.WriteLine("This Program calculate a number b to the n exponent: b ^ n. \nPlease input both values:");
            Console.WriteLine("b: "); bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("n: "); exp = Convert.ToInt32(Console.ReadLine());

            var e = new HW04ex1();
            Console.WriteLine("\nThe answer is: {0}", e.Exponent(bas, exp));
        }

        Double Exponent(Double x, int y)
        {
            Double r = 1;

            if (y == 0)
            {
                r = 0;
            }
            else if (y == 1)
            {
                r = x;
            }
            else if (y > 1)
            {
                for (int i = 1; i <= y; i++)
                {
                    r *= x;
                }
            }
            else if (y < 0)
            {
                r = 1 / Exponent(x, -y);
            }
            return r;
        }
    }
}
