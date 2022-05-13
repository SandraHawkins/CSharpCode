// Method calls:
Ex1WhileLoop();
Ex2DoWhileLoop();
//Ex3InfiniteLoop();
Ex4DoWhileExecutesOnce();
Ex5LoopCountingBackwards();
Ex6ForLoop10to20();
Ex7TotalOfZeroTo39();
Ex8ArrayOfPrices();
Ex9ProductsAndPrices();
Ex10TheSmallestNumber();
Ex11TheTotalOfArrayElements();
Ex12TotalAndAverage();
Ex13FootballTeams();
Ex14TimesTables();
Ex15Clock();

// Method bodies

/* 
 * Write a while loop that executes 20 times. 
 */
void Ex1WhileLoop()
{
    Console.WriteLine("Exercise 1: a while loop that executes 20 times");
    int i = 0;

    while (i < 20)
    {
        Console.WriteLine("The value of i is " + i);
        i++;
    }
}
/*  OUTPUT:
The value of i is 0
The value of i is 1
The value of i is 2
The value of i is 3
The value of i is 4
The value of i is 5
The value of i is 6
The value of i is 7
The value of i is 8
The value of i is 9
The value of i is 10
The value of i is 11
The value of i is 12
The value of i is 13
The value of i is 14
The value of i is 15
The value of i is 16
The value of i is 17
The value of i is 18
The value of i is 19
*/


/*
 * Convert the while loop you wrote in the previous exercise to a do...while loop. 
 */
void Ex2DoWhileLoop()
{
    Console.WriteLine("Exercise 2: A do while loop that executes 20 times");
    int i = 0;

    do
    {
        Console.WriteLine("The value of i is " + i);
        i++;
    } while (i < 20);
}
/*  OUTPUT:
The value of i is 0
The value of i is 1
The value of i is 2
The value of i is 3
The value of i is 4
The value of i is 5
The value of i is 6
The value of i is 7
The value of i is 8
The value of i is 9
The value of i is 10
The value of i is 11
The value of i is 12
The value of i is 13
The value of i is 14
The value of i is 15
The value of i is 16
The value of i is 17
The value of i is 18
The value of i is 19
*/


/*
 * Write a while loop that will result in an infinite loop. 
 */
void Ex3InfiniteLoop()
{
    Console.WriteLine("Exercise 3: An infinite while loop");
    // This is an infinite loop
    while (true)
    {
        Console.WriteLine("This will keep executing");
    }

    int i = 0;
    while(i < 2)
    {
        Console.WriteLine("This will keep executing as there is no increment to the counter");
    }
}


/*
 * Write a do...while loop that can never execute more than once. 
 */
void Ex4DoWhileExecutesOnce()
{
    Console.WriteLine("Exercise 4: a do...while loop that can never execute more than once");
    int i = 0;

    do
    {
        Console.WriteLine("This loop executes only once");
    } while (i > 10);
}
/* OUTPUT:
 * This loop executes only once
 */

/*
 * Write a while loop that counts backwards from 20 to 10.
 */
void Ex5LoopCountingBackwards()
{
    Console.WriteLine("Exercise 5: a while loop that counts backwards from 20 to 10");
    int i = 20;

    while(i >= 10)
    {
        Console.WriteLine("i is " + i);
        i--;
    }
}
/** OUTOUT
i is 20
i is 19
i is 18
i is 17
i is 16
i is 15
i is 14
i is 13
i is 12
i is 11
i is 10
*/


/*
 * Write a for loop that will print the numbers between 10 and 20.
 */
void Ex6ForLoop10to20()
{
    Console.WriteLine("Exericse 6: a loop that prints from 10 to 20");
    for (int i = 10; i <= 20; i++)
    {
        Console.WriteLine($"The value of i is {i}");
    }
}
/** OUTPUT:
The value of i is 10
The value of i is 11
The value of i is 12
The value of i is 13
The value of i is 14
The value of i is 15
The value of i is 16
The value of i is 17
The value of i is 18
The value of i is 19
The value of i is 20
*/



/*
 * Write a program that adds up the numbers 0 to 39 using a for loop.
 */
void Ex7TotalOfZeroTo39()
{
    Console.WriteLine("Exercise 7: a program that totals the numbers between 0 and 39");

    // for a running total, you will need to declare a variable to hold the total
    // it must be declared before the for loop and initialised. 
    int total = 0;

    for (int i = 0; i <= 39; i++)
    {
        total += i;
    }
    Console.WriteLine("The total is : " + total);
}
/** OUTPUT:
The total is : 780
*/

