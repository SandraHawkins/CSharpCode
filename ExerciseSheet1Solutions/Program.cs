using System.Globalization; // needed for CultureInfo in the first exercise

/*
namespace ExerciseSheet1
{
    public class Ex1
    {
        static void main()
        {

        }
    }
 }
*/

// Each exercise solution is typed in the body of a method underneath.
// The following lines are calls to each method. 

//Ex1Salary();
//Ex2Average();
//Ex3HoursWorked();
//Ex4SmallerNumber();
//Ex5MonthAsASeason();
//Ex6NumberAsAWord();
//Ex7VowelOrConsonant();
Ex8DiceGame();

/*
 * Your monthly salary (divide the salary by 12) 
 * Your weekly salary (divide the salary by 52)
 * The total amount you will earn in 5 years.
 * Your new salary if you get an 8% pay rise.
 */
void Ex1Salary()
{
    double salary = 30_000;
    double monthlySalary = salary / 12;
    double weeklySalary = salary / 52;
    double fiveYears = salary * 5;
    const double PAY_RISE = 1.08;  // 8%
    double salaryAfterPayRise = salary * PAY_RISE;

    Console.WriteLine("The monthly salary is " + monthlySalary);  // 2500
    Console.WriteLine("Monthly salary as a currency " + monthlySalary.ToString("C")); // €2,500.00

    // Create a CultureInfo object and ask to get the Culture information for Ireland
    CultureInfo culture = CultureInfo.GetCultureInfo("en-ie");
    Console.WriteLine("The monthly salary is : " + String.Format(culture, "{0:C}", monthlySalary));

    Console.WriteLine("The salary is : " + salary + " and the weekly salary is " + weeklySalary);
    Console.WriteLine($"The salary is : {salary} and the weekly salary is {weeklySalary}");

    Console.WriteLine($"The salary after an 8% payrise is {salaryAfterPayRise.ToString("C")}");
}

/*
 * Write a program that declares three numbers and assign them the following values: 
 * 1.25, 2.65 and 22.65. Using the appropriate operators, print out the total and 
 * average of these values.
 */
void Ex2Average()
{
    double num1 = 1.25;
    double num2 = 2.65;
    double num3 = 22.65;

    double total = num1 + num2 + num3;
    double average = total / 3;

    Console.WriteLine("The total is " + total);
    Console.WriteLine($"The total of {num1} and {num2} and {num3} is {total}");
    Console.WriteLine($"The average of {num1}, {num2} and {num3} is {(num1 + num2 + num3) / 3}");
    Console.WriteLine($"The average of {num1}, {num2} and {num3} is {average}");
}

/**
 * Write a program that contains variables that hold your hourly rate and number of hours 
 * that you worked. Display your gross pay, your withholding tax, which is 15 per cent of 
 * your gross pay, and your net pay (gross pay - withholding).
 */
void Ex3HoursWorked()
{
    double hourlyRate = 10;
    double numHoursWorked = 40;
    const double TAX = 0.15;

    // Calculations
    double grossPay = hourlyRate * numHoursWorked;
    double withHoldingTax = grossPay * TAX;
    double netPay = grossPay - withHoldingTax;

    Console.WriteLine($"Gross pay: {grossPay.ToString("c")}, tax paid: {withHoldingTax.ToString("c")}");
    Console.WriteLine($"Net pay: {netPay.ToString("c")}");
}


/**
 * Write a program to store two numbers in separate variables. Find the smaller of the 
 * two and output that number.
 */
void Ex4SmallerNumber()
{
    int number1 = 20;
    int number2 = 40;

    if (number1 < number2)
    {
        Console.WriteLine($"{number1} is smaller than {number2}");
    }
    else if (number2 < number1)
    {
        Console.WriteLine($"{number2} is smaller than {number1}");
    }
    else
    {
        Console.WriteLine($"{number1} is the same as {number2}");
    }
}

 /**
 * Store the month as an integer in a variable. Using if-else statements, 
 * output which season that month is, i.e. if the month is 5, output 
 * ‘Month 5 is Summer’.
 */
