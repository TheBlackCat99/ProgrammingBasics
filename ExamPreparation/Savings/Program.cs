namespace Savings
{
    using System;

    // From SoftUni Programming Basics April 2020 Exam Preparation Problems
    public class Program
    {
        /*The program takes a person's monthly salary, the number of months they want to save money for
        and the sum they need each month for personal expenses. They also set aside 30% of their income every month for emergency needs.
        Income per month is between 1500 and 10000, personal expenses are between 300 and 1000.
        As a result, the program calculates how much % in total they can save each month and the sum they'll save for the given period.*/

        public static void Main()
        {
            Console.WriteLine("Income per month: ");
            decimal incomePerMonth = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Months spent saving: ");
            int monthsToSave = int.Parse(Console.ReadLine());

            Console.WriteLine("Amount for personal expenses: ");
            decimal personalExpenses = decimal.Parse(Console.ReadLine());

            decimal emergencySavings = incomePerMonth * 0.3m;

            decimal moneyLeftToSavePerMonth = incomePerMonth - (personalExpenses + emergencySavings);

            decimal totalMoneySaved = moneyLeftToSavePerMonth * monthsToSave;
            decimal percentSavedPerMonth = (moneyLeftToSavePerMonth / incomePerMonth) * 100;

            Console.WriteLine($"She can save {percentSavedPerMonth:F2}%");
            Console.WriteLine($"{totalMoneySaved:F2}");

            Console.ReadLine();

            // string.Format("{0:0.00}", value); --> formats the floating point number to however many digits we want after the floating point
        }
    }
}