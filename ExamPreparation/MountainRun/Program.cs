namespace MountainRun
{
    using System;

    // From SoftUni Programming Basics February 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating if a person can beat the world record for mountain runnig. At the start of the program,
         we're typing the current record in seconds and the distance in meters as well as the person's speed per second.
         It is known that because of the hill, every 50 meters, they loose 30 seconds of their time.
         At the end, it is calculated if the record is beaten or not.*/
        public static void Main()
        {
            Console.Write("Current record in seconds: ");
            double currentRecord = double.Parse(Console.ReadLine());

            Console.Write("Distance in meters: ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Time in seconds per 1 meter: ");
            double timeForMeter = double.Parse(Console.ReadLine());

            double newTime = (distance * timeForMeter) + Math.Floor(distance / 50) * 30;

            if(currentRecord > newTime)
            {
                Console.WriteLine($"Yes! The new record is {newTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {newTime-currentRecord:F2} seconds slower.");
            }

            Console.ReadLine();
        }
    }
}
