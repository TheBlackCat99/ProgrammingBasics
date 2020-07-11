namespace FitnessCard
{
    using System;

    // From SoftUni Programming Basics February 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating if a person has enough money to pay for a fitness card, if it's known that everyone younger than or 19 years old
         gets 20% discount. Each price for the different sports, based on genders are also known. As a result, we get information whether the person's
        budget is enough for what they want to practice.*/
        public static void Main()
        {
            Console.Write("Your budget: ");
            double budget = double.Parse(Console.ReadLine());

            Console.Write("Gender(m or f): ");
            char gender = char.Parse(Console.ReadLine());

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Sport: ");
            string sport = Console.ReadLine();

            double price = 0;

            if (gender == 'm')
            {
                switch (sport)
                {
                    case "Gym":
                        price = 42;
                        break;
                    case "Boxing":
                        price = 41;
                        break;
                    case "Yoga":
                        price = 45;
                        break;
                    case "Zumba":
                        price = 34;
                        break;
                    case "Dances":
                        price = 51;
                        break;
                    case "Pilates":
                        price = 39;
                        break;
                }
            }
            else if (gender == 'f')
            {
                switch (sport)
                {
                    case "Gym":
                        price = 35;
                        break;
                    case "Boxing":
                        price = 37;
                        break;
                    case "Yoga":
                        price = 42;
                        break;
                    case "Zumba":
                        price = 31;
                        break;
                    case "Dances":
                        price = 53;
                        break;
                    case "Pilates":
                        price = 37;
                        break;
                }
            }

            if (age <= 19)
            {
                price -= price * 0.20;
            }

            if (budget >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport:F2}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${price - budget:F2} more.");
            }

            Console.ReadLine();

        }

    }
}
