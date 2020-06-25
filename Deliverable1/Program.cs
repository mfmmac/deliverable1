using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared variables
            string vacationType = "";
            int groupSize = 0;
            string location =  "";
            string transportation = "";
            string result = "";
            //user input what kind of trip
            while (location == "")
            {
                Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
                vacationType = Console.ReadLine();
                vacationType = vacationType.Trim();
                vacationType = vacationType.ToLower();
                
                if (vacationType == "musical")
                {
                    location = "New Orleans";
                }
                else if (vacationType == "tropical")
                {
                    location = "a beach vacation in Mexico";
                }
                else if (vacationType == "adventurous")
                {
                    location = "a whitewater rafting trip in the Grand Canyon";
                }
                else
                {
                    Console.WriteLine("Please type valid input.");
                }
            }
            //user input size of group
            while (transportation == "")
            {
                Console.Write("How many are in your group?");
                groupSize = int.Parse(Console.ReadLine());

                if (groupSize >= 6)
                {
                    transportation = "charter flight";
                }
                else if (groupSize >= 3)
                {
                    transportation = "helicopter";
                }
                else if (groupSize >= 1)
                {
                    transportation = "first class flight";
                }
                else
                {
                    Console.WriteLine("Plese type valid input.");
                }
            }
            //print result
            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + transportation + " to " + location + ".";
            Console.WriteLine(result);
        }
    }
}