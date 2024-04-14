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

            Boolean ingredientsCheck = preCheckIngredients.All(char.IsDigit); //Lifted from https://stackoverflow.com/questions/18251875/in-c-how-to-check-whether-a-string-contains-an-integer
        
            if (ingredientsCheck == false) 
            {
                
                Boolean corrected = false;
                while (corrected == false) 
                {
                    Console.WriteLine("Your entry was invalid, please try again");
                    String postCheck = Console.ReadLine();
                    ingredientsCheck = postCheck.All(char.IsDigit);
                    if (ingredientsCheck)
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
            String preCheckSteps = Console.ReadLine();

            Boolean stepsCheck = preCheckSteps.All(char.IsDigit);

            if (stepsCheck == false)
            {

                Boolean corrected = false;
                while (corrected == false)
                {
                    Console.WriteLine("Your entry was invalid, please try again");
                    String postCheck = Console.ReadLine();
                    stepsCheck = postCheck.All(char.IsDigit);
                    if (stepsCheck)
                    {
                        corrected = true;
                        preCheckSteps = postCheck;
                    }
                }
            }

            int stepsNum = Int32.Parse(preCheckSteps);

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
