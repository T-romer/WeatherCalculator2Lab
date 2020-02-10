using System;

namespace WeatherCalculator2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("*** IF-ELSE STATEMENT ***");
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";
            int RH;
            double HI;
            bool cont = true;

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            while (cont)
            {
                input = Console.ReadLine();
                temperature = int.Parse(input);
                if (temperature > 50)
                {
                    Console.WriteLine("Enter the relative humidity");

                    input = Console.ReadLine();

                    RH = int.Parse(input);

                    HI = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (RH * 0.094));

                    Console.WriteLine("The Heat Index is" + HI);
                }
                else
                {
                    // Get the windspeed from the user
                    Console.WriteLine("Enter the wind speed");

                    input = Console.ReadLine();

                    windSpeed = int.Parse(input);

                    // Calculate the wind chill

                    windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                    Console.WriteLine("The wind chill is " + windChill);
                }
                Console.WriteLine("Quit? yes or no");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    cont = false;
                }
            }
        }
    }
}
