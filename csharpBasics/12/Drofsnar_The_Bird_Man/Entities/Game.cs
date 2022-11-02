
public class Game
{
    public static void Run()
    {
        // your filePath will be different... rt-click on game_Sequence.txt and choose copy path and 
        // paste it between the double quotes.
        string filePath = @"C:\EFA160_Key\efa160\csharpBasics\12\Drofsnar_The_Bird_Man\game_Sequence.txt";

        List<string> lines = File.ReadAllLines(filePath).ToList();
        string[] events = new string[lines.Count];
        foreach (var line in lines)
        {
            events = line.Split(',');
        }
        foreach (var scenEvent in events)
        {
            Console.WriteLine(scenEvent);
        }

        int Points = 0;
        int VunerableBirdHunterCount = 0;
        Dictionary<string, int> stuff = new Dictionary<string, int>()
            {
                { "Bird",10 },
                { "CrestedIbis",100},
                { "GreatKiskudee",300},
                { "RedCrossbill",500},
                { "Red-neckedPhalarope",700},
                { "EveningGrosbeak",1000},
                { "GreaterPrairieChicken",2000},
                { "IcelandGull",3000},
                { "Orange-belliedParrot",5000},
                { "VulnerableBirdHunter",200},
            };

        foreach (var scenario in stuff)
        {
            if (scenario.Key == "Bird")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "CrestedIbis")
            {
            }
            if (scenario.Key == "GreatKiskudee")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "RedCrossbill")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "Red-neckedPhalarope")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "EveningGrosbeak")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "GreaterPrairieChicken")
            {
                Points += scenario.Value;

            }
            if (scenario.Key == "IcelandGull")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "Orange-belliedParrot")
            {
                Points += scenario.Value;
            }
            if (scenario.Key == "VulnerableBirdHunter")
            {
                if (VunerableBirdHunterCount != 1)
                {
                    VunerableBirdHunterCount++;
                    Points += scenario.Value;
                }
                else if (VunerableBirdHunterCount >= 1)
                {
                    if (Points <= 1600)
                    {
                        Points += scenario.Value * 2;
                    }
                }
            }
        }
        Console.WriteLine($"Overall Points: {Points}!");
    }

}
