using System;
using System.Globalization; // 📌 Needed for advanced parsing options

namespace StringParsingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 🧾 Sample input strings that represent numbers ---
            string numStr1 = "1";           // Simple integer
            string numStr2 = "2.00";        // Decimal number (can be parsed as int with special options)
            string numStr3 = "3,000";       // Number with thousands separator
            string numStr4 = "3,000.00";    // Number with both thousands separator and decimal

            // Variable to hold parsed results
            int targetNum;

            Console.WriteLine("🔍 Using int.Parse with error handling:\n");

            try
            {
                // --- ✅ Parse a simple integer string ---
                targetNum = int.Parse(numStr1);
                Console.WriteLine($"Parsed integer: {targetNum}");

                // --- ⚠️ Parse a decimal string into an int ---
                // NumberStyles.Float allows parsing decimals like "2.00" into an int,
                // but ONLY if the decimal part is zero (e.g., 2.00 → 2)
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine($"Parsed from '2.00': {targetNum}");

                // --- ✅ Parse a string with a comma (thousands separator) ---
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine($"Parsed from '3,000': {targetNum}");

                // --- ✅ Parse a number with both thousands and decimals ---
                // Combine styles using bitwise OR (`|`)
                targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float);
                Console.WriteLine($"Parsed from '3,000.00': {targetNum}");

                // --- ✅ Parse other data types like bool ---
                // "True" (case-insensitive) will convert to a Boolean true
                bool parsedBool = bool.Parse("True");
                Console.WriteLine($"Parsed boolean: {parsedBool}");

                // --- ✅ Parse a float and format it to 2 decimal places ---
                float parsedFloat = float.Parse("1.235");
                Console.WriteLine($"Parsed float: {parsedFloat:F2}"); // Outputs: 1.24
            }
            catch
            {
                // ⚠️ If any of the Parse methods above fail, this catch block will handle the error
                Console.WriteLine("❌ Conversion failed");
            }

            Console.WriteLine("\n✅ Using TryParse for safe parsing:\n");

            // --- 🔐 TryParse is safer than Parse: it avoids exceptions and returns a boolean ---
            bool succeeded = Int32.TryParse(numStr1, out targetNum);
            if (succeeded)
            {
                Console.WriteLine($"TryParse succeeded! Parsed value: {targetNum}");
            }
            else
            {
                Console.WriteLine("TryParse failed.");
            }
        }
    }
}

/*

🧠 Why Use TryParse Over Parse?
| Feature                      | `Parse()`                             | `TryParse()`                              |
| ---------------------------- | ------------------------------------- | ----------------------------------------- |
| Throws exception if invalid? | ✅ Yes                                 | ❌ No                                      |
| Returns value?               | ✅ Yes                                 | ✅ via `out` parameter                     |
| Returns success/failure?     | ❌ No                                  | ✅ Yes (`true` or `false`)                 |
| Best for...                  | Trusted input (e.g., internal values) | Untrusted input (e.g., user input, files) |


📘 Common NumberStyles for Parsing
| Style                         | Purpose                                                |                                                     |
| ----------------------------- | ------------------------------------------------------ | --------------------------------------------------- |
| `NumberStyles.Integer`        | Default for integers                                   |                                                     |
| `NumberStyles.Float`          | Allows decimals and exponents (like `"2.00"`, `"1e3"`) |                                                     |
| `NumberStyles.AllowThousands` | Allows commas (`"1,000"`)                              |                                                     |
| Combine styles with \`        | \` (bitwise OR):                                       | `NumberStyles.Float \| NumberStyles.AllowThousands` |


🔄 Supported Parsing Types
| Type       | Method                                     |
| ---------- | ------------------------------------------ |
| `int`      | `int.Parse()` / `int.TryParse()`           |
| `float`    | `float.Parse()` / `float.TryParse()`       |
| `double`   | `double.Parse()`                           |
| `decimal`  | `decimal.Parse()`                          |
| `bool`     | `bool.Parse()`                             |
| `DateTime` | `DateTime.Parse()` / `DateTime.TryParse()` |

// ❌ This throws FormatException
targetNum = int.Parse(numStr2, NumberStyles.Float);

// ✅ Works correctly
float parsedFloat = float.Parse(numStr2, NumberStyles.Float);
Console.WriteLine($"Parsed float: {parsedFloat}");

*/