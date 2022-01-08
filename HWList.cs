using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using h1e1 = HWn.HW01ex1;
using h2e1 = HWn.HW02ex1;
using h2e2 = HWn.HW02ex2;
using h3e1 = HWn.HW03ex1;
using h3e2 = HWn.HW03ex2;
using h3e3 = HWn.HW03ex3;
using h4e1 = HWn.HW04ex1;
using h4e2 = HWn.HW04ex2;
using h5e1 = HWn.HW05ex1;
using h5e2 = HWn.HW05ex2;
using h6e1 = HWn.HW06ex1;
using h7e1 = HWn.HW07ex1;

namespace HW
{
    class HWList
    {
        // Funtions
        public void GetHW(String HomeworkOp, String ExerciceOp)
        {
            String Homeex = HomeworkOp + "-" + ExerciceOp;
            switch (Homeex)
            {
                case "1-1":
                    h1e1.Main();
                    break;
                case "2-1":
                    h2e1.Main();
                    break;
                case "2-2":
                    h2e2.Main();
                    break;
                case "3-1":
                    h3e1.Main();
                    break;
                case "3-2":
                    h3e2.Main();
                    break;
                case "3-3":
                    h3e3.Main();
                    break;
                case "4-1":
                    h4e1.Main();
                    break;
                case "4-2":
                    h4e2.Main();
                    break;
                case "5-1":
                    h5e1.Main();
                    break;
                case "5-2":
                    h5e2.Main();
                    break;
                case "6-1":
                    h6e1.Main();
                    break;
                case "7-1":
                    h7e1.Main();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }


        /*void Hw(int n)
        {

                    
                case 2:

                case 3:

                    break;
            }
            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();
        }
*/
    }
}
