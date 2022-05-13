using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheet2SolutionsMethodsAndEnum
{
    internal class MethodsAndEnum
    {
        static void Main()
        {
            MethodsAndEnum me = new MethodsAndEnum();
            me.CalculateSeconds(1, 2, 3); // 1 hour, 2 minutes and 3 seconds.

            bool result = me.RangeTest(10, 0, 50);
            Console.WriteLine("Is 10 within the range 0 and 50: " + result);
            Console.WriteLine("Is 50 within the range of 51 to 100: " + me.RangeTest(50, 51, 100));

            int num1 = 40;
            int num2 = 20;
            int returnedValue = CompareIntegers(num1, num2);
            if (returnedValue == -1)
                Console.WriteLine($"The result of calling CompareIntegers is : {num1} is smaller than {num2}");
            else if (returnedValue == 1)
                Console.WriteLine($"The result of calling CompareIntegers is : {num1} is bigger than {num2}");
            else // 0 was returned
                Console.WriteLine($"The result of calling CompareIntegers is : {num1} and {num2} are equal");

            HowManyVowels("Today is Monday");
            HowManyVowelsToo("Today is Monday");
            Console.WriteLine("The min of 2, 3, 1 : " + getMinimum(2, 3, 1));

            int sum = 0;
            CalculateSum(ref sum, 2, 4, 6, 8, 10);
            Console.WriteLine("The sum is : " + sum);

            sum = 0; // reset the variable because it is going to be used again.
            CalculateSum(ref sum);
            Console.WriteLine("The sum is : " + sum);

            CalculateSum(ref sum, new int[] { 9, 8, 7, 6, 5 });
            Console.WriteLine("The sum is : " + sum);

            Random rand = new Random();
            // rand.Next(10) will get a number between 0 and 9.
            CalculateSum(ref sum, rand.Next(10), rand.Next(10), rand.Next(10));
            Console.WriteLine("The sum is : " + sum);

            // You can use the random class to populate an array
            int[] randomArray = new int[10];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(10); 
            }
            CalculateSum(ref sum, randomArray);
            Console.WriteLine("The sum of the random array is : " + sum);

            // Testing out the price of the coffee
            // Here the output parameter price is declare inside the call to the GetPriceOfCoffee() method,
            // it is reused in the next method call. 
            GetPriceOfCoffee(out decimal price, Coffee.LATTE);
            Console.WriteLine($"The price of my {Coffee.LATTE} is: {price:C}");
            // OUTPUT: The price of my LATTE is: ?3.00

            // Here I am reusing the output parameter price from the previous method call. 
            GetPriceOfCoffee(out price, Coffee.FROTHYCHINNO);
            // If you want convert the Enum member into lowercase, you call toString() on it and call
            // ToLower() on that string. 
            Console.WriteLine($"The price of my {Coffee.FROTHYCHINNO.ToString().ToLower()} is: {price:C}");
            // OUTPUT:  The price of my frothychinno is: ?3.00
        } // end of main

        /*
         * Question 1:
         * Write a method that takes in three values: hours, minutes and seconds. It should convert 
         * and output the total seconds.
         */
        void CalculateSeconds(int hours, int minutes, int seconds)
        {
            // First calculate 
            int numOfSeconds = (hours * 60 + minutes) * 60 + seconds;

            Console.WriteLine($"The number of seconds in {hours} hours, {minutes} minutes and " +
                $"{seconds} seconds is : {numOfSeconds}");
        }

        /*
         * Write a method to test whether an integer is within a range of values. The method 
         * declaration is: public bool rangeTest(int val, int low, int high);
         * Return true if val is within the specified range otherwise false.
         * 
         *      me.rangeTest(10, 0, 100) // return true
         *      me.rangeTest(50, 10, 40) // return false
         */
        bool RangeTest(int value, int low, int high)
        {
            bool result = false;
            if (value >= low && value <= high)
                result = true;

            return result;

            //return value >= low && value <= high;   // one-liner
        }

        /**
         * Write a method to compare two integers (for example num1 and num2). The method should return:
         *  	-1 if num1 is less than num2
         *  	0 if num1 is equal to num2
         *  	1 if num1 is greater than num2
         *  	
         * I have made this method static so it can be called direcly from Main().
         */
        static int CompareIntegers(int num1, int num2)
        {
            //if (num1 < num2)
            //    return -1;
            //else if (num1 == num2)
            //    return 0;
            //else
            //    return 1;

            int result; // Will hold the result
            if (num1 < num2)
                result = -1;
            else if (num1 == num2)
                result = 0;
            else
                result = 1;
            return result; // return the result
        }

        /*
         * Write a method to determine the frequency of each of the vowels in a piece of text.
         */
        static void HowManyVowels(string text) // Today is Monday
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int vowelCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    vowelCount++;
                }
            }
            // The backslash removes the special meaning from a double quote, i.e. if I want to print a " this is how
            Console.WriteLine($"The number of vowels in \"{text}\" is {vowelCount}");
        }

        static void HowManyVowelsToo(string text)
        {
            int vowelCount = 0;

            // This loops through the text passed in, one character at a time.
            for (int i = 0; i < text.Length; i++)
            {   // this is missing the capital letters
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'i')
                {
                    vowelCount++;
                }
                // This is an alternative to the previous if statement.
                switch (text[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                }
            }
            Console.WriteLine($"The number of vowels found in \"{text}\" is " + vowelCount);
        }

        /*
         * Write two methods, one to return the minimum of three integers and one to return the maximum of three 
         * integers.  Call both methods from main to test them. 
         */
        static int getMinimum(int num1, int num2, int num3)
        {
            int min = 0;
            if (num1 <= num2 && num1 <= num3)
                min = num1;
            else if (num2 <= num1 && num2 <= num3)
                min = num2;
            else if (num3 <= num1 && num3 <= num2)
                min = num3;
            return min;
        }
        //                                   2        2        2 
        static int getMinimumAlternative(int num1, int num2, int num3)
        {
            int min = num1;
            if (num2 < min)
                min = num2;
            if (num3 < min)
                min = num3;
            return min;
        }

        static int getMaximum(int num1, int num2, int num3)
        {
            int max = num1;
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;
            return max;
        }

        /*
         * Create a method that calculates the sum of a random number of integer arguments. 
         * The method should declare two parameters: the first an integer result which should 
         * be passed by reference and the second a variable length integer array. After 
         * calculating the sum, the value should be assigned to the result parameter. 
         * 
         * 'ref' means that this method can assign a value to the result parameter and it will 
         * change the value of the variable passed in (i.e. the 'sum' as declared in main).
         * params means a variable lenght argument, when calling this method, you can pass in
         * 0, 1 or more int values, or an array of integers.
         */
        static void CalculateSum(ref int result, params int[] numbers)
        {
            // reset the result each time.
            result = 0;
            // If the array is empty, nothing will happen here.
            foreach(int num in numbers)
            {
                Console.Write(num + " ");
                result += num;
            }   
        }

        /* 
         * Create a Coffee enum, supply as many members as you like, e.g.: AMERICANO, FLAT_WHITE, 
         * LATTE, MOCHA, ESPRESSO, etc. Create a method that accepts two parameters, an out parameter 
         * for the price and a Coffee enum.  The method should calculate the price and assign it to 
         * the out parameter.
         */
        enum Coffee { AMERICANO, FLAT_WHITE, LATTE, MOCHA, ESPRESSO, FROTHYCHINNO } 

        static void GetPriceOfCoffee(out decimal price, Coffee coffee)
        {
            switch(coffee)
            {
                case Coffee.AMERICANO:
                case Coffee.ESPRESSO:
                    price = 2.5m;
                    break;
                case Coffee.FLAT_WHITE:
                case Coffee.LATTE:
                case Coffee.MOCHA:
                    price = 3;
                    break;
                default:
                    Console.WriteLine("Error, unknown Coffee type");
                    price = 3;
                    break;
            }

            // An alternative: store the prices in an array, and use the index of the
            // Enum member to extract the correct price from the array
            decimal[] prices = {2.5m, 3, 3, 3, 2.5m, 3};
            price = prices[(int)coffee];
        }

    } // end of the class
} // end of the namespace
