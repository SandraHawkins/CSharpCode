using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsEnumTernary
{
    internal class ParamsEnumTernary
    {
        static void Main()
        {
            ParamsExample(5);
            ParamsExample(1, "Sandra");
            ParamsExample(6, "Sandra", "Fred");
            ParamsExample(7, "Sandra", "Fred", "Mary");
            ParamsExample(3, new string[] { "Sandra", "Fred", "Mary", "John" });

            TernaryOperatorExample();

            Console.WriteLine("Cost of small pizza: " + GetPizzaCost(3, PizzaSize.SMALL));
            Console.WriteLine("Cost of medium pizza: " + GetPizzaCost(4, PizzaSize.MEDIUM));
            Console.WriteLine("Cost of large pizza: " + GetPizzaCost(5, PizzaSize.LARGE));
        }

        /* An enum is like you are creating your own data type/ value types. 
         * You can type up an enum in a file on its own or you can type it into 
         * a class BUT it must not be inside a method, i.e. it is at the same level
         * as a method. 
         * You can optionally assign a value to each member. The value of each memeber is the base 
         * price of each pizza before toppings are added.
         */
        enum PizzaSize { SMALL = 5, MEDIUM = 9, LARGE = 12 };

        // Toppings on a small pizza are 1 euro each
        // Toppings on a medium pizza are 1.5 euro each
        // Toppings on a large pizza are 2 euro each
        static decimal GetPizzaCost(int numOfToppings, PizzaSize pizzaSize)
        {
            Console.WriteLine($"Num of toppings : {numOfToppings}, Pizza Size: {pizzaSize}");
            // The following line will print 5, 9 or 12 depending on which enum member was passed into
            // the method. 
            Console.WriteLine($"The value of the member is : { (int)pizzaSize }");
            decimal cost;

            // Store the price for each toppings in constants
            const decimal SMALL_TOPPINGS = 1;
            const decimal MEDIUM_TOPPINGS = 1.5m;
            const decimal LARGE_TOPPINGS = 2;

            // The next line takes the value for the member, i.e. if the PizzaSize is SMALL, then
            // the cost will start out as 5, if the PizzaSize is MEDIUM then the cost starts out at 9....
            // The following LOC was in each if/ else body and therefore I removed to appear before the
            // if else blocks.
            cost = (int)pizzaSize;

            if (pizzaSize == PizzaSize.SMALL)
                // cost = 5 + 3 * 1; // 8
                cost = cost + numOfToppings * SMALL_TOPPINGS;

            else if (pizzaSize == PizzaSize.MEDIUM)
                cost += numOfToppings * MEDIUM_TOPPINGS;

            else // LARGE
                cost += numOfToppings * LARGE_TOPPINGS;

            
            // Use a List to store the cost of each pizza, then in the case statements below,
            // I have to retrieve the price from the correct position in the list.
            List<decimal> listOfPrices = new List<decimal>();
            listOfPrices.Add(5);  // small price
            listOfPrices.Add(9);  // medium price
            listOfPrices.Add(12); // large price

            // This switch is an alternative to the previous if else, you must remove one,
            // or you will pay double for your pizza.
            switch(pizzaSize)
            {
                case PizzaSize.SMALL:
                    cost = listOfPrices[0] + numOfToppings * 1;
                    break;
                case PizzaSize.MEDIUM:
                    cost = listOfPrices[1] + numOfToppings * 1.5m;
                    break;
                case PizzaSize.LARGE:
                    cost = listOfPrices[2] + numOfToppings * 2;
                    break;
                default:
                    Console.WriteLine("Invalid pizza size?");
                    break;
            }

            return cost;
        }

        static void TernaryOperatorExample()
        {
            int num = 10;
            string message; // assigned to in the if else underneath

            if (num < 0)
                message = "Number is negative";
            else
                message = "Number is positive";

            // A ternary operator is an alternative to an if else 
            message = num < 0 ? "Number is negative" : "Number is positive";

            // Do something with the message
            Console.WriteLine(message);

            // I insert a customer into the database and it was successful, the method that I called
            // to insert the customer returns true and I want to inform the user that the insert worked.
            bool success = true;
            if (success)
                Console.WriteLine("Customer was inserted");
            else
                Console.WriteLine("Insert failed");

            // The ternary operator:
            // condition ? true part : false part;
            Console.WriteLine( success ? "Customer was inserted" : "Insert failed");
        }


        /*
         * The params modifier, if applied to the last parameter of a method, allows the method 
         * to accept any number of arguments of a particular type. The parameter type must be 
         * declared as an array.
         * You can only have one parameter declared with 'params' and it must be the last parameter.
         */
        static void ParamsExample(int num, params string [] names)
        {
            Console.WriteLine($"The number of elements in the params array: {names.Length}");
            // You must use a loop to print the contents of a params array because it might be empty
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
        // OUTPUT
        //The number of elements in the params array: 0

        //The number of elements in the params array: 1
        //Sandra
        //The number of elements in the params array: 2
        //Sandra Fred
        //The number of elements in the params array: 3
        //Sandra Fred Mary
        //The number of elements in the params array: 4
        //Sandra Fred Mary John
    }
}
