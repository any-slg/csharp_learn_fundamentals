// ✅ Scenario:
// You’re working on a sales report. 
// You want to format numbers to look more professional—add commas, currency signs, percentages, align columns, and control decimal places.

using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays representing sales data per quarter
            int[] quarters = { 1, 2, 3, 4 };
            int[] sales = { 100000, 150000, 200000, 225000 }; // Total sales numbers
            double[] intlMixPct = { 0.386, 0.413, 0.421, 0.457 }; // % of international sales per quarter

            // A sample string and numbers to demonstrate formatting
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m; // 'm' denotes a decimal literal

            // --- 🔤 Basic string output ---
            Console.WriteLine("Basic string output:");
            Console.WriteLine("{0}", str1); // Just prints the string
            Console.WriteLine(); // Adds a blank line

            // --- 🔢 Basic Numeric Formatting ---
            // Format syntax: {index[,alignment]:[formatSpecifier][precision]}
            // - index: position of the variable in the argument list
            // - alignment: (optional) positive = right-align, negative = left-align
            // - formatSpecifier: controls the style (N, F, C, D, P, etc.)

            Console.WriteLine("Different number format styles:");

            Console.WriteLine("{0:D}   // Decimal format (integer)", val1);      // D = Decimal
            Console.WriteLine("{0:N}   // Number with commas and 2 decimal places", val1); // N = Number
            Console.WriteLine("{0:F}   // Fixed-point with 2 decimals", val1);  // F = Fixed-point
            Console.WriteLine("{0:G}   // General format (automatic)", val1);   // G = General

            Console.WriteLine(); // Blank line

            Console.WriteLine("Decimal value formatting:");
            Console.WriteLine("{0:E}   // Exponential notation", val2);         // E = Scientific notation
            Console.WriteLine("{0:N}   // Number with comma separators", val2);
            Console.WriteLine("{0:F}   // Fixed-point", val2);
            Console.WriteLine("{0:G}   // General (best fit)", val2);

            Console.WriteLine(); // Blank line

            // --- 🧮 Adding precision and padding ---
            Console.WriteLine("Adding padding and precision:");

            Console.WriteLine("{0:D6}   // Decimal with at least 6 digits (padded with zeros)", val1);
            Console.WriteLine("{0:N2}   // Number with 2 decimal places", val1);
            Console.WriteLine("{0:F1}   // Fixed-point with 1 decimal", val1);
            Console.WriteLine("{0:G3}   // General format with 3 significant digits", val1);

            Console.WriteLine(); // Blank line

            // --- 📊 Tabular Sales Report with Alignment ---
            Console.WriteLine("Sales by Quarter:");

            // Right-align the quarters using width specifier (12 spaces each)
            Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quarters[0], quarters[1], quarters[2], quarters[3]);

            // Format sales as currency with no decimals using C0 (Currency, 0 decimals)
            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);

            Console.WriteLine(); // Blank line

            // --- 🌍 International Sales as Percentages ---
            Console.WriteLine("International Sales:");

            // Use P0 for whole percent, P1 for 1 decimal, P2 for 2 decimals
            Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",
                intlMixPct[0], intlMixPct[1], intlMixPct[2], intlMixPct[3]);

            // Output is neatly aligned into columns
        }
    }
}
