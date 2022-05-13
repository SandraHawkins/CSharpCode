using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheatreBooking
{
    public partial class Form1 : Form
    {
        // This bool will be set to true in the AnyTextBoxClicked Event and when the Exit
        // menuItem is pressed, we will check to see if this bool is true, and if it is,
        // ask the user if they want to save any changes. 
        // When the save button is pressed, reset this variable to false.
        private bool hasChanged = false;    


        // All the textboxes will be in a 2D array
        private TextBox[][] textboxArray;

        /*
         * FileName is a string, it is a public property, which means the NewBooking form will be able
         * to assign a value to the FileName property. For this to happen, this form need to sends across 
         * a reference to itself, it will do this by passing the 'this' reference into the constructor of 
         * the NewBooking form when it instantiates it behind the File -> New menu item. 
         */
        public string FileName { set; get; }

        // This property will hold the index that corresponds to the show selected in the listBox on 
        // the SelectPlayFromListBox form, it will also correspond to the matching ThreatreBooking in the
        // List underneath
        public int Index { set; get; }

        // This list will hold all theatre booking from the file, I am passing the full list to the main
        // form, so that it can be used to save all the bookings back to file. 
        public List<TheatreBooking> ListOfTheatreBookings { set; get; }


        public Form1()
        {
            InitializeComponent();

            //                       [10][20]
            textboxArray = new TextBox[][]
            {
                new TextBox[] { Textbox1_1, Textbox1_2, Textbox1_3, Textbox1_4, Textbox1_5, 
                                Textbox1_6, Textbox1_7, Textbox1_8, Textbox1_9, Textbox1_10,
                                Textbox1_11, Textbox1_12, Textbox1_13, Textbox1_14, Textbox1_15,
                                Textbox1_16, Textbox1_17, Textbox1_18, Textbox1_19, Textbox1_20},
                new TextBox[] { Textbox2_1, Textbox2_2, Textbox2_3, Textbox2_4, Textbox2_5,
                                Textbox2_6, Textbox2_7, Textbox2_8, Textbox2_9, Textbox2_10,
                                Textbox2_11, Textbox2_12, Textbox2_13, Textbox2_14, Textbox2_15,
                                Textbox2_16, Textbox2_17, Textbox2_18, Textbox2_19, Textbox2_20 },
                new TextBox[] { Textbox3_1, Textbox3_2, Textbox3_3, Textbox3_4, Textbox3_5,
                                Textbox3_6, Textbox3_7, Textbox3_8, Textbox3_9, Textbox3_10,
                                Textbox3_11, Textbox3_12, Textbox3_13, Textbox3_14, Textbox3_15,
                                Textbox3_16, Textbox3_17, Textbox3_18, Textbox3_19, Textbox3_20 }
            };
        }

        /*
         * This method will get the current TheatreBooking object from the list and use it to
         * populate the Heading/ label on the form and which seats are booked/ free.
         */
        public void PopulateForm()
        {
            // Get the current TheatreBooking object, I have a public property of a list of all the 
            // TheatreBooking objects and I have a public property of the index (play chosen by 
            // the user).
            TheatreBooking theatreBooking = ListOfTheatreBookings[Index];

            Console.WriteLine("In Form1, the current booking object is : " + theatreBooking);

            // Populate the label with the show name and date
            lblHeading.Text = theatreBooking.ShowName + " " + theatreBooking.Date.ToShortDateString();

            // Loop through the 2D array of Seats and populate the corresponding textboxes on the form
            // Any seat's that are 'S' should have a red background 
            // I have only included three rows of seats in the 2D array to keep to me sane.
            for(int row = 0; row < 3; row++)   // i < theatreBooking.Seats.Length
            {
                // A single dimensional array for the current row of seats
                // E.g. FFFFFSSSSSSSSFFFFFFF
                char[] seats = theatreBooking.Seats[row];

                for (int seat = 0; seat < seats.Length; seat++)
                {
                    Console.WriteLine(seats[seat]);

                    if (seats[seat].Equals('S')) 
                    {
                        textboxArray[row][seat].Text = "S";
                        // And the backgroud to red
                        textboxArray[row][seat].BackColor = Color.Red;
                    } else
                    {
                        textboxArray[row][seat].Text = (seat + 1).ToString();
                        textboxArray[row][seat].BackColor = Color.White;
                    }
                }
                Console.WriteLine();
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            // If the hasChanged bool is set to true, ask the user if they want to save
            if (hasChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Click the save MenuItem
                    MnuFileSave.PerformClick();
                    // And Exit
                    Application.Exit();

                } else if (result == DialogResult.No)
                {
                    Application.Exit();
                } else // Cancel
                {
                    // do nothing (message box will close)
                }
            } else // No changes were made
            {
                Application.Exit();
            }
        }

        private void MnuFileNew_Click(object sender, EventArgs e)
        {
            // This creates a new instance of the NewBooking form and shows it 
            // on the screen - one liner. 
            //new NewBooking().Show();

            // Two lines instead of that one liner
            // This creates a new instance of the NewBooking form
            // The code NewBooking(this) is calling het NewBooking construtor and sending in the 'this' 
            // reference, which is a reference to where this Form1 exists in memory, this will allow the
            // NewBooking form to access any public properties of this Form1.
            // The second arguement being passed is the lasest filename chosen by the user.
            NewBooking newBooking = new NewBooking(this);
            // Shows the form on the screen
            newBooking.Show();  

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This will click the menuItem in the File menu
            MnuFileNew.PerformClick();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MnuFileOpen.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MnuFileSave.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MnuFileExit.PerformClick();
        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            // This form is passing across a 'this' reference to the SelectPlayFromListbox form, 
            // it is sending across the memory address of this Form1, which means the SelectPlayFromListbox form
            // will be able to access the public properties that are declared here: FileName, Index,
            // ListOfTheatreBookings
            new SelectPlayFromListbox(this).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /*
         * This event handles 60 Textboxes (first 3 rows), when the text is 'S'
         * the background will change to white and back to the seat number.
         */
        private void AnyTextBoxClicked(object sender, EventArgs e)
        {
            // Check to make sure there are TheatreBooking objects in the list:
            // If the list has not yet been instantiated/ created and objects added to it,
            // the list will be null, here is a check to see if the list is null, then tell the 
            // user to load it from the file.
            if (ListOfTheatreBookings == null)
            {
                MessageBox.Show("List is empty, please load from file", "Empty list",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Set the hasChanged bool to true, this will be evaluated in the Exit
                // menuItem to see if there needs to be a prompt to ask the user if they
                // want to save any changes
                hasChanged = true;

                // Downcast the sender reference from an object (parent type) into a 
                // TextBox (child type) so that I can access TextBox properties, e.g. 
                // .Text .Name .BackColor
                //TextBox textBox = (TextBox)sender;  // C# and Java
                TextBox textBox = sender as TextBox;  // C#
                Console.WriteLine("This textbox was clicked " + textBox.Name);


                // Get the number from the Textbox's name
                //               01234567890
                // Textbox name: Textbox3_18, substring will return 18
                String textboxNumber = textBox.Name.Substring(9);  // 18
                                                                   // "3" parsed to an int and subtract 1 to make it zero based.
                int rowNum = int.Parse(textBox.Name.Substring(7, 1)) - 1;   // zero based row number
                int seatNum = int.Parse(textboxNumber) - 1;                 // zero based seat number

                // Only change the appearance of the Textbox if the Text is 'S'
                if (textBox.Text.Equals("S"))
                {
                    // Assign that number to text property
                    textBox.Text = textboxNumber;

                    // Changing the Backcolour to white
                    textBox.BackColor = Color.White;

                    // Update the 2D char array in the current booking object to 'S' for a sold seat
                    ListOfTheatreBookings[Index].Seats[rowNum][seatNum] = 'F';
                }
                else
                {
                    // Change the text to 'S'
                    textBox.Text = "S";

                    // Change the background to red
                    textBox.BackColor = Color.Red;

                    // Update the 2D char array in the current booking object to 'F' for an unsold seat
                    ListOfTheatreBookings[Index].Seats[rowNum][seatNum] = 'S';
                }
                Console.WriteLine($"Row number: {rowNum}, Seat Num: {seatNum}");
                Console.WriteLine($"2D Seat array: {ListOfTheatreBookings[Index].Seats[rowNum][seatNum]}");
            }
        }

        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            // reset the hasChanged variable
            hasChanged = false;

            // Update the current TheatreBooking object with the new sold seat (see which
            // textboxes are displaying 'S'.

            // You get the current TheatreBooking object from the list: ListOfTheatreBookings
            // the current one we are using is stored in Index
            TheatreBooking currentBooking = ListOfTheatreBookings[Index];

            Console.WriteLine("Booking object before saving: \n" + currentBooking.ToString());
            Console.WriteLine("Filename: " + FileName);

            try
            {
                // Open the file in overwrite mode
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    // loop through the list of Theatre Booking object
                    foreach (TheatreBooking tb in ListOfTheatreBookings)
                    {
                        // Write each object to file (use the toString())
                        sw.Write(tb);  // tb, this will implicitly call the toString() on tb
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error writing to file", "File error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }

            // Update the Seats 2D array in the currentBooking object to reflect the state of the form.
            // Loop through the Textbox 2D array
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int seat = 0; seat < currentBooking.Seats[row].Length; seat++)
            //    {
            //        // Check the textbox on the form to see if it's 'S'
            //        // If the textbox on the form displays 'S', make the 2D char array hold a 'S'
            //        if (textboxArray[row][seat].Text.Equals("S"))
            //        {
            //            currentBooking.Seats[row][seat] = 'S';
            //        } else // the textbox is a number, therefore update the 2D seat array to a 'F'
            //        {
            //            currentBooking.Seats[row][seat] = 'F';
            //        }
            //    }
            //}

            //Console.WriteLine("Updated before saving: \n" + currentBooking);

            // Loop through the whole list of Booking objects and save each one to file.

            // You can use the TheatreBooking's toString() method to return a string perfectly
            // formatted to write that out to file. 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Declare a font for the heading on the page
            Font fntHeading = new Font("Garmond", 24, FontStyle.Bold);

            //                    Text             Font        Brush colour      x    y
            e.Graphics.DrawString(lblHeading.Text, fntHeading, Brushes.DarkBlue, 100, 50);

            
        }

        private void mnuFilePrintPreview_Click(object sender, EventArgs e)
        {
            // Set the Document property of the print preview dialog to printDocument1
            // When you show the print preview dialog, it will preview the printDocument1
            // and the code written in the PrintPage event for printDocument1 will execute
            // when you show this dialog.
            printPreviewDialog1.Document = printDocument1;

            // Shows the dialog.
            printPreviewDialog1.ShowDialog();
        }

        private void mnuFilePageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();  
        }

        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
              
            // Check that the user clicks the print button before calling the print() 
            // method on the printDocument1
            if (printDialog1.ShowDialog() == DialogResult.OK) // User clicked Print
            {
                // Send the printDocument1 to the printer and it will call the 
                // printDocument1_PrintPage() to see what should be sent to the printer
                printDocument1.Print();
            }
        }

        private void BtnPrintAllTickets_Click(object sender, EventArgs e)
        {
            // Click the Print... menu item
            mnuFilePrint.PerformClick();
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            // Click the Exit menu Item
            MnuFileExit.PerformClick();
        }
    }
}
