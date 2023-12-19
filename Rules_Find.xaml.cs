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
    /// Interaction logic for Rules_Find.xaml
    /// </summary>
    public partial class Rules_Find : Window
    {
        public Rules_Find()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ifBack = MessageBox.Show("ARE YOU SURE ?", "FINDING CALL NUMBERS", MessageBoxButton.YesNo, MessageBoxImage.Question);

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

        private void playNowBtn_Click(object sender, RoutedEventArgs e)
        {
            FindCallNumbers FC = new FindCallNumbers();
            FC.Show();
            this.Close();
        }
    }
}
