using System;

namespace temperatureConversion
{

    class Program
    {
        public static void Main(string[] args)
        {
            string unit;
            double temp;
           

            while (true)
            {

                Console.WriteLine("Input temperature unit (C for Celsius, F for Fahrenheit or K for Kelvin): ");
                unit = Console.ReadLine();
                unit = unit.ToUpper();

                if (unit == "C")
                {
                    Console.WriteLine("Input temperature value for Celsius: ");
                    temp = Convert.ToDouble(Console.ReadLine());

                    double fahrenheit = (temp * 9 / 5) + 32;
                    double kelvin = (temp + 273.15);

                    Console.WriteLine("Converted to Fahrenheit it is: " + fahrenheit);
                    Console.WriteLine("Converted to Kelvin it is: " + kelvin);
                    break;
                }
                else if (unit == "F")
                {
                    Console.WriteLine("Input temperature value for Fahrenheit: ");
                    temp = Convert.ToDouble(Console.ReadLine());

                    double celsius = (temp - 32) / 9 / 5;
                    double kelvin = ((temp - 32) / 9 / 5) + 273.15;

                    Console.WriteLine("Converted to Fahrenheit it is: " + celsius);
                    Console.WriteLine("Converted to Kelvin it is: " + kelvin);
                    break;
                }

                else if (unit == "K")
                {
                    Console.WriteLine("Input temperature value for Fahrenheit: ");
                    temp = Convert.ToDouble(Console.ReadLine());

                    double celsius = (temp - 273.15);
                    double fahreinheit = ((temp - 273.15) * 9 / 5) + 32;

                    Console.WriteLine("Converted to Celsius it is: " + celsius);
                    Console.WriteLine("Converted to Fahrenheit it is: " + fahreinheit);
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter 'C', 'F', or 'K'.");

                }


            }
        }
    }
}