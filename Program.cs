using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu = HW.Menu;
using static HW.HWList;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            HWList h = new HWList();
            Boolean run = true;
            Boolean sub = true;
            String HomeworkOp, ExerciceOp;


            while (run)
            {
                // Print menu
                m.PrintM("0");
                HomeworkOp = m.ChooseOption();

                if (HomeworkOp != "0") 
                {
                    while (sub)
                    {
                        m.PrintM(HomeworkOp);
                        ExerciceOp = m.ChooseOption();
                        if (ExerciceOp != "0") 
                        { 
                            Console.Clear();
                            h.GetHW(HomeworkOp, ExerciceOp);
                        }
                        else
                        {sub = false;}
                    }
                    sub = true;
                }
                else
                {run = false;}
            }
        }
    }
}
