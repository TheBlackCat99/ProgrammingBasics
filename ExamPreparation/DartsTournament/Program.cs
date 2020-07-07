namespace DartsTournament
{
    using System;

    // From SoftUni Programming Basics April 2020 Exam Preparation Problems
    public class Program
    {
        /*Program, calculating points in darts tournament: the player has inital score and they can hit different sectors.
        If they hit the bullseye, they win immediately. If they hit number section, the points from it are substracted from the initial score.
        When hitting double/triple rings, the points from those sections are doubled/tripled and then substracted from the initial score.
        The game continues until the score is 0, in which case the player wins, or the score is < 0 and the player loses.*/

        public static void Main()
        {
            Console.Write("Initial score: ");
            int initialScore = int.Parse(Console.ReadLine());

            string sectorName;
            int moves = 0;
            int sectorScore = 0;

            do
            {
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Which sector did the arrow hit: number section/double ring/triple ring/bullseye");
                sectorName = Console.ReadLine();

                if (sectorName != "bullseye")
                {
                    Console.Write("Points: ");
                    sectorScore = int.Parse(Console.ReadLine());
                }

                if (sectorName == "number section")
                {
                    moves++;
                }
                else if (sectorName == "double ring")
                {
                    sectorScore *= 2;
                    moves++;
                }
                else if (sectorName == "triple ring")
                {
                    sectorScore *= 3;
                    moves++;
                }
                else if (sectorName == "bullseye")
                {
                    moves++;
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
                    break;
                }

                initialScore -= sectorScore;

                if (initialScore == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
                }
                else if (initialScore < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(initialScore)}.");
                }
            }
            while (initialScore > 0);
            Console.ReadLine();
        }
    }
}