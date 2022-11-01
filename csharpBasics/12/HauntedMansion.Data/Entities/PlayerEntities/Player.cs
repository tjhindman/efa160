
public class Player
{

    //* constructor
    public Player()
    {
        SetupPlayerInitialization();
    }

    public Player(string name)
    {
        Name = name;
        SetupPlayerInitialization();
    }

    //* properties 
    //* unique Identifier
    public int ID { get; set; }

    public string Name { get; set; }
    public int HealthPoints { get; set; } = 100;
    public bool IsDead
    {
        get
        {
            return (HealthPoints <= 0) ? true : false;
        }
    }

    public List<InGameItem> Items;

    public void DecreaseHealth(int pointValue = 5)
    {
        if (HealthPoints > 0)
            HealthPoints -= pointValue;
    }

    public void IncreaseHealth(int pointValue = 5)
    {
        if (HealthPoints > 0)
            HealthPoints += pointValue;
    }

    public void ShootPlasmaPistol(Enemy enemy, int attackPower = 15)
    {
        if (PlasmaPistol.IsUseable)
        {
            PlasmaPistol.TimesCanBeUsed--;
            System.Console.WriteLine($"You shot the Plasma Pistol at {enemy.Name}!\n" +
                                    $"You have {PlasmaPistol.TimesCanBeUsed} bullets left!");
            if (enemy.HealthPoints >= 0)
            {
                enemy.DecreaseHealth(attackPower);
            }
        }
        else
        {
            System.Console.WriteLine("Shoot! I better find some bullits!");
        }
    }
    public void LoadPlasmaPistol(int roundValue)
    {
        PlasmaPistol.TimesCanBeUsed += roundValue;
    }
    private InGameItem PlasmaPistol;
    private InGameItem FlashLight;
    private InGameItem Map;
    private InGameItem Knife;

    private void SetupPlayerInitialization()
    {
        //fill line 18 up with data...
        Items = GameUtilities.InitializePlayerStartUpItems();
        Knife = Items[0];
        Map = Items[1];
        FlashLight = Items[2];
        PlasmaPistol = Items[3];
    }

}
