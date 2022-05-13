using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // StreamWriter

namespace TheatreBooking
{
    public partial class NewBooking : Form
    {
        // this global variable will hold the memory address of Form1, it is set in the 
        // constructor below.
        private Form1 mainForm;
       
        /*
         * I have changed this constructor to take in a reference to the main form Form1
         */
        public NewBooking(Form1 form1)
        {
            InitializeComponent();
            // This takes the reference to form1, which was sent in from behind the New menu item,
            // and assigns it to the global variable mainForm. This will enable access to Form1's 
            // public properties, i.e. the FileName, which will be set behind the Save button below.
            mainForm = form1;   
        }

        private void BtnSaveSeatingPlanToFile_Click(object sender, EventArgs e)
        {
            // Check that the show name is not empty
            if (TxtShowName.Text == string.Empty) // if it is empty: message
            {
                MessageBox.Show("Show name cannot be empty", "Error - Empty Show Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Put the cursor in the TxtShowName Textbox
                TxtShowName.Focus();
            }
            else // There is a value for the show name
            {
                // Before showing the dialog on the screen, set it's filename if the global variable
                // currentFilename is not null
                if (mainForm.FileName != null)
                {
                    saveFileDialog1.FileName = mainForm.FileName; 
                }

                // Show the dialog on the screen, 
                // If the user pressed the Save button
                // Then save the theatre booking plan to file
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)  // save button
                {
                    // saveFileDialog1.FileName will return the filename that the user picked/ typed.
                    string filename = saveFileDialog1.FileName;

                    // Assign the filename that was chosen to the public property in Form1, this will enable
                    // the main form to reuse the filename behind the open and save buttons.
                    mainForm.FileName = filename;   

                    // Get the show name from the GUI
                    string showName = TxtShowName.Text;

                    // Get the date from the GUI,
                    // SelectionStart will return a DateTime object that the user picked, I only want
                    // the date and not the time, so calling ToShortDateString(), will return 16/02/2022
                    string date = monthCalendar1.SelectionStart.ToShortDateString(); // 16/02/2022
                    Console.WriteLine("Date : " + date);
                    Console.WriteLine("ToLongDateString() : " + monthCalendar1.SelectionStart.ToLongDateString());
                    Console.WriteLine("ToShortDateString() : " + monthCalendar1.SelectionStart.ToShortDateString());

                    try // try all this file code
                    {
                        // Open a file for appending
                        using (StreamWriter sw = new StreamWriter(path: filename, append: true))
                        {
                            // Write the show name to the file
                            sw.WriteLine(showName);

                            // Write the date to the file
                            sw.WriteLine(date);

                            // Write an empty seating plan to the file, using a loop
                            // Writes out 20 F characters 10 times
                            for (int i = 0; i < 10; i++)
                            {
                                sw.WriteLine("FFFFFFFFFFFFFFFFFFFF");
                            }

                            MessageBox.Show($"Blank seating plan written to file for {showName}",
                                "File created/ appended", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Empty the showname textbox
                            TxtShowName.Text = string.Empty;
                            // Reset to today's date
                            monthCalendar1.SelectionStart = DateTime.Today;

                        } // The StreamWriter object will automatically be closed at the end of the using block
                    } catch // This will catch all 7 exeception (only 1 can happen at once)
                    {
                        MessageBox.Show($"Error creating/ opening {filename}", "File Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // else the user pressed cancel or X, so do nothing
            }
        }
    }
}
