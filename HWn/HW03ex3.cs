using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW03ex3
    {
        public static void Main()
        {
            Console.WriteLine("Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00.");
            int time = Convert.ToInt32(ChooseOption());
            if (time <= 60)
            {
                Console.WriteLine("You need to pay $5.00.");
            }
            else if (time <= 120)
            {
                Console.WriteLine("You need to pay $15.00.");
            }
            else
            {
                Console.WriteLine("You need to pay $40.00");
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

