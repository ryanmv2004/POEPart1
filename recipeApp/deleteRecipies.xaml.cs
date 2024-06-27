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
    /// Interaction logic for deleteRecipies.xaml
    /// </summary>
    public partial class deleteRecipies : Window
    {
        List<Recipe> recList;
        MainWindow MainWindow;
        public deleteRecipies(List<Recipe> recipe, MainWindow mainWindow)
        {
            InitializeComponent();
            recList = recipe;
            this.MainWindow = mainWindow;
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.delAllArr();
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.Show();
        }
    }
}
