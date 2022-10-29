
public class Show : StreamingContent
{
    public Show() { }
    public Show(string title, string description, double starRating, MaturityRating maturityRating, GenreType genreType)
    : base(title, description, starRating, maturityRating, genreType)
    {

    }

    public Show(string title, string description, double starRating, MaturityRating maturityRating, GenreType genreType,
    List<Episode> episodes)
    : base(title, description, starRating, maturityRating, genreType)
    {
        Episodes = episodes;
    }

    public Show(List<Episode> episodes)
    {
        Episodes = episodes;
    }

    public List<Episode> Episodes = new List<Episode>();
    public int SeasonCount { get; set; }
    public int EpisodeCount { get { return Episodes.Count; } }
    public double AverageRuntime
    {
        get
        {
            return Math.Ceiling(Episodes.Average(c => c.RunTime));
        }
    }
}
