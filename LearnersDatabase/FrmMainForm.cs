using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;   // LearnerDAO
using model;        // Learner
using System.Globalization;
using System.Data.SqlClient; // SQLException

namespace view
{
    public partial class FrmMainForm : Form
    {
        // Global variables/ fields

        // Reference to the LearnerDAO class so I can access the select, insert, 
        // update methods, etc. 
        private LearnerDAO dao = new LearnerDAO();

        // A global List reference to hold the Learners coming from the database
        private List<Learner> listOfLearners;

        // A global variable for the current Learner to display from the list
        private int currentLearner;  // default value of 0

        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectAllLearners();
        }

        private void SelectAllLearners()
        {
            // The GetAllLearners in the DAO class will return a list of Learner object,
            // make sure you assign this method call to the global list reference
            listOfLearners = dao.GetAllLearners(out bool success);

            if (success)
            {
                PopulateGUI();
            }
            else
            {
                MessageBox.Show("Error connecting to/ reading from the database", "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // If the currentLearner is less than the number of items in the list minus 1, 
            // then one can be subtracted from the currentLearner.
            if (currentLearner < listOfLearners.Count - 1)
                currentLearner++;

            PopulateGUI();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentLearner > 0)
                currentLearner--;

            PopulateGUI();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            currentLearner = 0;
            PopulateGUI();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            currentLearner = listOfLearners.Count - 1;
            PopulateGUI();
        }

        private void PopulateGUI()
        {
            // Check that the list isn't empty
            if (listOfLearners.Count == 0)
            {
                MessageBox.Show("No records to display");
                BtnClearForm.PerformClick();
            }
            else
            {
                // Get the current learner from the list
                Learner learner = listOfLearners[currentLearner];

                // Populate the form
                TxtId.Text = learner.Id.ToString();
                TxtName.Text = learner.Name;
                TxtAddress.Text = learner.Address;
                // .Value take a DateTime object, which the DateOfBirth is in the Learner class
                DtpDateOfBirth.Value = learner.DateOfBirth;
                TxtRegFee.Text = learner.RegistrationFee.ToString("C"); // Currency
                // .Checked is a bool and learner.IsEnrolled is a bool
                CbEnrolled.Checked = learner.IsEnrolled;

                // Update the textbox with the number of records to say: 1 of 6
                TxtRecordNumber.Text = String.Format(
                    $"Record {currentLearner + 1} of {listOfLearners.Count}");
            }
        }

        private void BtnInsertLearner_Click(object sender, EventArgs e)
        {
            // Check all fields have values, i.e. that no textboxes are empty
            //if (!(TxtName.Text.Equals(String.Empty)) && 
            //    !(TxtAddress.Text.Equals(String.Empty)) && 
            //    !(TxtRegFee.Text.Equals(String.Empty)))
            //{

            //} else
            //{
            //    MessageBox.Show("Textboxes cannot be empty");
            //}

            // Checks if any textboxes are empty
            String message = "";
            if (TxtName.Text.Equals(String.Empty))
                message = "Name cannot be empty";
            if (TxtAddress.Text.Equals(string.Empty))
                message += "\nAddress cannot be empty";
            if (DtpDateOfBirth.Value.Year > 2004)
                message += "\nLearner must be over 18";
            // The Registration Fee is displayed on the form as a currency
            // TryParse returns a bool of its success. This code checks if it did not
            // parse, then add to the message variable
            if (!Decimal.TryParse(TxtRegFee.Text, NumberStyles.Currency,
                CultureInfo.CurrentCulture.NumberFormat, out decimal outputPrice))
            {
                message += "\nThe registration fee could not be parsed";
            }

            // If the message variable is not empty, then display an error message
            if (!message.Equals(string.Empty))
            {
                MessageBox.Show(message, "Empty textboxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Are values are okay, continue to create a learner
            {
                // If all textboxes have a value, read all the values into a learner object
                Learner learner = new Learner
                {
                    Name = TxtName.Text,
                    Address = TxtAddress.Text,
                    DateOfBirth = DtpDateOfBirth.Value,
                    RegistrationFee = outputPrice,
                    IsEnrolled = CbEnrolled.Checked
                };

                // Call the insertLearner method in the DAO class and pass in that learner object
                if (dao.InsertLearner(learner))  // == true
                {
                    // Call the code to select everything from the database
                    SelectAllLearners();
                    //MessageBox.Show($"{TxtName.Text} was successfully inserted.");
                    // Click the last record button
                    BtnLast.PerformClick();
                }
                else
                    MessageBox.Show("Error inserting into the database");
            }
        }

        private void BtnClearForm_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtId.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtRegFee.Text = string.Empty;
            DtpDateOfBirth.Value = DateTime.Today;
            CbEnrolled.Checked = false;
            // Reset the record number
            TxtRecordNumber.Text = "Record 0 of 0";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUpdateLearner_Click(object sender, EventArgs e)
        {
            Console.WriteLine("In BtnUpdateLearner_Click");
            // If you want, check for any empty fields

            // The Registration Fee is displayed on the form as a currency
            // TryParse returns a bool of its success. This code checks if it did not
            // parse, then add to the message variable
            if (!Decimal.TryParse(TxtRegFee.Text, NumberStyles.Currency,
                CultureInfo.CurrentCulture.NumberFormat, out decimal outputPrice))
            {
                MessageBox.Show("The registration fee could not be parsed");
                TxtRegFee.Focus();      // Click the mouse in the textbox
                TxtRegFee.SelectAll();  // Select the text
            }
            else
            {
                // Get all 6 values from all textboxes/ checkbox including the id
                // If all textboxes have a value, read all the values into a learner object
                // Create a Learner object from all 6 pieces of data
                Learner learner = new Learner
                {
                    // make sure you retrieve the ID from the GUI for an update
                    Id = int.Parse(TxtId.Text),
                    Name = TxtName.Text,
                    Address = TxtAddress.Text,
                    DateOfBirth = DtpDateOfBirth.Value,
                    RegistrationFee = outputPrice,
                    IsEnrolled = CbEnrolled.Checked
                };

                Console.WriteLine("Learner before update: " + learner);

                // Send that learner object to the UpdateLearner method in the DAO class
                bool success = dao.UpdateLearner(learner);

                // Check was it successful (the method will return a bool)
                // Tell the user the update was successful
                if (success)
                {
                    MessageBox.Show("Update successful");
                    // Update the form
                    // 1. Update the current learner in the list       
                    // The 'old' learner is in the 
                    // The 'new/ updated' learner is in a learner object
                    //Learner oldLearner = listOfLearners[currentLearner];
                    //oldLearner.Id = learner.Id;
                    //oldLearner.Address = learner.Address;
                    //oldLearner.RegistrationFee = learner.RegistrationFee;
                    //oldLearner.Name = learner.Name;
                    //oldLearner.DateOfBirth = learner.DateOfBirth;
                    //oldLearner.IsEnrolled = learner.IsEnrolled;

                    // Either use the previous 7 lines to update the learer in the list
                    // or use the following code to remove the 'old' learner and add
                    // the new updated learner into the list at the same position.
                    listOfLearners.RemoveAt(currentLearner);
                    listOfLearners.Insert(currentLearner, learner);
                    
                    // Update the GUI with the learner at the current position
                    PopulateGUI();

                    // 2. Select everything from the database
                    listOfLearners = dao.GetAllLearners(out bool result);
                    if (result)
                        PopulateGUI();
                    else
                        MessageBox.Show("Select from database unsuccessful");
                }
                else
                {
                    MessageBox.Show("Update didn't work");
                }
            }
        }

        private void BtnDeleteLearner_Click(object sender, EventArgs e)
        {
            // Get the id from the ID Textbox and send it to the DeleteLearner method
            // in the DAO class.
            int id = int.Parse(TxtId.Text);

            bool success = dao.DeleteLearner(id);

            // Check that it was successful, the method will return a bool
            if (success)
            {
                // You can do one of two things, either:
                // 1. Delete the current learner from the list and move the record on one (next button) 
                listOfLearners.RemoveAt(currentLearner);

                // If I remove the last learner from the list, check for that 
                if (currentLearner >= listOfLearners.Count - 1)
                    BtnLast.PerformClick();
                else 
                    PopulateGUI();
                
                // 2. Select all learners from the database, say you deleted the 4th learners, then
                //    the 5th one should display on the form.
                //listOfLearners = dao.GetAllLearners(out bool result);
                //if (result == true)
                //{
                //    currentLearner = 0;
                //    PopulateGUI();
                //} else
                //{
                //    MessageBox.Show("Selecting learers failed");
                //}
            }
            else
            {
                MessageBox.Show("Delete was unsuccessful");
            }
        }

        /*
         * The cancel button will undo any changes that were made, say you were
         * in the middle of an update and want to undo any changes you made.
         */
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PopulateGUI();
        }

        private void BtnOpenSearchForm_Click(object sender, EventArgs e)
        {
            new FrmSearch().Show();
        }

        /* This method will print out the contents of all Learners. It will call the 
         * GetAllLearners() in the DAO class, which returns a list. We can loop through
         * the list and print the contents of each property from each learner in the list.
         * 
                    XXXXXXXX
         */
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        /*
         * Print layout:
         *                     All Learners
         * 
         * Id  Name            Address         Date of Birth   Reg Fee     Enrolled 
         * 99  XXXXXXXXXXX     XXXXXXXXXXXX    99/99/9999      €9999.99    XXX    
         *                     XXXXXXXX
         *                     
         * 99  XXXXXXXXXXX     XXXXXXXXXXXX    99/99/9999      €9999.99    XXX    
         */
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fntMainHeading = new Font("Garmond", 20, FontStyle.Bold ^ FontStyle.Italic);
            Font fntSubHeading = new Font("Garmond", 16, FontStyle.Italic);
            Font fntRegular = new Font("Times New Roman", 12, FontStyle.Regular);

            int x = 50;

            int col1 = x;
            int col2 = x += 50;
            int col3 = x += 120;
            int col4 = x += 150;
            int col5 = x += 150;
            int col6 = x += 120;

            e.Graphics.DrawString("All Learners", fntMainHeading, Brushes.DarkBlue, 300, 100);

            e.Graphics.DrawString("Id", fntSubHeading, Brushes.DarkBlue, col1, 150);
            e.Graphics.DrawString("Name", fntSubHeading, Brushes.DarkBlue, col2, 150);
            e.Graphics.DrawString("Address", fntSubHeading, Brushes.DarkBlue, col3, 150);
            e.Graphics.DrawString("Date of Birth", fntSubHeading, Brushes.DarkBlue, col4, 150);
            e.Graphics.DrawString("Reg Fee", fntSubHeading, Brushes.DarkBlue, col5, 150);
            e.Graphics.DrawString("Enrolled", fntSubHeading, Brushes.DarkBlue, col6, 150);

            // Get the list of learners from the DAO class, assign it to a List<Learner> refernece
            List<Learner> listOfLearners = dao.GetAllLearners(out bool success);

            if (success) // If the list of learners could be retrieved from the database
            {
                // Declare a y coordinate for each row
                int y = 200;

                // Loop through the list - foreach loop
                // Retrieve the current learner object from the list (learner is a reference that
                // will refer to each Learner object in the list as it loops)
                foreach (Learner learner in listOfLearners)
                {
                    // Print out each property from the learner object
                    //  e.Graphics.DrawString( learner.ID, .....)
                    e.Graphics.DrawString(learner.Id.ToString(), fntRegular, Brushes.Black, col1, y);
                    e.Graphics.DrawString(learner.Name, fntRegular, Brushes.Black, col2, y);
                    e.Graphics.DrawString(learner.Address, fntRegular, Brushes.Black, col3, y);
                    e.Graphics.DrawString(learner.DateOfBirth.ToShortDateString(), fntRegular, Brushes.Black, col4, y);
                    e.Graphics.DrawString(learner.RegistrationFee.ToString("C"), fntRegular, Brushes.Black, col5, y);
                    // ternary operator: if (learner.IsEnrolled == true), "Yes" is printed, otherwise
                    // "No" is printed
                    e.Graphics.DrawString(learner.IsEnrolled ? "Yes" : "No", fntRegular, Brushes.Black, col6, y);

                    // increment the y coordinate to move to the next row
                    y += 100;
                }
            }else
            {
                MessageBox.Show("Error selecting from database");
            }
        }
    }
}
