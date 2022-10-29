using Xunit;
public class MovieTests
{
    [Fact]
    public void CreateMovie_AddToDatabase_ShouldReturnTrue()
    {
        //Arrange
        Movie movie = new Movie("Bad Boys", "Duo cop film", 10, MaturityRating.R, GenreType.Action);
        StreamingRepository _repo = new StreamingRepository();

        //Act
        bool expected = true;
        bool actual = _repo.AddContentToDb(movie);

        //Assert
        Assert.Equal(expected, actual);
    }
}
