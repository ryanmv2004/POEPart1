using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations ops = new Operations();
            double scaleAmount = 0;

            Boolean SENTINAL = true;
            while (SENTINAL)
            {

                Console.WriteLine("Welcome to the Recipie Storage App!");
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please make a Selection on which tool to use:");
                Console.WriteLine("1) Enter Recipie");
                Console.WriteLine("2) Display Recipie");
                Console.WriteLine("3) Scale Recipie");
                Console.WriteLine("4) Clear all Recipies");
                Console.WriteLine("5) Scale Recipies back to Original");
                Console.WriteLine("6) Exit");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please make a choice by entering only the tool number:");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice == 1) 
                {
                    ops.enterRecipie();
                }
                if (choice == 2) 
                {
                    ops.displayRecipie();
                }
                if (choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Please enter the scale which you want to multiply the recipie by:");
                    Console.WriteLine("This can either be 0.5, 2 or 3");
                    double scale = double.Parse(Console.ReadLine());

                    ops.scaleRecipie(scale);

                    scaleAmount = scale;
                }
                if (choice == 4) 
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Type Y to confirm this choice and N to go back");
                    String deleteChoice = Console.ReadLine();

                    if (deleteChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        ops.deleteRecipies();
                    }
                    else 
                    {

                    }
                }
                if (choice == 5) 
                {
                    ops.opsUnScale(scaleAmount);
                    scaleAmount = 0;
                }
                if (choice == 6)
                {
                    SENTINAL = false;
                    break;
                }
            }
        }
    }
}
