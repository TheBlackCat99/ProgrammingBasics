namespace ChangeBureau
{
    using System;

    // From SoftUni Programming Basics February 2020 Exam Preparation Problems
    public class Program
    {
        /*Program calculating how much euro a person has if we know how much bitcoins and chinese yuan they're willing to exchange.
        The exact calculations are based on knowing that 1 bitcoin = 1168 levs, 1 chinese yuan = 0.15 dollars, 1 dollar = 1.76 levs
        and 1 euro = 1.95 levs. The commission is also given at the start.*/
        public static void Main()
        {
            Console.Write("Number of bitcoins: ");
            int bitcoins = int.Parse(Console.ReadLine());

            Console.Write("Number of chinese yuan: ");
            double chineseYuan = double.Parse(Console.ReadLine());

            Console.Write("Commission: ");
            double commission = double.Parse(Console.ReadLine());

            double levs = bitcoins * 1168.0 + (chineseYuan * 0.15) * 1.76;
            double euros = levs / 1.95;

            double totalWithCommission = euros - euros * commission / 100;

            Console.WriteLine($"{totalWithCommission:F2}");

            Console.ReadLine();
        }
    }
}
