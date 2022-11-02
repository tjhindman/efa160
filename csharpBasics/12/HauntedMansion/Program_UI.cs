using static System.Console;


public class Program_UI
{
    public readonly HauntedHouseRepository _hHouseRepo = new HauntedHouseRepository();
    private HauntedHouse _house;
    private int _challengeCounter;
    private bool IsRunning = true;
    public bool _hasMiddleRoomkey;
    public bool _hasPuzzlePiece;

    public Program_UI()
    {
        SeedData();
        _house = _hHouseRepo.GetHauntedHouse();
        // System.Console.WriteLine(_house);
    }



    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        while (IsRunning)
        {
            WriteLine("Welcome to the Haunted House, Please make a selection:\n" +
                     "1. Start Game\n" +
                     "2. End Game");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    IsRunning = CloseGame();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
    }

    private bool CloseGame()
    {
        System.Console.WriteLine("Thanks for Playing!");
        PressAnyKeyToContinue();
        return false;
    }

    private void PressAnyKeyToContinue()
    {
        WriteLine("Press any key to continue...");
        ReadKey();
    }

    private void StartGame()
    {
        Clear();
        while (!_house.Player.IsDead && IsRunning)
        {
            GameUtilities.TellTheStory($"You are a Paranormal Investigator,\nand you have been ordered to enter a haunted house on {_house.Address}\n" +
                                                   $"You notice... Press any Key To Continue...");
            ReadKey();
            while (_hasMiddleRoomkey == false)
            {
                LoadFirstChallenge();
            }

            GameUtilities.TellTheStory("You use the key to open the Middle Room Door!");

            GameUtilities.TellTheStory("You go up the stairs, your on the Next Floor!");

            while (_hasPuzzlePiece == false)
            {
                LoadSecondChallenge();
            }

            LoadFinalChallenge();

            ReadKey();
        }

        if (_house.Player.IsDead)
        {
            IsRunning = CloseGame();
        }

    }

