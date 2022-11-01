public class Floor
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Challenge> Challenges { get; set; } = new List<Challenge>();
}