void Ex5MonthAsASeason()
{
   
    int month = 15;

    if (month == 11 || month == 12 || month == 1)
        Console.WriteLine("Month " + month + " is winter");
    else if (month == 2 || month == 3 || month == 4)
        Console.WriteLine($"Month {month} is spring");
    else if (month == 5 || month == 6 || month == 7)
        Console.WriteLine($"Month {month} is summer");
    else if (month == 8 || month == 9 || month == 10)
        Console.WriteLine($"Month {month} is autumn");
    else
        Console.WriteLine($"{month} is an invalid month");

    // The same but using a switch
    switch (month)
    {
        case 11:
        case 12:
        case 1:
            Console.WriteLine("Month " + month + " is winter");
            break;
        case 2:
        case 3:
        case 4:
            Console.WriteLine($"Month {month} is spring");
            break;
        case 5:
        case 6:
        case 7:
            Console.WriteLine($"Month {month} is summer");
            break;
        case 8:
        case 9:
        case 10:
            Console.WriteLine($"Month {month} is autumn");
            break;
        default:
            Console.WriteLine($"{month} is an invalid month");
            break;
    }
}

/*
 * Store a single numeral (0 - 9) in a variable then output its value as a 
 * word (the output routine must be capable of handling all the numbers
 * between 0 and 9). For example, an input of 5 will display the word 
 * “five”. Have the program display "Invalid value" for any other value.
 * Use the switch statement.
 */
void Ex6NumberAsAWord()
{
    int number = 15;
    string text = "The number is ";

    switch (number)
    {
        case 0:
            text += "zero";
            break;
        case 1:
            text = text + "one";
            break;
        case 2:
            text = text + "two";
            break;
        case 3:
            text = text + "three";
            break;
        case 4:
            text = text + "four";
            break;
        case 5:
            text = text + "five";
            break;
        case 6:
            text = text + "six";
            break;
        case 7:
            text = text + "seven";
            break;
        case 8:
            text = text + "eight";
            break;
        case 9:
            text = text + "nine";
            break;
        default:
            text = "Invalid value";
            break;
    }

    Console.WriteLine(text);
}

/*
 * Write a program to check whether a letter character is a vowel or a 
 * consonant using a switch statement. In English the vowels are 
 * a, e, i, o and u, both lowercase and uppercase. Letters other than 
 * vowels are known as consonants.
 */
void Ex7VowelOrConsonant()
{
    char letter = 'I';

    switch (char.ToLower(letter))
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            Console.WriteLine("The letter is a vowel");
            break;
        default:
            Console.WriteLine("The letter is a consonant");
            break;
    }
}

/*
 * A simple dice game is played with two dice (store those values in two variables). 
 * For a normal dice throw, the amount of points you get will be calculated by multiplying the 
 * eyes from each dice, i.e. a throw of 4 and 2 would give you 8 points. There are some 
 * exceptions to this rule:
 * - 6 is a special number: Whenever at least one 6 is thrown, the sum of the eyes will be 
 *   used instead of the multiplication.
 * - 3 is your lucky number: For each 3, you will get 10 bonus points.
 * - 5 is your unlucky number: For each 5, your score will be decreased by 4 points.
 */
void Ex8DiceGame()
{
    Random rnd = new Random();      // Creates an instance of the Random class
    int dice1 = rnd.Next(1, 7);     // Gets a random number between 1 and 6
    int dice2 = rnd.Next(1, 7);     
    int score;

    // Check for a 6 and sum the values if a 6 is rolled.
    if (dice1 == 6 || dice2 == 6)
        score = dice1 + dice2;  
    else // if neither are a 6
        score = dice1 * dice2;

    if (dice1 == 3)
        //score = score + 10;
        score += 10;
    else if (dice1 == 5)
        score -= 4; // score = score - 4;

    if (dice2 == 3)
        score += 10;
    else if (dice2 == 5)
        score -= 4;

    Console.WriteLine($"The score of {dice1} and {dice2} is {score}");
}