using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11GC
{
    class Program
    {
        public static List<Movie> movies = new List<Movie>
        {
            new Movie("La La Land","drama"),
            new Movie("The Gopher Among Us","scifi"),
            new Movie("Night of the Lepus","horror"),
            new Movie("Spicy Boys: Rise of the Fire Ant", "scifi"),
            new Movie("Golddiggin'","horror"),
            new Movie("Mencius Moldbug","animation"),
            new Movie("Watership Down","animation"),
            new Movie("StackOverflow","horror"),
            new Movie("Death Comes To Us All, Oroku Saki","drama"),
            new Movie("The Bunk Cauldrun","animation"),
            new Movie("P's and Q's","scifi"),
            new Movie("Night of the Lepus 2: Electric Boogaloo","horror")
        };

        static void Main()
        {
            Console.Write($"Welcome to the Movie List Application!" +
                $"\nThere are {movies.Count} movies in this list." +
                $"\nPlease select from the following categories to see a list of movies of that genre: " +
                $"\n1: SciFi" +
                $"\n2: Animation" +
                $"\n3: Drama" +
                $"\n4: Horror" +
                $"\n5: Exit" +
                $"\n\nSelection: ");
            string choice = Validator.CatValidator(Console.ReadLine());
            switch (choice)
            {
                case "1":
                    Movie.Lister(movies, "scifi");
                    break;
                case "2":
                    Movie.Lister(movies, "animation");
                    break;
                case "3":
                    Movie.Lister(movies, "drama");
                    break;
                case "4":
                    Movie.Lister(movies, "horror");
                    break;
                case "5":
                    Console.WriteLine("\nGoodbye");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            Console.Write("Would you like to continue? (y/n): ");
            if (Validator.yesNoChecker(Console.ReadLine()) == "y")
            {
                Console.Clear();
                Main();
            }
            Console.WriteLine("\nGoodbye");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
