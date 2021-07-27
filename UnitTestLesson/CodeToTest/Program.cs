using System;

namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ageOfViewer = 30;
            var ageCheck = AvailableClassifications(ageOfViewer);
            Console.WriteLine(ageCheck);
        }
        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 4)
            {
                result = "You are too young to watch films.";
            }
            else if (ageOfViewer < 8)
            {
                result = "U films are available.";
            }
            else if (ageOfViewer < 12)
            {
                result = "U & PG films are available.";
            }
            else if (ageOfViewer < 15)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer < 18)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
            return result;
        }

        /*
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            var myGreeting = Greeting(timeOfDay);
            Console.WriteLine(myGreeting);
        }
        public static string Greeting(int timeOfDay)
        {
            string greeting;
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                greeting = "Good Morning!";
            }
            else if (timeOfDay > 12 && timeOfDay <= 18)
            {
                greeting = "Good Afternoon!";
            }
            else if (timeOfDay > 18 && timeOfDay <= 24)
            {
                greeting = "Good Evening!";
            }
            else
            {
                greeting = "Go to bed!";
            }
            {
                return greeting;
            }
        } */
    }
}
