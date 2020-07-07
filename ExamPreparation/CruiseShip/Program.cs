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
            bool isDiscount = false;
            const int FamilyMembers = 4;

            Console.WriteLine("Choose type of cruise from Mediterranean/Adriatic/Aegean");
            string typeOfCruise = Console.ReadLine();

            Console.WriteLine("Choose type of cabin from standard cabin/cabin with balcony/apartment");
            string typeOfCabin = Console.ReadLine();

            Console.Write("Choose number of nights: ");
            int nights = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                isDiscount = true;
            }
            else if (typeOfCruise != "Mediterranean" && typeOfCruise != "Adriatic" && typeOfCruise != "Aegean")
            {
                Console.WriteLine("Incorrect destination!");
            }
            else if (typeOfCabin != "standard cabin" && typeOfCabin != "cabin with balcony" && typeOfCabin != "apartment")
            {
                Console.WriteLine("Incorrect type of cabin!");
            }
            else if (nights < 1 || nights > 50)
            {
                Console.WriteLine("Incorrect number of nights!");
            }

            if (typeOfCruise == "Mediterranean")
            {
                if (typeOfCabin == "standard cabin")
                {
                    costPerNightPerPerson = 27.50m;
                }
                else if (typeOfCabin == "cabin with balcony")
                {
                    costPerNightPerPerson = 30.20m;
                }
                else if (typeOfCabin == "apartment")
                {
                    costPerNightPerPerson = 40.50m;
                }
            }
            else if (typeOfCruise == "Adriatic")
            {
                if (typeOfCabin == "standard cabin")
                {
                    costPerNightPerPerson = 22.99m;
                }
                else if (typeOfCabin == "cabin with balcony")
                {
                    costPerNightPerPerson = 25.00m;
                }
                else if (typeOfCabin == "apartment")
                {
                    costPerNightPerPerson = 34.99m;
                }
            }
            else if (typeOfCruise == "Aegean")
            {
                if (typeOfCabin == "standard cabin")
                {
                    costPerNightPerPerson = 23.00m;
                }
                else if (typeOfCabin == "cabin with balcony")
                {
                    costPerNightPerPerson = 26.60m;
                }
                else if (typeOfCabin == "apartment")
                {
                    costPerNightPerPerson = 39.80m;
                }
            }

            decimal totalSum = FamilyMembers * costPerNightPerPerson * nights;

            if (isDiscount)
            {
                totalSum -= totalSum * 0.25m;
            }

            Console.WriteLine($"Annie's holiday in the {typeOfCruise} sea costs {totalSum:F2} lv.");

            Console.ReadLine();
        }
    }
}