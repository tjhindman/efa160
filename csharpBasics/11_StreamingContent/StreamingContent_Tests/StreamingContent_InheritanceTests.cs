using System.Collections.Generic;
using Xunit;

public class StreamingContent_InheritanceTests
{
    private StreamingRepository _repo;
    private Movie _movieA;
    private Movie _movieB;
    private Show _ShowA;
    private List<Episode> _TRIRepisodes;
    private Episode _EpisodeA;
    private Episode _EpisodeA1;
    private Show _showTestA;

    public StreamingContent_InheritanceTests()
    {
        _repo = new StreamingRepository();

        _movieA = new Movie("Bad Boys","Cop Film", 10 , MaturityRating.R,GenreType.Action);
        _movieB= new Movie("50 First Dates","Romance Flick Film", 10 , MaturityRating.R,GenreType.RomCom);

          _TRIRepisodes = new List<Episode>
        {
            new Episode
            {
                Title ="The Price is Right Ep.1",
                RunTime= .5d,
                SeasonNumber =1
            },
            new Episode
            {
                Title ="The Price is Right Ep.2",
                RunTime= .5d,
                SeasonNumber =1
            }

        };

        _ShowA = new Show
        ("The Price is Right",
        "Family Show, where the Elderly Hit it big!!",
        10,
        MaturityRating.G,
        GenreType.Drama,
        _TRIRepisodes);

        //we add stuff to the database
        _repo.AddContentToDb(_ShowA);
        _repo.AddContentToDb(_movieA);
        _repo.AddContentToDb(_movieB);

         _EpisodeA = new Episode("Ep.1",.5d,1);  
         _EpisodeA1 = new Episode("Ep.2",.5d,1);  

        _showTestA = new Show(new List<Episode>{
            _EpisodeA,
            _EpisodeA1
        });
        
    }

    [Fact]
    public void TotalCount()
    {
        //Act
        int expected = 2;
        int actual = _showTestA.EpisodeCount;

        //Assert
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void AverageShowTime()
    {
        double expected = .5d;
        double actual = _showTestA.AverageRuntime;

        Assert.Equal(expected,actual);
    }

    [Fact]
    public void GetShowByTitle_ShouldGiveMeAShow()
    {
        //Act 
        Show retrivedShow = _repo.GetShowByTitle("The Price is Right");

        Show expected = _ShowA;
        Show actual = retrivedShow;

        //Assert
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void GetMovieByTitle_ShouldGiveMeAMovie()
    {
        //Act
        Movie retrivedMovie = _repo.GetMovieByTitle("Bad Boys");

        Movie expected = _movieA;
        Movie actual = retrivedMovie;

        //Assert
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void GetAllShows_ShouldGiveMeAListOfShows()
    {
        //Act
        List<Show> retrievedShows = _repo.GetAllShows();

        int expectedCount = 1;
        int actual = retrievedShows.Count;

        //Assert
        Assert.Equal(expectedCount,actual);
    }

    [Fact]
    public void GetAllMovies_ShouldGiveMeAListOfMovies()
    {
        //Act
        List<Movie> retrievedMovies = _repo.GetAllMovies();

        int expectedCount = 2;
        int actual = retrievedMovies.Count;

        //Assert
        Assert.Equal(expectedCount,actual);
    }
}