    private void LoadFinalChallenge()
    {
        Clear();
        ClearChallengeCounter();
        //This is the second index of the seeded Challenges -> and it only has one challenge.
        var currentChallenge = _house.FloorsInHouse[(int)ChallengesIndex.SecondChallenge].Challenges[_challengeCounter];
        GameUtilities.TellTheStory("You place the Puzzle Piece inside of the missing section of the Puzzle\nDARKNESS SURROUNDS YOU\n" +
                                    "A creepy individual with Pins in his head approaches, what will you do?\n" +
                                    "1. Shoot the damn Demon!\n" +
                                    "2. Ask him what he wants\n" +
                                    "3. Try to Escape\n");

        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                ShootTheDamnDemon();
                break;
            case "2":
                AskWhatHeWants();
                break;
            case "3":
                TryToEscape();
                break;
            default:
                WriteLine("Invalid Selection, THIS CAN COST YOU YOUR LIFE!");
                break;
        }
        ReadKey();
    }

    private void TryToEscape()
    {
        Console.Clear();
        BossChallenge currentChallenge = (BossChallenge)_house.FloorsInHouse[1].Challenges[0];
        GameUtilities.TellTheStory("You try to get away, Fish Hooks fly from nowhere and attach to you.\nThey RIP YOU APART\n" +
                                  "The Man with Pins In His Head Laughs, 'HAAAAAA,HA,HA!'");

        currentChallenge.Boss.Attack(_house.Player, 1000, "Fish-Hooks of Destruction!");
        _hasPuzzlePiece = false;
    }

    private void AskWhatHeWants()
    {
        Console.Clear();
        BossChallenge currentChallenge = (BossChallenge)_house.FloorsInHouse[1].Challenges[0];
        GameUtilities.TellTheStory("You ask him what he wants\n" +
        "He replies 'Your Soul'\n" +
        "You try to get away, Fish Hooks fly from nowhere and attach to you.\nThey RIP YOU APART\n" +
                                  "The Man with Pins In His Head Laughs, 'HAAAAAA,HA,HA!'");

        currentChallenge.Boss.Attack(_house.Player, 1000, "Fish-Hooks of Destruction!");
        _hasPuzzlePiece = false;
    }


    private void ShootTheDamnDemon()
    {
        Console.Clear();
        BossChallenge currentChallenge = (BossChallenge)_house.FloorsInHouse[1].Challenges[0];
        GameUtilities.TellTheStory("You Shoot the Damn Demon!");
        _house.Player.ShootPlasmaPistol(currentChallenge.Boss, 50);
        while (currentChallenge.Boss.HealthPoints > 0)
        {
            GameUtilities.TellTheStory("Will you shoot again? y/n");
            var userInput = ReadLine();
            if (userInput != "Y".ToLower())
            {
                Console.Clear();
                GameUtilities.TellTheStory("You ask him what he wants\n" +
                "You try to get away, Fish Hooks fly from nowhere and attach to you.\nThey RIP YOU APART\n" +
                                          "The Man with Pins In His Head Laughs, 'HAAAAAA,HA,HA!'");

                currentChallenge.Boss.Attack(_house.Player, 1000, "Fish-Hooks of Destruction!");

            }
            else
            {
                _house.Player.ShootPlasmaPistol(currentChallenge.Boss, 20);
            }
        }
        WriteLine("You Killed the Demon with the Pins in his Head... or so you thought...");
        IsRunning = CloseGame();
    }


    private void ClearChallengeCounter()
    {
        _challengeCounter = 0;
    }

    private void LoadSecondChallenge()
    {
        Clear();
        ClearChallengeCounter();
        var currentChallenge = _house.FloorsInHouse[(int)ChallengesIndex.FirstChallenge].Challenges[++_challengeCounter];
        GameUtilities.TellTheStory("There is a large Puzzle in the middle of the Hall.");
        GameUtilities.TellTheStory(currentChallenge.ChallengeDescription);
        GameUtilities.TellTheStory("Which Room will you Select this time?.\n" +
                                   "1. The Room down the hall and to the Left?\n" +
                                   "2. The Room down the hall and to the Right?\n");
        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                LoadTheRoomDownTheHall_ToTheLeft();
                break;
            case "2":
                LoadTheRoomDownTheHall_ToTheRight();
                break;
            default:
                WriteLine("Invalid Selection");
                break;
        }
    }

    private void LoadTheRoomDownTheHall_ToTheRight()
    {
        bool hasLeftRoom = false;
        while (!hasLeftRoom)
        {
            Clear();
            GameUtilities.TellTheStory("You Entered the Room. Its just a basic room.\n,lets investigate further. Where do you want to look?\n" +
           "1. Inside a Random Coffie Cup\n" +
           "2. A Shiny Box (it looks like a puzzle box)\n" +
           "3. A Dead Body thats slumped over by the fireplace.\n" +
           "4. Leave The Room");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    Clear();
                    GameUtilities.TellTheStory("You Look inside...NOTHING...");
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    Clear();
                    GameUtilities.TellTheStory("You Rub the box... It Reconfigures itself..It looks like its what we have been looking for!");
                    _hasPuzzlePiece = true;
                    hasLeftRoom = true;
                    PressAnyKeyToContinue();
                    break;
                case "3":
                    Clear();
                    GameUtilities.TellTheStory("You move it around and.... Yuck! Its head falls off!");
                    PressAnyKeyToContinue();
                    break;
                case "4":
                    Clear();
                    GameUtilities.TellTheStory("You Exit the Room.");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadSecondChallenge();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
        //  ReadKey();
    }

    private void LoadTheRoomDownTheHall_ToTheLeft()
    {
        bool hasLeftRoom = false;
        while (!hasLeftRoom)
        {
            Clear();
            GameUtilities.TellTheStory("You Entered the Room. Its some sort of Theater of Lost Souls, lets investigate further. Where do you want to look?\n" +
           "1. Inside of the Broken Globe in the middle of the Room\n" +
           "2. A Random Purse on the Floor\n" +
           "3. A Dead Body that was stapled to the wall\n" +
           "4. Leave The Room");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    Clear();
                    GameUtilities.TellTheStory("You Look inside...NOTHING...");
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    Clear();
                    GameUtilities.TellTheStory("You look inside...random stuff..");
                    PressAnyKeyToContinue();
                    break;
                case "3":
                    Clear();
                    GameUtilities.TellTheStory("You move it around and.... Yuck! Its head falls off!");
                    PressAnyKeyToContinue();
                    break;
                case "4":
                    Clear();
                    GameUtilities.TellTheStory("You Exit the Room.");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadSecondChallenge();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }
        //   ReadKey();
    }

    private void LoadFirstChallenge()
    {
        Clear();
        var currentChallenge = _house.FloorsInHouse[(int)ChallengesIndex.FirstChallenge].Challenges[_challengeCounter];
        GameUtilities.TellTheStory(currentChallenge.ChallengeDescription);

        GameUtilities.TellTheStory("Which Room will you select?\n" +
                                            "1. Room on the Left\n" +
                                            "2. Room on the Right\n");
        var userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                YouChoseTheLeftRoom();
                break;
            case "2":
                YouChoseTheRightRoom();
                break;
            default:
                WriteLine("Invalid Selection.");
                break;
        }
    }

    private void YouChoseTheRightRoom()
    {
        bool hasLeftRoom = false;
        while (!hasLeftRoom)
        {
            Clear();
            GameUtilities.TellTheStory("You Entered the Right Room. Its the Kitchen, and its a mess. But, lets investigate further. Where do you want to look?\n" +
            "1. In the Refrigerator\n" +
            "2. On top of the Kitchen Island\n" +
            "3. In the Lower Cabinets\n" +
            "4. Leave The Room");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    Clear();
                    GameUtilities.TellTheStory("You open the refrigerator door...NOTHING...");
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    Clear();
                    GameUtilities.TellTheStory("You look on top of the Kitchen Island. Its completely covered with random stuff..");
                    PressAnyKeyToContinue();
                    break;
                case "3":
                    Clear();
                    GameUtilities.TellTheStory("You check the Lower Cabinets...Again Theres NOTHING...");
                    PressAnyKeyToContinue();
                    break;
                case "4":
                    Clear();
                    GameUtilities.TellTheStory("You Exit the Room.");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadFirstChallenge();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }

        // ReadKey();
    }

    private void YouChoseTheLeftRoom()
    {

        Clear();
        bool hasLeftRoom = false;
        while (!hasLeftRoom)
        {
            Clear();
            GameUtilities.TellTheStory("You Entered the Left Room.\nIts the Living Room, and its a mess.\nBut, lets investigate further.\nWhere do you want to look?\n" +
            "1. On the Couch\n" +
            "2. On the Coffie Table\n" +
            "3. Inside of the Broken Television\n" +
            "4. Leave The Room");

            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    Clear();
                    GameUtilities.TellTheStory("You Check the couch...Nothing...");
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    Clear();
                    GameUtilities.TellTheStory("You check the Coffie Table...Nothing.\nYou take a seat on the Couch and notice that there is something shiny inside of the Broken Television Screen!");
                    PressAnyKeyToContinue();
                    break;
                case "3":
                    Clear();
                    GameUtilities.TellTheStory("You check inside the Broken Television Screen, You Found the Key to the Middle Room!");
                    _hasMiddleRoomkey = true;
                    GameUtilities.TellTheStory("You Exit the Room.");
                    hasLeftRoom = true;
                    PressAnyKeyToContinue();
                    break;
                case "4":
                    Clear();
                    GameUtilities.TellTheStory("You Exit the Room.");
                    PressAnyKeyToContinue();
                    hasLeftRoom = true;
                    LoadFirstChallenge();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
        }

    }
    private void SeedData()
    {
        _hHouseRepo.SeedData();
    }
}
