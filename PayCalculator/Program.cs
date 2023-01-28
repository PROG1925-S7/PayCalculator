/*
 * Pay Calculator
 * 
 * Purpose: to demonstrate getting input from the user
 * Name:    Tony Theodoropoulos
 * Revision History: created Jan 28 by Tony Theo...
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // variable declaration
            string firstName;
            double hours;
            double payRate;
            double preTax;
            double taxRate = 0.25;
            double taxAmount;
            double earned;

            //get inputs
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter hours worked: ");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your rate of pay: ");
            payRate = Convert.ToDouble(Console.ReadLine());

            //do calcuations
            preTax = hours * payRate; 
            taxAmount = preTax * taxRate;
            earned = preTax - taxAmount;

            earned = Math.Round(earned, 2); 

            //show outputs
            Console.WriteLine($"Pay for {firstName}\n");
            Console.WriteLine($"Hours worked:   {hours}");
            Console.WriteLine($"Rate of Pay:    {payRate.ToString("C")}");
            Console.WriteLine($"Pre Tax amount: {preTax.ToString("C")}");
            Console.WriteLine($"Tax Amount:     {taxAmount.ToString("C")}");
            Console.WriteLine($"Total Earned:   {earned.ToString("C")}");      
            
            Console.ReadKey();
        }
    }
}
