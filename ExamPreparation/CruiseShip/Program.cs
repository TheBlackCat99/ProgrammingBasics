namespace CruiseShip
{
    using System;

    // From SoftUni Programming Basics April 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calulating the cost of a cruise vacation, based on type of the cruise, sea and number of nights spent there.
         It is known that the family has 4 members. We know that if they book more than 7 nights, they get 25% discount.
         We also know the cost for every type of cabin per person per night.*/

        public static void Main()
        {
            decimal costPerNightPerPerson = 0;
            const int FamilyMembers = 4;

            Console.WriteLine("Choose type of cruise from Mediterranean/Adriatic/Aegean");
            string typeOfCruise = Console.ReadLine();

            Console.WriteLine("Choose type of cabin from standard cabin/cabin with balcony/apartment");
            string typeOfCabin = Console.ReadLine();

            Console.Write("Choose number of nights: ");
            int nights = int.Parse(Console.ReadLine());

            switch (typeOfCruise)
            {
                case "Mediterranean":
                    switch (typeOfCabin)
                    {
                        case "standard cabin":
                            costPerNightPerPerson = 27.50m;
                            break;
                        case "cabin with balcony":
                            costPerNightPerPerson = 30.20m;
                            break;
                        case "apartment":
                            costPerNightPerPerson = 40.50m;
                            break;
                    }
                    break;

                case "Adriatic":
                    switch (typeOfCabin)
                    {
                        case "standard cabin":
                            costPerNightPerPerson = 22.99m;
                            break;
                        case "cabin with balcony":
                            costPerNightPerPerson = 25.00m;
                            break;
                        case "apartment":
                            costPerNightPerPerson = 34.99m;
                            break;
                    }
                    break;

                case "Aegean":
                    switch (typeOfCabin)
                    {
                        case "standard cabin":
                            costPerNightPerPerson = 23.00m;
                            break;
                        case "cabin with balcony":
                            costPerNightPerPerson = 26.60m;
                            break;
                        case "apartment":
                            costPerNightPerPerson = 39.80m;
                            break;
                    }
                    break;
            }

            decimal totalSum = FamilyMembers * costPerNightPerPerson * nights;

            if (nights > 7)
            {
                totalSum -= totalSum * 0.25m;
            }

            Console.WriteLine($"Annie's holiday in the {typeOfCruise} sea costs {totalSum:F2} lv.");

            Console.ReadLine();
        }
    }
}