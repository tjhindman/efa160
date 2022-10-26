
public class SuperMario
{
    public int Lives { get; set; } = 3;
    public PowerUps PowerUp { get; set; }

    public float speed { get; set; } = 3.7f;

    public void PoweredUp()
    {
        Random rnd = new Random();
        Thread.Sleep(500);
        int powerUpValue = rnd.Next(0, 3);

        switch (powerUpValue)
        {
            case 1:
                System.Console.WriteLine("You Activated the Fire Flower");
                break;
            case 2:
                System.Console.WriteLine("You Activated the Ice Flower");
                break;
            default:
                System.Console.WriteLine("You Activated the Mushroom....BIG...");
                break;
        }
    }

    //used with a method
    //Random power-ups
}
