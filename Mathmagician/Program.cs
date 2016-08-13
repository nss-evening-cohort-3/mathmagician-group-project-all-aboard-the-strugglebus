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

            String prompt = "> ";  // Prompt symbol for the user
            String userTypeProper = "";  // Will hold the capitalized user selection
            // A list of the possible choices in lowercase to loop through for validation
            List<string> Choices = new List<string>() { "integer", "prime", "fibonacci", "even", "odd" };
            List<int> ReturnList = new List<int>();  // List to hold the iteration

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
                Console.WriteLine("Apparently you can't read, so I will show you can example with Integers.");
                userTypeProper = "Integer";
            }

            // Number of Iterations Section

            // Asks for what length of sequence the user would like to see returned
            Console.WriteLine("Next.. How long would you like this sequence of " + userTypeProper + " numbers to be?");
            Console.Write(prompt);

            // Pulls the user input and converts to a number
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Checks to make sure that number is greater than 0
            if (userNum < 1)
            {
                //  Tells user they are dumb and makes the userNum 5
                Console.WriteLine("No, you have to pick a number greater than zero... Let's pretend you picked five..");
                userNum = 5;
                
            }

            //  Outputs the number of iterations and type that the user selected
            Console.WriteLine("Here's your sequence of {0} {1} numbers:", userNum, userTypeProper);

            //  Checks for the userType and instantiates and iterates accordingly
            if (userTypeProper == "Even")
            {
                Even userInstance = new Even();
                ReturnList = userInstance.Iterate(userNum);
            }
            else if (userTypeProper == "Odd")
            {
                Odd userInstance = new Odd();
                ReturnList = userInstance.Iterate(userNum);
            }
            else if (userTypeProper == "Integer")
            {
                Integer userInstance = new Integer();
                ReturnList = userInstance.Iterate(userNum);
            }
            else if (userTypeProper == "Prime")
            {
                Prime userInstance = new Prime();
                ReturnList = userInstance.Iterate(userNum);
            }
            else if (userTypeProper == "Fibonacci")
            {
                Fibonacci userInstance = new Fibonacci();
                ReturnList = userInstance.Iterate(userNum);
            }


            // Prints out the generated list for the user
            ReturnList.ForEach(Console.WriteLine);
            Console.Read();
        }
    }
}
