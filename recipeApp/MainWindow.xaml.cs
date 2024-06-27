using POEPart1;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using POEPart1;

namespace recipeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Recipe> recList = new List<Recipe>();

        double scaleAmount = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            enterRecipe enterRecipe = new enterRecipe(this);
            enterRecipe.Show();
            this.Hide();
        }

        public void addRecipe(Recipe recipe)
        {
            recList.Add(recipe);
        }

        public void changeScaleAmount(double amount) 
        {
            scaleAmount = amount;
        }

        public void updateArr(List<Recipe> recipe)
        {
            recList = recipe;
        }

        public void delAllArr() 
        {
            recList.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            displayRecipies displayRecipies = new displayRecipies(recList, this);
            displayRecipies.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            recipeSearch recipeSearch = new recipeSearch(recList, this);
            recipeSearch.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            scaleRecipe scaleRecipe = new scaleRecipe(this, recList);
            scaleRecipe.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            deleteRecipies deleteRecipies = new deleteRecipies(recList, this);
            deleteRecipies.Show();
            this.Hide();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            scaleOriginal scaleOriginal = new scaleOriginal(this, recList, scaleAmount);
            scaleOriginal.Show();
            this.Hide();
        }
    }
}
