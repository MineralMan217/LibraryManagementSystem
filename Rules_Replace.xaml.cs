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

namespace MockOne
{
    /// <summary>
    /// Interaction logic for Rules_Replace.xaml
    /// </summary>
    public partial class Rules_Replace : Window
    {
        public Rules_Replace()
        {
            InitializeComponent();
        }

        //window will load UI elements
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        //method will take user to the replace books window
        private void playNowBtn_Click(object sender, RoutedEventArgs e)
        {
            ReplaceBooks RB = new ReplaceBooks();
            RB.Show();
            this.Close();

        }

        //method will allow user to go back to home page
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ifBack = MessageBox.Show("ARE YOU SURE ?", "REPLACING BOOKS :(", MessageBoxButton.YesNo, MessageBoxImage.Question);
           
            if (ifBack == MessageBoxResult.Yes)
            {
                Home hm = new Home();
                hm.Show();
                this.Close();
            }
            else if (ifBack == MessageBoxResult.No)
            {
                this.Show();
            }


        }
    }
}
