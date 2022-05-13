using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model; // This will give access to Product class which is in the model namespace
using System.Diagnostics;
using System.IO; // Files

namespace view
{
    public partial class Form1 : Form
    {
        // An autonumber for the Id
        private int currentId = 1;

        // File for saving Products
        private string ProductFile = "../../Products.txt";

        // File for saving the id
        private string IdNumberFile = "../../IdNumber.txt";

        // A list to store all product objects. <Product> that is Generics, a message
        // to the compiler to make sure I only put Product objects into the list, and
        // a string or int cannot be added: the code wouldn't compile.
        private List<Product> listOfProducts = new List<Product>();

        private int listPosition; // default to 0

        public Form1()
        {
            InitializeComponent();

            //ProductFile = "../../Products" + DateTime.Now.ToString() + ".txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the next id from file
            GetProductIdFromFile();

            /*Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Bread";
            p1.QuantityPerUnit = "800g loaf";
            p1.Price = .79m;
            Console.WriteLine(p1);  // implicitly calls the toString()

            // The following code is called an object initialiser and it is a 
            // shortcut for creating an object in one line and setting all the 
            // properties
            Product p2 = new Product
            {
                Id = 2,
                Name = "Apples",
                QuantityPerUnit = "Bag of 12",
                Price = 2.49m
            };

            Console.WriteLine("Console: " + p2);  // calls my ToString()
            Debug.WriteLine("Debug: " + p2);*/
        }

        private void GetProductIdFromFile()
        {
            // Only load the ID from the file, if the file exists.
            if (File.Exists(IdNumberFile))
            {
                string numberFromFile = File.ReadAllText(IdNumberFile);

                // If the TryParse method returns false, the parse failed
                if (int.TryParse(numberFromFile, out currentId) == false)
                {
                    Console.WriteLine("Current Id " + currentId);

                    MessageBox.Show("Number from file failed to parse",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSaveProductToFile_Click(object sender, EventArgs e)
        {
            // Check that the list isn't empty
            if (listOfProducts.Count == 0)
            {
                MessageBox.Show("The list is empty, cannot save to file");
            }
            else
            {
                // Create the file for writing to (StreamWriter), each time the entire
                // list will be written to the file is one go and therefore it will 
                // overwrite mode
                using (StreamWriter sw = new StreamWriter(path: ProductFile, append: false))
                {
                    // Write all products out to file. 
                    // [p1- id:1 name:milk ][p2 - id:2 name:bread][p3- ][p4- ]
                    foreach (Product product in listOfProducts)
                    {
                        sw.WriteLine(product.Id);
                        sw.WriteLine(product.Name);
                        sw.WriteLine(product.QuantityPerUnit);
                        sw.WriteLine(product.Price);
                    }
                    MessageBox.Show("List was written to " + ProductFile);
                } // sw.close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save the next product id out to file.
            using (StreamWriter sw = new StreamWriter(IdNumberFile)) // default is overwrite
            {
                sw.Write(currentId);
            }
        }

        private void BtnSaveProductToList_Click(object sender, EventArgs e)
        {
            // The first thing to check to see if the first two textboxes are empty
            if (TxtName.Text == string.Empty || TxtQuantityPerUnit.Text == string.Empty)
            {
                MessageBox.Show("Name and Quantity Per Unit cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  // if they are not empty check to see if the price can be parsed
                  // to a decimal

            // Try parse the text from the TxtPrice Textbox, if it works, store the
            // result into the price variable, if it doesn' work, then alert the user.
            if (decimal.TryParse(TxtPrice.Text, out decimal price) == false)
            {
                MessageBox.Show("Error parsing: " + TxtPrice.Text, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Everything is ok
            {
                // Get all the info from the GUI's Textboxes
                //string name = TxtName.Text;
                //string quantityPerUnit = TxtQuantityPerUnit.Text;

                // Convert that info into a Product object
                // This one-liner is called an object initialiser
                Product product = new Product
                {
                    Id = currentId, // global variable
                    Name = TxtName.Text,
                    QuantityPerUnit = TxtQuantityPerUnit.Text,
                    Price = price
                };

                // Add that product to the list
                listOfProducts.Add(product);

                // Increment the Id for the next product
                currentId++;

                // Clear all textboxes after adding to the list
                BtnClearTextboxes.PerformClick();

                // String.Join will insert a newline between each product in the list
                // It will also call to ToString() method on each Product object in the list
                Console.WriteLine("The contents of the list are: \n" + String.Join("\n", listOfProducts));

                // OUTPUT: 

                //The contents of the list are: 
                //Id is:              1
                //Name is :           Milk
                //Quantity Per Price: 1 Litre
                //Price is :          €1.49
                //Id is:              1
                //Name is :           Bread
                //Quantity Per Price: 1 loaf
                //Price is :          €1.29
            }
        }

        private void BtnClearTextboxes_Click(object sender, EventArgs e)
        {
            // Loop through the Controls collection of the panel, it only
            // contains Textboxes and clear the text from each one.
            foreach(TextBox textBox in PnlTextboxes.Controls)
            {
                textBox.Text = string.Empty;    
            }

            // put the cursor in the Name text box
            TxtName.Focus();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            listPosition = 0;
            PopulateTextBoxes();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (listPosition > 0)
            {
                listPosition--;
                PopulateTextBoxes();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (listPosition < listOfProducts.Count - 1)
            {
                listPosition++;
                PopulateTextBoxes();
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            listPosition = listOfProducts.Count - 1;
            PopulateTextBoxes();
        }

        private void BtnLoadProductsFromFile_Click(object sender, EventArgs e)
        {
            // Check the file exists
            if (File.Exists(ProductFile))
            {
                // Clear the list before adding more products from the file
                listOfProducts.Clear();

                // Read all lines from the file into a string array
                string[] allLines = File.ReadAllLines(ProductFile);

                // Loop through the string array
                int i = 0;

                //for (int i = 0; i < allLines.Length; i += 4)
                while (i < allLines.Length)
                {

                    // Every 4 elements in the array will be converted into a Product
                    Product product = new Product
                    {
                        Id = int.Parse(allLines[i]),
                        Name = allLines[i + 1],
                        QuantityPerUnit = allLines[i + 2],
                        Price = decimal.Parse(allLines[i + 3])
                    };

                    listOfProducts.Add(product);
                    i += 4;
                }

                // Click the BtnFirst button to display the 1st product on the Form
                BtnFirst.PerformClick();
            } else
            {
                MessageBox.Show(ProductFile + " does not exist", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Write a method to populate the Textboxes on the GUI using the current
        // listPosition value. 
        private void PopulateTextBoxes()
        {
            Product product = listOfProducts[listPosition];
            TxtId.Text = product.Id.ToString();
            TxtName.Text = product.Name;
            TxtQuantityPerUnit.Text = product.QuantityPerUnit;
            TxtPrice.Text = String.Format($"{product.Price:C}");

            // Update the label: Record 0 of 0
            LblRecordNumber.Text = String.Format(
                $"Record {listPosition + 1} of {listOfProducts.Count}");
        }
    }
}
