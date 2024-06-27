using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using POEPart1;

namespace recipeApp
{
    /// <summary>
    /// Interaction logic for recipeSearch.xaml
    /// </summary>
    public partial class recipeSearch : Window
    {
        private List<Recipe> recList;
        MainWindow mainWindow;
        public recipeSearch(List<Recipe> rec, MainWindow mainWindow)
        {
            InitializeComponent();
            recList = rec;
            this.mainWindow = mainWindow;
        }


        private void srcBtn_Click(object sender, RoutedEventArgs e)
        {
            displayBox.Clear();
            var recipe = recList.FirstOrDefault(r => r.name == recNameBox.Text); //searches the array list for the recipe with the name that the user entered
            if (recipe != null) //If the recipe is found then it will display the recipe and the total calories
            {
                displayBox.AppendText(recipe.toString());

            }
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void ingSearch_Click(object sender, RoutedEventArgs e)
        {
            displayBox.Clear();
            string ingredient = ingBox.Text.Trim(); // Trim to remove any leading/trailing spaces for debugging

            // Filter the recipes based on the specified ingredient
            var recipesWithIngredient = recList.Where(r => r.ingredients.Any(i => i.getinName().Equals(ingredient, StringComparison.OrdinalIgnoreCase))).ToList();
            //Learned String comparison from here https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
            if (recipesWithIngredient.Any())
            {
                // Display the recipes that contain the specified ingredient
                foreach (var recipe in recipesWithIngredient)
                {
                    displayBox.AppendText(recipe.toString());
                    displayBox.AppendText(Environment.NewLine);
                }
            }
            else
            {
                displayBox.AppendText($"No recipes found containing the ingredient: {ingredient}\n");
            }
        }

        private void fGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            displayBox.Clear(); // Assuming displayBox is a TextBox or similar control for displaying the results.
            string selectedFoodGroup = ((ComboBoxItem)foodGroupCBox.SelectedItem).Content.ToString(); // Correctly getting the selected item's content.

            // Filter the recipes based on the specified food group
            var recipesWithFoodGroup = recList.Where(recipe => recipe.ingredients.Any(ingredient => ingredient.getFoodGroup().Equals(selectedFoodGroup, StringComparison.OrdinalIgnoreCase))).ToList();

            if (recipesWithFoodGroup.Any())
            {
                // Display the recipes that contain the specified food group
                foreach (var recipe in recipesWithFoodGroup)
                {
                    displayBox.AppendText(recipe.toString());
                    displayBox.AppendText(Environment.NewLine);
                }
            }
            else
            {
                displayBox.AppendText($"No recipes found containing the food group: {selectedFoodGroup}\n");
            }
        }
    }
}

