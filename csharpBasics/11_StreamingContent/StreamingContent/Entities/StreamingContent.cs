
public class StreamingContent
{
    public StreamingContent() { }
    public StreamingContent
    (
        string title,
        string description,
        double starRating,
        MaturityRating maturityRating,
        GenreType genreType
    )
    {
        Title = title;
        Description = description;
        StarRating = starRating;
        MaturityRating = maturityRating;
        GenreType = genreType;
    }

    //Unique identifier
    //This is our 'Key' -> string, but for us it can be a string or int value 
    public string Title { get; set; }
    public string Description { get; set; }
    public double StarRating { get; set; }
    public MaturityRating MaturityRating { get; set; }
    public GenreType GenreType { get; set; }
    public bool IsFamilyFriendly
    {
        get
        {
            switch (MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                    return true;
                case MaturityRating.R:
                case MaturityRating.PG_13:
                case MaturityRating.TV_14:
                case MaturityRating.NC_17:
                case MaturityRating.TV_MA:
                    return false;
                default:
                    return false;
            }

            //order of the ENUM matters here:
            // if((int)MaturityRating >4)
            // {
            //     return false;
            // }
            // else
            // return true;
        }
    }
}


/*
       Users have been complaining about their family friendly content. 
   Some users have been reporting that when filtering for family friendly, 
   they're getting some content with inappropriate maturity ratings. We need to fix this. 
   Currently the maturity rating and family friendly bool are independent, we need to tie them together. 
   If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 

       We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.
   */