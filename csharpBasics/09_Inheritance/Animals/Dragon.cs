
public class Dragon : Animal, IAttack
{
    public Dragon()
    {
        HasFur = false;
        IsMammal = false;
        DietType = DietType.Carnivore;
        System.Console.WriteLine("This is the Dragon Constructor.");
    }

    public void BasicAttack()
    {
        System.Console.WriteLine("I just took -10atk");
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

public class Hydra : Dragon , IWaterAttack
{
    public Hydra(int headCount = 5)
    {
        HeadCount = headCount;
        System.Console.WriteLine("This is the Hydra Constructor.");
    }
    public int HeadCount { get; set; }

     public void WaterAttack()
    {
        System.Console.WriteLine("I spit on you..Ha ha!");
        System.Console.WriteLine("I just took -100atk");
    }
}

public class FreezeDragon : Dragon, IWaterAttack, IFreezeAttack
{
     public void FreezeAttack()
    {
        System.Console.WriteLine("I just took -1000atk");
    }

    public void WaterAttack()
    {
        System.Console.WriteLine("I JUST SPIT ON YOU !!!");
        System.Console.WriteLine("I just took -300atk");
    }
}

public class SuperDuperDragon : Dragon, IWaterAttack, IFreezeAttack
{
    //the super duper dragon can do EVERYTHING!!!
    public void FreezeAttack()
    {
       System.Console.WriteLine("I just took -100_000atk");
    }

    public void WaterAttack()
    {
        System.Console.WriteLine("I JUST SPIT ON YOU !!!");
        System.Console.WriteLine("I just took -300_000atk");
    }
}