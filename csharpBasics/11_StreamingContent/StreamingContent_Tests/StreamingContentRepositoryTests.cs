using Xunit;
using System.Collections.Generic;
public class StreamingContentRepositoryTests
{
    private StreamingContentRepository _globalRepo;
    private StreamingContent _contentA;
    private StreamingContent _contentB;
    private StreamingContent _contentC;
    private StreamingContent _contentD;

    public StreamingContentRepositoryTests()
    {
        _globalRepo = new StreamingContentRepository();
        _contentA = new StreamingContent(
            "Rubber",
            "A tire that kills people!",
            2,
            MaturityRating.R,
            GenreType.Horror);

        _contentB = new StreamingContent(
            "Bad Boys",
            "A Cop Movie",
            10,
            MaturityRating.R,
            GenreType.Action);

        _contentC = new StreamingContent(
            "Last Action Hero",
            "Another Action Movie",
            10,
            MaturityRating.R,
            GenreType.Action);

        _contentD = new StreamingContent(
            "50 First Dates",
            "Romance Flick, Sandler's awesome!",
            10,
            MaturityRating.PG_13,
            GenreType.RomCom);
        //todo: Add these to the database -> _globalRepo
        _globalRepo.AddContentToDb(_contentA);
        _globalRepo.AddContentToDb(_contentB);
        _globalRepo.AddContentToDb(_contentC);
        _globalRepo.AddContentToDb(_contentD);
    }

    [Fact]
    public void AddToDirectory_ShouldGetCorrectBoolean()
    {
        //AAA

        //Arrange
        StreamingContent content = new StreamingContent();
        StreamingContentRepository repository = new StreamingContentRepository();

        //Act 
        bool addResult = repository.AddContentToDb(content);

        //Assert
        Assert.True(addResult);
    }

    [Fact] //GetAll
    public void Get_DatabaseInfo_Should_Return_CorrectCollection()
    {
        //Arrange
        StreamingContent content = new StreamingContent();
        StreamingContentRepository repository = new StreamingContentRepository();

        repository.AddContentToDb(content);

        //Act 
        List<StreamingContent> contents = repository.GetAllStreamingContent();

        bool dbaseHasContent = contents.Contains(content);

        //Assert
        Assert.True(dbaseHasContent);
    }

    [Fact] // get by Unique Identifier
    public void GetTitle_Should_Return_Correct_Content()
    {
        //Arrange is done... within the constructor

        //Act
        StreamingContent searchResult = _globalRepo.GetContentByTitle("Rubber");

        //Assert
        Assert.Equal(searchResult, _contentA);

    }

    [Fact] //update
    public void UpdateExistingContent_Should_Return_True()
    {
        StreamingContent updatedContent = new StreamingContent("Rubber UPDATED",
        "You know what it doess....Kills",
        7.0,
        MaturityRating.PG,
        GenreType.Horror);

        bool updateResult = _globalRepo.UpdateExistingContent("Rubber", updatedContent);

        Assert.True(updateResult);

        StreamingContent modifiedContent = _globalRepo.GetContentByTitle("Rubber UPDATED");
        System.Console.WriteLine(modifiedContent.Description);
    }

    [Fact]
    public void Delete_Existing_Content_Should_Return_True()
    {
        //arrange
        var content = _globalRepo.GetContentByTitle("Rubber");

        //Act
        bool removeResult = _globalRepo.DeleteExistingContent(content);

        Assert.True(removeResult);
        Assert.Equal(3,_globalRepo.GetAllStreamingContent().Count);
    }

    [Fact]
    public void GetContentByMatruityRating()
    {
        var contents = _globalRepo.GetContentByMatruityRating(MaturityRating.PG_13);
        Assert.Equal(1,contents.Count);
    }
}
