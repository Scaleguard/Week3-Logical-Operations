using System;

namespace TestFeedBack
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that asks the users about their test result and givees the feedback
             * A - Excellet!
             * B - Very good~!
             * C - Passed! 
             * D - Failed!
             * default - Wasted!
             */
            Console.WriteLine("What grade did you get on your test?");
            string letter = Console.ReadLine().ToLower();
            
            switch (letter)
            {
                case "A":
                    Console.WriteLine("Excellent!");
                    break;
                case "B":
                    Console.WriteLine("Very good~!");
                    break;
                case "C":
                    Console.WriteLine("Passed!");
                    break;
                case "D":
                    Console.WriteLine("Failed");
                    break;
               
                default:
                    Console.WriteLine("WASTED!");
                    break;



            }



        }
    }
}
