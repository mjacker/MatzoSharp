using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW03ex2
    {
        public static void Main()
        {
            Console.WriteLine("Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.");
            Console.WriteLine(Oddeven(Convert.ToInt32(ChooseOption())));
            
            String Oddeven(int n)
            {
                return (n % 2 == 0 ? "Is even" : "Is odd");
            }

            String ChooseOption()
            {
                Console.Write(">> ");
                String r = Console.ReadLine();
                return r;
            }
        }
    }
}
