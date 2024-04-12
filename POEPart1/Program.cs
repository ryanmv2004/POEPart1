using System;
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
            Console.WriteLine("Welcome to the Recipie Storage App!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please make a Selection on which tool to use:");
            Console.WriteLine("1) Enter Recipie");
            Console.WriteLine("2) Display Recipie");
            Console.WriteLine("3) Scale Recipie");
            Console.WriteLine("4) Clear all Recipies");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Please make a choice by entering only the tool number:");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine(choice);
            Console.ReadKey();
        }
    }
}
