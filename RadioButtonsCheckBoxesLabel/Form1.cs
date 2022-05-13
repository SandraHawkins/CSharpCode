using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonsCheckBoxesLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            // When comparing strings, use the .Equals() method. The Equals()
            // is called on one string and it compares the character to the string
            // that you pass into the Equals() method, i.e. the argument passed in.
            if (TxtUserInput.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please enter some text in the TextBox", "Empty Text",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Clicks in the textbox, so that the cursor is there.
                TxtUserInput.Focus();
            }
            else // there is some text in the textbox
            {
                // put the text from the textbox into the label
                // Read the right hand side of the = first, this takes the 
                // text from the textbox and asigns it to the text of the label
                LblResult.Text = TxtUserInput.Text;
            }
        }

        /*
         * The click event will only happen when a radiobutton is checked,
         * i.e. it's Checked property changes to true
         */
        private void RbRed_Click(object sender, EventArgs e)
        {
            // Assigns the colour red to the BackColor property of the label
            LblColour.BackColor = Color.Red;
        }

        private void RbGreen_Click(object sender, EventArgs e)
        {
            LblColour.BackColor = Color.Green;
        }

        private void RbBlue_Click(object sender, EventArgs e)
        {
            LblColour.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // PerformClick(); is the code to click on a button (or a 
            // radioButton), this will in turn check the radioButton and
            // fire the Click event above.
            RbRed.PerformClick();
        }

        private void BtnWhichRadioButton_Click(object sender, EventArgs e)
        {
            // Radio buttons can be evaluated using if else statements 
            // because only one can be checked at once.
            if (RbGreen.Checked)
                TxtResult.Text = "The green radio button is checked";
            else if (RbRed.Checked)
                TxtResult.Text = "The red radio button is checked";
            else if (RbBlue.Checked)
                TxtResult.Text = "The blue radio button is checked";
            else
                TxtResult.Text = "No radio buttons are checked";
        }

        /*
         * This event handler will handle any of the three checkboxes being checked on or 
         * off.  I need to write code to determine which checkbox is on or off. 
         */
        private void ACheckBoxWasChanged(object sender, EventArgs e)
        {
            // Clear the text box
            TxtResult.Text = String.Empty;

            if (CbSausages.Checked)
                TxtResult.Text += "Sausage checkbox was checked" + Environment.NewLine;

            if (CbStreakyBacon.Checked)
                TxtResult.Text += "Streak bacon checkbox was checked" + Environment.NewLine;

            if (CbEggs.Checked)
                TxtResult.Text += "Eggs checkbox was checked" + Environment.NewLine;

            CalculatePrice();
        }

        /*
         * This method is typed by Sandra and called from behind the Reset button
         */
        private void ResetForm()
        {
            // Emptying the textboxes
            TxtResult.Text = String.Empty;
            TxtUserInput.Text = String.Empty;
            // Check the first colour radiobutton
            RbRed.PerformClick();
            // Clear all / uncheck the checkboxes
            CbEggs.Checked = false;
            CbSausages.Checked = false;
            CbStreakyBacon.Checked = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Text", "Heading", MessageBoxButtons..., MessageBoxIcon...)
            // The Show() method for the MessageBox will return an enum: DialogResult, you can
            // query which DialogResult enum member was returned in an if statement.
            if (MessageBox.Show("Are you sure you want to exit?", "Exit?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            
                // If the user presses the Yes button, then exit the application
                Application.Exit();
        }

        private void BtnCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button");
        }

        private void BtnLoopThroughCheckboxes_Click(object sender, EventArgs e)
        {
            TxtResult.Text = String.Empty;

            // Loop thorugh the Controls collection/ list of the Groupbox
            foreach (CheckBox checkBox in GrpLunchOptions.Controls)
            {
                if (checkBox.Checked)
                {
                    TxtResult.Text += checkBox.Text;    
                }
            }
        }

        // This variable price is global and is available to all methods in this class.
        // If you want the price to be available to another method / button, then do make
        // it global but make sure you reset it in each method, e.g. price = 0;
        // If you only need the price inside the CalculatePrice() method, then make sure
        // it is declare inside that method. 
        
        // decimal price = 0;

        private decimal CalculatePrice()
        {
            // Reset the price
            decimal price = 0;

            if (CbSausages.Checked)
                price += .8m; // price = price + 0.8m;
            if (CbStreakyBacon.Checked)
                price += .8m;
            if (CbEggs.Checked)
                price += .8m;

            // Converts the price into a currency string and assigns that to the label
            LblPrice.Text = "Price : " + price.ToString("C");

            // Use the previous line to put a price into the label
            // The next line uses the method String.Format() which take a formatted
            // string, i.e. you can use string interpolation, the same as you have been
            // using for Console.WriteLine();
            // String.Format() will return a formatted string.
            LblPrice.Text = String.Format($"Price: {price:C}");

            return price;
        }

        private void ReceiptText()
        {
            String text = "Your ordered: ";
            String newline = Environment.NewLine;

            if (CbSausages.Checked)
                text += "sausages ";
            if (CbStreakyBacon.Checked)
                text += "streaky bacon ";
            if (CbEggs.Checked)
                text += "eggs ";

            text += newline; // Add a newline before the price is appended on

            // The next line calls the CalculatePrice() method will will return
            // a decimal, the formatter string will convert that decimal into
            // a currency and that gets appended onto the text variable to be
            // displayed in a messagebox on the next line
            text += String.Format($"The price is : {CalculatePrice():C}");

            // Another way to get the price: you can get the price from the label
            text += newline + LblPrice.Text;

            MessageBox.Show(text, "Your receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYourReceipt_Click(object sender, EventArgs e)
        {
            ReceiptText();
        }
    }
}
