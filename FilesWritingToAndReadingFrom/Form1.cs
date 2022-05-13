using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  // this must be added for using StreamWriter and File

namespace FilesWritingToAndReadingFrom
{
    public partial class Form1 : Form
    {
        // Global variables section
        // This path will save the file in the main directory of your project, if you leave
        // out the ../../ the file would be created in the debug/bin folder, which is the same
        // location as the .exe file of this project.
        private string filename = "../../textFile.txt";

        // A file to store the id 
        private string currentIdFileName = "CurrentId.txt";

        // A file to store the products
        private string productsFile = "../../products.txt";

        // This variable currentId will be assigned to each new product and
        // incremented behind the button that saves a product to file.
        // It starts at 1, so the first product will have an id of 1.
        private int currentId = 1;

        // This will hold all the products loaded from the file
        private string[] allProducts;

        // This is the current position in the array, it will default to = 0;
        private int arrayPosition;

        // The constructor will execute just before the form loads onto the screen. 
        // Here I want to retrieve the currentId from the file CurrentId.txt
        public Form1()
        {
            InitializeComponent();

            GetIdFromFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the products into the array and display them:
            BtnLoadProductFromFile.PerformClick();
        }

        private void GetIdFromFile()
        {
            // Firstly check that the file CurrentId.txt exists before attempting
            // to read from it. This line is required to prevent the program for
            // throwing a FileNotFoundException the first time it executes.
            if (File.Exists(currentIdFileName))
            {
                // Read the contents of the file. ReadAllText returns a string. 
                // Below we have File.ReadAllLines which returns a String array.
                string lineFromFile = File.ReadAllText(currentIdFileName);
                // Convert the string into an int and assign it to the currentId
                // TryParse() attemps to covert a string (1st parameter) into an
                // int and stores the result in the out parameter currentId. This
                // method will also return it's success, i.e. true or false
                if (int.TryParse(lineFromFile, out currentId) == false)
                {
                    Console.WriteLine("The current id from file is " + lineFromFile);
                    MessageBox.Show("Error converting id from file into an int");
                }
            }
            // otherwise this might be the first time that the application runs,
            // therefore the file will be created when the application closes, and
            // the currentId will have a value of 1. 
        }

        private void BtnWriteToFile_Click(object sender, EventArgs e)
        {
            // path: and append: these are called named arguments, you can
            // swap them around, they are handy in that when you come back to
            // this in the future they help explain what the paramters are.
            // The using statement can be used to declare a resource that should be 
            // closed, the resouce must implement an interface called IDisposable, i.e.
            // when you are finished with the object (here the sw object), the resource
            // will automatically closed for you, this will happen just before the closing
            // curly bracket.
            using (StreamWriter sw = new StreamWriter(path: filename, append: true))
            {
                sw.WriteLine("Today is Tuesday");
                sw.WriteLine("It's the 1st of February");
                // A messagebox to say that it worked
                MessageBox.Show("Text written to file");

                // Instead of calling the close() method on a resource (connection to a database,
                // or a file), you can use the 'using statement'.
                //sw.Close();

            } // automatically closes the resource. 
        }

        private void BtnReadFromFile_Click(object sender, EventArgs e)
        {
            // This try block says, try the following block of code, I am aware that
            // it might generate an exception, e.g. FileNotFoundException. If an exception
            // does occur, exection will go to the catch block below
            try
            {
                using (StreamReader sr = new StreamReader(path: filename))
                {
                    string allLines = sr.ReadToEnd();
                    MessageBox.Show(allLines);

                } // automatically closes the StreamReader
            } catch(FileNotFoundException ex)
            {
                // Report the problem to the user and print into the console window
                // this is for the programmer to see.
                MessageBox.Show("File cound not be found");
                // Print out the exception in the console window
                Console.WriteLine(ex);
            } catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Directory cound not be found");
                Console.WriteLine(ex);
            } catch (IOException ex)
            {
                MessageBox.Show("Check the path is correct or another IO exception occured");
                Console.WriteLine(ex);
            }
        }

        private void BtnReadFromFileOneLiner_Click(object sender, EventArgs e)
        {
            // File.Exists() is a method that returns a bool of whether the file exists
            if (File.Exists(filename))
            {
                // File.ReadAllLines() reads the entire file at once (you must pass a
                // path/ filename into the method)
                string[] allLines = File.ReadAllLines(filename);

                // If you want to read the file contents into one string, you can use
                // File.ReadAllText(filename);
                string allText = File.ReadAllText(filename);

                // Join will insert a newline in between each array element, it returns
                // one string.
                MessageBox.Show(string.Join(Environment.NewLine, allLines));
            } else
            {
                MessageBox.Show("The file does not exist");
            }
        }

