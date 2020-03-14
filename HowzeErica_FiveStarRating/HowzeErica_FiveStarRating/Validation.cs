using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricaHowze_ce09
{
    class Validation
    {

        //validate int
        public static int GetInt(string a)
        {
            int validatedInt;
            string input = null;

            do
            {
                Console.Write(a);
                input = Console.ReadLine();
            }
            while (!Int32.TryParse(input, out validatedInt));

            return validatedInt;
        }

        //validate a range of numbers
        public static int GetRangeInt(int min, int max, string message)
        {
            int validatedInt;
            string input = null;

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            while (!(Int32.TryParse(input, out validatedInt) && (validatedInt >= min && validatedInt <= max)));

            return validatedInt;
        }

        //validate true or false
        public static bool GetBool(string message = "Enter yes or no: ")
        {
            bool answer = false;
            string input = null;

            bool needAValidResponse = true;

            while (needAValidResponse)
            {
                Console.WriteLine(message);
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "yes":
                    case "y":
                    case "true":
                    case "t":
                        {
                            answer = true;
                            needAValidResponse = false;
                        }
                        break;
                    case "no":
                    case "n":
                    case "false":
                    case "f":
                        {
                            needAValidResponse = false;
                        }
                        break;
                }
            }

            return answer;
        }

        public static double GetDouble(string message)
        {
            double validatedDouble;
            string input = null;

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            while (!Double.TryParse(input, out validatedDouble));

            return validatedDouble;
        }

        //validate a range of numbers
        public static double GetRangeDouble(int min, int max, string message = "Enter a number: ")
        {
            double validatedDouble;
            string input = null;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!(Double.TryParse(input, out validatedDouble) && (validatedDouble >= min && validatedDouble <= max)));

            return validatedDouble;
        }

        public static string ValidateTextString(string a)
        {
            Console.WriteLine(a);
            string userInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You can not leave this blank, proceed with letters only");
                userInput = Console.ReadLine();


                for (int i = 0; i < userInput.Length; i++)
                {
                    while (!char.IsLetter(userInput[i]))
                    {
                        Console.WriteLine("Please enter letter only");
                        userInput = Console.ReadLine();
                    }

                }
            }
            return userInput;

        }

        public static string ValidateSentence(string a)
        {
            Console.Write(a);
            string userInput = Console.ReadLine();
            string[] words = userInput.Split();
            while (String.IsNullOrWhiteSpace(userInput))
            {
                Console.Write("You cannot proceed with this space blank!! Please enter a valid response to continue: ");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }
}
