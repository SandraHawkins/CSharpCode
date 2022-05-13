using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginDetailsLocalServiceDatabase.LoginDetailsDataSetTableAdapters;
using System.Data.SqlClient;

namespace LoginDetailsLocalServiceDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDetailsDataSet.Logins' table. You can move, or remove it, as needed.
            this.loginsTableAdapter.Fill(this.loginDetailsDataSet.Logins);

        }

        private bool CheckPasswordForLettersAndDigits(String password)
        {
            int numberCount = 0;
            // Between 48 and 57 is 0 to 9
            // Count how many numbers are in the password, if it has at least one
            // number, then the password is okay.
            for (int i = 0; i < password.Length; i++)
            {
                // (int) will cast/ convert each letter into its ASCII equivalent
                int letter = (int)password[i];
                if (letter >= 48 && letter <= 57) // 0 to 9
                {
                    numberCount++;
                }
            }
            // When the loop is finished numberCount will be 0 if no numbers were found
            // Will return false if no numbers were found
            // will return true if any numbers were found
            return numberCount != 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            // Check for empty

            // Check the length, must be between 5 and 16
            if (TxtUsername.Text.Length >= 5 && TxtUsername.Text.Length <= 16)
            {
                // pass the username to the function above
                // If this method returns true, the username contains both letters and
                // numbers
                if (CheckPasswordForLettersAndDigits(TxtPassword.Text))
                {
                    // The password is ok
                    // Correct length, insert into database
                    try
                    {
                        // Call the insert method on the tableAdapter and insert a row
                        // straight into the database (.mdf file) in the Debug folder
                        LoginsTableAdapter tableAdapter = new LoginsTableAdapter();
                        tableAdapter.Insert(TxtUsername.Text, TxtPassword.Text);

                        // Fill the Logins DataTable in the DataSet and the DataGridView on the
                        // form is bound to the dataset
                        tableAdapter.Fill(loginDetailsDataSet.Logins);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("A database error occured");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A exception occured");
                    }
                } else
                {
                    MessageBox.Show("Password must contain letter and numbers");
                }
            } else // 
            {
                MessageBox.Show("Username not the correct length");
                TxtUsername.Focus();
                TxtUsername.SelectAll();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpDialog helpDialog = new HelpDialog();

            if (helpDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The ok button was pressed");
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsername.Text.Length > 8)
            {
                LblWarning.Text = "Username is too large, 8 characters only";
                // Chop off any charcters over 8
               // TxtUsername.Text = TxtUsername.Text.Substring(0, 8);
            } else
            {
                LblWarning.Text = string.Empty;
            }
        }
    }
}
