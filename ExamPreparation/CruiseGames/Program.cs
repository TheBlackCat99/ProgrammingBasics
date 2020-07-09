namespace CruiseGames
{
    using System;

    // From SoftUni Programming Basics April 2020 Exam Preparation Problems
    public class Program
    {
        /*Program that calculates points in played games by a person on a cruise. They can choose how many games they want to play and
         the games available are tennis, badminton and volleyball. Each game has different bonuses that we know from the start
        (points in volleybal increase with 7%, those in tennis with 5% and badminton - with 2 %). The average point count from each type of game
        has to be more than 75 in order for the player to win.*/
        public static void Main()
        {
            string gameName;
            double points;
            int volleyballCounter = 0;
            double volleyballScore = 0;
            int tennisCounter = 0;
            double tennisScore = 0;
            int badmintonCounter = 0;
            double badmintonScore = 0;

            Console.Write("Player name: ");
            string playerName = Console.ReadLine();

            Console.Write("Number of played games: ");
            int playedGames = int.Parse(Console.ReadLine());

            for (int i = 0; i < playedGames; i++)
            {
                Console.Write("Name of the game: ");
                gameName = Console.ReadLine();

                Console.Write("Points: ");
                points = int.Parse(Console.ReadLine());

                switch (gameName)
                {
                    case "volleyball":
                        volleyballScore += points + points * 0.07;
                        volleyballCounter++;
                        break;
                    case "tennis":
                        tennisScore += points + points * 0.05;
                        tennisCounter++;
                        break;
                    case "badminton":
                        badmintonScore += points + points * 0.02;
                        badmintonCounter++;
                        break;
                }
            }

            double score = volleyballScore + tennisScore + badmintonScore;

            double volleyballAvg = volleyballScore / volleyballCounter;
            double tennisAvg = tennisScore / tennisCounter;
            double badmintonAvg = badmintonScore / badmintonCounter;

            if (Math.Floor(volleyballAvg) < 75 || Math.Floor(tennisAvg) < 75 || Math.Floor(badmintonAvg) < 75)
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {Math.Floor(score)}.");
            }
            else
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {Math.Floor(score)} points.");
            }

            Console.ReadLine();
        }
    }
}