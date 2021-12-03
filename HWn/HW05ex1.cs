using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HWn
{
    class HW05ex1
    {
        public static void Main()
        {
            Console.Write("Crear un método para transformar de grados a radianes.\n----------------------------------------------------------------");
            try 
            {
                Console.Write("\nEnter Celsius degrees: ");
                Console.Write("\nCelsius degrees to radians: {0}", Grad2rad(Convert.ToDouble(Console.ReadLine())));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Warning - Error: {0}.\n Press enter to try again.", e.Message);
                Console.ReadLine();
            }
        }

        static Double Grad2rad(Double g)
        {
            Console.Write("\nEl valor de g recibido es: {0}", g);
            return ((Math.PI * g) / 180);
        }
    }
}
