using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace POEPart1
{
    class Operations //Class that holds all the operations to be performed
    {
        public List<Recipe> recArr = new List<Recipe>();

        public Operations()//Default Constructor
        {

        }

        public void enterRecipie() //Method that saves a recipie entered by the user to the array lists declared above
        {
            Console.WriteLine("Please enter the name of the recipie:");
            String name = Console.ReadLine(); //Prompts the user for the name of the recipie and stores it in a string

            Recipe recipe = new Recipe(name); //Creates a new Recipe object with the recipe name provided
            recipe.OnCaloriesExceeded += message => Console.WriteLine(message);

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
                String ingName = Console.ReadLine();

                Console.WriteLine("Please enter ingredient measurement:");
                String measurement = Console.ReadLine();

                Console.WriteLine("Please enter quantity:");
                double quantity = double.Parse(Console.ReadLine()); 

                Console.WriteLine("Please enter the calories contained in the ingredient quantity:"); //prompts the user for the ingredient name, measurement of the ingredient, its quantity and food group.
                double calories = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the number for the corresponding food group it belongs to: \n 1) Carbohydrates \n 2) Protein \n 3) Dairy Product \n 4) Fruit and Veg \n 5) Fats and Sugars");
                int choiceFG = Int32.Parse(Console.ReadLine());
                String foodGroup = "";

                if (choiceFG == 1)
                {
                    foodGroup = "Carbohydrates";
                }
                if (choiceFG == 2)
                {
                    foodGroup = "Protein";
                }
                if (choiceFG == 3)
                {
                    foodGroup = "Dairy Product";
                }
                if (choiceFG == 4)
                {
                    foodGroup = "Fruit and Veg";
                }
                if (choiceFG == 5)
                {
                    foodGroup = "Fats and Sugars";
                }

                Ingredients ingredient = new Ingredients(name, quantity, measurement, calories, foodGroup); //Created a new Ingredients object with the inforamtion that the user had supplied
                recipe.ingredients.Add(ingredient); //I then added this object to the ingredients array list contained inside my recipe class

            }
            recipe.CalculateTotalCalories(); //Checks if the total calories of the recipie exceed 300 and if they do it will print a message to the console
            recArr.Add(recipe); //Adds the recipe to the array list of recipes

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

                Steps step = new Steps(description); // Creates a new Steps object with the provided description
                recipe.steps.Add(step); // Adds the Steps object to the steps list of the Recipe object

            }
        }

        public void searchRecipe(string name)
        {
            var recipe = recArr.FirstOrDefault(r => r.name == name); //searches the array list for the recipe with the name that the user entered
            if (recipe != null) //If the recipe is found then it will display the recipe and the total calories
            {
                Console.WriteLine(recipe.toString());
                Console.WriteLine("Total Calories: " + recipe.CalculateTotalCalories());
            }
        }

        public void displayRecipes()
        {
            foreach (var recipe in recArr.OrderBy(r => r.name)) //Displays all the recipies in the array list
            {
                Console.WriteLine(recipe.name); //Displays the name of the recipie
            }
        }

        public void scaleRecipie(double scale, String name) //method that sclaes the recipie by a certain valid amount with the parameter scale
        {
            var recipe = recArr.FirstOrDefault(r => r.name == name); //searches the array list for the recipe with the name that the user entered
            if (recipe != null) //If the recipe is found 
            {
                foreach (Ingredients ingredient in recipe.ingredients) //Looks in the array for the specified recipe and scales the ingredients by the scale amount
                {
                    double newQuantity = ingredient.getinQuantity() * scale;
                    ingredient.setinQuantity(newQuantity);
                }
            }

        }

        public void opsUnScale(double scale, String name) //method that undo's the scale that the user has made use of
        {

            var recipe = recArr.FirstOrDefault(r => r.name == name); //searches the array list for the recipe with the name that the user entered
            if (recipe != null)
            {
                foreach (Ingredients ingredient in recipe.ingredients) //Looks in the array for the specified recipe and un-scales the ingredients by the scale amount
                {
                    double newQuantity = ingredient.getinQuantity() / scale;
                    ingredient.setinQuantity(newQuantity);
                }
            }

        }

        public void deleteRecipies(String name) //method that clears each array from memory
        {
            var recipe = recArr.FirstOrDefault(r => r.name == name);
            if (recipe != null)
            {
                foreach (Ingredients ingredient in recipe.ingredients) //Looks in the array for the specified recipe and deletes it from the recipe array
                {
                    recArr.Remove(recipe);
                }
            }
        }


    }
}
