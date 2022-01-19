using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HWn.HW08_Bank
{
    public class Menu
    {
        public static void MenuPrint()
        {
            Console.Clear();
            Console.WriteLine("     MJBANK    \n----------");
            Console.WriteLine("1) New client account.");
            Console.WriteLine("2) Search client by ID..");
            Console.WriteLine("3) Show all clients.");
            Console.WriteLine("4) Delete client account.");
            Console.WriteLine("5) Exit.");
        }

        public static string MenuOption()
        {
            int option = 0;
            while (true)
            {
                Console.Write(">> ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < 0 || option > 5)
                    {
                        Console.WriteLine("Option not in range.");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid option.");
                }
            }
            return Convert.ToString(option);
        }
    }
}
