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

namespace Wishlist
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(Income.Text);
            int expenses = int.Parse(Expenses.Text);
            int wishlist = int.Parse(Wishlist.Text);
            int minus = (income - expenses);
            int result = ((wishlist - minus) /365);

            string total = result.ToString();
            Result.Text = total;
               
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

    }
}
