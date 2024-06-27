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
    /// Interaction logic for displayRecipies.xaml
    /// </summary>
    public partial class displayRecipies : Window
    {
        private List<Recipe> recipies;
        public displayRecipies(List<Recipe> recList, MainWindow mainWindow)
        {
            InitializeComponent();
            recipies = recList;
            this.mainWindow = mainWindow;
        }

        private MainWindow mainWindow;

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void recDisplayBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void displayRecBtn_Click(object sender, RoutedEventArgs e)
        {
            recDisplayBox.Clear();
            foreach (var recipe in recipies.OrderBy(r => r.name)) //Displays all the recipies in the array list
            {
                recDisplayBox.AppendText(recipe.toString() + "\n");
            }
        }
    }
}
