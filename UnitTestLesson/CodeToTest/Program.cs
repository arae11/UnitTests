using System;

namespace CodeToTest
{
    public class Program
    {
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
        }
    }
}
