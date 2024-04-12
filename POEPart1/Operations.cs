using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class Operations
    {
        private ArrayList ingArr;
        private ArrayList stepArr;

        public Operations()
        {
            ingArr = new ArrayList();
            stepArr = new ArrayList();
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
                int quantity = Int32.Parse(Console.ReadLine());

                Ingredients ing = new Ingredients(name, quantity, measurement);
                ingArr.Add(ing);
            }

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
                Steps s = new Steps(description);
                stepArr.Add(s);
            }
        }

        public void displayRecipie() 
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ingredients:");
            foreach (Ingredients i in ingArr)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }


    }
}
