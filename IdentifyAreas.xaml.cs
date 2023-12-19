using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MockOne
{
    /// <summary>
    /// Interaction logic for IdentifyAreas.xaml
    /// </summary>
    public partial class IdentifyAreas : Window
    {
        /// <summary>
        /// globally declared variables for global use
        /// </summary>
        private int timeInSeconds = 120; // adjustable time limit
        private DispatcherTimer timer;
        private int remainingTime;
        private int userPoints = 0;
        private Dictionary<string, string> callNumberDescriptions;
        public Dictionary<string, string> userAnswersDictionary = new Dictionary<string, string>();
        private bool isMatchingCallNumberToDescription; // Flag to track the current question type


        public IdentifyAreas()
        {
            InitializeComponent();

            // Use of a dictionary to store the call numbers and their descriptions 
            callNumberDescriptions = new Dictionary<string, string>
            {
                { "000", "Computer science, Information, and General Works" },
                { "100", "Philosophy and Psychology" },
                { "200", "Religion" },
                { "300", "Social Sciences" },
                { "400", "Language" },
                { "500", "Science" },
                { "600", "Technology" },
                { "700", "Arts and Recreation" },
                { "800", "Literature" },
                { "900", "History and Geography" }
            };



            // Calling of the GenerateQuestion Method to populate both listBoxes with Call Numbers and Descriptions
            GenerateQuestion();
        }


        /// <summary>
        /// method to handle the start button event: starting the game, the timer, displaying the call numbers and descriptions
        /// </summary>
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            // Timer initialization for when the Start game button is pressed
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickTock;

            // Setting of the time and userPoints values
            remainingTime = 120;
            userPoints = 0;

            // Match, the label, and quit buttons will only become visible once the play button has been clicked
            matchButton.Visibility = Visibility.Visible;
            quitButton.Visibility = Visibility.Visible;
            matchLabel.Visibility = Visibility.Visible;

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
        /// method to handle the the Match Button event for when the user decides the check their answers
        /// </summary>
        private void matchButton_Click(object sender, RoutedEventArgs e)
        {

            //this will clear any pre-existing Dictionary data
            userAnswersDictionary.Clear();



            int rightAnswers = 0;

            // A for loop to iterate 4 times and add the users answers to the userAnswersDictionary
            for (int i = 0; i < 4; i++)
            {
                string callNumber = callNumberListBox.SelectedItems[i].ToString();
                string description = descriptionListBox.SelectedItems[i].ToString();

                userAnswersDictionary[callNumber] = description;
            }

            // A foreach loop to iterate through the entire userAnswersDictionary to check if each selected call number matches its corresponding description using the dictionary's TryGetValue method. adapted from https://makolyte.com/csharp-get-value-from-dictionary/ 
            foreach (var item in userAnswersDictionary)
            {
                string callNumber = item.Key;
                string description = item.Value;

                if (callNumberDescriptions.TryGetValue(callNumber, out string matchedDescription) && matchedDescription == description ||
                    callNumberDescriptions.TryGetValue(description, out string matchedNumber) && matchedNumber == callNumber)
                {
                    rightAnswers++;

                }

            }

            // User points get calculated based on the number of answers they get right 
            int pointsEarned = rightAnswers * 3;

            //if-statement that will display the necessary messages and only generate the next question if the user gets at least 3 points for each question
            if (pointsEarned > 0)
            {
                // Increment userPoints for each right answer 
                userPoints += pointsEarned;
                pointsLabel.Content = $"POINTS: {userPoints}";

                MessageBox.Show($"GREAT! YOU GOT +{pointsEarned} POINTS :)", "IDENTIFYING AREAS", MessageBoxButton.OK, MessageBoxImage.Information);

                // Generates next the column set if the user gets the answer right
                GenerateQuestion();
            }
            else
            {
                MessageBox.Show("NEED TO GET AT LEAST 3 POINTS! TRY AGAIN :(", "IDENTIFYING AREAS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            // This will clear the list of ListBox Items once the user gets the answer right
            callNumberListBox.SelectedItems.Clear();
            descriptionListBox.SelectedItems.Clear();

        }




        /// <summary>
        /// /method to handle the generation of Match-the-coloumn questions
        /// </summary>
        private void GenerateQuestion()
        {
            // Data from the previous gets cleared
            callNumberListBox.ItemsSource = null;
            descriptionListBox.ItemsSource = null;

            // this will randomly select four call number Items from the Dictionary. Logic adapted from https://stackoverflow.com/questions/9449452/linq-order-by-random 
            var randomItems = callNumberDescriptions.OrderBy(x => Guid.NewGuid()).Take(4).ToList();

            //Extraction of Call numbers and Descriptions using LNGQ. Adapted from https://stackoverflow.com/questions/20675469/tolist-after-select-in-linq
            var randomCallNumbers = randomItems.Select(item => item.Key).ToList();
            var randomDescriptions = randomItems.Select(item => item.Value).ToList();

            // This selects 3 random incorrect answers(Descriptions and Call Numbers) from the Dictionary to put into the DescriptionsListBox https://stackoverflow.com/questions/9449452/linq-order-by-random 
            var incorrectDescriptions = callNumberDescriptions.Values.Except(randomDescriptions).OrderBy(x => Guid.NewGuid()).Take(3).ToList();
            var incorrectCallNumbers = callNumberDescriptions.Keys.Except(randomCallNumbers).OrderBy(x => Guid.NewGuid()).Take(3).ToList();


            // Combine the correct descriptions with the incorrect descriptions. https://www.programiz.com/csharp-programming/library/string/concat
            var allDescriptions = randomDescriptions.Concat(incorrectDescriptions).OrderBy(x => Guid.NewGuid()).ToList();
            var allCallNumbers = randomCallNumbers.Concat(incorrectCallNumbers).OrderBy(x => Guid.NewGuid()).ToList();

            // if-else statement to alternate between descriptions to call numbers questions, and call numbers to descriptions questions by changing the item sources of the list boxes
            if (!isMatchingCallNumberToDescription)
            {

                callNumberListBox.ItemsSource = randomDescriptions;
                descriptionListBox.ItemsSource = allCallNumbers;
            }
            else if (isMatchingCallNumberToDescription)
            {
                callNumberListBox.ItemsSource = randomCallNumbers;
                descriptionListBox.ItemsSource = allDescriptions;
            }



            isMatchingCallNumberToDescription = !isMatchingCallNumberToDescription;
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
                MessageBox.Show($"TIME'S UP! YOUR SCORE: {userPoints}", "IDENTIFYING AREAS", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("PRESS *START* TO PLAY AGAIN.", "IDENTIFYING AREAS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           

        }
        
    
    



            /// <summary>
            /// Method to handle the back button functionality
            /// </summary>
            private void backButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("ARE YOU SURE?", "IDENTIFYING AREAS", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                timer.Stop();
                userPoints = 0;
                pointsLabel.Content = $"POINTS: {userPoints}";
                remainingTime = 0;
                Rules_Identify RI = new Rules_Identify();
                RI.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }


        /// <summary>
        /// method to handle the quit button functionality
        /// </summary>
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("ARE YOU SURE?", "IDENTIFYING AREAS", MessageBoxButton.YesNo, MessageBoxImage.Warning);

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