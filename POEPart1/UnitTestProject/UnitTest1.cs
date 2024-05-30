using Microsoft.VisualStudio.TestTools.UnitTesting;
using POEPart1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateTotalCalories()
        {
            string recipeName = "Test Recipe";
            Recipe recipe = new Recipe(recipeName);

            string ingredientName = "Test Ingredient";
            double quantity = 1.0;
            string unit = "cup";
            double calories = 100.0;
            string foodGroup = "Test Food Group";

            Ingredients ingredient = new Ingredients(ingredientName, quantity, unit, calories, foodGroup);
            recipe.ingredients.Add(ingredient);

            string ingredientName1 = "Test Ingredient1";
            double quantity1 = 1.0;
            string unit1 = "cup";
            double calories1 = 100.0;
            string foodGroup1 = "Test Food Group";

            Ingredients ingredient1 = new Ingredients(ingredientName1, quantity1, unit1, calories1, foodGroup1);
            recipe.ingredients.Add(ingredient1);


            double ActualCalories = 200.0;

            double result = recipe.CalculateTotalCalories();

            
            Assert.AreEqual(ActualCalories, result);
        }
        public void TestCalculateTotalCaloriesNotEqual()
        {
            string recipeName = "Test Recipe";
            Recipe recipe = new Recipe(recipeName);

            string ingredientName = "Test Ingredient";
            double quantity = 1.0;
            string unit = "cup";
            double calories = 100.0;
            string foodGroup = "Test Food Group";

            Ingredients ingredient = new Ingredients(ingredientName, quantity, unit, calories, foodGroup);
            recipe.ingredients.Add(ingredient);

            string ingredientName1 = "Test Ingredient1";
            double quantity1 = 1.0;
            string unit1 = "cup";
            double calories1 = 100.0;
            string foodGroup1 = "Test Food Group";

            Ingredients ingredient1 = new Ingredients(ingredientName1, quantity1, unit1, calories1, foodGroup1);
            recipe.ingredients.Add(ingredient1);


            double ActualCalories = 300.0;

            double result = recipe.CalculateTotalCalories();


            Assert.AreNotEqual(ActualCalories, result);
        }

    }
}
