
public abstract class Challenge
{
    public int ID { get; set; }
    public string ChallengeDescription { get; set; }
    public List<string> ChallengeTasks { get; set; } = new List<string>();

    public bool IsComplete
    {
        get
        {
            return (ChallengeTasks.Count() <= 0) ? true : false;
        }
    }
}
