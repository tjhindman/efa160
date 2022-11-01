
public class HauntedHouse
{
    public HauntedHouse()
    {
        Name = "BoonVille Farms";
        Address = "1357 Evil Lane";
        City = "Monsterville Indiana";
        Player = new Player("Buddy");
    }
    //properties
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public Player Player { get; set; }
    public List<Floor> FloorsInHouse { get; set; } = new List<Floor>();

    public override string ToString()
    {
        var str = $"ID: {ID}\n" +
                 $"Name: {Name}\n" +
                 $"Addresss: {Address}\n" +
                 $"City: {City}\n" +
                 $"Player: {Player.Name}\n" +
                 "-------- Floors In House ---------\n";
        foreach (Floor floor in FloorsInHouse)
        {
            str += $"FloorID: {floor.ID}\n" +
                 $"Floor Name: {floor.Name}\n" +
                 "-------- Floors In House ---------\n";
            foreach (Challenge floorChallenge in floor.Challenges)
            {
                str += $"Floor Challenge Id: {floorChallenge.ID}\n" +
                      $"Floor Name: {floorChallenge.ChallengeDescription}\n";
                foreach (string task in floorChallenge.ChallengeTasks)
                {
                    str += $"{task}";
                }
                str += $"Floor Challenge Complete: {floorChallenge.IsComplete}\n";
            }
        }

        return str;
    }
}
