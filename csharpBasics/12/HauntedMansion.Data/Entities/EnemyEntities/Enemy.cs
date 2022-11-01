
public abstract class Enemy
{
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

    public virtual void Attack(Player player, int attackPower, string attackName)
    {
        if (player.HealthPoints > 0)
        {
            player.DecreaseHealth(attackPower);
            System.Console.WriteLine($"{Name} just Hit you with {attackName.ToUpper()} You Lost {attackPower} Health!");
        }
    }
}
