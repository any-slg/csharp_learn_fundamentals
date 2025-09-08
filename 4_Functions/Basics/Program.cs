using System;

//
// Function Basics in C#
// ----------------------
// Functions (also known as methods) help us to organize and reuse code.
// They can accept inputs (called parameters) and optionally return a value.
//

// This function converts distance from miles to kilometers.
// Return Type: float - It returns a floating-point number.
// Name: MilesToKm - PascalCase is the convention for method names in C#.
// Parameter: miles (float) - the distance in miles to convert.
float MilesToKm(float miles)
{
    // 1 mile is approximately 1.6 kilometers
    float result = miles * 1.6f;

    // Return the converted value
    return result;

    // TIP: The 'f' suffix denotes a float literal in C#
    // e.g., 1.6f ensures the number is treated as a float, not double.
}

// This function prints a string to the console with a prefix.
// Return Type: void - It doesn't return any value.
// Name: PrintWithPrefix
// Parameter: thestr (string) - the text to print with a prefix.
void PrintWithPrefix(string thestr)
{
    // String interpolation (note the $ symbol) allows us to embed expressions
    // inside string literals using curly braces {}
    Console.WriteLine($"::> {thestr}");

    // NOTE: Console.WriteLine adds a newline automatically after the string
    // Use Console.Write instead if you want to avoid the newline.
}

// Main program logic
// ------------------

// Call the MilesToKm function with different inputs and print the results.
// Output will display converted values in kilometers.
Console.WriteLine($"The result is {MilesToKm(8.0f)}");   // 8 miles -> 12.8 km
Console.WriteLine($"The result is {MilesToKm(52.0f)}");  // 52 miles -> 83.2 km

// Call the PrintWithPrefix function with different string inputs
PrintWithPrefix("Test string");            // Output: ::> Test string
PrintWithPrefix("Another test string");    // Output: ::> Another test string

//
// Tips:
// -----
// 1. Reuse: Functions reduce code repetition and make your code easier to maintain.
// 2. Testing: Smaller, isolated functions are easier to test and debug.
// 3. Naming: Use descriptive function names and parameter names.
// 4. Scope: Functions can be declared inside a class or struct in actual applications.
// 5. Entry Point: In real applications, code execution starts from static void Main().
//
// In this example, the functions are defined at the script-level, which is allowed in
// top-level statements (C# 9.0+ feature).
//
