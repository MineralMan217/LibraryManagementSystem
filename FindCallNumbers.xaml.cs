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
using System.IO;
using System.Reflection;
using System.Windows.Resources;
using System.Diagnostics;
using System.Windows.Threading;
using static MockOne.ClassificationNode;

namespace MockOne
{
    /// <summary>
    /// Interaction logic for FindCallNumbers.xaml
    /// </summary>

    public partial class FindCallNumbers : Window
    {
        private ClassificationRunner runner;
        private int timeInSeconds = 120; // adjustable time limit
        private DispatcherTimer timer;
        private int remainingTime;
        private int userPoints = 0;




        public FindCallNumbers()
        {
            InitializeComponent();
            runner = new ClassificationRunner();
            runner.GenerateNextUniqueQuizQuestion();
            RefreshWindow();

        }

        /// <summary>
        /// Updates the UI with the current question and options.
        /// </summary>
        private void RefreshWindow()
        {
            QuestionTextBlock.Text = runner.RetrieveUniqueQuestion();
            var options = runner.UniqueQuizOptions();

            Debug.WriteLine($"Options: {string.Join(", ", options)}");

            // Create an array of CheckBox controls
            CheckBox[] checkBoxes = { RCheckBox1, RCheckBox2, RCheckBox3, RCheckBox4 };

           
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (i < options.Count)
                {
                    checkBoxes[i].Content = options[i];
                    checkBoxes[i].Visibility = Visibility.Visible;
                }
                else
                {
                    checkBoxes[i].Content = "";
                    checkBoxes[i].Visibility = Visibility.Collapsed;
                }
            }
        }


        /// <summary>
        /// method to handle the back button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("ARE YOU SURE?", "FINDING CALL NUMBERS", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {

