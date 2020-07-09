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
            decimal discount = int.Parse(Console.ReadLine());

            decimal umbrellaPrice = 2 * (towelPrice / 3); // umbrella = 2/3 of towel's price

            decimal flipFlopsPrice = umbrellaPrice * 0.75m; // flip-flops = 75% from the umbrella's price

            decimal bagPrice = (flipFlopsPrice + towelPrice) / 3; // bag is 1/3 from flip-flops + towel prices

            decimal total = towelPrice + umbrellaPrice + bagPrice + flipFlopsPrice;
            total -= total * discount / 100; // substracts discount from total price

            if (budget >= total)
            {
                Console.WriteLine($"Annie's sum is {total:F2} lv. She has {budget - total:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {total:F2} lv. She needs {total - budget:F2} lv. more.");
            }

            Console.ReadLine();
        }
    }
}