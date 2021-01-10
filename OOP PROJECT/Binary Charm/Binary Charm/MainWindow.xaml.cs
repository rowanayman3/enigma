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

namespace Binary_Charm
{
    /// <summary>

    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {


        Random rand = new Random();

        int total;
        // The total integer that will be used to calculate the total number

        int randomInt; 
        // The random number that will appear to the user


        public MainWindow()
        {
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
            Hide();
            Form1 n = new Form1();
            n.ShowDialog();
            


           
           

            btnCheck.IsEnabled = false;
            // The Check Button will be disabled till the user start the game it will be enabled
        }
        //con
        public MainWindow(bool doNotMakeInvisiblity)
        {
            InitializeComponent();
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            // This is the StartGame Code
            // We will generate a random number from 0 to 511

            randomInt = rand.Next(0, 511);
            
            // 511 is the biggest decimal number that can be obtained from the binary numbers that are represented in the game
            // 0 is the starting as we can't take negative numbers

            txtQuestion.Content = "What is " + randomInt + " in Binary?";
            // To show the question to the screen on the Question Label

            btnCheck.IsEnabled = true;
            // To enable the Check Button

            txtAnswer.Content = "";
            // We will keep an empty string in the txt Answer till we use it

            // To find all the TextBoxes in the Grid
            foreach (var x in mainGrid.Children.OfType<TextBox>())
            {
                x.Text = "0";
                // Set all the TextBoxes into zero as a default number inside all of them

            }

        }

        // What is shown when you click on Help Button
        // MessageBox with the Game Instructions

        private void ShowHelp(object sender, RoutedEventArgs e)
        {
            // The spaces between the quotation and Welcome in the first line is to make the Welcome sentence in the center of the page
            // The spaces between the quotaion and the instructions under Tips word is to make a satisfying shape to the eyes
            // "\n" To start a new line
            MessageBox.Show(
                "                                      Welcome to the game \n" +
                "Tips for Binary Charm: \n" +
                "   1- Click on the start button to start the game.\n" +
                "   2- Enter 1 or 0 into the LightBlue Boxes. \n" +
                "   3- If you entered 1 into the box it will represent the value mentioned above it. \n" +
                "   4- If you entered 0 into the box it will not count towards the total. \n" +
                "   5- Once you finish and feel satisfied with your numbers click on check button to see if the answer correct. \n" +
                "Feel fry to retry unlimited times.\n" +
                "Have fun and Enjoy.."
                );

        }

        private void CheckGame(object sender, RoutedEventArgs e)
        {
            total = 0;
            // Set the initial value of total to zero in the beginning

            txtAnswer.Content = "";
            // txtAnswer string will still empty untill we need to use it

            foreach (var x in mainGrid.Children.OfType<TextBox>())
            {
                // Function to calculate the numbers in the TextBoxes
                // If the TextBox contains 1 it means that the box is active
                // If the TextBox contains 0 it means that the box is inactive

                if (x.Text == "1")
                {
                    total += Convert.ToInt32(x.Tag);
                    // Search for the tags associated with the TextBoxes
                    // We will Convert the Tags in Integers first
                    // Then we will Add the Tags above the active TextBoxes together to find the total number
                }

                // When we finish the calculation the binary number will be shown on the screen
                // Important Note: += means that we will add them to the existing string instead of adding them up
                txtAnswer.Content += x.Text;
            }

            // This If statement will check if the result is correct or incorrect
            if (total == randomInt)
                // If the total is equal to the Random number so the answer is correct
            {
                btnCheck.IsEnabled = false;
                //Check Button will be disabled now

                txtAnswer.Content += " is correct! Good job";
                // The binary number will be shown saying that it is a correct answer
            }
            else
            {
               // If the totals isn't equal to the Random number so the answer is incorrect
               // The binary number will be shown saying that it is incorrect answer
               // The user has the right to try unlimited times or change the number by using start again 
                txtAnswer.Content +=" is incorrect! Don't give up";
            } 
                
        }

        // What is shown when you click on en;gma Button
        // A MessageBox with enigma team members names
        private void enigma(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
             " enigma Team Members: \n \n" +
             "   1- Hassan Sayed \n" +
             "   2- Ahmed Mahfouz \n" +
             "   3- Ahmed magdy \n" +
             "   4- Mariam Salah \n" +
             "   5- Rowan Ayman \n"
                );
        }
    }
}