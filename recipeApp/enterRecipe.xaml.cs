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
using POEPart1;

namespace recipeApp
{
    /// <summary>
    /// Interaction logic for enterRecipe.xaml
    /// </summary>
    public partial class enterRecipe : Window
    {
        public enterRecipe(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow; // Store the reference to MainWindow
        }

        List <Ingredients> ingredients = new List<Ingredients>();
        List<Steps> steps = new List<Steps>();
        private MainWindow mainWindow;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void addIngredientBtn_Click(object sender, RoutedEventArgs e)
        { 
            String ingName = ingNameBox.Text;
            String measurement = ingMeasurementBox.Text;
            double quantity = double.Parse(ingQuantityBox.Text);
            double calories = double.Parse(ingCaloriesBox.Text);
            String foodGroup = ingFGroupCBox.Text;

            Ingredients ingredient = new Ingredients(ingName, quantity, measurement, calories, foodGroup);
            ingredients.Add(ingredient);

            ingCaloriesBox.Text = "";
            ingMeasurementBox.Text = "";
            ingNameBox.Text = "";
            ingQuantityBox.Text = "";
        }

        private void addStepBtn_Click(object sender, RoutedEventArgs e)
        {
            String step = stepsBox.Text;
            Steps stepObj = new Steps(step);
            steps.Add(stepObj);
            stepsBox.Text = "";
        }

        private void submitRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe = new Recipe(recNameBox.Text, ingredients, steps);

            mainWindow.addRecipe(recipe);

           this.Close();
            mainWindow.Show();

        }
    }
}
