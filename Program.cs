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

            // James - good use of a do while loop, we know this program is going to run at least once
            do
            {
                // James - simple and well organized, easy pattern to follow.
                Console.Write("Enter Length: ");

                // James - your stlyes does make your code more readible doing things line by line
                // what makes reading code even more easier sometimes is just figuring out
                // the end result right away. for example you could do something 
                // like 
                //
                // decimal roomLength = decimal.Parse(Console.ReadLine());
                //
                // this way at first glance, we know that this variable is going to be the 
                // room length, and if the other developers want to know how that was figured out,
                // we can read anything after the "=" :)
                string length = Console.ReadLine();
                decimal parsedLength = decimal.Parse(length);

                Console.Write("Enter Width: ");
                string width = Console.ReadLine();
                decimal parsedWidth = decimal.Parse(width);

                decimal calculatedArea = parsedLength * parsedWidth;
                decimal calculatedPerimeter = (parsedLength * 2) + (parsedWidth * 2);

                Console.WriteLine($"Area: {calculatedArea}");
                Console.WriteLine($"Perimeter: {calculatedPerimeter}");

                Console.Write("Continue? (y/n): ");

                // James - what if the user enters a capital Y?
                // also when comparing strings, consider using the Equal method on string.
                //
                //  while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase))
                // 
                //  or
                // 
                // while (string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase))
                // but also what if the user enters a space after y?
                // consider looking at other string methods to manipulate the answer, or using a 
                // different input method alltogether like Console.ReadKey();
            } while(Console.ReadLine() == "y");

            // James - Overall, I really like your way of organizing the code, each block of lines clearly 
            // had its own overall responsibility. You also used string Interpolation which made 
            // reading your strings even easier. good job, I look forward to reviewing your other
            // code.
        }
    }
}
