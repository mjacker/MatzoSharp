using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Temas que estoy abordando en este programa:
 *  - Imprementacion de clases abstractas para calcular el area de figuras.
 *  -
 */

namespace HWn
{
    class HW05ex2
    {
        public static void Main()
        {
            // Exercice:
            Console.Write("Crear una aplicación que calcule el área de un círculo, cuadrado, o triangulo. " +
                "Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos.\n--------------------------------------------------------------------");

            // Program:
            Console.Write("Choose a figure: \n---------------\n 1) Circle.\n 2) Square.\n 3) Triangle.\n>> ");
            String op = Console.ReadLine();

            try 
            { 
                switch (op)
                {
                    case "1":
                        Circulo miCirculo = new Circulo();
                        miCirculo.Area();
                        break;
                    case "2":
                        Cuadrado miCuadrado = new Cuadrado();
                        miCuadrado.Area();
                        break;
                    case "3":
                        Triangulo miTriangulo = new Triangulo();
                        miTriangulo.Area();
                        break;
                    default:
                        Console.Write("Invalid option.");
                        break;
                }
            }
            catch (Exception a)
            {
                Console.Write("WARNING: {0}", a.Message);
            }
        }
    }


    // Abstract class
    public abstract class Figures
    { 
        // Abstract method (does not have a body)
        public abstract void Area();
    };

    // Derived class (inherit from Animal)
    public class Triangulo : Figures
    {
        public override void Area()
        {
            // The body of Area() is provided here
            Console.Write("Enter base: ");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hight: ");
            Double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nThe area is: {0}", (b * h) / 2);
        }
    }

    public class Cuadrado : Figures
    {
        public override void Area()
        {
            // The body of Area() is provided here
            Console.Write("Enter side: ");
            Double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nThe area is: {0}", s * s);
        }
    }

    public class Circulo : Figures
    {
        public override void Area()
        {
            // The body of Area() is provided here
            Console.Write("Enter radio: ");
            Double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nThe area is: {0}", Math.PI * r * r);
        }
    }
}