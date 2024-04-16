using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    class Operations //Class that holds all the operations to be performed
    {
        public List<Ingredients> ingArr = new List<Ingredients>();
        public List<Steps> stepArr = new List<Steps>(); //Instantiates two array lists of both the Steps and Ingredients class. That will work as a parralel array

        public Operations()//Default Constructor
        {

        }

        public void enterRecipie() //Method that saves a recipie entered by the user to the array lists declared above
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the amount of ingredients to be used:");
            String preCheckIngredients = Console.ReadLine(); //Asks the user for the amount of ingredients that will be used then stores it in a pre check string

            Boolean ingredientsCheck = preCheckIngredients.All(char.IsDigit); //Lifted from https://stackoverflow.com/questions/18251875/in-c-how-to-check-whether-a-string-contains-an-integer
        
            if (ingredientsCheck == false) //If statement that runs if the ingredientsheck didnt contain a valid number
            {
                
                Boolean corrected = false;
                while (corrected == false) 
                {
                    Console.WriteLine("Your entry was invalid, please try again");
                    String postCheck = Console.ReadLine();
                    ingredientsCheck = postCheck.All(char.IsDigit); //asks the user to re enter their number and checks it again to see if it contains a valid integer
                    if (ingredientsCheck) //If the check was true then this If statement
                    {
                        corrected = true; //makes the corrected variable true to break the loop
                        preCheckIngredients = postCheck; //updates the valid integer value to the varibale
                    }
                }
            }

            int numIngredients = Int32.Parse(preCheckIngredients); //Converts this variable into an integer

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < numIngredients; i++) //For loops that runs for however many time they wanted to enter an ingredient
            {
                Console.WriteLine("Please enter the ingredient name:");
                String name = Console.ReadLine();

                Console.WriteLine("Please enter ingredient measurement:");
                String measurement = Console.ReadLine();

                Console.WriteLine("Please enter quantity:");
                double quantity = double.Parse(Console.ReadLine()); //prompts the user for the ingredient name, measurement of the ingredient and its quantity.

                
                ingArr.Add(new Ingredients(name, quantity, measurement)); //Adds these variables by creating a new object with those variables as arguements and stores it in the array list for ingredients
            }

            Console.WriteLine();
            Console.WriteLine("Enter the amount of steps in the recipie");
            String preCheckSteps = Console.ReadLine(); //asks the user for the amount of steps in the recipie then stores the response in a variable

            Boolean stepsCheck = preCheckSteps.All(char.IsDigit); //runs the same check from above to see if the given string is a valid integer and stores the answer in a boolean variable

            if (stepsCheck == false) //If statement that runs if the string did not contain a valid integer
            {

                Boolean corrected = false;
                while (corrected == false) //while loop that will ask the user until they enter a valid integer
                {
                    Console.WriteLine("Your entry was invalid, please try again");
                    String postCheck = Console.ReadLine();
                    stepsCheck = postCheck.All(char.IsDigit); //prompts the user to please try again until they enter a valid integer and also checking this input to see if it is a valid integer.
                    if (stepsCheck)//if statement that runs if the string was a valid integer
                    {
                        corrected = true; //makes this boolean true so that the loop breaks
                        preCheckSteps = postCheck; //updates a variable with the validated integer
                    }
                }
            }

            int stepsNum = Int32.Parse(preCheckSteps); //converts the valid inter in string format finally to an intger.

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i < stepsNum + 1; i++)//For loop that runs for the amount of steps the user entered
            {
                Console.WriteLine("Enter description for step " + i + ":");
                String description = Console.ReadLine();
                stepArr.Add(new Steps(description)); //prompts the user for a description of an increasing amount of steps then stores this response in the array list for steps.
            }
        }

        public void displayRecipie() //method that displays the recipie
        {

            Console.WriteLine("\n" + "\n" + "Ingredients:"); //housekeeping
            foreach (Ingredients i in ingArr) //a foreach loop that runs through the array list for ingredients and then makes use of the toString method inside the Ingredients class to print each element in the array
            {
                Console.WriteLine(i.toString()); //prints each element in the array using a toString method
            }
            Console.WriteLine();
            Console.WriteLine("Steps:");

            int counter = 1; //counter that keeps track of step number
            foreach (Steps s in stepArr) //foreach loop that runs through the array and prints out the description for each element using a toString method in the Steps class
            {
                Console.WriteLine(counter + ") " + s.toString()); //makes use of this counter to print the step number and then the desription of each element using a toString
                counter++; //increases the counter by one
            }
        }

        public void scaleRecipie(double scale) //method that sclaes the recipie by a certain valid amount with the parameter scale
        {
            foreach (Ingredients i in ingArr) //foreach loop that runs through the ingArr and multiplies each quantity using the setInQuantity method
            {
                i.setinQuantity(scale); //uses the setinQuantity method to scale each quantity amount of the ingredient
            }
        }

        public void opsUnScale(double scale) //method that undo's the scale that the user has made use of
        {
            foreach (Ingredients i in ingArr) //foreach loop that runs through the ingArr and reverses the scale that the user did by dividing by what they sclaed the recipie with originally.
            {
                i.undoScale(scale);//uses the undoScale to reset the recipie to its original quantity
            }
        }

        public void deleteRecipies() //method that clears each array from memory
        {
            ingArr.Clear();
            stepArr.Clear(); //makes use of the .clear() method to clear each Array List
        }
    }
}
