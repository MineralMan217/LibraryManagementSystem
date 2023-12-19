using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MockOne
{
    public partial class ReplaceBooks : Window
    {
        //private variables declared globally for global use
        private List<string> originalCallNumbers;
        private List<string> userOrderedCallNumbers;
        private int userPoints = 0;
        private bool isGameStarted = false;

        public ReplaceBooks()
        {
            InitializeComponent();
        }

        //this will initialize the Stopwatch timer a second after the window has been loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickTock;
        }


        //back button event will take user's back to the home page
        // event handling logic adapted from https://stackoverflow.com/questions/4663372/how-to-add-event-handler-programmatically-in-wpf-like-one-can-do-in-winform 
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            userPoints = 0;
            pointsLabel.Content = $"POINTS: {userPoints}";
            orderedListView.ItemsSource = null;
            originalListBox.Items.Clear();
            remainingTime = 0;
            timerLabel.Content = $"TIME LEFT: {remainingTime} seconds";
            Rules_Replace rb = new Rules_Replace();
            rb.Show();
            this.Close();
        }


        //play button event handler to start the game when clicked on 
        // event handling logic adapted from https://stackoverflow.com/questions/4663372/how-to-add-event-handler-programmatically-in-wpf-like-one-can-do-in-winform 
        private void startReplaceButton_Click(object sender, RoutedEventArgs e)
        {
            //check and reorder buttons will only become visible once the play button has been clicked
            checkButton.Visibility= Visibility.Visible; 
            reorderButton.Visibility= Visibility.Visible;  
            

            // Start the timer and set the initial remaining time
            remainingTime = timeInSeconds;
            timer.Start();

            // Update the UI to display the remaining time
            timerLabel.Content = $"TIME LEFT: {remainingTime} seconds";

            arrangeLabel.Visibility = Visibility.Visible;

            // Generate and display 10 different call numbers
            originalCallNumbers = CallNumberGenerator(10);
            userOrderedCallNumbers = new List<string>(originalCallNumbers);

            DisplayCallNumbers(originalCallNumbers);

            // means that the game has been started
            isGameStarted = true;


            //resets the user's game points to zero
            userPoints = 0;
            pointsLabel.Content = $"POINTS: {userPoints}";

        }


        //this method generates call numbers based on the random ones created in the RandomCallNumber() method
        //Random class knowledge adapated from : https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
        private List<string> CallNumberGenerator(int count)
        {
            List<string> callNumbers = new List<string>();
            Random random = new Random();

            // Generate unique call numbers
            while (callNumbers.Count < count)
            {
                string callNumber = RandomCallNumber();
                if (!callNumbers.Contains(callNumber))
                {
                    callNumbers.Add(callNumber);
                }
            }

            return callNumbers;
        }


        //this method will combine a topic(numeric) with the first three letters of the author's surname to create a random Call Number 
        //Random class knowledge adapated from : https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
        private string RandomCallNumber()
        {
            Random random = new Random();

            // Generates a random topic number between 0 and 999
            int topic = random.Next(1000);
            string topicToString = topic.ToString().PadLeft(3, '0');


            List<string> authorSurnames = new List<string> { "Smith", "Johnson", "Brown", "Taylor", "Miller", "Wilson", "Moore", "Anderson", "Clark", "White","Aaroensen", "Franco", "Connelly","Churchill" };
            string authorSurname = authorSurnames[random.Next(authorSurnames.Count)].Substring(0, 3).ToUpper();

       

            string callNumber = $"{topicToString}.{authorSurname}";

            return callNumber;
        }


        //this method adds and clears call numbers from the listview that is displayed to the user, allowing them to reorder
        private void DisplayCallNumbers(List<string> callNumbers)
        {
          if (callNumbers == null || callNumbers.Count == 0)
             {
                 return;
             }

            // this will clear the existing Call Numbers and add new call numbers to this ListBox 
                originalListBox.Items.Clear();

             foreach (string callNumber in callNumbers)
             {
                originalListBox.Items.Add(callNumber);
             }

                orderedListView.ItemsSource = callNumbers;
        }



        // private int variables as control variables for the reorder button function Handles the button click event to reorder the user's call numbers based on specific conditions.
        private int reorderButtonClicks = 0;
        private const int Attempts = 10;

        //this method will reorder the displayed Call Numbers based on how many times the users clicks the reorder button. exception handling included for when the button is clicked and the game has not started.
        // event handling logic adapted from https://stackoverflow.com/questions/4663372/how-to-add-event-handler-programmatically-in-wpf-like-one-can-do-in-winform 
        private void reorderButton_Click(object sender, RoutedEventArgs e)
        {
            
            reorderButtonClicks++;

            if (reorderButton.IsEnabled && !isGameStarted)
            {
                MessageBox.Show("Please start the game first by clicking PLAY.", "Game Not Started", MessageBoxButton.OK, MessageBoxImage.Information);
            }

               else if (isGameStarted && reorderButtonClicks % 4 == 0 || reorderButtonClicks == 1)
                {

                    // Display the call numbers in ascending order
                    userOrderedCallNumbers = MergeSorting(userOrderedCallNumbers);
                    orderedListView.ItemsSource = userOrderedCallNumbers;

                }
                else
                {
                    // Shuffle the user-ordered call numbers randomly
                    Random random = new Random();
                    userOrderedCallNumbers = userOrderedCallNumbers.OrderBy(x => random.Next()).ToList();

                    int attempts = 0;
                    while (!IsAscendingOrder(userOrderedCallNumbers) && attempts < Attempts)
                    {
                        userOrderedCallNumbers = userOrderedCallNumbers.OrderBy(x => random.Next()).ToList();
                        attempts++;
                    }

                    orderedListView.ItemsSource = userOrderedCallNumbers;
                }
            }


        //this method will check the order of the user's call numbers and update their points based on their "answers". also includes exceptions for when the button is clicked when the game has not started 
        // event handling logic adapted from https://stackoverflow.com/questions/4663372/how-to-add-event-handler-programmatically-in-wpf-like-one-can-do-in-winform 
        private void checkButton_Click(object sender, RoutedEventArgs e)
        {

            bool isAscendingOrder = IsAscendingOrder(userOrderedCallNumbers);

            if (checkButton.IsEnabled && !isGameStarted)
            {
                MessageBox.Show("Please start the game first by clicking PLAY.", "Game Not Started", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else if (isGameStarted && isAscendingOrder)
                {
                    userPoints += 15;
                    MessageBox.Show("BRAVO! YOU GOT +15 POINTS :)", "PAID DUES", MessageBoxButton.OK, MessageBoxImage.Information);
                    // Start a new game
                    // Generate and display 10 different call numbers
                    originalCallNumbers = CallNumberGenerator(10);
                    userOrderedCallNumbers = new List<string>(originalCallNumbers);
                }
                else
                {
                    userPoints -= 4;
                    MessageBox.Show("WRONG! THAT'S -4 POINTS :(", "CHECK FIRST, MATE", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            
                UpdateUserPoints();
            DisplayCallNumbers(originalCallNumbers);

        }



        //method that will update the user points that appear on the UI
        private void UpdateUserPoints()
        {
            pointsLabel.Content = $"POINTS: {userPoints}";
        }



        //as part of gamification, this declares private timer/countdown variables to be implemented in the TickTock Method()
        private int timeInSeconds = 80; // adjustable time limit
        private System.Windows.Threading.DispatcherTimer timer;
        private int remainingTime;
        //and this methods implements the countdown timer with actions for when time has run out.
        private void TickTock(object sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime <= 0)
            {
                timer.Stop();
              
                MessageBox.Show($"TIME'S UP :(\nSCORE: {userPoints}", "Time's Up", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                timerLabel.Content = $"TIME LEFT : {remainingTime} seconds";
            }
        }


        //with the use of the mergeSorting() method, this method will check if the call numbers are sorted in ascending order
        private bool IsAscendingOrder(List<string> callNumbers)
        {
            if (callNumbers == null || callNumbers.Count == 0)
            {

                return false;
            }

            // Use Merge Sort algorithm to check if the call numbers are sorted in ascending order
            List<string> sortedNumbers = MergeSorting(callNumbers);

            return callNumbers.SequenceEqual(sortedNumbers);
        }



        //MergeSort sorting algorithm to sort call numbers in ascending order
        //logic adapted from https://www.geeksforgeeks.org/merge-sort/
        private List<string> MergeSorting(List<string> numbers)
      {
             if (numbers == null)
        {
            return new List<string>(); 
        }

        if (numbers.Count <= 1)
        {
        return numbers;
        }

        int mergeId = numbers.Count / 2;
        List<string> left = numbers.GetRange(0, mergeId);
        List<string> right = numbers.GetRange(mergeId, numbers.Count - mergeId);

        left = MergeSorting(left);
        right = MergeSorting(right);

        return MergeItems(left, right);
}



        //Method that will merge two sperate lists into one single and sorted list with Compare methods in case values are the same, that way can be arranged correctly
        //Logic Adapted from https://www.geeksforgeeks.org/merge-two-sorted-lists-place/ & https://stackoverflow.com/questions/2280987/merging-two-lists-into-one-and-sorting-the-items
        private List<string> MergeItems(List<string> left, List<string> right)
        {
            List<string> mergedItems = new List<string>();
            int IndexOnLeft = 0;
            int IndexOnRight = 0;

            while (IndexOnLeft < left.Count && IndexOnRight < right.Count)
            {
                if (string.Compare(left[IndexOnLeft], right[IndexOnRight]) <= 0)
                {
                    mergedItems.Add(left[IndexOnLeft]);
                    IndexOnLeft++;
                }
                else
                {
                    mergedItems.Add(right[IndexOnRight]);
                    IndexOnRight++;
                }
            }

            while (IndexOnLeft < left.Count)
            {
                mergedItems.Add(left[IndexOnLeft]);
                IndexOnLeft++;
            }

            while (IndexOnRight < right.Count)
            {
                mergedItems.Add(right[IndexOnRight]);
                IndexOnRight++;
            }

            return mergedItems;
        }



        //Quit method that wil reset timer, user points,the listbox and listview when clicked on
        // event handling logic adapted from https://stackoverflow.com/questions/4663372/how-to-add-event-handler-programmatically-in-wpf-like-one-can-do-in-winform 
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult ifQuit = MessageBox.Show("ARE YOU SURE ?", "REPLACING BOOKS :(", MessageBoxButton.YesNo, MessageBoxImage.Question);

          
                if (ifQuit == MessageBoxResult.Yes)
                {
                    timer.Stop();
                    userPoints = 0;
                    pointsLabel.Content = $"POINTS: {userPoints}";
                    orderedListView.ItemsSource = null;
                    originalListBox.Items.Clear();
                    remainingTime= 0;   
                    timerLabel.Content = $"TIME LEFT: {remainingTime} seconds";
                    arrangeLabel.Visibility = Visibility.Hidden;

                Home hm = new Home();
                hm.Show();
                this.Close();

            }
            else if (ifQuit == MessageBoxResult.No)
                {
                    this.Show();
                }
            

        }
    }
}