using System;

namespace StringOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 📌 Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";

            // An array of strings for Join and Concat examples
            string[] strs = { "one", "two", "three", "four" };

            // --- 🔤 String Length ---
            // ✅ Returns the total number of characters in the string (including spaces and punctuation)
            Console.WriteLine("Length of str1: " + str1.Length);

            // --- 🔤 Accessing Individual Characters ---
            // ✅ You can use indexing to access individual characters in a string (zero-based index)
            // For example, str1[14] returns the 15th character
            Console.WriteLine("Character at index 14: " + str1[14]);

            // --- 🔁 Iterating Over a String ---
            // ✅ Strings are sequences of characters, so you can loop through them using foreach
            Console.WriteLine("Characters in str1 until 'b' is found:");
            foreach (char ch in str1)
            {
                Console.Write(ch);
                if (ch == 'b')
                {
                    Console.WriteLine(); // Move to the next line
                    break; // Stop the loop when 'b' is found
                }
            }

            // --- 🔗 String Concatenation ---
            // ✅ String.Concat combines multiple strings into one (no separator)
            outstr = String.Concat(strs);
            Console.WriteLine("Concatenated string (no separator): " + outstr);

            // --- 🔗 Joining Strings with a Separator ---
            // ✅ String.Join joins elements of an array with a given separator between them
            outstr = String.Join('.', strs); // joins with dots
            Console.WriteLine("Joined with dot: " + outstr);

            outstr = String.Join("---", strs); // joins with custom separator
            Console.WriteLine("Joined with ---: " + outstr);

            // --- ⚖️ String Comparison ---
            // ✅ String.Compare performs case-sensitive ordinal comparison:
            //    Returns:
            //      < 0: str2 comes before compared string
            //      = 0: both strings are equal
            //      > 0: str2 comes after compared string
            int result = String.Compare(str2, "This is a string");
            Console.WriteLine("String.Compare result: " + result);

            // --- ✅ String Equality Check ---
            // ✅ Equals checks if two strings are exactly equal (case-sensitive)
            bool isEqual = str2.Equals(str3);
            Console.WriteLine("str2 equals str3? " + isEqual); // false, due to case difference

            // --- 🔍 Searching in Strings ---
            // ✅ IndexOf returns the first index of a character or substring
            Console.WriteLine("First index of 'e' in str1: " + str1.IndexOf('e'));
            Console.WriteLine("First index of \"fox\" in str1: " + str1.IndexOf("fox"));

            // ✅ LastIndexOf returns the last occurrence of a character or substring
            Console.WriteLine("Last index of 'e' in str1: " + str1.LastIndexOf('e'));
            Console.WriteLine("Last index of \"the\" in str1: " + str1.LastIndexOf("the")); 
            // Note: "the" (lowercase) won't match "The" at the start

            // --- 📝 Replacing Text ---
            // ✅ Replace creates a new string with specified text replaced
            outstr = str1.Replace("fox", "cat");
            Console.WriteLine("After replacing 'fox' with 'cat': " + outstr);

            // ✅ If you search for a word that was replaced, it won't be found anymore
            Console.WriteLine("Index of 'fox' after replacement: " + outstr.IndexOf("fox")); // should be -1
        }
    }
}
