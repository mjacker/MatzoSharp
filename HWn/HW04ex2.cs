using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW04ex2
    {
        public static void Main()
        {
            Console.WriteLine("Hacer un programa que calcule los números primos que existen entre 1 y 100");
            for (int i = 2; i <= 100; i++)
            {
                int divisores = 0;
                int j = 1;

                while (divisores <= 2 && j <= 100)
                {
                    if (i % j == 0)
                    {
                        //Console.WriteLine("{0} % {1}  es {2}", j, i, j % i);
                        divisores++;
                    }
                    j++;
                }
                if (divisores <= 2)
                {
                    Console.WriteLine("El número {0} es primo.", i);
                }
            }
        }
    }
}
