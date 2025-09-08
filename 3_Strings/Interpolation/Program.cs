// ✅ Scenario:
// You’re building a car listing application 
// that prints out formatted vehicle information for buyers. You’ll use string interpolation to make the output clean and readable.

using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 🚗 Declaring variables to represent car details ---
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;       // Using underscore for better readability
            decimal price = 60_275.0m;     // 'm' suffix denotes a decimal number

            // --- 🧾 Output using old-style formatting (index-based) ---
            Console.WriteLine("Using traditional format strings:");
            Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}",
                year, make, model, miles, price);

            Console.WriteLine(); // Adds a blank line for clarity

            // --- 🪄 Using string interpolation (modern and cleaner) ---
            // Just prefix the string with $ and insert variables directly inside {}
            Console.WriteLine("Using string interpolation:");

            Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles} miles and costs {price:C2}");
            // 💡 Note:
            // - `${price:C2}` formats the price as currency with 2 decimal places (e.g., $60,275.00)
            // - `{{model}}` prints a literal `{}` around the model name (double braces escape the character)

            Console.WriteLine(); // Another blank line

            // --- ➕ Using inline expressions inside interpolated strings ---
            Console.WriteLine("Using inline expressions:");
            Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles * 1.6:F2} kilometers and costs {price:C2}");

            // 💬 Here:
            // - `{miles * 1.6:F2}` converts miles to kilometers and shows 2 decimal places
            // - You can use any valid C# expression inside the interpolation syntax
        }
    }
}
