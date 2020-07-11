namespace ChristmasTournament
{
    using System;

    // From SoftUni Programming Basics February 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating the money raised at a Christmas tournament. Each day different games are played, the result of which is win or loose.
         People raise 20 bucks for every won game and at the end of the day, if the wins are more than the loses, they increase the amount of money
        by 10%. At the end of the tournament, is the total wins are more than the total loses, the money are increased with 20%.
        Win or lose, the money raised are always printed.*/
        public static void Main()
        {
            Console.Write("Days of the tournament: ");
            int days = int.Parse(Console.ReadLine());

            int totalWincounter = 0;
            int totalLoseCounter = 0;

            double totalMoneyRaised = 0;

            for (int i = 0; i < days; i++)
            {
                double dailyMoneyRaised = 0;
                int dailyWinCounter = 0;
                int dailyLoseCounter = 0;

                Console.Write("Sport or finish: ");
                string input = Console.ReadLine();

                while (input != "Finish")
                {
                    Console.Write("Result: ");
                    string result = Console.ReadLine();

                    switch (result)
                    {
                        case "win":
                            dailyWinCounter++;
                            dailyMoneyRaised += 20;
                            break;
                        case "lose":
                            dailyLoseCounter++;
                            break;
                    }

                    Console.Write("Sport or finish: ");
                    input = Console.ReadLine();
                }

                if (dailyWinCounter > dailyLoseCounter)
                {
                    dailyMoneyRaised += dailyMoneyRaised * 0.10;
                    totalWincounter++;
                }
                else if (dailyLoseCounter > dailyWinCounter)
                {
                    totalLoseCounter++;
                }

                totalMoneyRaised += dailyMoneyRaised;
            }

            if (totalWincounter > totalLoseCounter)
            {
                totalMoneyRaised += totalMoneyRaised * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyRaised:F2}");
            }
            else if (totalLoseCounter > totalWincounter)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyRaised:F2}");
            }

            Console.ReadLine();
        }
    }
}