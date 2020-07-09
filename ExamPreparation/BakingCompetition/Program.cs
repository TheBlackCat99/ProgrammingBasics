namespace BakingCompetition
{
    using System;

    // From SoftUni Programming Basics April 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating results from baking competition. Each person can choose the dessert they want to bake.
        Options are cookies, cakes and waffles. Each baked good is then sold for a specific price that is known from the start. 
        The results is the total number of baked goods, as well as the money raised for the charity.
        In order for each person to stop their turn, we have to enter "Stop baking!" in the console.*/
        public static void Main()
        {
            Console.Write("Number of participants in the tournament: ");
            int participants = int.Parse(Console.ReadLine());

            int totalSoldBakedGoods = 0;
            double totalMoneyDonated = 0;

            for (int i = 0; i < participants; i++)
            {
                Console.Write("Name of participant: ");
                string participantName = Console.ReadLine();

                int cakesCount = 0;
                int wafflesCount = 0;
                int cookiesCount = 0;

                Console.Write("Type of baked good or end of competition: ");
                string input = Console.ReadLine();

                while (input != "Stop baking!")
                {
                    Console.Write("Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case "cookies":
                            cookiesCount += quantity;
                            break;
                        case "waffles":
                            wafflesCount += quantity;
                            break;
                        case "cakes":
                            cakesCount += quantity;
                            break;
                    }

                    Console.Write("Type of baked good or end of competition: ");
                    input = Console.ReadLine();
                }

                totalSoldBakedGoods += cookiesCount + wafflesCount + cakesCount;
                totalMoneyDonated += cakesCount * 7.80 + cookiesCount * 1.50 + wafflesCount * 2.30;

                Console.WriteLine($"{participantName} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");
            }

            Console.WriteLine($"All bakery sold: {totalSoldBakedGoods}");
            Console.WriteLine($"Total sum for charity: {totalMoneyDonated:F2} lv.");

            Console.ReadLine();
        }
    }
}