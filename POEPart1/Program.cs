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
            Boolean SENTINAL = true;
            while (SENTINAL)
            {
                Ingredients[] ingArr;
                Steps[] stepArr;

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
                    Console.WriteLine(); 
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Please enter to amount of ingredients to be used:");
                    int numIngredients = Int32.Parse(Console.ReadLine());

                    ingArr = new Ingredients[numIngredients];
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < numIngredients; i++) 
                    {
                        Console.WriteLine("Please enter the ingredient name:");
                        String name = Console.ReadLine();

                        Console.WriteLine("Please enter ingredient measurement:");
                        String measurement = Console.ReadLine();

                        Console.WriteLine("Please enter quantity:");
                        int quantity = Int32.Parse(Console.ReadLine());

                        ingArr[i] = new Ingredients(name, quantity, measurement);
                    }
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
