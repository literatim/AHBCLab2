using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AHBCGrandCircus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            do
            {
                Console.Write("Enter Length: ");
                string length = Console.ReadLine();
                int parsedLength = int.Parse(length);

                Console.Write("Enter Width: ");
                string width = Console.ReadLine();
                int parsedWidth = int.Parse(width);

                int calculatedArea = parsedLength * parsedWidth;
                int calculatedPerimeter = (parsedLength * 2) + (parsedWidth * 2);

                Console.WriteLine($"Area: {calculatedArea}");
                Console.WriteLine($"Perimeter: {calculatedPerimeter}");

                Console.Write("Continue? (y/n): ");
            }while(Console.ReadLine() == "y");
        }
    }
}
