using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POEPart1
{
    internal class Recipe
    {
        public string name { get; set; }
        public List<Ingredients> ingredients { get; set; }
        public List<Steps> steps { get; set; } //declares the attributes. This being the Recipe name, an array list of the ingredients class and a =n array list for the steps class.

        public delegate void CaloriesExceededHandler(string message);
        public event CaloriesExceededHandler OnCaloriesExceeded; //Delegates and events for the calories exceeded message


        public Recipe(string name)  //Parameterised constructor
        {
            this.name = name;
            ingredients = new List<Ingredients>();
            steps = new List<Steps>();
        }

        public double CalculateTotalCalories() //Method that calculates the total calories of the recipe
        {
            double totalCalories = 0;

            foreach (Ingredients ingredient in ingredients) //Loops through the array list of ingredients and adds the calories of each ingredient to the total calories
            {
                totalCalories += ingredient.getCalories();
            }
            if (totalCalories > 300) //If the total calories exceed 300 then it will invoke the event
            {
                OnCaloriesExceeded?.Invoke($"Total calories in {name} have exceeded 300.");
            }
            return totalCalories; //Returns the total calories
        }


        public String toString() //https://www.geeksforgeeks.org/stringbuilder-class-in-java-with-examples/ used this website for help setting up the StringBuilder Library Method.
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name + "\n");
            sb.Append("Ingredients:\n");
            foreach (Ingredients i in ingredients)
            {
                sb.Append(i.toString() + "\n");
            }
            sb.Append("Steps:\n");
            foreach (Steps s in steps)
            {
                sb.Append(s.toString() + "\n");
            }
            return sb.ToString();
        }
    }
}
