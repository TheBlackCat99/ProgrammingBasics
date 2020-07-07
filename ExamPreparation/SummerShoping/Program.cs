namespace SummerShopping
{
    using System;

    // From SoftUni Programming Basics April 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating if someone has enough money to buy the summer items they want, based on their budget, 
         the cost of a towel and the discount they will get, because they're regular customers.
         It's known that they want to buy 4 different summer items and each of them has a price,
         based on the price of the other items(excluding the towel, which price we know from the beginning)
         The result is the money that the person will have left after the purchase or the amount that is not enough, based on their budget.*/

        public static void Main()
        {
            Console.Write("Budget: ");
            int budget = int.Parse(Console.ReadLine());

            Console.Write("Beach towel price: ");
            decimal towelPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Discount in %: ");
            int discount = int.Parse(Console.ReadLine());

            decimal umbrellaPrice = 2 * (towelPrice / 3); // umbrella = 1/3 of towel's price

            decimal flipFlopPrice = umbrellaPrice * 0.75m; // flip-flops = 75% from the umbrella

            decimal bagPrice = (flipFlopPrice + towelPrice) / 3; // bag is 1/3 from flip-flop + towel prices

            decimal total = towelPrice + umbrellaPrice + bagPrice + flipFlopPrice;
            decimal totalSumWithDiscount = total - (total * discount / 100);

            if (budget >= totalSumWithDiscount)
            {
                Console.WriteLine($"Annie's sum is {totalSumWithDiscount:F2} lv. She has {budget - totalSumWithDiscount:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalSumWithDiscount:F2} lv. She needs {totalSumWithDiscount - budget:F2} lv. more.");
            }

            Console.ReadLine();
        }
    }
}