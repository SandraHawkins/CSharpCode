using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracking.BugTrackingDataSetTableAdapters;

namespace BugTracking
{
    public partial class LogBug : Form
    {
        private int customerId;

        public LogBug(Login login, string fullname)
        {
            InitializeComponent();

            // store the customer's id in the global variable
            customerId = login.Id;

            // put the customer's full name into the textbox on the form
            TxtCustomersName.Text = fullname;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CmbProductName.Text == string.Empty || TxtSubject.Text == string.Empty
                || TxtDetails.Text == string.Empty)
            {
                MessageBox.Show("Some fields are empty, please input values");
            } else
            {
                string severity = "";
                if (rbCritical.Checked)
                    severity = "Critical";
                else if (rbLow.Checked)
                    severity = "Low";
                else if (rbMajor.Checked)
                    severity = "Major";
                else if (rbMinor.Checked)
                    severity = "Minor";
                
                if (severity == string.Empty)
                    MessageBox.Show("Please choose a severity level");
                else
                {
                    // insert the bug here
                    // Instantiate the table adapter
                    BugsTableAdapter bugsTableAdapter = new BugsTableAdapter();
                    bugsTableAdapter.Insert(customerId, 0, CmbProductName.Text, TxtSubject.Text, 
                        TxtDetails.Text, severity, "NEW", "");

                    MessageBox.Show("Bug inserted");
                }
            }
        }

        private void BtnGetBugsByID_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(TxtUsersID.Text, out int userId))
            {
                DataTable dataTable = myTableAdapter1.GetDataByUserID(userId);
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row[0]);
                    Console.WriteLine(row[1]);
                    Console.WriteLine(row[2]);
                    Console.WriteLine(row[3]);
                }

            } else // The textbox didn't parse
            {
                MessageBox.Show("Please enter a user's id");
            }
        
            
        }
    }
}