/*
 * Showing you how to format output
 */
void FormattingOutputExample()
{
    String name = "Sandra";
    int age = 45;
    decimal price = 2.5m;

    Console.WriteLine($"{name}{age}{price}");               // Sandra452.5

    // output each value in a column width of 12, right aligned by default
    Console.WriteLine($"{name,12}{age,12}{price,12}");      //       Sandra          45         2.5

    Console.WriteLine($"{name,-12}{age,-12}{price,-12}");   // Sandra      45          2.5

    // :N formats the decimal as a number, i.e. to 2 decimal places
    Console.WriteLine($"{name,-12}{age,-12}{price,-12:N}"); // Sandra      45          2.50

    // :C format a number as a currency
    Console.WriteLine($"{name,-12}{age,-12}{price,-12:C}"); // Sandra      45          ?2.50

    // Using literals instead of variable names:
    Console.WriteLine($"{"Ted",-12}{30,-12}{1.9,-12:C}");   // Ted         30          ?1.90
}

/*
 * Create an array that holds 12 prices, for example:
 * 12.50	11.20	10.90	4.99	5.66	25.40	14.30	33	24.50	1.25	2.20	3.48
 * Due to inflation all the prices have to be increased by 4%.
 * Create a second array that will hold the updated prices, and finally display the old and the 
 * new prices, for example:
 * Old Price		New Price
 * 12.50			13.50
 * 11.20			11.64
 * 10.90			11.33
 * 4.99			    5.18
 * 5.66			    5.88
 * ……
 */
void Ex8ArrayOfPrices()
{
    Console.WriteLine("Exercise 8: Arrays of Prices");

    decimal[] oldPrices = { 12.50m, 11.20m, 10.90m, 4.99m, 5.66m, 25.40m, 
                         14.30m, 33m, 24.50m, 1.25m, 2.20m, 3.48m};

    decimal[] newPrices = new decimal[oldPrices.Length];

    // Initialise the newPrices array
    for (int i = 0; i < newPrices.Length; i++)
    {
        newPrices[i] = oldPrices[i] * 1.04m;
    }

    // Using the method String.Format() you can control how dates, times and numbers
    // are displayed, you can specifiy a column width to output your values in, you can
    // change the alignment from right to left, you can format a value as number which
    // will display a number as two decimal places, format a number as a currency, etc.
    // The example underneath:
    // When using String.Format() you specify which argument you are formatting, i.e. 0, 1, 2, etc.
    // these arguments appear after the format string: 
    // {0}   refers to the 1st value for foramtting, i.e. "Old Price"
    // {1}   refers to the 2nd value for foramtting, i.e. "New Price"

    // If you are using String interpolation $"{}" you don't need the argument numbers are in the
    // previous two lines.
    // {,12} means to output the text into a column width of 12, it aligns right by default
    // {-12} means to left align in a column width of 12
    // {:N}  means to format the value as a number, i.e. to 2 decimal places
    // 
    // For more on formatting strings, see
    // https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=net-6.0

    //Console.WriteLine(String.Format("{0,12}{1,12}", "Old Price", "New Price"));
    Console.WriteLine($"{"Old Price",-12}{"New Price",-12}");

    // To print the contents of two arrays at once, you cannot use the foreach loop
    // and must use the for loop where you will use the counter i to access the elements
    // in each array.
    for (int i = 0; i < oldPrices.Length; i++)
    {
        // Using String.Format()
        //Console.WriteLine(String.Format("{0,12}{1,12:N}", oldPrices[i], newPrices[i]));

        // And using string interpolation:
        Console.WriteLine($"{oldPrices[i], -12:N}{newPrices[i], -12:N}");
    }
}
/** OUTPUT:
Old Price   New Price
12.50       13.00
11.20       11.65
10.90       11.34
4.99        5.19
5.66        5.89
25.40       26.42
14.30       14.87
33.00       34.32
24.50       25.48
1.25        1.30
2.20        2.29
3.48        3.62
*/


/**
 * Create an array to hold five product names, e.g.: Mouse mat, A4 refill pad, keyboard, 
 * Sharpie box of 12, Level arch file.  Print out the contents of the array.
 * Create a second array called prices and store the prices for each product, 
 * e.g.: 4.50, 1.29, 34.99, 10.49, 2.50. Print out the contents of the prices array. 
 * Now using one loop, print out the product and its corresponding price on the same line.
 */
