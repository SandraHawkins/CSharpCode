using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // For reading from the file "FiveLetterWords.txt"

namespace Wordle
{
    public partial class Form1 : Form
    {
        // Declare any global varirable, i.e. any variables that will be used
        // in more than one method:
        // The array of labels
        private readonly Label[,] letters;

        // The current row number/ guess
        private int rowNum;

        // The position the next letter goes into
        private int position;

        // A list of words that are allowed, i.e. actual words/ valid guesses
        private List<String> listOfAllowedWords = new List<String>();

        private char[] currentWord; 

        private char[] guess;

        public Form1()
        {
            InitializeComponent();

            // Put all labels into a Label array
            letters = new Label[,] { 
                { Lbl1, Lbl2, Lbl3, Lbl4, Lbl5 },
                { Lbl6, Lbl7, Lbl8, Lbl9, Lbl10 },
                { Lbl11, Lbl12, Lbl13, Lbl14, Lbl15 },
                { Lbl16, Lbl17, Lbl18, Lbl19, Lbl20 },
                { Lbl21, Lbl22, Lbl23, Lbl24, Lbl25 },
                { Lbl26, Lbl27, Lbl28, Lbl29, Lbl30 }
            };

            guess = new char[5];

            LoadWordsFromFileAndPickWord();
            LoadAllowableWordsIntoList();
        }

        /*
         * This method loads the allowable words from the file: AllowedWords.txt
         * Each guess is checked against the list of allowable words to check if it's a
         * valid five letter words. The AllowedWords.txt file contains words that are
         * not in the FiveLetterWords.txt file.
         */
        private void LoadAllowableWordsIntoList()
        {
            string[] allowableWords = File.ReadAllLines("AllowedWords.txt");

            // AddRange() is a list method that can take in a collection / array 
            // and populate the list.
            listOfAllowedWords.AddRange(allowableWords);

            Console.WriteLine("List of Allowable words: " + 
                              String.Join(", ", listOfAllowedWords));
        }

        /*
         * This method loads all the words from the file FiveLetterWords.txt, a random
         * word is picked and assigned to the global variable: currentWord.
         */
        private void LoadWordsFromFileAndPickWord()
        {
            // The filename, it is in the bin/ debug folder
            string filename = "FiveLetterWords.txt";

            // ReadAllLines() takes in the filename and returns a sting array
            string[] allWords = File.ReadAllLines(filename);

            // A list to store all the words from the file
            // The list constructor can receieve an array of strings
            // The list of words, it's global as it is needed to validate if each
            // guess is a real word
            List<string> listOfWords = new List<string>(allWords);

            Console.WriteLine("List of Guess words: " + String.Join(", ", listOfWords));

            // Get the number of words in the list
            int numOfwords = listOfWords.Count;

            // Use the random's next method to select a word from the list
            Random random = new Random();
            currentWord = listOfWords[random.Next(0, numOfwords)].ToCharArray();
            Console.WriteLine("The current word is: " + new string(currentWord));
        }

        /*
         * This event handler handles all 26 letter buttons. 
         * The first argument passed into the event handler is an object, called
         * sender, this will be the object/ button that was clicked. Using this
         * sender parameter we can get the Text off the button that was pressed.
         * Every event hander, its first parameter is the object that caused the
         * event to occur, this is a click event, therefore the object here will
         * be the button that was clicked. 
         */
        private void LetterClicked(object sender, EventArgs e)
        {
            // Only execute this code when the position variable is less
            // than the or equal to 4, the index of the guess goes from 
            // 0 to 4.
            if (position <= 4 && rowNum <= 6)
            {
                // I know that sender is defintely a Button object, so I can 
                // downcast the sender from its parent type object into a Button 
                // object, and that will allow me to call/ access the button's 
                // properties.
                // Button button = (Button)sender;
                Button button = sender as Button; // downcast into the child type
                // convert the Letter into lowercase and into a char
                guess[position] = button.Text.ToLower()[0]; 
                Console.Write(button.Text + " ");

                // This will take the text from the button that was pressed and
                // assign it to the Text property of the label. The position variable
                // is used to populate the correct label and needs to incremented 
                // each time. 
                letters[rowNum, position].Text = button.Text;
                position++;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // if the position is greater than 0, decrement the position by 1
            // and use that value to access the correct label in the array
            // and set its Text property to an empty string.
            if (position > 0)
            {
                //letters[--position].Text = String.Empty;
                // or
                position--; // position = position - 1;
                letters[rowNum, position].Text = String.Empty;
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // Chech the user has entered 5 letters
            if (position < 5)
            {
                MessageBox.Show("Not enough letters", "Go again",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Convert the char array into a string
                string strGuess = new string(guess);

                Console.WriteLine("Your guess is: " + strGuess);
                // Check it's a real word in the listOFAllowableWords before resetting
                // the positions for the next guess
                if (listOfAllowedWords.Contains(strGuess))
                {
                    // Call the CheckWord() method which will see if any of the letters
                    // are in the correct spot or if the word is fully correct.
                    CheckWord();

                    // it's a valid guess
                    // Move down to the next row/ guess
                    rowNum++;
                    // Reset the position to 0
                    position = 0;
                }
                else
                {
                    MessageBox.Show("That is not a valid word", "Try again",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /*
         * This method is used to check the user's 'guess' again the currentWord
         * both of which are character arrays.
         */
        private void CheckWord()
        {
            Console.WriteLine("CheckWord() has been called");

            // Convert the char arrays into strings.
            string strGuess = new string(guess);
            string strCurrentWord = new string(currentWord);
            Console.WriteLine($"guess: {strGuess}, currentWord {strCurrentWord}");

            // First check to see if the guess is an exact match to the currentWord.
            // If it is then change the background colour on all labels on the 
            // current row to green and prevent any further turns.
            if (strGuess.Equals(strCurrentWord))
            {
                for (int i = 0; i < 5; i++)
                {
                    letters[rowNum, i].BackColor = Color.ForestGreen;
                    letters[rowNum, i].ForeColor = Color.White;
                }

                // Allow no more guesss
                rowNum = 6;

                MessageBox.Show("That is correct!", "Congratulations",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else
            {
                Console.WriteLine("Not an exact match, check the individual letters");

                // Loop through the guess
                for(int i = 0; i < guess.Length; i++)
                {
                    // Check each letter to see if it occurs anywhere in the word
                    // being guessed
                    if (strCurrentWord.Contains(guess[i])) 
                    {
                        // Now check for an exact position match
                        if (currentWord[i] == guess[i])
                        {
                            // Yes, then change the backgroud to green
                            Console.WriteLine("Exact letter match");
                            letters[rowNum, i].BackColor = Color.ForestGreen;
                            letters[rowNum, i].ForeColor = Color.White;
                        } else // correct letter, not correct position
                        { // change the background to gold
                            Console.WriteLine("Letter match but not in the correct position");
                            letters[rowNum, i].BackColor = Color.Gold;
                            letters[rowNum, i].ForeColor = Color.White;
                        }
                    } else // Incorrect letter guess, background goes to grey
                    {
                        letters[rowNum, i].BackColor = Color.DimGray;
                        letters[rowNum, i].ForeColor = Color.White;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode + " was pressed");
        }
    }
}
