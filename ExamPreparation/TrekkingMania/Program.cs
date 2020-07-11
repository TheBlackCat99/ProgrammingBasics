namespace TrekkingMania
{
    using System;

    // From SoftUni Programming Basics February 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating how much people are climbing different peaks. We know that based on the size of a group, the group is climbing
         different mountains. The goal is to calculate in % how much people climb what peak.*/
        public static void Main()
        {
            Console.Write("Number of groups: ");
            int numOfGroups = int.Parse(Console.ReadLine());

            int musalaClimbers = 0;
            int montblancClimbers = 0;
            int kilimanjaroClimbers = 0;
            int kTwoClimbers = 0;
            int everestClimbers = 0;

            for (int i = 0; i < numOfGroups; i++)
            {
                Console.Write("Number of people in the group: ");
                int numOfPeople = int.Parse(Console.ReadLine());

                if (numOfPeople <= 5)
                {
                    musalaClimbers += numOfPeople;
                }
                else if (numOfPeople >= 6 && numOfPeople <= 12)
                {
                    montblancClimbers += numOfPeople;
                }
                else if (numOfPeople >= 13 && numOfPeople <= 25)
                {
                    kilimanjaroClimbers += numOfPeople;
                }
                else if (numOfPeople >= 26 && numOfPeople <= 40)
                {
                    kTwoClimbers += numOfPeople;
                }
                else if (numOfPeople >= 41)
                {
                    everestClimbers += numOfPeople;
                }
            }

            int people = musalaClimbers + montblancClimbers + kilimanjaroClimbers + kTwoClimbers + everestClimbers;

            double musalaClimbersInPercents = (double)musalaClimbers / people * 100;
            double montblancClimbersInPercents = (double)montblancClimbers / people * 100;
            double kilimanjaroClimbersInPercents = (double)kilimanjaroClimbers / people * 100;
            double kTwoClimbersInPercents = (double)kTwoClimbers / people * 100;
            double everestClimbersInPercents = (double)everestClimbers / people * 100;

            Console.WriteLine($"{musalaClimbersInPercents:F2}%");
            Console.WriteLine($"{montblancClimbersInPercents:F2}%");
            Console.WriteLine($"{kilimanjaroClimbersInPercents:F2}%");
            Console.WriteLine($"{kTwoClimbersInPercents:F2}%");
            Console.WriteLine($"{everestClimbersInPercents:F2}%");

            Console.ReadLine();
        }
    }
}