void Ex9ProductsAndPrices()
{
    String[] productNames = {"Mouse mat", "A4 refill pad", "keyboard",
                              "Sharpie box of 12", "Level arch file"};

    decimal[] prices = { 4.50m, 1.29m, 34.99m, 10.49m, 2.50m };

    Console.WriteLine("Printing out the product names");
    foreach (string name in productNames)
    {
        Console.WriteLine(name);
    }

    Console.WriteLine("Printing out the product prices");
    foreach (decimal price in prices)
    {
        Console.WriteLine(price);
    }

    for (int i = 0; i < productNames.Length; i++)
    {
        Console.WriteLine($"Product: {productNames[i]}, price: {prices[i]:C}");
    }
}
/** OUTPUT:         NOTE: The EURO € symbol will not display in the console window.
Product: Mouse mat, price: ?4.50
Product: A4 refill pad, price: ?1.29
Product: keyboard, price: ?34.99
Product: Sharpie box of 12, price: ?10.49
Product: Level arch file, price: ?2.50
*/


/*
 * Declare an array of 10 int elements and populate it. Using a loop work out which is 
 * the smallest number in the array and display that number when the loop has finished. 
 */
void Ex10TheSmallestNumber()
{
    int[] numbers = { 5, 8, 6, 9, 12, 3, 7, 1, 15, 12 };

    // Make the smallest be the first element in the array
    int smallest = numbers[0];

    // The for loop starts on the second element (i is set to 1 and not 0), the 1st time
    // through the loop, it checks to see if 8 is smaller than 5. With each iteration, 
    // it will check the next number in the array against the 'smallest'. 
    for (int i = 1; i < numbers.Length; i++)
    {
        // If the current element is smaller than the smallest
        if (numbers[i] < smallest)
            // Make the current element the smallest
            smallest = numbers[i];
    }
    // The smallest number is 1
    Console.WriteLine("The smallest number is " + smallest);
}



/*
 * Declare an array of 10 int elements and populate it. Declare a variable to hold the
 * total of all ten numbers, after you have declared the variable, use a loop to add
 * each element onto the total variable, when the loop is finished output the total. 
 */
void Ex11TheTotalOfArrayElements()
{
    int[] numbers = {7, 5, 9, 12, 24, 9, 6, 21, 3, 4};
    int total = 0;

    // You can use either the for or the foreach loop here, you are simply adding
    // each element onto the total variables
    foreach(int number in numbers)
    {
        total += number; // total = total + number;
    }

    Console.WriteLine("The total is " + total); // The total is 100
}



/*
 * A)	Amend the previous exercise so that the average of all 10 numbers is calculated 
 *      and displayed after the loop has complete.
 * B)	Amend the previous exercise so that an average is calculated and displayed inside 
 *      the loop for each iteration. 
 */
void Ex12TotalAndAverage()
{
    int[] numbers = { 7, 5, 11, 12, 24, 9, 6, 21, 3, 4 };
    int total = 0;
    decimal average = 0;

    // You can use either the for or the foreach loop here, you are simply adding
    // each element onto the total variables
    foreach (int number in numbers)
    {
        total += number;
    }

    // Here the total is cast to a decimal/ converted to a decimal, so that there isn't
    // the error of dividing and int by an int, which would produce the wrong result.
    average = (decimal)total / numbers.Length;

    Console.WriteLine($"The total is: {total} and the average is : {average}");

    // A running average:
    decimal runningTotal = 0;
    decimal runningAverage = 0;
    string text = "";

    // int[] numbers = { 7, 5, 11, 12, 24, 9, 6, 21, 3, 4 };
    for (int i = 0; i < numbers.Length; i++)
    {
        // This concatenates each element onto the string text, just for display purposes
        text += numbers[i] + " ";
        // This will print out each element
        Console.WriteLine("Elements: " + text);

        runningTotal += numbers[i];
        runningAverage = runningTotal / (i + 1);
        // :N converts each decimal to two decimal places
        Console.WriteLine($"The running average is {runningAverage:N}");
    }
}
/* OUTPUT
Elements: 7
The running average is 7.00
Elements: 7 5
The running average is 6.00
Elements: 7 5 11
The running average is 7.67
Elements: 7 5 11 12
The running average is 8.75
Elements: 7 5 11 12 24
The running average is 11.80
Elements: 7 5 11 12 24 9
The running average is 11.33
Elements: 7 5 11 12 24 9 6
The running average is 10.57
Elements: 7 5 11 12 24 9 6 21
The running average is 11.88
Elements: 7 5 11 12 24 9 6 21 3
The running average is 10.89
Elements: 7 5 11 12 24 9 6 21 3 4
The running average is 10.20
*/


