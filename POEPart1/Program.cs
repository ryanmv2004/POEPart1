using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("5) Exit");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please make a choice by entering only the tool number:");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice == 1) 
                {
                    Console.WriteLine("1");
                }
                if (choice == 2) 
                {
                    Console.WriteLine("2");
                }
                if (choice == 3)
                {
                    Console.WriteLine("3");
                }
                if (choice == 4) 
                {
                    Console.WriteLine("4");
                }
                if (choice == 5) 
                {
                    SENTINAL = false;
                    break;
                }
            }
        }
    }
}
