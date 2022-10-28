using Xunit;

namespace StreamingContent_Tests;

public class StreamingContentTests
{
    [Fact]
    public void SetTitle_ShouldReturnCorrectString()
    {
        //AAA 

        //Arrange
        StreamingContent content = new StreamingContent();

        //lets assign a value 
        content.Title = "Toy Story";

        //Act
        string expected = "Toy Story";

        string actual = content.Title;

        //Assert
        Assert.Equal(expected,actual);

    }

    [Theory]
    [InlineData(MaturityRating.G,true)]
    [InlineData(MaturityRating.TV_PG,true)]
    [InlineData(MaturityRating.R,false)]
    [InlineData(MaturityRating.TV_MA,false)]
    public void SetMaturityRating_Should_Get_Correct_IsFamilyFriendly(MaturityRating rating, bool expectedIsFamilyFriendly)
    {
        StreamingContent content = new StreamingContent("ContentTitle", "Some Description", 4.2d,rating,GenreType.SciFi);

        bool actual = content.IsFamilyFriendly;
        bool expected= expectedIsFamilyFriendly;

        Assert.Equal(expected,actual);
    }
}