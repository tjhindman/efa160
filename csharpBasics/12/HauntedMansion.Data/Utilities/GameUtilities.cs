
public static class GameUtilities
{
    public static List<InGameItem> InitializePlayerStartUpItems()
    {
        //we need to read the InGameItems.txt file
        var listOfStuff = File.ReadAllLines(@"C:\EFA160_Key\efa160\csharpBasics\12\HauntedMansion.Data\InGameItems.txt");

        List<InGameItem> playerStartingItems = new List<InGameItem>();

        for (int i = 0; i < listOfStuff.Length; i++)
        {
            //check i
            if (listOfStuff[i] == "|")
            {
                //create an InGameItem
                var inGameItem = new InGameItem
                {
                    ID = int.Parse(listOfStuff[++i]),
                    Name = listOfStuff[++i],
                    TimesCanBeUsed = int.Parse(listOfStuff[++i])
                };

                playerStartingItems.Add(inGameItem);
            }
        }
        return playerStartingItems;
    }

    public static void FoundPistolCartriage(int roundValue, Player player)
    {
        player.LoadPlasmaPistol(roundValue);
    }

    public static void TellTheStory(string storySection)
    {
        System.Console.WriteLine(storySection);
    }

    public static void DisplayFloorChallengeInfo(HauntedHouse _house)
    {
        foreach (Floor floor in _house.FloorsInHouse)
        {
            foreach(Challenge fChallenge in floor.Challenges)
            {
                System.Console.WriteLine(fChallenge.ChallengeDescription);
            }
        }
    }
}
