using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for the table adpaters
using BugTracking.BugTrackingDataSetTableAdapters;

namespace BugTracking
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            // Select the first role in the listbox
            LstRole.SelectedIndex = 0;
        }

        private void BtnRegisterUser_Click(object sender, EventArgs e)
        {
            // Instantiate the loginAdapter
            LoginTableAdapter loginTableAdapter = new LoginTableAdapter();    

            // Calling the generated Insert statement
            loginTableAdapter.Insert(TxtUsername.Text, TxtPassword.Text, LstRole.Text);

            // Calls another query to get the new Id, so that it can be used for the next
            // insert
            int id = (int)loginTableAdapter.GetMaxId();

            // Instantiate the userDetailsAdapter
            UserDetailsTableAdapter userDetailsTableAdapter = new UserDetailsTableAdapter();

            // Insert a row into the userDetails table
            userDetailsTableAdapter.Insert(id, TxtFirstname.Text, TxtLastname.Text, TxtEmail.Text);

            MessageBox.Show("Inserted, id : " + id);

            // Clear the form
            ClearAllFormControls();
        }

        /*
         * Clear all textboxes and reset the listbox
         */
        private void ClearAllFormControls()
        {
            // Loop through all controls on this form
            // If you change Control to var - it's type would only be decided at runtim
            // and therefore I couldn't call .Text on it. 
            foreach (Control control in this.Controls)
            {
                // If the control is a textbox
                if (control is TextBox)
                {
                    // Clear the text
                    control.Text = string.Empty;
                }
            }

            // Reset the listbox
            LstRole.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllFormControls();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Instantiate the loginTableAdapter
            LoginTableAdapter loginTableAdapter = new LoginTableAdapter();
            UserDetailsTableAdapter userDetailsTableAdapter = new UserDetailsTableAdapter();

            // Call the query GetLoginDetailsByUsernameAndPassword()
            // This query returns a DataTable
            BugTrackingDataSet.LoginDataTable loginTable =
                loginTableAdapter.GetLoginDetailsByUsernameAndPassword(
                    TxtUsername.Text, TxtPassword.Text);

            int numRows = loginTable.Rows.Count;
            Console.WriteLine("num of rows: " + loginTable.Rows.Count);

            // If the datatable contains one row, sucessful login
            // If the datatable is empty - login failed
            if (numRows == 1)
            {
                // Assigns the first row in the datatable to row
                DataRow row = loginTable.Rows[0];
                int id = (int)row["id"];
                string username = row["username"].ToString();  
                string password = row["password"].ToString();
                string role = row["role"].ToString();

                // Turn all that info into a Login objec using the contructor in the Login class
                // This is an object initialisation block.
                Login login = new Login()
                {
                    Id = id,
                    Username = username,
                    Password = password,
                    Role = role
                };

                Console.WriteLine("Login: " + login); // call login.ToString();

                // Open up the LogBug form and pass across the login object,
                // only do this for the Customer
                switch (role)
                {
                    case "Customer":
                        // Call the query in the UserDetails table to get the customers
                        // full name
                        String fullname = userDetailsTableAdapter.GetFullNameById(id);

                        // If the role is 'customer', open the LogBug screen and pass
                        // across the Login details
                        new LogBug(login, fullname).Show();
                        break;
                    case "Programmer":
                    case "Tester":
                        new UpdateBug().Show();
                        break;
                    default:
                        MessageBox.Show("Role was invalid");
                        break;
                }
            } else if (numRows == 0)
            {
                MessageBox.Show("Login incorrect");
            } else // numRows > 1
            {
                MessageBox.Show("Did you allow more than one username the same?");
            }           
        }
    }
}