        private void BtnSaveProductToFile_Click(object sender, EventArgs e)
        {
            // If the file does not exist, it will be created. 
            using (StreamWriter sw = new StreamWriter(productsFile, append: true)) 
            {
                // ++ written after a variable is called a postfix increment, one
                // will be added onto currentId after its value is used in the call
                // to the WriteLine method.
                sw.WriteLine(currentId++);
                sw.WriteLine(TxtName.Text);
                sw.WriteLine(TxtQuantityPerUnit.Text);
                sw.WriteLine(TxtPrice.Text);

                MessageBox.Show(TxtName.Text + " has been saved to file");
                // Click the Clear Textboxes button
                BtnClearTextboxes.PerformClick();
            }
        }

        /*
         * Just after the form closes but before the application shutsdown, the
         * currentId will be saved to file.
         */
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // I haven't passed in a second parameter of setting the append mode
            // to true, and therefore the default mode is to overwrite the file.
            using(StreamWriter sw = new StreamWriter(currentIdFileName))
            {
                // Save the currentId to a file called CurrentId.txt
                sw.Write(currentId);
            }
        }

        private void BtnClearTextboxes_Click(object sender, EventArgs e)
        {
            //TxtId.Text = string.Empty;
            //TxtName.Text = string.Empty;
            //TxtPrice.Text = string.Empty;
            //TxtQuantityPerUnit.Text = string.Empty;

            // Loop through the GroupBoxes controls collection, when the 
            // control is a Textbox, then clear its text.
            foreach (Control control in GroupBoxProducts.Controls)
            {
                // If the control is a Textbox (not a label or a button)
                if (control is TextBox)
                {
                    // You can use the following code, which will set the text
                    // property of the control to an empty string, if execution
                    // gets here, the control is a Textbox.
                    control.Text = string.Empty;

                    // If you want to call a method specific to a Textbox, you will
                    // need to cast the 'control' variable from a Control reference
                    // type into a Textbox type. 
                    //((TextBox)control).Clear();

                    // You can use the following two line of code instead of the previous
                    // 'as' performs a downcast
                    //TextBox textbox = control as TextBox;
                    //textbox.Clear();
                }
            }
            // Put the cursor in the name textbox
            TxtName.Focus();
        }

        private void BtnLoadProductFromFile_Click(object sender, EventArgs e)
        {
            // Check the product file exists before reading
            if (File.Exists(productsFile))
            {
                // Read the contents of the products file and assign it to 
                // the global variable allProducts
                allProducts = File.ReadAllLines(productsFile);

                // reset the array position after reading from file
                arrayPosition = 0;
                PopulateTextBoxes();
            } else
            {
                MessageBox.Show(productsFile + " does not exist");
            }
        }

        private void TxtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            // If the Enter key was pressed in the Price Textbox, then press
            // the Save button
            if (e.KeyCode == Keys.Enter)
                // Click the Save button
                BtnSaveProductToFile.PerformClick();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (arrayPosition <= allProducts.Length - 4)
            {
                // move the array position variable up by 4
                arrayPosition += 4;

                PopulateTextBoxes();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            // Only take 4 away if it's not already at the beginning, i.e.
            // the array position is greater than 0.
            if (arrayPosition > 0)
            {
                // decrease the array position by 4
                arrayPosition -= 4;

                PopulateTextBoxes();
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            arrayPosition = 0;

            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            Console.WriteLine("The array position: " + arrayPosition);

            // Populate the four textboxes
            TxtId.Text = allProducts[arrayPosition];
            TxtName.Text = allProducts[arrayPosition + 1];
            TxtQuantityPerUnit.Text = allProducts[arrayPosition + 2];
            TxtPrice.Text = decimal.Parse(allProducts[arrayPosition + 3]).ToString("C");

            // Populate the label, e.g.: Record 1 of 9
            //LblRecordNumber.Text = String.Format(
            //    $"Record {arrayPosition / 4 + 1} of {allProducts.Length / 4}");
            LblRecordNumber.Text = String.Format(
                $"Record {TxtId.Text} of {currentId - 1}");
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            arrayPosition = allProducts.Length - 4;
            PopulateTextBoxes();
        }
    }
}
