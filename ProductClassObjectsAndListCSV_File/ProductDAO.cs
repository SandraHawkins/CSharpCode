using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;        // Product class
using System.IO;    // StreamWriter and File

namespace controller
{
    // DAO stands for Data Access Object. 
    internal class ProductDAO
    {
        // File for saving Products
        private string ProductFile = "../../Products.csv";

        /*
         * This method saves the Products to a CSV file, this is what it might look like:
         * 
         * 1, Milk, 1 Litre, 1.49
         * 2, Break, 800g loaf, .89
         * 3, Strawberries, 250g, 2.49
         */
        public bool SaveProductListToFile(List<Product> listOfProducts)
        {
            try
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
                        sw.Write(product.Id + ",");
                        sw.Write(product.Name + ",");
                        sw.Write(product.QuantityPerUnit + ",");
                        sw.Write(product.Price);
                        // Insert a newline after each product
                        sw.WriteLine();
                    }
                } // sw.close();
                // If execution gets here, everything is ok
                return true;
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException occured: " + ex);
                return false;
            }
            catch (Exception ex) // Means catch any other exceptions that might have occurred
            {
                Console.WriteLine("An other exception occured: " + ex);
                return false;
            }
        }

        /*
         * This method reads the contents of a CSV file. 
         * If everything works okay, a populated list will be returned via the out
         * parameter and true will be returned.
         * If the files does not exits, an empty list will be returned via the out
         * parameter and false will be returned.
         */
        public bool GetProductsFromFile(out List<Product> listOfProducts)
        {
            // Set up an empty list.
            listOfProducts = new List<Product>();   

            // Check the file exists
            if (File.Exists(ProductFile))
            {
                // Read all lines from the file into a string array, each 
                // element in the array will be one product, e.g.:
                // 1,Milk,1 Litre,1.49
                // 2,Bread,800g loaf,.89
                string[] allLines = File.ReadAllLines(ProductFile);

                // Loop through the string array
                foreach(String oneLine in allLines)
                {
                    // Split oneLine (1, Milk, 1 Litre, 1.49) into its separate parts
                    // The string class has a Split() method which will split up a 
                    // string using ',' as the separator character.
                    string [] productParts = oneLine.Split(',');

                    // Every 4 elements in the array will be converted into a Product
                    Product product = new Product
                    {
                        Id = int.Parse(productParts[0]),
                        Name = productParts[1],
                        QuantityPerUnit = productParts[2],
                        Price = decimal.Parse(productParts[3])
                    };

                    listOfProducts.Add(product);
                    Console.WriteLine("In GetProductsFromFile:\n");
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
