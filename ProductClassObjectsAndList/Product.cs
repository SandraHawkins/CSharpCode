using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class is called Product, it will be used for creating many Product objects.
 * Each Product object will get its own set of properties, i.e. Id, Name, QuantityPerUnit
 * and Price. 
 * 
 * The namespace is model. I am implementing some of the Model, View, Controller 
 * Framework. The model namespace/ package/ folder will hold all class files for 
 * the system, e.g. Product, Customer, Account, Order, Shipper, etc. these will all be
 * stored in the system, e.g. into a database or into a file. 
 * 
 * The view namespace will be where the GUI code will go. 
 */
namespace model
{
    internal class Product
    {
        // This constructor is needed if you call it explicitly or if you use
        // an object initialiser block, e.g.:
        //          Product p2 = new Product
        //          {
        //               Id = 2,
        //              Name = "Apples",
        //              QuantityPerUnit = "Bag of 12",
        //              Price = 2.49m
        //          };
        public Product() {
            Price = 1;
        }

        public Product(String name, String qtyPerUnit, decimal price)
        {
            Name = name;
            QuantityPerUnit = qtyPerUnit;   
            Price = price;
        }


        // Here is where the properties go. 
        // This syntax is called auto property. 
        public int Id { get; set; }

        public string Name { get; set; }    

        public string QuantityPerUnit { get; set; } 

        public decimal Price { get; set; }

        // The following 6 lines are the long way instead of the above auto properties
        private string size;
        public string Size
        {
            get { return size; }    

            set { size = value; }   
        }

        /*
         * After I create a product object (behind a button):
         * 
         *          Product p1 = new Product();
         *          p1.Id = 1;
         *          p1.Name = "Bread";
         *         
         * I can print out the reference variable p1, e.g.:
         * 
         *          Console.WriteLine(p1);
         *          
         * that will implilicty call the toString() method. The toString() method
         * here should return a string containing all of the properties value:
         */
        public override string ToString()
        {
            string newLine = Environment.NewLine;

            return String.Format(
                $"Id is:              {Id}{newLine}" +
                $"Name is :           {Name}{newLine}" +
                $"Quantity Per Price: {QuantityPerUnit}{newLine}" +
                $"Price is :          {Price:C}");
        }
    }
}
