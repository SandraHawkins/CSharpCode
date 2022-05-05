using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BugTracking.BugTrackingDataSetTableAdapters;
using System.Collections;

namespace BugTracking
{
    public partial class UpdateBug : Form
    {
        public UpdateBug()
        {
            InitializeComponent();
        }

        private void UpdateBug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugTrackingDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.bugTrackingDataSet.Bugs);

            // Instantiate the UserDetailsTableAdapter
            UserDetailsTableAdapter userDetailsTableAdapter = new UserDetailsTableAdapter();
            // Execute the GetProgrammersAndTesters() query which was created in the DataSet under the 
            // userDetailsTableAdapter
            BugTrackingDataSet.UserDetailsDataTable userDetailsTable = 
                userDetailsTableAdapter.GetProgrammersAndTesters();

            // Declare an arraylist to hold each UserDetails object
            ArrayList userList = new ArrayList();

            foreach(DataRow row in userDetailsTable.Rows)
            {
                int id = (int)row["id"];
                string firstName = row["firstName"].ToString();
                string lasttName = row["lastName"].ToString();
                string email = row["email"].ToString();

                // Create a UserDetails object from each row
                //UserDetails user = new UserDetails(id, firstName, lasttName, email);

                // Object initialiser block
                UserDetails user = new UserDetails
                {
                    Id = id,
                    FirstName = firstName,  
                    LastName = lasttName,
                    Email = email
                };

                // Add each UserDetails object to an ArrayList 
                userList.Add(user);
            }

            // When the loop has finished, now I want to bind the ListBox lstAssignedTo to the 
            // ArrayList
            lstAssignedTo.DataSource = userList;
            lstAssignedTo.DisplayMember = "FullName";
            lstAssignedTo.ValueMember = "Id";
            Console.WriteLine("Value member of list box: " + lstAssignedTo.ValueMember);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            Console.WriteLine("row index " + selectedRowIndex);

            // populate the status listbox
            Console.WriteLine("STATUS : " + bugTrackingDataSet.Bugs[selectedRowIndex]["status"]);
            lstStatus.SelectedItem = bugTrackingDataSet.Bugs[selectedRowIndex]["status"];

            // populate the correct radiobutton
            // get the severity level from the datatable in the dataset
            string severity = bugTrackingDataSet.Bugs[selectedRowIndex]["severityLevel"].ToString();
            Console.WriteLine("Severity level : " + severity);

            switch (severity)
            {
                case "Critical":
                    rbCritical.Checked = true;
                    break;
                case "Major":
                    rbMajor.Checked = true;
                    break;
                case "Minor":
                    rbMinor.Checked = true;
                    break;
                case "Low":
                    rbLow.Checked = true;
                    break;
                default:
                    MessageBox.Show("Severity level not set");
                    break;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Get the bug id from the dataGrid
            // Get the current row from the datagrid, which corresponds to the datatable in the dataset
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
           
            // Get the bug id from the Bugs datatable in the dataset
            int id = (int)bugTrackingDataSet.Bugs[selectedRowIndex]["id"];

            try
            {
                // To get the programmers id from the listbox, in the form load event, the listbox
                // has it's ValueMember property set to the 'Id' property of each UserDetails object
                // in the ArrayList, to retrieve that (When I click on 'Fred Jones' in the listBox, I 
                // can retrieve Fred's id of 12 using the listbox's SelecteValue property).
                int currentProgrammersId = int.Parse(lstAssignedTo.SelectedValue.ToString());

                bugsTableAdapter.UpdateQuery(currentProgrammersId, lstStatus.SelectedItem.ToString(), TxtActionTaken.Text, id);

                // Refill the datagrid, refilling the dataset - bug datatable
                // NOTE: the following line crashes the program, need to fix this.
               // bugsTableAdapter.Fill(bugTrackingDataSet.Bugs);

                MessageBox.Show("Update successful");
            } catch (SqlException ex)
            {
                Console.WriteLine("Error updating the database " + ex);
            }
        }

        private void lstAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Display member: " + lstAssignedTo.DisplayMember);
            Console.WriteLine("Value member: " + lstAssignedTo.ValueMember);
        }
    }
}
