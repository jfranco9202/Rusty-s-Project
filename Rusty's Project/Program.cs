using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rusty_s_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Sometimes employees will not get paid for a day ex using all PTO/Sick time//
            {
                int ptoTime = 0;
                if (ptoTime == 0)
                    Console.WriteLine("Not Paid");
           
                else
                    Console.WriteLine("Paid");
            }

            {
                int sickTime = 0;
                if(sickTime == 0)
                    Console.WriteLine("Not Paid");

                else
                    Console.WriteLine("Paid");

            }
            //Bad Weather paid time benefit if used it will not pay the employee
            {
                int badWeather = 0;               
                    if (badWeather != 0)
                        Console.WriteLine("Paid for the day");
                    else
                        Console.WriteLine("Not paid");
                   
             }
            //CEO privalages
            {
                string ceo = "Justin Smith";
                int ceoPto = 120;
                int workFromhome = 120;
                string bossMan = "I am the Boss";

                Console.WriteLine($"{ceo} has {ceoPto} unlimited PTO hours.  Also {ceo} has unlimited {workFromhome} hours. He is also the boss hints {bossMan}");

            }
            //It Level Support Departments
            {
                int depts;
                int iTlevel = 1;
                int iTsupport = 2;
                int disPatch = 3;

                switch (iTlevel)
                {
                    case 1:
                        Console.WriteLine("IT department level 1");
                        break;

                    case 2:
                        Console.WriteLine("IT department level 2");
                        break;

                    case 3:
                        Console.WriteLine("Dispatch support"):
                        break;

                    default:
                        Console.WriteLine("You are not in IT");
                        break;


                }
                //Support levels of support 
                switch(iTsupport)
                {
                    case 1:
                        Console.WriteLine("Support department level 1");
                        break;

                    case 2:
                        Console.WriteLine("Support department level 2");
                        break;

                    case 3:
                        Console.WriteLine("Dispatch support"):
                        break;

                    default:
                        Console.WriteLine("You are not in IT");
                        break;
                }
            }


           

        }
        
        


        




    }
}
