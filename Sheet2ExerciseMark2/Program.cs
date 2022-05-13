// method calls
Ex1();
Ex2();
//Ex3();  
Ex4();
Ex5();
Ex6();
Ex7();
Ex8();
Ex8ArrayOfPrices();
Ex9PRoductAndPrice();
Ex10SmallestNumber();

// methods bodies

/*
 * Write a while loop that executes 20 times. 
 */
void Ex1()
{
    int i = 0;

    while (i < 20)
    {
        Console.WriteLine("The value of i " + i);
        i++;
    }
}

/*
 * Convert the while loop you wrote in the previous exercise to a do...while loop. 
 */
void Ex2()
{
    int i = 0;
    do
    {
        Console.WriteLine("The value of i " + i);
        i++;
    } while (i < 20);
}

/*
 * Write a while loop that will result in an infinite loop. 
 */
void Ex3()
{
    while (true)
    {
        Console.WriteLine("This is an infinite loop");
    }

    int i = 0;

    while (i > 10)
    {
        Console.WriteLine("This is an infinite loop");
    }
}

/*
 * Write a do...while loop that can never execute more than once. 
 */
void Ex4()
{
    do
    {
        Console.WriteLine("This will execute once");

    } while (false); // When the condition is true, loop again, when the condition is false,
    // don't loop again.
}

/*
 * Write a while loop that counts backwards from 20 to 10.
 */
void Ex5()
{
    int i = 20;

    while (i >= 10)
    {
        Console.WriteLine("The value of i is: " + i);
        i--; 
        // --i;
        // i = i - 1;
        // i -= 1;
    }
}

/*
 * Write a for loop that will print the numbers between 10 and 20.
 */
void Ex6()
{
    for (int i = 10; i <= 20; i++)
    {
        Console.WriteLine("The value of i is : " + i);
    }
}


/*
 * Write a program that adds up the numbers 0 to 39 using a for loop.
 */
void Ex7()
{
    int total = 0; 

    for (int i = 0; i <= 39; i++)
    {
        //total = total + i;
        total += i;
    }

    Console.WriteLine("The total is : " + total);
}


/*
 * Showing you how to format output
 */
void Ex8()
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
 */
void Ex8ArrayOfPrices()
{
    decimal[] oldPrices = { 12.50m, 11.20m, 10.90m, 4.99m, 5.66m, 25.40m, 
                            14.30m, 33m, 24.50m, 1.25m, 2.20m, 3.48m };
    // The second array that is the same size as the first.
    decimal[] newPrices = new decimal[oldPrices.Length];

    // Loop for populating the newPrices array
    for (int i = 0; i < oldPrices.Length; i++)
    {
        newPrices[i] = oldPrices[i] * 1.04m;
    }

    Console.WriteLine($"{"Old Prices",-15}{"New Prices",-15}");
    for (int i = 0; i < oldPrices.Length; i++)
    {
        Console.WriteLine($"{oldPrices[i],-15:N}{newPrices[i],-15:N}");
    }
}


/**
 * Create an array to hold five product names, e.g.: Mouse mat, A4 refill pad, keyboard, 
 * Sharpie box of 12, Level arch file.  Print out the contents of the array.
 * 
 * Create a second array called prices and store the prices for each product, 
 * e.g.: 4.50, 1.29, 34.99, 10.49, 2.50. Print out the contents of the prices array. 
 * 
 * Now using one loop, print out the product and its corresponding price on the same line.
 */
void Ex9PRoductAndPrice()
{
    string[] names = { "Mouse mat", "A4 refill pad", "keyboard", "Sharpie box of 12", "Level arch file" };

    decimal[] prices = { 4.50m, 1.29m, 34.99m, 10.49m, 2.50m };

    Console.WriteLine("List of products and their price");
   
    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine($"Product name: {names[i]}, price: {prices[i]:c}");
    }
}


/* 
 * Declare an array of 10 int elements and populate it. Using a loop work out which is the 
 * smallest number in the array and display that number when the loop has finished. 
 */
void Ex10SmallestNumber()
{
    Random random = new();
    int[] numbers = new int[10];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(20); // a number between 0 and 19 inclusive

        Console.Write(numbers[i] + " ");  // 5 0 4 9 15 17 19 16 14 6
    }

    // Make smallest the first element in the list.
    int smallest = numbers[0];   // 5

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < smallest) 
            smallest = numbers[i];
    }

    Console.WriteLine("The smallest number is " + smallest);
} 

