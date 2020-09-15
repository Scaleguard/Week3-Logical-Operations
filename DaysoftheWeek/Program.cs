using System;

namespace DaysoftheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it?");
            string day = Console.ReadLine().ToLower();
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                Console.WriteLine("So it's a work day ay. Not fun.");
            } else if (day == "saturday" || day == "sunday")
            {
                Console.WriteLine("So it's the weekend ay? Beautiful");
            } else
            {
                Console.WriteLine($"Since when is {day} a day in the week?");
            }



        }
    }
}
