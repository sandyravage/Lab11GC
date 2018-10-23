using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11GC
{
    class Movie
    {
        private string title { get; set; }
        private string category { get; set; }
        private string SearchTerm { get; set; }

        public Movie(string Title, string Category)
        {
            title = Title;
            category = Category;
            SearchTerm = "";
        }

        public static void Lister(List<Movie> movies, string input)
        {
            int i = 0;
            List<Movie> sublist = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.category.ToLower().Contains(input.ToLower()))
                {
                    i++;
                    sublist.Add(movie);
                }
            }
            sublist = sublist.OrderBy(m => m.title).ToList();
            foreach (var movie in sublist)
            {
                    Console.WriteLine(movie.title);
            }
            Console.WriteLine($"Found {i} match(es).");
        }
    }
}
