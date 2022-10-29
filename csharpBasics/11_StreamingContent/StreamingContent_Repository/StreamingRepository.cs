
public class StreamingRepository : StreamingContentRepository
{

    public Show GetShowByTitle(string title)
    {
        //try to access the fake database in StreamingContentRepository...
        foreach (StreamingContent content in _contentDb)
        {
            if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
            {
                return (Show)content;
            }
        }

        return null;
    }

    public List<Show> GetAllShows()
    {
        List<Show> allShows = new List<Show>();

        foreach (var content in _contentDb)
        {
            if (content is Show)
            {
                allShows.Add((Show)content);
            }
        }
        return allShows;

        // return _contentDb
        //             .Where(s => s is Show)
        //             .Select(s => (Show)s)
        //             .ToList();
    }

    public Movie GetMovieByTitle(string title)
    {
        // foreach (var content in _contentDb)
        // {
        //     if(content.Title.ToLower() == title.ToLower() && content.GetType()== typeof(Movie))
        //     {
        //         return (Movie)content;
        //     }
        // }
        // return null;

        //todo: use L.I.N.Q
        var movie = _contentDb.FirstOrDefault(c => c.Title.ToLower() == title.ToLower() && c is Movie);
        return (Movie)movie;
    }

    public List<Movie> GetAllMovies()
    {
        // List<Movie> allMovies = new List<Movie>();

        //loop throught the whole database and grab movies
        // foreach (StreamingContent content in _contentDb)
        // {
        //     if (content is Movie)
        //     {
        //adding movie to the list of allMovies
        //         allMovies.Add((Movie)content);
        //     }
        // }
        // return allMovies;

        //todo: L.I.N.Q
        var movies = _contentDb
                    .Where(c => c is Movie)
                    .Select(c => (Movie)c)
                    .ToList();

        return movies;
    }

}
