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
    /// Interaction logic for scaleRecipe.xaml
    /// </summary>
    public partial class scaleRecipe : Window
    {
        private List<Recipe> recList;
        public scaleRecipe(MainWindow mainWindow, List<Recipe> recipe)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.recList = recipe;
        }

        private MainWindow mainWindow;

        private void scaleRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            var recipe = recList.FirstOrDefault(r => r.name == recInputBox.Text); //searches the array list for the recipe with the name that the user entered
            if (recipe != null) //If the recipe is found 
            {
                foreach (Ingredients ingredient in recipe.ingredients) //Looks in the array for the specified recipe and scales the ingredients by the scale amount
                {
                    double newQuantity = ingredient.getinQuantity() * double.Parse(scaleCBox.Text);
                    ingredient.setinQuantity(newQuantity);
                }
            }

            mainWindow.updateArr(recList);
        }

        private void goBackBtn_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }
    }
}
