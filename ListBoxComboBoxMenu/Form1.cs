using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComboBoxMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCenterAMessageBox_Click(object sender, EventArgs e)
        {
            // Instantiate or create an instance of MyDialog
            MyDialog myDialog = new MyDialog();
            
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                TxtOutputFromListbox.Text = "OK was pressed on the dialog";
            } else
            {
                TxtOutputFromListbox.Text = "The cancel button was pressed";
            }
        }

        private void BtnGetSelectedItems_Click(object sender, EventArgs e)
        {
            // If you have your Listbox with the SelectionMode property set
            // to MultiSelect, you can loop through all of the items selected
            // using a foreach loop and getting the SelectedItems property of 
            // the list box. 
            foreach (var item in LstDaysOfWeek.SelectedItems)
            {
                Console.WriteLine(item);
            }
        }

        /**
         * This event will fire every time the user clicks on something in the listbox
         */
        private void LstDaysOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtOutputFromListbox.Text = String.Empty;

            // This loops through the collection of strings selected in the listbox
            // and appends each string/ day of the week into the Textbox
            foreach (var item in LstDaysOfWeek.SelectedItems)
            {
                TxtOutputFromListbox.Text += item + Environment.NewLine;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // This will take the text from the ComboBox that the user either
            // typed or selected from the ComboBox and add it to the list of
            // items

            // Don't add an empty string or don't add something already in the list
            if (CmbItems.Text != string.Empty && !CmbItems.Items.Contains(CmbItems.Text))
            {
                CmbItems.Items.Add(CmbItems.Text);
                // When you hit the down array, this will select the new item just added
                CmbItems.SelectedItem = CmbItems.Text;  
                // Highlight the text in Textbox, this means you don't have to click
                // the mouse to start typing in the textbox
                CmbItems.Focus();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Will take the text from the ComboBox, that text was either typed
            // or selected from the list, and removes it from the list
            CmbItems.Items.Remove(CmbItems.Text);

            // Clear the textbox when the list is empty
            if (CmbItems.Items.Count == 0)
            {
                CmbItems.Text = string.Empty;
            }
            else
            // When there is at least one item in the list, then select the 1st one
            {
                // Select the first item in the list
                CmbItems.SelectedIndex = 0;
                // Highlights the text of the first item
                CmbItems.Focus();
            }
        }

        /*
         * In the keydown event, the 2nd paramter is a KeyEventArgs and you can
         * use this parameter to query the KeyCode property to check which key
         * was pressed on the keyboard.
         */
        private void CmbItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Press the Add button
                BtnAdd.PerformClick();
            }
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            // Remove all items from the list part
            CmbItems.Items.Clear();
            // Clear the text in the text part
            CmbItems.Text = string.Empty;
        }

        /**
         * You can use a DateTimePicker to 
         */
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // You can use .Value or .Text on a DateTimePicker to get the date
            // selected by the user. It will return the current time. You can change 
            // the format of the returned value, see below.
            // .Value() returns a DateTime object and that could easily be inserted 
            // into a database. 
            // .Text return a string
            // .Value() returns a DateTime object, call toString() on it to put
            // the value into a label's text.
            LblDateTime.Text = dateTimePicker1.Value.ToString();

            // How to change the format of the DateTime selected by the user:
            Console.WriteLine(dateTimePicker1.Value.ToShortDateString());   // 31 / 01 / 2022
            Console.WriteLine(dateTimePicker1.Value.ToShortTimeString());   // 13:49
            Console.WriteLine(dateTimePicker1.Value.ToLongDateString());    // Monday 31 January 2022
            Console.WriteLine(dateTimePicker1.Value.ToLongTimeString());    // 13:49:02
        }

        /*
         * When you add a MonthCalender to the form, by default you can select
         * up to 7 days at once, you can change this to a single day by settting 
         * the property MaxSelectionCount to 1. Then in the Date_Changed event
         * you can use the code:
         *          monthCalendar1.SelectionStart 
         * to get the date chosen by the user, it will be a DateTime type.
         */
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LblDateTime.Text = monthCalendar1.SelectionStart.ToString();  
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