/*
 * Using a 2-dimensional array, store some football teams along with the players’ names. 
 * You could use the first element in each array to store the name of the team and the 
 * other elements to store the player’s names.  Print out all of the details.
 */
void Ex13FootballTeams()
{
    string[][] footballTeams = new string[3][];

    footballTeams[0] = new string[] {"Team 1", "Adam", "Aaron", "Able"};

    footballTeams[1] = new string[] {"Team 2", "Ben", "Brian", "Bill", "Benny", "Bernard"};

    footballTeams[2] = new string[] {"Team 3", "Callum", "Colin", "Carl", "Cian"};

    for (int i = 0; i < footballTeams.Length; i++) // 3 teams
    {   // The 1st element as a header, i.e. Team 1:
        Console.WriteLine(footballTeams[i][0] + ":");
        Console.WriteLine("-------");

        // Length for the inner loop will be 4, 6 and 5. Start the loop at 1
        // to skip the team name and go straight  to the players
        for (int j = 1; j < footballTeams[i].Length; j++)
        {
            // Print the player's name
            Console.Write(footballTeams[i][j]);

            // If it's not the last element in the array, 
            // add a ',' after the player's name
            if (j != footballTeams[i].Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("\n"); // Two newlines after each team
    }
}
/** OUTPUT
Team 1:
-------
Adam, Aaron, Able

Team 2:
-------
Ben, Brian, Bill, Benny, Bernard

Team 3:
-------
Callum, Colin, Carl, Cian
*/




/*
 * Use nested for loops to output the multiplication table for the number 12 to the 
 * console. Your output should be similar to the following:
 * 
                   1   2   3   4   5   6   7   8   9  10  11  12
               +------------------------------------------------
             1 |   1   2   3   4   5   6   7   8   9  10  11  12
             2 |   2   4   6   8  10  12  14  16  18  20  22  24
             3 |   3   6   9  12  15  18  21  24  27  30  33  36
             4 |   4   8  12  16  20  24  28  32  36  40  44  48
             5 |   5  10  15  20  25  30  35  40  45  50  55  60
             6 |   6  12  18  24  30  36  42  48  54  60  66  72
             7 |   7  14  21  28  35  42  49  56  63  70  77  84
             8 |   8  16  24  32  40  48  56  64  72  80  88  96
             9 |   9  18  27  36  45  54  63  72  81  90  99 108
            10 |  10  20  30  40  50  60  70  80  90 100 110 120
            11 |  11  22  33  44  55  66  77  88  99 110 121 132
            12 |  12  24  36  48  60  72  84  96 108 120 132 144
 */
void Ex14TimesTables()
{
    // Output the heading:
    Console.Write("     "); // followed by 1 to 12
    for (int i = 1; i <= 12; i++)
    {
        Console.Write($"{i,5}");
    }
    Console.WriteLine("\n    +------------------------------------------------------------");

    for (int i = 1; i <= 12; i++)
    {
        Console.Write($"{i,3} |");
        for (int j = 1; j <= 12; j++)
        {
            Console.Write($"{i * j,5}"); // '5' is to right align the output in a column width of 5 characters
        }
        Console.WriteLine();
    }
}


/*
 * Using loops, output all the possible times in a 24 hours clock. Start off with 
 * hours and minutes and then add seconds. Sample output (hours and minutes): 
 * 00:00
 * 00:01
 * 00:02
 * 00:03
 * 00:04
 * 00:05
 * 00:06
 * ...
 * 11:55
 * 11:56
 * 11:57
 * 11:58
 * 11:59
 */
void Ex15Clock()
{
    // Hours
    for (int hh = 0; hh <= 23; hh++)
    {
        for (int mm = 0; mm <= 59; mm++)
        {
            for (int ss = 0; ss <= 59; ss++)
            {
                // :00 will pad the column width of 2 with zeros 
                Console.WriteLine($"{hh:00}:{mm:00}:{ss:00}");
            }
        }
    }
    // Output: 
    //00:00:00
    //00:00:01
    //00:00:02
    //00:00:03
    //00:00:04
    //00:00:05
    //00:00:06
    //.....lines missing
    //23:59:53
    //23:59:54
    //23:59:55
    //23:59:56
    //23:59:57
    //23:59:58
    //23:59:59
}
