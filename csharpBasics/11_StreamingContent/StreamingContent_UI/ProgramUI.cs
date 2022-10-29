
public class ProgramUI
{
    //we need to connect to the Fake Database
    private readonly StreamingContentRepository _repo = new StreamingContentRepository();
    private readonly IConsole _console;

    public ProgramUI(IConsole console)
    {
        _console = console;
    }

    public void Run()
    {
        SeedContentList();
        RunApplication();
    }

    private void RunApplication()
    {
        bool isRunning = true;
        //while loop to run the app
        while (isRunning)
        {
            _console.Clear();

            _console.WriteLine("Enter the Number of the Option you would like to select:\n" +
                                    "1. Show All Streaming Content\n" +
                                    "2. Find Streaming Content By Title \n" +
                                    "3. Add New Streaming Content \n" +
                                    "4. Remove Streaming Content\n" +
                                    "5. Exit\n");

            string userInput = _console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ShowAllContent();
                    break;
                case "2":
                    ShowContentByTitle();
                    break;
                case "3":
                    CreateNewContent();
                    break;
                case "4":
                    RemoveContentFromList();
                    break;
                case "5":
                    isRunning = false;
                    _console.WriteLine("Thank you, press any key to exit");
                    _console.ReadKey();
                    break;
                default:
                    _console.WriteLine("Sorry, invalid selection, please try again.");
                    break;
            }
        }
    }

    private void RemoveContentFromList()
    {
        _console.Clear();
        _console.WriteLine("Which Item do you want to remove?");

        //get data from database
        List<StreamingContent> contentList = _repo.GetAllStreamingContent();

        if (contentList.Count() > 0)
        {
            #region listing Setup
            int count = 0;

            foreach (StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}. {content.Title}");
            }
            #endregion

            int targetContentId = int.Parse(_console.ReadLine());
            int targetIndex = targetContentId - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];

                if (_repo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} successfully deleted.");
                }
                else
                {
                    _console.WriteLine($"{desiredContent.Title} failed to be deleted.");
                }
            }
            else
            {
                _console.WriteLine("Invalid Id selection.");
            }
        }
        else
        {
            _console.WriteLine("There is no available content.");
        }

        _console.ReadKey();
    }

    private void CreateNewContent()
    {
        _console.Clear();
        StreamingContent content = AddStreamingContentDetails();

        //add what we have to the database
        if (_repo.AddContentToDb(content))
        {
            _console.WriteLine("Added To the Database");
        }
        else
        {
            _console.WriteLine("Failed to Add To the Database");
        }

        _console.ReadKey();
    }

    private StreamingContent AddStreamingContentDetails()
    {
        StreamingContent content = new StreamingContent();

        //Title
        _console.WriteLine("Please enter a title.");
        string userInputTitle = _console.ReadLine();
        content.Title = userInputTitle;

        //Description
        _console.WriteLine("Please enter a discription: ");
        string userInputDescription = _console.ReadLine();
        content.Description = userInputDescription;

        //star rating
        _console.WriteLine("Please enter a star rating from 1-5:");
        double userInputStarRating = Convert.ToDouble(_console.ReadLine());
        content.StarRating = userInputStarRating;

        //maturity rating
        _console.WriteLine("Please enter a Maturity Rating\n" +
                        "1. G\n" +
                        "2. PG\n" +
                        "3. PG 13\n" +
                        "4. R\n" +
                        "5. NC 17\n" +
                        "6. TV Y\n" +
                        "7. TV G\n" +
                        "8. TV PG\n" +
                        "9. TV 14\n" +
                        "10. TV Ma\n");

        string maturityRating = _console.ReadLine();
        switch (maturityRating)
        {
            case "1":
                content.MaturityRating = MaturityRating.G;
                break;
            case "2":
                content.MaturityRating = MaturityRating.PG;
                break;
            case "3":
                content.MaturityRating = MaturityRating.PG_13;
                break;
            case "4":
                content.MaturityRating = MaturityRating.R;
                break;
            case "5":
                content.MaturityRating = MaturityRating.NC_17;
                break;
            case "6":
                content.MaturityRating = MaturityRating.TV_Y;
                break;
            case "7":
                content.MaturityRating = MaturityRating.TV_G;
                break;
            case "8":
                content.MaturityRating = MaturityRating.TV_PG;
                break;
            case "9":
                content.MaturityRating = MaturityRating.TV_14;
                break;
            case "10":
                content.MaturityRating = MaturityRating.TV_MA;
                break;
        }
        //Genre
        _console.WriteLine("Select a Genre\n" +
            "1. Horror\n" +
            "2. RomCom\n" +
            "3. Scifi\n" +
            "4. Documentary\n" +
            "5. Bromance\n" +
            "6. Drama\n" +
            "7. Action\n");

        string genreInput = _console.ReadLine();

        int genreId = int.Parse(genreInput);

        //converting an int to a GenreType, their both ints so it just works
        content.GenreType = (GenreType)genreId;

        System.Console.WriteLine("What kind of content is this?\n" +
                                "1. Movie\n" +
                                "2. Show\n");

        var userInputType = Console.ReadLine();

        switch (userInputType)
        {
            case "1":
                System.Console.WriteLine("You chose a move type");
                return new Movie
                {
                    Title = content.Title,
                    Description = content.Description,
                    StarRating = content.StarRating,
                    MaturityRating = content.MaturityRating,
                    GenreType = content.GenreType
                };


            case "2":
                System.Console.WriteLine("You chose a show type");
                var theShow = new Show
                {
                    Title = content.Title,
                    Description = content.Description,
                    StarRating = content.StarRating,
                    MaturityRating = content.MaturityRating,
                    GenreType = content.GenreType
                };

                System.Console.WriteLine("Are there any episodes");
                var episode = new Episode();
                System.Console.WriteLine("Episode title");
                var userInputepTitle = Console.ReadLine();
                episode.Title = userInputepTitle;
                //...all other stuff...
                theShow.Episodes.Add(episode);

                return theShow;
            default:
                return content;

        }

    }

    private void ShowContentByTitle()
    {
        _console.Clear();
        _console.WriteLine("Enter a Title: ");
        string userInput = _console.ReadLine();

        StreamingContent content = _repo.GetContentByTitle(userInput);

        if (content != null)
        {
            ShowStreamingContentDetails(content);
        }
        else
        {
            _console.WriteLine("Invalid Title. Could not find results.");
        }
        _console.WriteLine("Press any key to continue.");
        _console.ReadKey();
    }

    private void ShowAllContent()
    {
        _console.Clear();
        List<StreamingContent> listOfContent = _repo.GetAllStreamingContent();

        if (listOfContent.Count > 0)
        {
            foreach (var content in listOfContent)
            {
                ShowStreamingContentDetails(content);
            }
        }
        else
        {
            _console.WriteLine("Sorry there is no available content!");
        }

        _console.ReadKey();
    }

    private void ShowStreamingContentDetails(StreamingContent content)
    {
        _console.WriteLine($"Title: {content.Title}\n" +
                                $"Description: {content.Description}\n" +
                                $"Star Rating: {content.StarRating}\n" +
                                $"Maturity Rating: {content.MaturityRating}\n" +
                                $"Genre: {content.GenreType}\n" +
                                "-----------------------------------\n");
    }

    private void SeedContentList()
    {
        StreamingContent rubber = new StreamingContent("Rubber", "Tyre comes to life and kills people.", 5, MaturityRating.R, GenreType.Drama);
        StreamingContent toyStory = new StreamingContent("Toy Story", "Best childhood movie.", 10, MaturityRating.G, GenreType.Bromance);
        StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the world.", 9.2, MaturityRating.PG_13, GenreType.SciFi);

        _repo.AddContentToDb(rubber);
        _repo.AddContentToDb(toyStory);
        _repo.AddContentToDb(starWars);
    }
}
