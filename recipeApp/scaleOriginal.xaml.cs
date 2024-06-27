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
    /// Interaction logic for scaleOriginal.xaml
    /// </summary>
    public partial class scaleOriginal : Window
    {
        double originalScale;
        List<Recipe> recArr;
        MainWindow mainWindow;
        public scaleOriginal(MainWindow mainWindow, List<Recipe> recipe, double scale)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            recArr = recipe;
            originalScale = scale;
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void originalBtn_Click(object sender, RoutedEventArgs e)
        {
            var recipe = recArr.FirstOrDefault(r => r.name == recNameBox.Text); //searches the array list for the recipe with the name that the user entered
            if (recipe != null)
            {
                foreach (Ingredients ingredient in recipe.ingredients) //Looks in the array for the specified recipe and un-scales the ingredients by the scale amount
                {
                    double newQuantity = ingredient.getinQuantity() / originalScale;
                    ingredient.setinQuantity(newQuantity);
                }
            }

            mainWindow.updateArr(recArr);
        }
    }
}
