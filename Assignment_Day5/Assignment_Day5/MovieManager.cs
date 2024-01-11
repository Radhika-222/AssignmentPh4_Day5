using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day5
{
   public class MovieManager
    {
        private List<Movie> movies = new List<Movie>();
        
       
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public Movie GetMovieByTitle(String title)
        {
            return movies.FirstOrDefault(m => m.Title == title);
        }
    }
}
