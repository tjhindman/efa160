
//POCO -> Plain Old C# Object
public class Developer
{
    public Developer()
    {

    }
    public Developer(string firstName, string lastName, bool hasPluralsight)
    {
        FirstName = firstName;
        LastName = lastName;
        HasPluralsight = hasPluralsight;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public bool HasPluralsight { get; set; }
}
