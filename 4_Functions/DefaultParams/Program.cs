using System;

//
// Default Parameter Values & Named Arguments in C#
// ------------------------------------------------
// Functions can define default values for one or more parameters.
// These defaults are used when arguments are not supplied by the caller.
//

// Function: PrintWithPrefix
// --------------------------
// Purpose: Print a string to the console with an optional prefix.
// Parameters:
// - thestr (string): The main string to be printed.
// - prefix (string): An optional prefix. Default is an empty string ("").
// Return type: void - This function performs an action but returns nothing.
void PrintWithPrefix(string thestr, string prefix = "")
{
    // The prefix is printed followed by the string.
    // String interpolation (with $) is used here.
    Console.WriteLine($"{prefix} {thestr}");
}

// ----------------------
// Function Calls / Tests
// ----------------------

// ✅ 1. Call with only the required parameter.
// Since 'prefix' has a default value, we can omit it.
PrintWithPrefix("Hello there!"); // Output: " Hello there!" (prefix is "")

// ✅ 2. Call with both parameters supplied.
PrintWithPrefix("Hello there!", ">: "); // Output: ">: Hello there!"

// ✅ 3. Call with named parameters (in any order).
// Named arguments allow clarity and flexibility.
PrintWithPrefix(prefix: "% ", thestr: "Hello there!"); // Output: "% Hello there!"

//
// 💡 Tips:
// --------
// • Default parameter values must be constant expressions (e.g., strings, numbers, null).
// • All parameters with default values must appear **after** required parameters.
// • Named arguments improve readability, especially when many parameters are of the same type.
// • Mixing positional and named arguments is allowed, but named arguments must come after positional ones.
//
// ⚠️ Good Practice:
// ----------------
// Don’t overuse default parameters in public APIs — they can introduce ambiguity and confusion
// when used with method overloading.
//
// 🌟 Feature Note:
// ----------------
// Default parameters and named arguments have been available in C# since version 4.0 (Visual Studio 2010).
//
