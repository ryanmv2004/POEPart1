using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("Please enter the amount of ingredients to be used:");
            String preCheckIngredients = Console.ReadLine();

            Boolean check = preCheckIngredients.All(char.IsDigit); //Lifted from https://stackoverflow.com/questions/18251875/in-c-how-to-check-whether-a-string-contains-an-integer
        
            if (check == false) 
            {
                
                Boolean corrected = false;
                while (corrected == false) 
                {
                    Console.WriteLine("Your entry was invalid, please try again");
                    String postCheck = Console.ReadLine();
                    check = postCheck.All(char.IsDigit);
                    if (check)
                    {
                        corrected = true;
                        preCheckIngredients = postCheck;
                    }
                }
            }

            int numIngredients = Int32.Parse(preCheckIngredients);

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
            Console.WriteLine("Enter the amount of steps in the recipie");
            int stepsNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i < stepsNum + 1; i++)
            {
                Console.WriteLine("Enter description for step " + i + ":");
                String description = Console.ReadLine();
                stepArr.Add(new Steps(description));
            }
        }

        public void displayRecipie()
        {

            Console.WriteLine("\n" + "\n" + "Ingredients:");
            foreach (Ingredients i in ingArr)
            {
                Console.WriteLine(i.toString());
            }
            Console.WriteLine();
            Console.WriteLine("Steps:");

            int counter = 1;
            foreach (Steps s in stepArr)
            {
                Console.WriteLine(counter + ") " + s.toString());
                counter++;
            }
        }

        public void scaleRecipie(double scale) 
        {
            foreach (Ingredients i in ingArr)
            {
                i.setinQuantity(scale);
            }
        }

        public void opsUnScale(double scale) 
        {
            foreach (Ingredients i in ingArr)
            {
                i.undoScale(scale);
            }
        }

        public void deleteRecipies() 
        {
            ingArr.Clear();
            stepArr.Clear();
        }
    }
}
