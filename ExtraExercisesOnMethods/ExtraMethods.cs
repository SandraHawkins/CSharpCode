using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercisesOnMethods
{
    internal class ExtraMethods
    {
        static void Main()
        {
            // I have declared variables to hold the price and quantity, and used those variable
            // names to pass a copy of the values down into the method below
            decimal price = 249.99m;
            int quantity = 6;
            CalculateTotal(price, quantity);

            // Here I have typed in literals and a copy of those values will be passed to the method
            // below. This code is testing out the method below.
            CalculateTotal(.49m, 8);

            CalculateTotalShortenedVersion(1.49m, 2);

            decimal celsius = ConvertFromFahIntoCel(96);
            Console.WriteLine($"96 in celsius is {celsius:N} degrees.");

            // One liner to test the other method
            Console.WriteLine($"35.56 in fahrenheit is {ConvertFromCelIntoFah(35.56m):N} degrees.");

            string result = ExamResult(40, 40, 40);
            Console.WriteLine(result);
            result = ExamResult(40, 20, 80);
            Console.WriteLine(result);
            Console.WriteLine(ExamResult(39,39,80));
        } // end of main

        /** 
         * Write a method called calculateTotal that takes in two parameters; price and quantity. 
         * The method should calculate the total and print it out.  In main declare two variables: 
         * price and quantity, assign then appropriate values and pass them to the calculateTotal method. 
         */
        static void CalculateTotal(decimal price, int quantity)
        {
            Console.WriteLine($"The total price of {price:C} times {quantity} is {price * quantity:C}");
        }

        /*
         * => this symbol is used to shorten the body of a method when the method only contains
         * one statement. You replace the {} (and the return statement if there is one) with =>.
         * If your method had a return statement, you remove the return keyword and it is implied.
         * This is known as an 'expression-bodied method'.
         */
        static void CalculateTotalShortenedVersion(decimal price, int quantity) =>
        
            Console.WriteLine($"The total price of {price:C} times {quantity} is {price * quantity:C}");


        /*
         * Write a program that can convert temperatures from Fahrenheit to Celsius and vice versa. 
         * Create two methods, one to convert from Fahrenheit to Celsius and one to convert from 
         * Celsius to Fahrenheit, each method should take in one double parameter and return the result. 
         * Call each method from main and pass in the value for conversion.
            To convert a Fahrenheit temperature into Celsius:  
            Celsius = 5.0 / 9 * (Fahrenheit - 32)
            To convert a Celsius temperature into Fahrenheit: 
            Fahrenheit = (9.0 /5 * Celsius) + 32
            NOTE: When you divide an integer literal by an integer literal, the result will be an 
            integer, for example: 9 divided by 5 is 1.  That is why the equation is 5.0 / 9 to produce a 
            double result.
        */
        static decimal ConvertFromFahIntoCel(decimal fah)
        {
            decimal celsius;
            celsius = 5.0m / 9 * (fah - 32);
            return celsius;
        }

        static decimal ConvertFromCelIntoFah(decimal cel)
        {
            decimal fahrenheit;
            fahrenheit = (9.0m / 5 * cel) + 32;
            return fahrenheit;
        }

        /*
         * Percentage marks attained by a student in three exams are to be stored in variables in 
         * your program. Pass the values to a method that will output an indication of Pass or Fail 
         * for the three marks. The criteria for passing are as follows: 
         * A student passes if all three examinations are passed. Additionally a student may pass 
         * if only one subject is failed and the overall average is greater than or equal to 50. 
         * The pass mark for an individual subject is 40. 
         */
        static string ExamResult(int mark1, int mark2, int mark3)
        {
            double average;
            string result = "fail";
            int numOfPasses = 0;

            average = (mark1 + mark2 + mark3) / 3;
            Console.WriteLine($"Mark 1 : {mark1}, Mark 2 : {mark2}, Mark 3 : {mark3} and average : {average}");

            // This is checking each mark and counting how many passes there are
            if (mark1 >= 40)
                numOfPasses++;
            if (mark2 >= 40)
                numOfPasses++;
            if (mark3 >= 40)
                numOfPasses++;

            // numOfPasses:
            // 0 - fail
            // 1 - fail
            // 2 - check the average, >= 50 pass, otherwise fail
            // 3 - pass
            if (numOfPasses == 3)
                result = "pass";
            else if (numOfPasses == 2 && average >= 50)
                result = "pass";

            // This switch is an alternative to the above if else.
            switch (numOfPasses)
            {
                case 0:
                case 1:
                    result = "fail";
                    break;
                case 2:
                    if (average >= 50)
                        result = "pass";
                    else
                        result = "fail";
                    break;
                default:
                    result = "pass";
                    break;
            }

            return result;
        }

    } // end of the class
}
