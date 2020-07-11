namespace SuitcasesLoad
{
    using System;

    // From SoftUni Programming Basics February 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating number of suitcases that can fit in a given trunk, based on its capacity and the volume of each suitcase.
         Every third one's volume is increased by 10% due to the way they're arranged. The result of the program is the number of suitcases
        that were able to fit and if all of them are loaded. This result is shown when the capacity is less than the next suitcase
        or when the user types in End.*/
        public static void Main()
        {
            Console.Write("Capacity: ");
            double capacity = double.Parse(Console.ReadLine());

            Console.Write("End of loading or volume of next suitcase: ");
            string input = Console.ReadLine();

            double suitcaseVol;
            int suitcaseCounter = 0;

            while (true)
            {
                if (input == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                else
                {
                    suitcaseCounter++;
                    suitcaseVol = Convert.ToDouble(input);

                    if (suitcaseCounter % 3 == 0)
                    {
                        suitcaseVol += suitcaseVol * 0.10;
                    }

                    if (capacity < suitcaseVol)
                    {
                        suitcaseCounter--;
                        Console.WriteLine("No more space!");
                        break;
                    }

                    capacity -= suitcaseVol;
                }

                Console.Write("End of loading or volume of next suitcase: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");

            Console.ReadLine();
        }
    }
}