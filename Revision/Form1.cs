using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //double num1;

            if (Double.TryParse(TxtOne.Text, out double num1))
            {
                if (Double.TryParse(TxtTwo.Text, out double num2))
                {
                    double result = num1 + num2;
                    LblResult.Text = result.ToString();
                }
                else // TxtTwo could not be parsed
                {
                    MessageBox.Show("Please enter a valid number");
                    TxtTwo.Focus();
                    TxtTwo.SelectAll();
                }
            }
            else // TxtOne could not be parsed
            {
                MessageBox.Show("Please enter a valid number");
                TxtOne.Focus();
                TxtOne.SelectAll();
            }
        }

        private void LstDaysOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The following line will work when you can only select one item from the list,
            // i.e. SelectionMode for the ListBox is set to One

            //TxtDayOfWeekSelected.Text += LstDaysOfWeek.SelectedItem.ToString() + Environment.NewLine;

            // Clear the textbox first
            TxtDayOfWeekSelected.Text = String.Empty;

            // The following code will work when you can select multiple items from the list,
            // i.e. SelectionMode for the ListBox is set to MultiExtended
            foreach (var item in LstDaysOfWeek.SelectedItems)
            {
                // add item to the multiline textbox
                TxtDayOfWeekSelected.Text += item + Environment.NewLine;
            }
        }

        /*
         * The 1st parameter - object sender is the control that caused this event to happen
         * i.e. it will be one of the RadioButtons, you can cast this object into a RadioButton
         * and use it to access one of the RadioButton's properties, i.e. the Text property.
         * The code below will get the Text property from the RadioButton and put it into
         * the Textbox.
         */
        private void ARadioButtonWasChecked(object sender, EventArgs e)
        {
            // The following code could be written behind a button to see which
            // radiobutton was selected.

            //if (RbPersonal.Checked)
            //    TxtDayOfWeekSelected.Text = "Personal was checked";
            //else if (RbSmall.Checked)
            //    TxtDayOfWeekSelected.Text = "Small was checked";
            //else if (RbMedium.Checked)
            //    TxtDayOfWeekSelected.Text = "Medium was checked";
            //else // if (RbLarge.Checked)
            //    TxtDayOfWeekSelected.Text = "Large was checked";

           RadioButton rb = (RadioButton)sender;
           // Gets the text from the Radiobutton that was checked and assigns it
           // to the text of the Textbox.
           TxtDayOfWeekSelected.Text = rb.Text;
        }
    }
}