                Rules_Find RF = new Rules_Find();
                RF.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }


        /// <summary>
        /// method to handle the events that take place after user clicks on the Check button to validate their answers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            RCheckBox1.IsEnabled = RCheckBox2.IsEnabled = RCheckBox3.IsEnabled = RCheckBox4.IsEnabled = false;

            string selectedOption = RetrieveCheckedCheckBox();

            if (string.IsNullOrEmpty(selectedOption))
            {
                MessageBox.Show("Please select an option before checking.", "FINDING CALL NUMBERS", MessageBoxButton.OK, MessageBoxImage.Warning);
                RCheckBox1.IsEnabled = RCheckBox2.IsEnabled = RCheckBox3.IsEnabled = RCheckBox4.IsEnabled = true;
                return;
            }

            bool isCorrect = runner.ValidateUserAnswer(selectedOption);
            int pointsEarned = isCorrect ? 5 : 0;

            if (isCorrect)
            {
                // Increment userPoints for each right answer 
                userPoints += pointsEarned;
                pointsLabel.Content = $"POINTS: {userPoints}";

                MessageBox.Show($"CORRECT! YOU GOT +{pointsEarned} POINTS :)", "FINDING CALL NUMBERS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"INCORRECT! YOU GOT +{pointsEarned} POINTS :)", "FINDING CALL NUMBERS", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            // Clear radio button selection
            RCheckBox1.IsChecked = RCheckBox2.IsChecked = RCheckBox3.IsChecked = RCheckBox4.IsChecked = false;

            // Enable all radio buttons for the next question
            RCheckBox1.IsEnabled = RCheckBox2.IsEnabled = RCheckBox3.IsEnabled = RCheckBox4.IsEnabled = true;

            // Load the next question
            runner.GenerateNextUniqueQuizQuestion();
            RefreshWindow();
        }


        /// <summary>
        /// method to retrieve the string values of the user selected checkbox
        /// </summary>
        /// <returns></returns>
        private string RetrieveCheckedCheckBox()
        {
            // Implement the logic to get the selected option from CHECKBOX
            if (RCheckBox1.IsChecked == true)
                return RCheckBox1.Content.ToString();
            else if (RCheckBox2.IsChecked == true)
                return RCheckBox2.Content.ToString();
            else if (RCheckBox3.IsChecked == true)
                return RCheckBox3.Content.ToString();
            else if (RCheckBox4.IsChecked == true)
                return RCheckBox4.Content.ToString();

            return null;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Uncheck other checkboxes when one is checked
            CheckBox currentCheckBox = sender as CheckBox;

            if (currentCheckBox != null)
            {
                if (currentCheckBox == RCheckBox1)
                {
                    UncheckOtherCheckBoxes(RCheckBox1);
                }
                else if (currentCheckBox == RCheckBox2)
                {
                    UncheckOtherCheckBoxes(RCheckBox2);
                }
                else if (currentCheckBox == RCheckBox3)
                {
                    UncheckOtherCheckBoxes(RCheckBox3);
                }
                else if (currentCheckBox == RCheckBox4)
                {
                    UncheckOtherCheckBoxes(RCheckBox4);
                }
            }
        }


        /// <summary>
        /// method to disable the user from checking more than one checkbox
        /// </summary>
        /// <param name="currentCheckBox"></param>
        private void UncheckOtherCheckBoxes(CheckBox currentCheckBox)
        {
            if (currentCheckBox != null)
            {
                // Uncheck other checkboxes
                if (currentCheckBox != RCheckBox1)
                    RCheckBox1.IsChecked = false;

                if (currentCheckBox != RCheckBox2)
                    RCheckBox2.IsChecked = false;

                if (currentCheckBox != RCheckBox3)
                    RCheckBox3.IsChecked = false;

                if (currentCheckBox != RCheckBox4)
                    RCheckBox4.IsChecked = false;
            }
        }

        /// <summary>
        /// method for timer gamification function 
        /// </summary>
        private void TickTock(object sender, EventArgs e)
        {
            //decrementing remaining time for when the game is started
            remainingTime--;

            // Updates the UI to display the remaining time
            timerLabel.Content = $"TIME LEFT: {remainingTime} seconds";

            if (remainingTime <= 0)
            {
                timer.Stop();
                MessageBox.Show($"TIME'S UP! YOUR SCORE: {userPoints}", "FINDING CALL NUMBERS", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("PRESS *PLAY AGAIN* TO PLAY AGAIN.", "FINDING CALL NUMBERS", MessageBoxButton.OK, MessageBoxImage.Information);
                PlayAgainbTN.Visibility = Visibility.Visible;   

                runner.GenerateNextUniqueQuizQuestion();
                RefreshWindow();
               
            }


        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Timer initialization for when the Start game button is pressed
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickTock;

            // Setting of the time and userPoints values
            remainingTime = 120;
            userPoints = 0;


            // To start the timer
            timer.Start();
            // Start the timer and set the initial remaining time
            remainingTime = timeInSeconds;


            // Update the UI to display the remaining time
            timerLabel.Content = $"TIME LEFT: {remainingTime} seconds";

            // Resets the user's game points to zero every time the user starts a new game
            userPoints = 0;
            pointsLabel.Content = $"POINTS: {userPoints}";
        }


        /// <summary>
        /// event handler to allow user to play again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgainbTN_Click(object sender, RoutedEventArgs e)
        {
            // Timer initialization for when the Start game button is pressed
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickTock;

            // Setting of the time and userPoints values
            remainingTime = 120;
            userPoints = 0;


            // To start the timer
            timer.Start();
            // Start the timer and set the initial remaining time
            remainingTime = timeInSeconds;


            // Update the UI to display the remaining time
            timerLabel.Content = $"TIME LEFT: {remainingTime} seconds";

            // Resets the user's game points to zero every time the user starts a new game
            userPoints = 0;
            pointsLabel.Content = $"POINTS: {userPoints}";
        }

        /// <summary>
        /// method to take user back to Home window after ending the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QUITBtn_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("ARE YOU SURE?", "FINDING CALL NUMBERS", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                timer.Stop();
                userPoints = 0;
                pointsLabel.Content = $"POINTS: {userPoints}";
                remainingTime = 0;
                Home hm = new Home();
                hm.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

    }
    
}
