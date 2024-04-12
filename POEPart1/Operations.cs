using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    class Operations
    {
        public List<Ingredients> ingArr = new List<Ingredients>();
        public List<Steps> stepArr = new List<Steps>();

        public Operations()
        {
        }

        public void enterRecipie()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the amount of ingredients to be used:");
            int numIngredients = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Please enter the ingredient name:");
                String name = Console.ReadLine();

                Console.WriteLine("Please enter ingredient measurement:");
                String measurement = Console.ReadLine();

                Console.WriteLine("Please enter quantity:");
                double quantity = double.Parse(Console.ReadLine());

                
                ingArr.Add(new Ingredients(name, quantity, measurement));
            }
            Console.WriteLine(ingArr.Count());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter the amount of steps in the recipie");
            int stepsNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < stepsNum; i++)
            {
                Console.WriteLine("Enter description for step " + i + ":");
                String description = Console.ReadLine();
                stepArr.Add(new Steps(description));
            }
            Console.WriteLine(stepArr.Count());
        }

        public void displayRecipie()
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredients i in ingArr)
            {
                Console.WriteLine(i.toString());
            }
            Console.WriteLine();
            Console.WriteLine("Steps:");

            foreach (Steps s in stepArr)
            {
                Console.WriteLine(s.toString());
            }
        }

        public void scaleRecipie(double scale) 
        {
            foreach (Ingredients i in ingArr)
            {
                i.setinQuantity(scale);
            }
        }

        public void deleteRecipies() 
        {
            ingArr.Clear();
            stepArr.Clear();
        }
    }
}
