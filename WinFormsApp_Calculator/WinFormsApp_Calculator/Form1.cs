using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp_Calculator
{

    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>

        private void CEbutton_Click(object sender, EventArgs e)
        {
            //function linked to CE Esc button on keyboard for fun. Running on UI thread
            //MessageBox.Show("Hi");
            
            this.UserInputText.Text = string.Empty;  // same as this.UserInputText.Text= "";
            
            //focuses user input test
            FocusInputText();

        }
        /// <summary>
        /// Deletes the first character in front of the cursor
        /// </summary>
        /// <param name="sender">THe event sender</param>
        /// <param name="e">The event arguments</param>
        private void Delbutton_Click(object sender, EventArgs e)
        {
            //Delete the value of the selected position
            DeleteTextValue();

            //focuses user input test
            FocusInputText();
        }

        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the divide character to the text field at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void Divbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("/");

            //focuses user input test
            FocusInputText();
        }

        /// <summary>
        /// Adds the multiplication character to the text field at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void Multbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("*");

            //focuses user input test
            FocusInputText();
        }

        /// <summary>
        /// Adds the minus character to the text field at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void Minusbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("-");

            //focuses user input test
            FocusInputText();
        }

        /// <summary>
        /// Adds the addition character to the text field at the current selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void Plusbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("+");

            //focuses user input test
            FocusInputText();
        }

        /// <summary>
        /// Calculates the given equation in the equals character to the text field 
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void Equalbutton_Click(object sender, EventArgs e)
        {
            //TODO:Finish
            //calculates the user equation
            CalculateEquation();

            //focuses user input test
            FocusInputText();
        }

       
        #endregion

        #region Number Methods

        /// <summary>
        /// Formatiting the Numbers
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="e">the even arguments</param>

        private void Dotbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue(".");

            //focuses user input test
            FocusInputText();
        }
        private void Zerobutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("0");

            //focuses user input test
            FocusInputText();
        }

        
        private void Onebutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("1");

            //focuses user input test
            FocusInputText();
        }

        private void Twobutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("2");

            //focuses user input test
            FocusInputText();
        }

        private void Threebutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("3");

            //focuses user input test
            FocusInputText();
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("4");

            //focuses user input test
            FocusInputText();
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("5");

            //focuses user input test
            FocusInputText();
        }

        private void Sixbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("6");

            //focuses user input test
            FocusInputText();
        }

        private void Sevbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("7");

            //focuses user input test
            FocusInputText();
        }

        private void Eightbutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("8");

            //focuses user input test
            FocusInputText();
        }

        private void Ninebutton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("9");

            //focuses user input test
            FocusInputText();
        }

        #endregion

        #region Calculate Equation

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>

        private void CalculateEquation()
        {
            //Recursive functions - functions that call themselves
            //Switch statements

            this.CalculationResultText.Text = ParseOperation();        //(int)OperationType.Multiply;  ex- explicit cast

            FocusInputText();
        }
        /// <summary>
        /// Parses the users equation and calcualtes the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            //alot of instances that can happen at any point- easiest to use exceptions ex) num/0

            try
            {
                //Get user equation input and store it
                var input = this.UserInputText.Text;

                //Remove all spaces
                input = input.Replace(" ", "");

                //Create new top level operation    ex (order) 5.34 + 4 * (2 / 4)
                var operation = new Operation();
                var leftSide = true;
                //Loop through each character of the input
                //Starting from the Left working to the righ- for loops commonly used to loop through array
                for (int i = 0; i < input.Length; i++)
                {
                    //MessageBox.Show(i.ToString());            //input is 333 hit equal output 0,1,2 (index) 
                    //MessageBox.Show(input[i].ToString());       //input is 333 output 3,3,3 (value of index)

                    //TODO: Handle order priority
                    //4+5*3
                    //should calculate 5*3 first then result + 4 (15+4)


                    //while does same thing just not clean
                    //int j = 0;
                    //while(j < input.Length)
                    //{
                    //    MessageBox.Show(j.ToString());      //input is 456 hit equal output 0,1,2
                    //    j++;
                    //}

                    //check if the current character is a number  //assume input 333  //need System.Liq for .Any   
                    if ("0123456789.".Any(c => input[i] == c))  //if first chcaracter in string (c=0) == first value in input string = false
                    {
                        if (leftSide)
                            //operation.LeftSide += input[i];  //could do this but want to do some smart checking
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]); //AddNumber function checks if more than one . throws error if there is 
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]); //AddNumber function checks if more than one . throws error if there is 
                    }
                    //Checks if the character is an operator ( +  - * /) set the operator type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        //If we are on the right side already, we now need to calculate our current operation 
                        //and set the result to the left sie of the next operation
                        if (!leftSide)
                        {
                            var operatorType = GetOperationType(input[i]);

                            //What happens if you have a second operator- -calculate the Left side
                            //Check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                //Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * - / or more than one -) specified without a right side number");

                                //If we got here, the operator is a minus, and there is no left number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                //Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);  //if we hav 1+2 work out the operation and then set left side to 3

                                //Set new operator
                                operation.OperationType = operatorType;

                                //Clear the previous right side number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            //Check if we actually have a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                //Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * - / or more than one -) specified without a left side number");

                                //If we got here, the operator is a minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }

                            else
                            {
                                //If we got here, we hava a left number and now an operator, so we want to move to the right side

                                //Set the operation type
                                operation.OperationType = operatorType;

                                //Move to right side
                                leftSide = false;

                            }

                        }
                    }
                }

                    //The above inner loop parses the equation and if there wer no exceptions/errors
                    //calculate the current loop
                    return CalculateOperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }
        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result  //this is the crux of the calculator the hard part was parsing the user information
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            //Store the number values of the string representations
            decimal left = 0;           //decimal is most accurate
            decimal right = 0;

            //Check if we have a valid left side value and parse
            //Don't need this but is a good double chek - if we have a null or not able to parse then
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))              //can also use IsNullOrWhiteSpace- don't need this 
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            //Check if we have a valid right side value and parse            
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))               
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");

            //example will crash the system
            //var i = 0;
            //var j = 0;
            //var k = i / j;

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkonw operator type when calculating operation. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide} {ex.Message}");
                //double 0/0= Nan
                //int 0/0= exception is caught
            }
            /*return string.Empty; */               //testing purposes


        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>  //displaying this way allows user to click on the when exported 
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)   //switch stetment takes in a character and must return OperationType 
            {
                case '+':
                    //
                    return OperationType.Add;           //enums that were previously set up
                case '-':
                    //
                    return OperationType.Minus;
                case '/':
                    //
                    return OperationType.Divide;
                case '*':
                    //
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }

        }

        /// <summary>
        /// Attempt to add an new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="currentCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a  . in the number'
            if (newCharacter == '.' && currentNumber.Contains('.')) //
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added.");

            return currentNumber + newCharacter;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();         //occassionally won't work when used in 
        }

        /// <summary>
        /// Inserts the given text inot the user inputs text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            //Remeber selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //Set selection length to 0
            this.UserInputText.SelectionLength = 0;


            //var s = "Hello World";
            //this.UserInputText.Text = this.UserInputText.Text.Insert(1, "0");  //takes original string and at index 1 inserts a zero
            //this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);  //takes original string and inserts value zero at curser

        }


        /// <summary>
        /// Deletes the character to the right of the selection start of the useru input text box
        /// </summary>
        
        private void DeleteTextValue()
        {
            //If we don't have a value to delete- the negative check  //var= "Hello"
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //Remeber selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection length to 0
            this.UserInputText.SelectionLength = 0;            

        }

        #endregion


    }
}
