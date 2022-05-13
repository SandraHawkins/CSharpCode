using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ExerciseSheet1VariablesOperatorsIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Your monthly salary (divide the salary by 12)
         * Your weekly salary (divide the salary by 52)
         * The total amount you will earn in 5 years.
         * Your new salary if you get an 8% pay rise.
         */
        private void BtnEx1Salary_Click(object sender, EventArgs e)
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
        private void BtnAverage_Click(object sender, EventArgs e)
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
        private void BtnEx3HoursWorked_Click(object sender, EventArgs e)
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

            LblResult.Text = "Gross pay: " + grossPay.ToString("c");    
            TxtResult.Text = "Net pay: " + netPay.ToString("c");    
        }

        /**
         * Write a program to store two numbers in separate variables. Find the smaller of the 
         * two and output that number.
         */
        private void BtnSmallerNumber_Click(object sender, EventArgs e)
        {
            int number1 = 20;
            int number2 = 40;

            if (number1 < number2)
            {
                Console.WriteLine($"{number1} is smaller than {number2}");
            } else if (number2 < number1)
            {
                Console.WriteLine($"{number2} is smaller than {number1}");
            } else
            {
                Console.WriteLine($"{number1} is the same as {number2}");
            }
        }

        private void BtnEx2AnotherWay_Click(object sender, EventArgs e)
        {
            int number1 = 20;
            int number2 = 40;

            Console.WriteLine($"The smaller number is {Math.Min(number1, number2)}");
        }
    }
}
