using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double tempC, tempF;

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            double temperature = double.Parse(Console.ReadLine());
            Console.Write("Unit (C/F): ");
            string unit = Console.ReadLine();

            switch (unit)
            {
                case "C":
                    tempF = temperature * 1.8 + 32.0;
                    Console.WriteLine($"{temperature:f2} C = {tempF:f2} F");
                    tempF = Math.Abs(tempF);
                    Console.WriteLine($"Absolute value: {tempF:f2}");
                    break;
                case "F":
                    tempC = (temperature - 32) / 1.8;
                    Console.WriteLine($"{temperature:f2} F = {tempC:f2} C");
                    tempC = Math.Abs(tempC);
                    Console.WriteLine($"Absolute value: {tempC:f2}");
                    break;

                default:
                    Console.WriteLine($"Invalid unit");
                    break;

            }
        }
    }
}