using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region MainMembers
        /// <summary>
        /// Holds the current results of cells i the active game
        /// </summary>
        private MarkType[] mResults;

        /// <summary>
        /// True if it is player 1's turn (X) or player 2's turn (0)
        /// </summary>
        private bool mPlayer1Turn;

        /// <summary>
        /// True if the game has ended
        /// </summary>
        private bool mGameEnded;



        #endregion


        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        #endregion

        #region New Game

        /// <summary>
        /// Starts a new game and clears all values back to the start
        /// </summary>
        private void NewGame()
        {
            //Create a new blak array of free cells  - by default free is = 0
            mResults = new MarkType[9];

            //Go through every Resutl and set it to Free
            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            //Make sure Player ! starts the game
            mPlayer1Turn = true;

            //New game need to clear off all the content from the grid
            // Cast (alt .) to add to Linq to namespace Button (alt .) will add Windows controls to namespace
            //Cast -converts the array of children(UI element to a button)- which is a enumerables- converted/fetches every button to a list
            //Iterate through everybutton on the grid...
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                //Chnage background foreground and content to default values

                button.Content = string.Empty;                  //works content was originally set to X / O for the first two entries in row
                button.Background = Brushes.Black;              //Brushes (alt .) adds Windows media 
                button.Foreground = Brushes.Red;                //Foregroundcolor is the text color   
            });

            //Make sure the game hasn't finished
            mGameEnded = false;
        }
        #endregion

        #region Button Events & Details

        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The events of the click</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //first check if the previous game has ended then start a new game
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            //cast sender to button
            var button = (Button)sender;                //sender of the object is a button need to expicit cast- converts object to button

            //Find the button position in the array
            var column = Grid.GetColumn(button);            //c0,c1,c3
            var row = Grid.GetRow(button);                 //r0, r1, r2

            var index = column + (row * 3);            //find the index - see notes for details

            //Don't do anythng if the cell already had a value in it
            if (mResults[index] != MarkType.Free)
                return;

            //set the cell value based on which players turn it is
            //Option 1  if/else
            //if (mPlayer1Turn)
            //    mResults[index] = MarkType.Cross;
            //else
            //    mResults[index] = MarkType.Nought;

            //option 2 ternary operator
            mResults[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;

            //Set the button text to the result
            button.Content = mPlayer1Turn ? "X" : "O";

            //Change the noughts to green
            if (!mPlayer1Turn)
                button.Foreground = Brushes.Blue;

            //Toggle the players turns
            //Opiton 1  if/else
            //if (mPlayer1Turn)
            //    mPlayer1Turn = false;
            //else
            //    mPlayer1Turn = true;

            //Easier way - use bitwise operator ^ to ge the opposite result 
            mPlayer1Turn ^= true;                   //if mPlayer1turn is the opposite of true so false

            //Check for a winner
            CheckForWinner();


        }
        #endregion

        #region Check Wins
        private void CheckForWinner()
        {
            //Check for all 8 possible win combinations Button-Col_Row           
            //& is a bitwise operator (checks if all values are the same and the space is not taken 
            #region Horizontal Wins
            //Check for horizontal wins
            //
            // - Row 0
            //
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
            }
            //
            // - Row 1
            //
            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
            }
            //
            // - Row 2
            //
            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion

            #region Vertical Wins
            //
            // - column 0
            //
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }
            //
            // - column 1
            //
            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }
            //
            // - column 2
            //
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion

            #region Diagonal Wins
            //
            // - Top Left to Bottom Right
            //
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }
            //
            // - Top Left to Bottom Right
            //
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                //Game Ends
                mGameEnded = true;

                //Highlight winning cells in Black
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;
            }
            #endregion

            #region No Winner
            //
            //- No Winner
            //
            //Check for no winner- If all squares are ful and above conditions not met
            if (!mResults.Any(f => f == MarkType.Free))                 //link expression
            {
                //Game ended
                mGameEnded = true;

                //Turn all Cells orange
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {           
                                                      
                    button.Background = Brushes.Orange;              
                                   
                });

                #endregion

            }
            #endregion

        }

    }
}
