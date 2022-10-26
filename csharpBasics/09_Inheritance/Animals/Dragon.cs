
public class Dragon : Animal
{
    public Dragon()
    {
        HasFur = false;
        IsMammal = false;
        DietType = DietType.Carnivore;
        System.Console.WriteLine("This is the Dragon Constructor.");
    }
}


public class Wyrm : Dragon
{
    public Wyrm()
    {
        NumberOfLegs = 0;
        System.Console.WriteLine("This is the Wyrm Constructor.");
    }
}


public class Hydra : Dragon
{
    public Hydra(int headCount = 5)
    {
        HeadCount = headCount;
        System.Console.WriteLine("This is the Hydra Constructor.");
    }
    public int HeadCount { get; set; }
}