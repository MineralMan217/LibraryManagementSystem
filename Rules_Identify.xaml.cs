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
    /// Interaction logic for Rules_Identify.xaml
    /// </summary>
    public partial class Rules_Identify : Window
    {
        public Rules_Identify()
        {
            InitializeComponent();
        }

        //this window will load UI elements
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //method to display the identifying areas window when button has been clicked
        private void playNowBtn_Click(object sender, RoutedEventArgs e)
        {
            IdentifyAreas IA = new IdentifyAreas();
            IA.Show();
            this.Close();
        }

        //method will allow user to go back to home page
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ifBack = MessageBox.Show("ARE YOU SURE ?", "IDENTIFYING AREAS :(", MessageBoxButton.YesNo, MessageBoxImage.Question);

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
