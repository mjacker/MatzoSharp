using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW06ex1
    {
        // Static Menu Variables
        private static IDictionary<int, string> menu = new Dictionary<int, string>()
        {
            { 0, "Back." },
            { 1, "Enter student notes." },
            { 2, "Print all notes." },
            { 3, "Compute average." },
            { 4, "Find min max notes." },
            { 5, "Delete notes." },
        };

        // Static Students/Class/Notes data
        private static int numberClass = 0;
        private static double[][] jaggedStudenNotesArray;
        private static double actualNote;
        private static double totalNote = 0;
        private static int totalStudent = 0;
        private static double maxNote = 0;
        private static double minNote = 0;

        public static void Main()
        {
            try
            {
                PrintMenu();
                int varOption = ChooseOption();
                while (varOption > 0)
                {
                    switch (varOption)
                    {
                        case 1:
                            SetStudentNotes();
                            break;
                        case 2:
                            PrintJaggedArray();
                            break;
                        case 3:
                            AverageStudentNotes();
                            break;
                        case 4:
                            MinMaxNotes();
                            break;
                        case 5:
                            DeleteNotes();
                            break;
                    }
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    PrintMenu();
                    varOption = ChooseOption();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Warning: {0}", Ex.Message);
            }
        }


        // #### FUNCTIONS ####//
        private static void PrintMenu()
        {

            System.Console.Clear();
            Console.WriteLine("" +
                "#### Welcome to Homework number 6 ####\n" +
                "______________________________________\n");
            for (int i = 1; i <= menu.Count - 1; i++)
            {
                Console.WriteLine("\t{0}) {1}", i, menu[i]);
            }
            Console.WriteLine("\t{0}) {1}", 0, menu[0]);
        }

        private static int ChooseOption()
        {
            while (true)
            {
                try
                {
                    Console.Write(">> ");
                    int optionChoosen = Convert.ToInt32(Console.ReadLine());
                    if (optionChoosen > menu.Count - 1)
                    {
                        throw new FormatException();
                    }
                    return optionChoosen;
                }
                catch (Exception Ex)
                {
                    //if (Ex.GetType() == FormatException){ //How to catch this Exception???
                    Console.WriteLine("\nPlease enter a number between 0 and {0} and try again.", menu.Count - 1);
                    //}
                }
            }
        }

        private static void SetStudentNotes()
        {
            if (jaggedStudenNotesArray == null)
            {
                Console.Write("Enter number of class: ");
                    numberClass = Convert.ToInt32(Console.ReadLine()); //need try catch
                    jaggedStudenNotesArray = new double[numberClass][];

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
            }
            else
            {
                Console.WriteLine("Warning: Students notes already charged.");
            }    
        }

        private static void PrintJaggedArray()
        {
            if (jaggedStudenNotesArray != null)
            {
            Console.WriteLine("-----------------");
                int dimention1 = jaggedStudenNotesArray.Length;
            int dimention2;
            for (int i = 0; i < dimention1; i++)
            {
                Console.WriteLine("Class number: {0}", i + 1);
                    dimention2 = jaggedStudenNotesArray[i].Length;
                for (int j = 0; j < dimention2; j++)
                {
                        Console.WriteLine("   Student id {0} note: {1}.", j + 1, jaggedStudenNotesArray[i][j]);
                }
                Console.Write("\n");
            }
        }
            else
                throw new NullReferenceException("Che, no se puede imprimir algo que aún no cargaste!!.");
        }

        private static void AverageStudentNotes()
        {
            if (jaggedStudenNotesArray != null)
            {
                Console.WriteLine("The average note is: {0}", totalNote / totalStudent);
            }
            else
                throw new NullReferenceException("Average can not be computed because notes had not register!.");

        }

        private static void MinMaxNotes()
        {
            if (jaggedStudenNotesArray != null)
            {
                int dimention1 = jaggedStudenNotesArray.Length;
                int dimention2;
                maxNote = jaggedStudenNotesArray[0][0];
                minNote = jaggedStudenNotesArray[0][0];
                for (int i = 0; i < dimention1; i++)
                {
                    dimention2 = jaggedStudenNotesArray[i].Length;
                    for (int j = 0; j < dimention2; j++)
                    {
                        if (jaggedStudenNotesArray[i][j] > maxNote) maxNote = jaggedStudenNotesArray[i][j];
                        if (jaggedStudenNotesArray[i][j] < minNote) minNote = jaggedStudenNotesArray[i][j];
                    }
                }
                Console.WriteLine("\nThe min Note is: {0}", minNote);
                Console.WriteLine("\nThe max Note is: {0}", maxNote);
            }
            else
                throw new NullReferenceException("Che, no se puede imprimir algo que aún no cargaste!!.");
        }

        private static void DeleteNotes()
        {
            Console.Write("Are you sure you want to delete all student's notes? (YES/NO)\n>> ");
            string option = Console.ReadLine();
            if (option == "YES")
            {
                numberClass = 0;
                jaggedStudenNotesArray = null;
                actualNote = 0;
                totalNote = 0;
                totalStudent = 0;
                Console.WriteLine("All notes deleted.");
            }
            else
            {
                Console.WriteLine("Operation cancelled.");
            }    
        }
    }
}
