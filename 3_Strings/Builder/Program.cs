// ✅ Scenario:
// You’re generating a dynamic report (or story) 
// that includes formatted text, repeated values, and changing words — and you want it to be efficient and editable.

using System;
using System.Text; // 📌 Required for using StringBuilder

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 🛠 Create a new StringBuilder ---
            // Parameters: initial content and initial capacity (optional)
            StringBuilder sb = new StringBuilder("Initial String. ", 200); 
            // 200 = initial space allocated to avoid resizing as content grows

            int jumpCount = 10;
            string[] animals = { "goats", "cats", "pigs" };

            // --- 🔍 View current Capacity and Length ---
            // Capacity = how much the builder can hold before it resizes
            // Length = current number of characters in the builder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // --- 📌 Append() adds text to the end ---
            sb.Append("The quick brown fox ");
            sb.Append("jumps over the lazy dog.");

            // --- 📥 AppendLine() adds a line break (\n at the end) ---
            sb.AppendLine();

            // --- 🎯 AppendFormat() adds text with placeholders ---
            // Similar to string interpolation or string.Format
            sb.AppendFormat("He did this {0} times.", jumpCount);
            sb.AppendLine(); // Adds a line break after it

            // --- 🔁 AppendJoin() adds items from a collection, separated by a character ---
            sb.Append("He also jumped over ");
            sb.AppendJoin(",", animals); // joins the array with commas

            // --- 📝 Replace() finds and replaces text inside the builder ---
            sb.Replace("fox", "cat");

            // --- 🧩 Insert() adds text at a specific index ---
            sb.Insert(0, "This is the "); // Adds text to the very beginning

            // --- 🔍 Check final Capacity and Length after modifications ---
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // --- 🧾 Convert the StringBuilder to a string and print it ---
            Console.WriteLine("Final string:");
            Console.WriteLine(sb.ToString());
        }
    }
}
