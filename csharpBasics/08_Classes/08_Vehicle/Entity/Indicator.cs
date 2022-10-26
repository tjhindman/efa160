
public class Indicator
{
    //user will only have the ablity to "Read" this data
    // cannot directly write to .....
    public bool IsFlashing { get; private set; }

    public void TurnOn()
    {
        IsFlashing = true;
    }

    public void TurnOff()
    {
        IsFlashing = false;
    }
}
