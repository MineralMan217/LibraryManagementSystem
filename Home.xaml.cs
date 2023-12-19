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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        //window will load UI elements
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        //method will redirect user to the replacing books window
        private void replaceButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("ARE YOU SURE ?", "REPLACING BOOKS :)", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Rules_Replace RB = new Rules_Replace(); 
                RB.Show();
                this.Close();
            }
            else if (result == MessageBoxResult.No)
            {
                this.Show();
            }
        }


        //For part 3, this method will redirect user to the finding call numbers window
        private void findCallButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("ARE YOU SURE ?", "FINDING CALL NUMBERS :)", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Rules_Find RF = new Rules_Find();
                RF.Show();
                this.Close();
            }
            else if (result == MessageBoxResult.No)
            {
                this.Show();
            }
        }

        //For part 2, this method will redirect user to the identify areas window
        private void identifyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("ARE YOU SURE ?", "IDENTIFYING AREAS :)", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
              Rules_Identify RI = new Rules_Identify();
                RI.Show();
                this.Close();
            }
            else if (result == MessageBoxResult.No)
            {
                this.Show();
            }
        }
    }
}
