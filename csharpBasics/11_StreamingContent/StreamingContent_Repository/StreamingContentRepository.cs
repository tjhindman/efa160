
public class StreamingContentRepository
{
    //we need a FAKE DATABASE! -> WE WILL USE A List<T> collection
    //private readonly field
    protected readonly List<StreamingContent> _contentDb = new List<StreamingContent>();



    //C.R.U.D -> Create, Read , Update , and Delete  (methods)

    //todo Create:
    public bool AddContentToDb(StreamingContent content)
    {
        int startingCount = _contentDb.Count;
        _contentDb.Add(content);

        if (_contentDb.Count > startingCount)
        {
            return true;
        }
        else
        {
            return false;
        }

        // bool wasAdded = (_contentDb.Count > startingCount)? true : false;

        // return wasAdded;

    }

    //todo Read GetAll:
    public List<StreamingContent> GetAllStreamingContent()
    {
        return _contentDb;
    }

    //todo Read Get (helper method):
    public StreamingContent GetContentByTitle(string title)
    {
        //we need to iterate (loop) threw the database
        foreach (var content in _contentDb)
        {
            // if we find the matching title 
            if (content.Title == title)
            {
                // then we will return that title
                return content;
            }
        }
        // or retun null
        return null;
    }

    //todo Update:
    public bool UpdateExistingContent(string originalTitle, StreamingContent updatedData)
    {
        //Make sure that the content exsists
        StreamingContent oldContent = GetContentByTitle(originalTitle);

        //todo: if content actually exists
        if (oldContent != null)
        {
            //todo: we are now updating data
            oldContent.Title = updatedData.Title;
            oldContent.StarRating = updatedData.StarRating;
            oldContent.Description = updatedData.Description;
            oldContent.MaturityRating = updatedData.MaturityRating;
            oldContent.GenreType = updatedData.GenreType;
            return true;
        }
        else
        {
            return false;
        }
    }

    //todo Delete:
    public bool DeleteExistingContent(StreamingContent existingContent)
    {
        bool deleteResult = _contentDb.Remove(existingContent);
        return deleteResult;
        //  return _contentDb.Remove(existingContent);
    }

    //todo retun a List<StreamingContent> based on its MaturityRating
    public List<StreamingContent> GetContentByMatruityRating(MaturityRating rating)
    {
        //make a list that will hold the data
        List<StreamingContent> aux = new List<StreamingContent>();

        foreach (var item in _contentDb)
        {
            if (item.MaturityRating == rating)
            {
                aux.Add(item);
            }
        }

        return aux;
    }

}
