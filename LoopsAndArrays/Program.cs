
// Calls the method underneath
//WhileLoop();
//DoWhileLoop();
//ReadFromTheConsole();
//ForLoop();
//ArraysExample();
//ArraysRefresher();
//rectangularArrays();
jaggedArray();


void WhileLoop()
{

    int i = 0;

    // The body of the loop will execute when the condition is true, the condition
    // will be checked after the body has executes to see if the loop should execute
    // again. When the condition becomes false, the body will not execute. 
    // The condition must be a bool, i.e. true or false
    while (i < 4)
    {        
        Console.WriteLine($"The value of i is {i}"); // 0 
        i++;    // increment operator, the same as:
                // i = i + 1;
                // i += 1;
    }
}

void DoWhileLoop()
{
    // A do while loop will ALWAYS execute at least once, because the condition is physically at
    // the bottom. Use a do while loop when you want to present a meny to the user and depending
    // on their choice, you might display the meny again. 

    // The loop counter
    int i = 0; 

    do
    {
        // Anything declared inside curly brackets cannot be seen outside of those {}.
        Console.WriteLine($"The value of i is {i}");
        i++; // increment the counter by 1  

    } while (i < 4);
}

void ForLoop()
{
    // There are three sections in this for loop:
    // 1. The initialisation section, where you declare and initialise a counter. 
    //    This section will only execute ONCE per loop. 
    // 2. The condition or test. The condition must evaluate to a bool. When the condition
    //    is true, the body of the loop will execute, when the condition becomes false, the
    //    next line of code after the loop will execute.
    // 3. This can be any statement but is traditionally used to increment the counter: the 
    //    increment section.

    // Anythnig declared inside the parenthesis can be seen inside the body of the loop

    // i = 

    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("The value of i is: " + i);
    }

    // The last thing to happen in any loop is the condition. When the condition is true
    // The body of the loop will execute, when the condition is false, the next line of code
    // after the loop will execute. 


    // The code below is identical to the for loop above and written so that it look like
    // a while loop. The point is, a while loop can be used instead of a for loop and vice versa.
    int j = 0;
    for (; j < 4; )
    {
        Console.WriteLine("The value of j is : " + j);
        j++;    
    }
}


void ArraysExample()
{
    // Only one value can be stored in a value type (int, long, short, double, decimal,
    // string, bool, char).
    // Just a reminder of how to declare a single variable
    // data type followed by the name and assign a value to it.
    int num = 10;   // num [10]

    // You can store multiple values in the one variable when you declare ar array.
    int[] numbers; // Declares a variable called numbers that will refer to an array of int types.
    // no memory is yet assigned
    // numbers ->

    numbers = new int[6]; // Sets up new memory for 6 elemens in an int array, each element 
    // will get a default value

    // index:      0  1  2  3  4  5
    // numbers -> [0][0][0][0][0][0]

    // To print out each element, you use an index, the first element is at the index 0:
    Console.WriteLine(numbers[0]);  // [0] will print the first element
    Console.WriteLine(numbers[1]);
    Console.WriteLine(numbers[2]);
    Console.WriteLine(numbers[3]);
    Console.WriteLine(numbers[4]);
    Console.WriteLine(numbers[5]);
    //Console.WriteLine(numbers[6]); //  IndexOutOfRangeException

    // Populate the array:
    numbers[0] = 2;
    numbers[1] = 8;
    numbers[2] = 6;
    numbers[3] = 8;
    numbers[4] = 1;
    numbers[5] = 5;

    // If there are six elements in the array, the index goes from 0 to 5
    // Any index outside of that range will throw an IndexOutOfRangeException
    Console.WriteLine(numbers[0]);  // [0] will print the first element
    Console.WriteLine(numbers[1]);
    Console.WriteLine(numbers[2]);
    Console.WriteLine(numbers[3]);
    Console.WriteLine(numbers[4]);
    Console.WriteLine(numbers[5]);


    // Use a loop to print out the contents of the array
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);  
    }

    // A one-liner for creating and populating an array of decimals
    // You never place a number in [] when declaring an array (on the LHS), only on the 
    // RHS side when you are setting up new memory (see line 93).
    decimal[] prices = {1.25m, .49m, 2.5m, 12.8m, 23.5m, .2m};

    // new decimal[] is optional when you are declaring an array
    //decimal[] prices = new decimal[] { 1.25m, .49m, 2.5m, 12.8m, 23.5m, .2m };

    // Use the foreach loop, which can be used to iterate through a list or an array.
    // You don't have to declare a counter, an internal counter is maintained for you.
    // This foreach loop cannot be used to change the value of the elements in the array.
    // As it loops, the variable price gets a copy of each element, you can then print out the
    // copy. 
    Console.WriteLine("Contents of the prices array: ");

    foreach (decimal price in prices)
    { 
        Console.WriteLine(price);
    }

    // Use a for loop to increase each price by 20 cent.
    foreach (decimal price in prices)
    {
        //price = price + 20;  // won't work
    }

    for (int i = 0; i < prices.Length; i++)
    {
        prices[i] = prices[i] + .2m; // Add .2 to each element in the array
        // prices[i] += .2m;
    }

    Console.WriteLine("The array after a price increase:");

    // Print out the content of the array
    foreach (var price in prices)
    {
        Console.WriteLine(price);
    }
}

