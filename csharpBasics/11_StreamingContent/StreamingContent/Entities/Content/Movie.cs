

//todo: Movie is a StreamingContent obj (Inheritance)
public class Movie : StreamingContent
{
    public double RunTime { get; set; }

    public Movie() { }
    public Movie
    (string title, string description,double starRating,MaturityRating maturityRating,GenreType genreType) 
    : base(title, description, starRating, maturityRating, genreType)
    {

    }
}
