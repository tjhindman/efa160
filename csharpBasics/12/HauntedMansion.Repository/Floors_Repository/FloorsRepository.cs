
public class FloorsRepository
{
    private readonly ChallengeRepository _hHouseChallengeRepo = new ChallengeRepository();
    //Fake Db
    private readonly List<Floor> _hHouseFloorDb = new List<Floor>();
    private int _count;

    public FloorsRepository()
    {
        SeedFloors();
    }

    public bool AddFloor(Floor floor)
    {
        if (floor is null)
        {
            return false;
        }
        else
        {
            _count++;
            floor.ID = _count;
            _hHouseFloorDb.Add(floor);
            return true;
        }
    }

    public List<Floor> GetAllFloors()
    {
        return _hHouseFloorDb;
    }

    public Floor GetFloor(int id)
    {
        foreach (Floor floor in _hHouseFloorDb)
        {
            if (floor.ID == id)
            {
                return floor;
            }
        }
        return null;
    }


    public void SeedFloors()
    {
        var floor = new Floor
        {
            ID = 1,
            Name = "Main Floor",
            Challenges = _hHouseChallengeRepo.GetChallenges().Where(c => c.GetType() == typeof(FloorChallenge)).ToList()
        };

        var floor2 = new Floor
        {
            ID = 1,
            Name = "Second Floor",
            Challenges = _hHouseChallengeRepo.GetChallenges().Where(c => c.GetType() == typeof(BossChallenge)).ToList()
        };
        _hHouseFloorDb.Add(floor);
        _hHouseFloorDb.Add(floor2);
    }
}