/*
 * This code here will read a string from the Console window and attempt to
 * convert it into an int, if unsuccessful a message is displayed.
 */
void ReadFromTheConsole()
{
    Console.WriteLine("Please enter your choice: ");
    String choice = Console.ReadLine();
    Console.WriteLine("You typed : " + choice);

    // Convert/ parse the string into an int
    //int number = int.Parse(choice);
    // Console.WriteLine("The string as a number " + number);

    // TryParse() will attempt to convert a String into an int, if successful
    // this method will return true and the variable value will contain the result, 
    // if unsuccessful, the method will return false.
    bool success = int.TryParse(choice, out int value);
    if (success == true)
    {
        Console.WriteLine("You string as a number is " + value);
    }
    else
    {
        Console.WriteLine("The string could not be parsed");
    }
}


void ArraysRefresher()
{
    // Once an array is created in memory, its size cannot change, you cannot add an
    // extra element or remove an element.
    String[] names;
    names = new String[4];     // [null][null][null][null]
    names[0] = "Maggie";
    names[1] = "Emma";
    names[2] = "Geetha";

    // If you just want to print the contents of an array, use the foreach loop.
    // If you want to use a loop to populate an array, you need access to each element,
    // i.e. you need the index [i] and therefore you must use the for loop. 
    // If you are printing the contents of an array and you want to print out which element
    // each value is at, then you must use the for loop with the i counter.

    // A foreach loop can only print/ access the contents of one collection/ array at once
    // If you want to print two arrays at once, you must use the for loop. 

    // On the RHS of the keyword 'in' is the name of the array you are looping through
    // On the LHS, you declare a single variable to hold a copy of each element as it loops.
    foreach (String name in names)
    {
        Console.WriteLine(name);
    }


    // The only way to change the array size is to create a brand new array and reassign
    // that array to the old reference variable. 
    // null - means no object
    names = new String[5]; // ["Renata"][null][null][null][null]
    names[0] = "Renata";

    // Use a loop to populate this array  // ["Name 1"]["Name 2"]["Name 3"]["Name 4"]["Name 5"]
    for (int i = 0; i < names.Length; i++) // i = 5
    {
        names[i] = "Name " + (i + 1);
    }

    Console.WriteLine("Print the contents of the names array with 5 elements");
    // Print the contents 
    foreach (string item in names)
    {
        Console.WriteLine(item);
    }

    decimal[] taxRates = { 9, 13.5m, 21 };
    String[] taxName = { "Dining", "Service", "Sales" };

    // Heading, each heading is in a column width of 15 spaces and left aligned
    Console.WriteLine($"{"Name",-15}{"Tax Rate",-15}");

    for (int i = 0; i < taxRates.Length; i++)
    {
        Console.WriteLine($"{taxName[i],-15}{taxRates[i] + "%",-15}");
    }

    Console.WriteLine(names.ToString()); 

    // OUTPUT
    //Name           Tax Rate
    //Dining         9%
    //Service        13.5%
    //Sales          21%
}

void rectangularArrays()
{
    // In this rectangular array, each array MUST be the same size, here
    // there are four arrays each with two elements.
    int[,] nums = { { 6, 2 }, { 9, 5 }, { 2, 7 }, {9, 1} };


    //  1st dimension   nums ->   []    []    []      []       .GetLength(0) -> 4
    //                            /     /      \       \
    //  2nd dimension         [6][2] [9][5]  [2][7]  [9][1]   .GetLength(1) -> 2
  
    // Declares a 2D array: 4 arrays, each with 2 elements.
    int[,] TwoD = new int[4,2];
    // initialise each one here........

    // Print out the contents of the 2D array, the long way (no loop)
    Console.WriteLine(nums[0, 0]);
    Console.WriteLine(nums[0, 1]);
    Console.WriteLine(nums[1, 0]);
    Console.WriteLine(nums[1, 1]);
    Console.WriteLine(nums[2, 0]);
    Console.WriteLine(nums[2, 1]);
    Console.WriteLine(nums[3, 0]);
    Console.WriteLine(nums[3, 1]);

    Console.WriteLine("Output from the for loops:");
    //       i = 0 1 2 3 4 
    for (int i = 0; i < nums.GetLength(0); i++)
    {    //      j = 0 1 2 
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + " ");  // 6 2
                                              // 9 5
        }                                     // 2 7 
                                              // 9 1 
        Console.WriteLine();  // output a new line after each array is printed
    }
}

void jaggedArray()
{
    // This is a jagged array, there are three arrays and each one can be any length
    int[][] matrix = new int[3][];
    // Specify what size each array is
    matrix[0] = new int[2];
    matrix[1] = new int[4];
    matrix[2] = new int[3];

    matrix[0][0] = 6;
    matrix[0][1] = 4;

    matrix[1][0] = 3;
    matrix[1][1] = 1;
    matrix[1][2] = 8;
    matrix[1][3] = 9;

    matrix[2][0] = 2;
    matrix[2][1] = 3;
    matrix[2][2] = 8;

    // one-liner for creating a jagged array
    double[][] matrix2 =  { new double[2] {2,3}, new double[] {2, 6, 5}, new double[3] {4,6,5} };

    Console.WriteLine("Output from the Jagged Array");
    foreach (int [] singleArray in matrix)
    {
        foreach (int num in singleArray)
        {
            Console.Write(num  + " ");
        }
        Console.WriteLine();
    }
}