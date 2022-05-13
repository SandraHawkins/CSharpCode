using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  // File class

namespace TheatreBooking
{
    public partial class SelectPlayFromListbox : Form
    {
        // Declare a list to hold all ThreatreBooking objects
        private List<TheatreBooking> listOfTheatreBookings = new List<TheatreBooking>();

        // Declare a reference to Form1, which will get its value in the constructor
        private Form1 form1;

        /*
         * If the user already saved a seating plan to file, the public property
         * FileName in Form1 will have a value. When the Open menu item is pressed
         * in Form1, the FileName is sent across into the constructor here.
         */
        public SelectPlayFromListbox(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;

            // Calls the PopulateListBox() method underneath and passes the FileName down
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            // If the user already saved a file, the FileName property will have
            // a value, i.e. it won't be null. 
            // If the FileName property is not null, then prepopulate the 
            // openFileDialog with that FileName.
            if (form1.FileName != null)
                openFileDialog1.FileName = form1.FileName;

            // If the user pressed the ok button on the open file dialog        
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog1.FileName;

                    // Load the contents of the file into a string array
                    string[] allLines = File.ReadAllLines(filename);

                    // Send the filename back to the main form
                    form1.FileName = filename;

                    // This loop will jump up in counts of 12, i.e. reading 12
                    // lines from the allLines array at a time.
                    for (int i = 0; i < allLines.Length; i += 12)
                    {
                        // The 1st line from the file will be the show name
                        string showName = allLines[i];

                        // The 2nd line from the file will be the date
                        DateTime date = DateTime.Parse(allLines[i + 1]);

                        // Put the show name and date into the Listbox
                        lstShows.Items.Add(showName + " " + date.ToShortDateString());
                        

                        // The 3rd to 12th lines from the file will be seats
                        char[][] seatsFromFile = new char[10][];

                        // The 3rd to 12th lines from the file will be seats
                        //seatsFromFile[0] = allLines[2].ToCharArray();
                        //seatsFromFile[1] = allLines[3].ToCharArray();
                        //seatsFromFile[2] = allLines[4].ToCharArray();
                        //seatsFromFile[3] = allLines[5].ToCharArray();
                        //seatsFromFile[4] = allLines[6].ToCharArray();
                        //seatsFromFile[5] = allLines[7].ToCharArray();
                        //seatsFromFile[6] = allLines[8].ToCharArray();
                        //seatsFromFile[7] = allLines[9].ToCharArray();
                        //seatsFromFile[8] = allLines[10].ToCharArray();
                        //seatsFromFile[9] = allLines[11].ToCharArray();

                        int lineNum = i + 2;
                        for (int row = 0; row < seatsFromFile.Length; row++, lineNum++)
                        {
                            // Takes the next line from the file (the free/ booked seats)
                            // converts it into a character array and assigns it to the 2D 
                            // char array variable seatsFromFile.
                            seatsFromFile[row] = allLines[lineNum].ToCharArray();
                        }

                        // Instantiate a TheatreBooking and set it's properties
                        // This code is known as an object initialiser block, it is one
                        // statement (i.e. one line of code).
                        TheatreBooking theatreBooking = new TheatreBooking
                        {
                            ShowName = showName,
                            Date = date,
                            Seats = seatsFromFile
                        };

                        // Add it to the global list
                        listOfTheatreBookings.Add(theatreBooking);

                        // The following 4 lines creates a TheatreBooking object and
                        // sets a value to each property.
                        //TheatreBooking t = new TheatreBooking();
                        //t.ShowName = showName;
                        //t.Date = date;
                        //t.Seats = seatsFromFile;

                        // Print out the TheatreBooking object to see if it works so far
                        Console.WriteLine(theatreBooking.ToString());
                    }
                }
                catch // This will catch any file opening / reading exception
                // it will also catch any issues parsing the date.
                {
                    MessageBox.Show("Error opening or reading from file",
                                    "Error reading from file",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Console.WriteLine("The index selected from the listbox " + lstShows.SelectedIndex);
            Console.WriteLine("The current theatre object: " + listOfTheatreBookings[lstShows.SelectedIndex]);


            // Send the index and list over to Form1, these can be assigned to the public
            // properties using the global form1 reference.
            // The index selected from the Listbox will sent across to the Index property in form1
            form1.Index = lstShows.SelectedIndex;
            // The global listOfTheatreBookings which is populated from the contents of the text
            // file will be assigned to the public property in form1.
            form1.ListOfTheatreBookings = listOfTheatreBookings;

            // Call the PopulateForm method in Form1
            form1.PopulateForm();

            // Close this form and removes it from memory
            this.Dispose();
        }
    }
}
