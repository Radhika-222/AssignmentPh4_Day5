// See https://aka.ms/new-console-template for more information
using Assignment_Day5;
using System.Net.Http.Headers;

MovieManager manager = new MovieManager();
manager.AddMovie(new Movie { Title = "Cipher Code", Genre = "Action", ReleaseYear =2023});
manager.AddMovie(new Movie { Title = "Aasman Ki Or", Genre = "Adventure", ReleaseYear = 2023 });
manager.AddMovie(new Movie { Title = "Dil Se Dosti", Genre = "Friendship", ReleaseYear = 2022 });
manager.AddMovie(new Movie { Title = "Pushpa",        Genre = "Action", ReleaseYear = 2022 });

Console.WriteLine("All Movies");
Console.WriteLine("Title\t             Genre\t          ReleaseYear");
foreach(Movie movies in manager.GetAllMovies())
{
    Console.Write(movies.Title +" \t \t");
    Console.Write(movies.Genre + " \t \t");
    Console.Write(movies.ReleaseYear + "\t \t");
    Console.WriteLine("\n");
}

Console.WriteLine("Enter title to search ");
string title = Console.ReadLine();
Movie movie = manager.GetMovieByTitle(title);

if (movie!=null)
{
    Console.WriteLine($"Movie found:{movie.Title} ({movie.Genre}),{movie.ReleaseYear}");
}
else
{
    Console.WriteLine($"Movie not found:{title}");
}
