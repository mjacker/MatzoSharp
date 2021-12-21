using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW06ex1
    {
        public static void Main()
        {
            // calcular de promedio.
            Console.Write("Enter number of class: ");
            int numberClass = Convert.ToInt32(Console.ReadLine());
            double [][] jaggedStudenNotesArray = new double[numberClass][];
            double actualNote = 0;
            double totalNote = 0;
            int totalStudent = 0;

            for (int i = 0; i < numberClass; i++)
            {
                Console.Write("\n\nPlease enter number of students in class number {0}: ", i + 1);
                int numStudent = Convert.ToInt32(Console.ReadLine());
                jaggedStudenNotesArray[i] = new double[numStudent];
                for (int j = 0; j < numStudent; j++)
                {
                    Console.Write("   Enter id {0} note: ", j + 1);
                    actualNote = Convert.ToDouble(Console.ReadLine());
                    jaggedStudenNotesArray[i][j] = actualNote;
                    totalNote += actualNote;
                    totalStudent += 1;
                }
            }

            printJaggedArray(jaggedStudenNotesArray);
            Console.WriteLine("\n\nThe average note is: {0}", totalNote / totalStudent);
        }

        private static void printJaggedArray(double[][] jaggedArray)
        {
            Console.WriteLine("-----------------");
            int dimention1 = jaggedArray.Length;
            int dimention2;
            for (int i = 0; i < dimention1; i++)
            {
                Console.WriteLine("Class number: {0}", i + 1);
                dimention2 = jaggedArray[i].Length;
                for (int j = 0; j < dimention2; j++)
                {
                    Console.WriteLine("  Student id {0} note: {1}.", j + 1, jaggedArray[i][j]);
                }
                Console.Write("\n");
            }
        }
    }
}
