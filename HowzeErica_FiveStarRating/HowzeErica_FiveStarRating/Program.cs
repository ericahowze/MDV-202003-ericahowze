using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowzeErica_FiveStarRating
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isProgramRunning = true;

            while (isProgramRunning)
            {

                Console.Clear();
                //prompt user for choice
                Console.WriteLine("Welcome to my Restaurant Rating System" +
                    "\nWhat would you like to do today?" +
                    "\n1). Convert The Restaurant Profile Table From SQL To JSON" +
                    "\n2). Showcase Our 5 Star Rating System" +
                    "\n3). Showcase Our Animated Bar Graph Review System" +
                    "\n4). Play A Card Game" +
                    "\n5). Exit");

                string choice = Validation.ValidateSentence("Choose an option to continue ");

                switch (choice)
                {
                    case "1":
                    case "convert to json":
                        {

                        }
                        break;
                    case "2":
                    case "show stars":
                        {

                        }
                        break;
                    case "3":
                    case "show bars":
                        {

                        }
                        break;
                    case "4":
                    case "play card game":
                        {

                        }
                        break;
                    case "5":
                    case "exit":
                        {
                            Console.WriteLine("Thank you for shopping with us");
                            break;
                        }
                    default:
                        Console.WriteLine("You chose an invalid option, please choose from the menu");
                        Console.WriteLine("Press the return key to return to the main menu");
                        Console.ReadKey();
                        return;
                }
            }
        }

        public static void ConvertedData()
        {

        }

        public static void ShowStars()
        {

        }

        public static void ShowBar()
        {

        }

        public static void PlayCardGame()
        {

        }
    }
}
