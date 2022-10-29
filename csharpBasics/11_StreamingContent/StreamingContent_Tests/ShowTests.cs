using System.Collections.Generic;
using Xunit;
public class ShowTests
{
    private StreamingRepository _repo;
    private Show _showA;
    private List<Episode> _TPIRepisodes;

    public ShowTests()
    {
        _repo = new StreamingRepository();
        
        _TPIRepisodes = new List<Episode>
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

        _showA = new Show
        ("The Price is Right",
        "Family Show, where the Elderly Hit it big!!",
        10,
        MaturityRating.G,
        GenreType.Drama,
        _TPIRepisodes);
    }

    [Fact]
    public void CreateShow_AddToDatabase_ShouldReturnTrue()
    {
        //Act
        bool expected = true;
        bool actual = _repo.AddContentToDb(_showA);

        //Assert
        Assert.Equal(expected,actual);
    }


}
