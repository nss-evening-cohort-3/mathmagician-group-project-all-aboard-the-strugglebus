using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        // Functions Section
        // This function capitalizes the first character of the user's selected type
        public static string FirstCharToUpper(string input)
        {
            return input = input.First().ToString().ToUpper() + input.Substring(1);
        }

        static void Main(string[] args)
        {
            // Variables Section
            String prompt = "> ";  // Pretty little prompt symbol for the user/loser
            String userTypeProper = "";
            // A list of the possible choices in lowercase to loop through for (I really need) validation
            List<string> Choices = new List<string>() { "integer", "prime", "fibonacci", "even", "odd" };

            // Type Section
            // Asks for the type of number input from user
            Console.WriteLine("What kind of number sequence would you like me to print?");
            Console.WriteLine("Options I know: Integer, Prime, Fibonacci, Even, Odd");
            Console.Write(prompt);
            // Collects the entry, makes it lowercase, and saves it as a variable
            String userTypeLower = Console.ReadLine().ToLower();
            // Checks to if this choice is one of the five accepted choices
            if (Choices.Contains(userTypeLower))
            {
                // If user chose an accepted option:
                // Capitalizes the first character of the sequence choice
                userTypeProper = FirstCharToUpper(userTypeLower);
                // Repeats the choice back to the user
                Console.WriteLine("You picked " + userTypeProper + " numbers.");
            }
            else
            {
                // If user did not choose an accepted option:
                Console.WriteLine("Please enter one of the following choices: Integer, Prime, Fibonacci, Even, Odd");
            }
            // Fuck it, I'm tired of this shit so I'm taking a break on figuring out how to run that bullshit again and moving on to the #s.

            // Fuck yeah, Number of Iterations Section!
            // Asks for what length of sequence the user would like to see returned
            Console.WriteLine("Next.. How long would you like this sequence of " + userTypeProper + " numbers to be?");
            Console.Write(prompt);
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Spiffers! I'm going to print a sequence of {0} {1} numbers.", userNum, userTypeProper);
            Even my_even = new Even();
            Odd my_odd = new Odd();
            my_even.Iterate(userNum);
            my_odd.Iterate(userNum);
            Console.WriteLine();

            Console.Read();
        }
    }
}
