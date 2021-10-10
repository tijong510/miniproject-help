using System;

namespace miniproj_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.Clear();
            Selection();


            static void Intro()
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t H E L L O !!!");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to TJ's Mini-Priject!\n");
                Console.WriteLine("\tThis program is assigned to calculate the areas, circumference,");
                Console.WriteLine("and other formulas relating Circles, Semi-Circles, Ellipses, and Rings.");
                Console.ResetColor();
                Console.WriteLine("\nPress 'enter' to continue.");
                Console.ReadLine();
            }

            static void Selection()
            {

                Console.WriteLine("Where do you want to go?\n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("1. CALCULATIONS");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. SUMMARY");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3. EXIT\n");
                Console.ResetColor();

                int select = Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    Console.Clear();
                    Calculations();
                }
                else if (select == 2)
                {
                    Console.Clear();
                    Summary();
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Not in the selection!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Selection();
                }



            }

            //ALL CALCLULATIONS
            static void Calculations()
            {
                Console.WriteLine("Please select the curve you wish to solve: ");
                Console.WriteLine("1. CICLES\t 2. SEMI-CIRCLES\t 3. ELLIPSE\t 4. RINGS\t 5. SECTOR OF A CIRCLE\t 6. SEGMENT OF A CIRCLE");
                int selectcalc = Convert.ToInt32(Console.ReadLine());
                if (selectcalc == 1)
                {
                    GetCircle(selectcalc);
                }
                else if (selectcalc == 2)
                {
                    GetSemicircle();
                }
                else if (selectcalc == 3)
                {
                    GetEllipse();
                }
                else if (selectcalc == 4)
                {
                    GetRing();
                }
                else if (selectcalc == 5)
                {
                    GetSector();
                }
                else if (selectcalc == 6)
                {
                    GetSegment();
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Not in the selection!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Calculations();
                }
                static void GetCircle(int selectcalc)
                {
                    double circlearea, circleperim;
                    double resultarea=0; 
                    double resultperim=0;
                    Console.Clear();
                    Console.Write("What is the radius? ");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    circlearea = CircleArea(rad,   resultarea);
                    circleperim = CirclePerim(rad,   resultperim);
                    Circleprintresult(circlearea, circleperim);
                    screenexit();
                }

                static void GetSemicircle()
                {
                    Console.Clear();
                }

                static void GetEllipse()
                {
                    Console.Clear();
                }

                static void GetRing()
                {
                    Console.Clear();
                }

                static void GetSector()
                {
                    Console.Clear();
                }

                static void GetSegment()
                {
                    Console.Clear();
                }


            }
            //SUMMARY, BASICALLY A HISTORY OF INPUTS AND RESULTS IN CALCULATIONS
            static void Summary( )
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tS U M M A R Y");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n");
                Console.ResetColor();

                // i want to use selectcalc in Calculations and Circleprintresult for this
                // if(selectcalc==1)
                // {
                //      Circleprintresult(resultarea, resultperim)
                // }

            }
            
            static double CircleArea(double rad,  double resultarea)
            {
                resultarea = 0;
                resultarea = Math.PI * (rad * rad);
                return resultarea;
            }
            static double CirclePerim(double rad,  double resultperim)
            {
                resultperim = 0;
                resultperim = 2 * Math.PI * rad;
                return resultperim;
            }
            static void Circleprintresult(double resultarea, double resultperim)
            {
                Console.WriteLine("\nArea = {0}", resultarea);
                Console.WriteLine("Circumference = {0}", resultperim);
            }

            static void screenexit( )
            {
                Console.WriteLine("\nPress (0) to go back to Selection screen.");
                Console.WriteLine("Press(1) to go back to Calculations Screen.");
                int exitchoice = Convert.ToInt32(Console.ReadLine());
                if (exitchoice == 0)
                {
                    Console.Clear();
                    Selection();
                }
                else if (exitchoice == 1)
                {
                    Console.Clear();
                    Calculations();
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Not in the selection!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Black;
                    screenexit();
                }

            }
            
        }
    }
}
