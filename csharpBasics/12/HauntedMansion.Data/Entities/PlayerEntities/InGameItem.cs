public class InGameItem
{
    //constructors
    public InGameItem()
    {

    }
    
    public InGameItem(int id, string name, int timesCanBeUsed = 2)
    {
        ID = id;
        Name = name;
        TimesCanBeUsed = timesCanBeUsed;
    }

    //properties
    public int ID { get; set; }
    public string Name { get; set; }
    public int TimesCanBeUsed { get; set; }
    public bool IsUseable
    {
        get
        {
            return (TimesCanBeUsed > 0) ? true : false;
        }
    }
}