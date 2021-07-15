using System;

namespace IT213_Douglass_Unit7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set assignment variables
            double temp1 = 35.5;
            double temp2 = 30.5;
            double temp3 = 22.2;
            double temp4 = 16.1;
            double temp5 = 7.3;
            double temp6 = -1;

            // Call method to convert Celsius to Fahrenheit
            toFahrenheit(temp1);
            toFahrenheit(temp2);
            toFahrenheit(temp3);
            toFahrenheit(temp4);
            toFahrenheit(temp5);
            toFahrenheit(temp6);

        }

        static int toFahrenheit(double temp)            // Create method to convert Celsius to Fahrenheit
        {
            double result = temp * 9 / 5 + 32;          // Formula to convert Celsius to Fahrenheit
            int rnd = Convert.ToInt32(result + .5);     // An easy way to round integer values is to add .5 to the decimal
                                                        // value before converting it to integer.
            Weather(rnd, temp);                         // Call method to generate weather statement
            return rnd;
            
        }

        // Method to generate weather statement
        static int Weather(int temp, double c_Temp)
        {
            // Weather statement logic
            if (temp >= 95)
                {
                Console.WriteLine($"The temperature is {c_Temp}C or {temp}F. A heat advisory has been issued.");
                }
            else if (temp >= 85 && temp <= 94)
            {
                Console.WriteLine($"The temperature is {c_Temp}C or {temp}F. Pleasant but warm.");
            }
            else if (temp >= 70 && temp <= 84)
            {
                Console.WriteLine($"The temperature is {c_Temp}C or {temp}F. Very pleasant weather today.");
            }
            else if (temp >= 50 && temp <= 69)
            {
                Console.WriteLine($"The temperature is {c_Temp}C or {temp}F. Pleasant but cool.");
            }
            else if (temp >= 33 && temp <= 49)
            {
                Console.WriteLine($"The temperature is {c_Temp}C or {temp}F. Cold weather.");
            }
            else if (temp <= 32)
            {
                Console.WriteLine($"The temperature is {c_Temp}C or {temp}F. A freeze warning has been issued.");
            }
            return temp;
        }
    }
}
