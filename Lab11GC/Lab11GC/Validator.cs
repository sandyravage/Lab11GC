using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11GC
{
    class Validator
    {
        public static string yesNoChecker(string choice) //validates the many y/n decisions in this program
        {
            while (choice != "y" && choice != "n")
            {
                Console.Write("\nInvalid choice. Please enter \"y\" for yes or \"n\" for no: ");
                choice = Console.ReadLine();
            }
            return choice;
        }
        public static string CatValidator(string input)
        {
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.Write("\nInvalid choice. Please enter \"1\" for scifi, \"2\" for animation, \"3\" for drama, or \"4\" for horror: ");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
