using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's say this is the student's score
            int studentScore = 90;

            // We'll use a switch statement to print a message depending on the score
            switch (studentScore)
            {
                // If the score is exactly 100
                case 100:
                    Console.WriteLine("Perfect score! Excellent job!");
                    break;

                // If the score is 90 or above (but not 100)
                case 90:
                    Console.WriteLine("Great job! You got an A.");
                    break;

                // If the score is 80, 81, 82, 83, or 84
                case 80:
                case 81:
                case 82:
                case 83:
                case 84:
                    Console.WriteLine("Good work! You got a B.");
                    break;

                // If the score is between 70 and 79
                case 70:
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 78:
                case 79:
                    Console.WriteLine("You passed with a C.");
                    break;

                // If the score doesn't match any of the above cases
                default:
                    Console.WriteLine("Score not recognized or needs review.");
                    break;
            }
        }
    }
}
