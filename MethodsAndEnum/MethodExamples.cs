using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndEnum
{
    internal class MethodExamples
    {
        // When you press the run button (F5), the contents of the main method will run, it must be
        // static void Main().
        static void Main()
        {
            // The next line of code creates an instance (or object) of this class (MethodExamples)
            // the reference to this object is called 'me' and that reference must be used to call
            // any method in this class. 
            MethodExamples me = new MethodExamples();
            me.PrintHello();
            me.PrintHello();
            me.AddTwoNumbers(10, 12);
            me.AddTwoNumbers(22, 23.5m);

            int numberOne = 23;
            decimal numberTwo = 12.5m;
            // The actual values / literals you pass into a method are called arguments.
            me.AddTwoNumbers(numberOne, numberTwo);

            // When you call a method that returns a value, you can assign the returned value to 
            // a variable or you can call the method in a call to Console.WriteLine() as is below.
            decimal result = me.MultiplyByTen(22.2m);
            Console.WriteLine("The result of multiplying by ten is : " + result);

            // one-liner for calling MultiplyByTen()
            Console.WriteLine("The result of calling MultiplyByTen() is : " + me.MultiplyByTen(33.4m));

            me.ManipulateString("Today is Monday");

            //me.MenuChoice();

            decimal localPrice = 20;
            decimal localVAT = 21;
            decimal localpostage = 2.5m;
            decimal total = me.CalculatePriceAfterVATAndPostage(localPrice, localVAT, localpostage);
            Console.WriteLine($"The total is : {total:C}");

            Console.WriteLine($"The total is : {me.CalculatePriceAfterVATAndPostage(11.99m, 21, 1.05m):C}");

            // Named arguments enable you to specify an argument/ value for a parameter by matching the
            // argument with its name rather than with its position in the parameter list.
            // MethodName(ParameterName: literal/ localVariable, ParameterName: value);
            total = me.CalculatePriceAfterVATAndPostage(VAT: 9, postage: 4.5m, netPrice: 45.99m);
            Console.WriteLine("Total " + total);
            total = me.CalculatePriceAfterVATAndPostage(45.99m, 9, 4.5m);
            Console.WriteLine("Total " + total);



            Console.WriteLine("*************** Method modifiers ****************************");
            // Pass by value
            int value = 10;
            Console.WriteLine("In main, before method call, value is " + value);
            CannotChangeTheOriginalValue(value); // here a copy of value is passed to the method, i.e.
                                                 // the method get a copy of 10.
            Console.WriteLine("In main, after method call, value is " + value);

            // When you pass a variable into a method where the parameter is modified with the
            // ref keyword, that means it received the memory address of the original variable
            // and the method CAN change the original variable. When  you call a method that
            // uses the ref modifier, you must include the ref keyword/ modifier here in the
            // calling code.
            CanChangeTheOriginalValue(ref value);
            Console.WriteLine("In main, after CanChangeTheOriginalValue(), value is " + value);
            // When you call a method that accepts an output parameter, you can declare the variable before 
            // the method call, or you can delcare the output variable inside the call to the method (where
            // the arguments are passed in).
            int numRows = 0;
            bool success = UpdateDetailsInDatabase(5, "Mary Murphy", "Cork", out numRows);
            
            success = UpdateDetailsInDatabase(6, "Joe", "Co. Dublin", out int numRowsAffected);
            Console.WriteLine($"success was returned from the method, its value : {success} " +
                $"and the output parameter numRowsAffected is : {numRowsAffected}");
        }

        /*
         * The out modifier is most commonly used to get multiple return values back from a method.
         * A method can return one value via its return type, e.g. the following method returns
         * a bool, i.e. whether the update succeeded or not. 
         * 
         *          bool UpdateDetailsInDatabase(int id, string name, string address) 
         *          {
         *              // update details in the database 
         *          }
         *          
         *  If I want this method to return more information, e.g. the number of rows that 
         *  were updated. How can it be done? Because the return type (bool) can only return
         *  one value. 
         *  Solution, the 'out' modifier can be used to return another value out of a method.
         *  
         *  In the example underneath, numOfRowsUpdated is an output parameter, it must be assigned
         *  a value before the method completes and it is another way to return a value from a method.
         */

        static bool UpdateDetailsInDatabase(int id, string name, string address, out int numOfRowsUpdated)
        {
            // Update something in the database, all going well, get how many row were updated, and 
            // also return true if the code was successful
            numOfRowsUpdated = 1;
            return true;
        }


        static void CannotChangeTheOriginalValue(int number) // number gets a copy of 10
        {
            // Will this change the original value in main?
            number = number * 6; // The parameter will change from 10 to 60;
                                 // the original variable in main (10) will not change. 
            Console.WriteLine("In CannotChangeTheOriginalValue(), value is " + number);
        }

        // ref means this method received the memory address of the argument (value passed in)
        static void CanChangeTheOriginalValue(ref int number)
        {
            number = number * 6; // The parameter will change from 10 to 60;
                                 
            Console.WriteLine("In CanChangeTheOriginalValue(), value is " + number);
        }

        /*
         * This method returns nothing (void) and takes in no parameters. When you call this 
         * method, it will print Hello to the console window.
         */
        void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        /*
         * This method takes in two parameter, an int and a decimal, when this method is called
         * you must pass in two values/ arguments. The method declaration declares two parameters,
         * and int and a decimal, those parameters num1 and num2 can only be seen in the body of
         * the method.
         * 
         */
        void AddTwoNumbers(int num1, decimal num2)
        {
            decimal result;
            result = num1 + num2;
            Console.WriteLine($"{num1} added to {num2} is {result}");
        }

        /*
         * This method takes in one parameter, a decimal, it will multiply that value by ten
         * and return it. 
         */
        decimal MultiplyByTen(decimal number) // 22.2
        {
            decimal result;
            result = number * 10;
            return result;  // return number * 10;  // 222.9
        }

        void ManipulateString(string text)
        {
            Console.WriteLine("You passed in: " + text);

            // You can treat a string like it's an array of characters:
            char firstLetter = text[0];
            Console.WriteLine("The first letter in the text is : " + firstLetter);
            
            char lastLetter = text[text.Length - 1];
            Console.WriteLine("The last letter in the text is : " + lastLetter);

            Console.WriteLine("The text in upper case: " + text.ToUpper());
        }

        //                                               20              21.0           2.5
        decimal CalculatePriceAfterVATAndPostage(decimal netPrice, decimal VAT, decimal postage)
        {
            Console.WriteLine($"Net price: {netPrice}, VAT: {VAT}, postage: {postage}");
            decimal total;
            total = netPrice * (VAT / 100 + 1) + postage;
            Console.WriteLine("In the method CalculatePriceAfterVATAndPostage, total is " + total);
            return total;
        }

        void MenuChoice()
        {
            bool goAgain = true;

            do
            {
                // prompt the user, yes is to go again, no is to stop
                Console.WriteLine("Enter your choice, yes or no " );
                String choice = Console.ReadLine().ToLower(); // read in from the console and convert to lowercase

                if (choice.Equals("yes") || choice.Equals("go again"))
                    goAgain = true;
                else // default in the switch
                    goAgain = false;

            } while (goAgain == true);
        }
    }
}
