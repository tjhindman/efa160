
public class ChallengeRepository
{
    private readonly BossRepository _hHouseBossRepo = new BossRepository();
    //fake database
    private readonly List<Challenge> _hHouseChallengeDb = new List<Challenge>();
    private int _count;

    public ChallengeRepository()
    {
        SeedChallenges();
    }

    public bool AddChallenge(Challenge challenge)
    {
        if (challenge is null)
        {
            return false;
        }
        else
        {
            _count++;
            challenge.ID = _count;
            _hHouseChallengeDb.Add(challenge);
            return true;
        }
    }

    //Get all challenges
    public List<Challenge> GetChallenges()
    {
        return _hHouseChallengeDb;
    }

    public Challenge GetChallenge(int challengeID)
    {
        return (from challenge in _hHouseChallengeDb
                where challenge.ID == challengeID
                select challenge).FirstOrDefault();

        //  return _hHouseChallengeDb.FirstOrDefault(x=>x.ID==challengeID);
    }

    public void SeedChallenges()
    {
        var floor1 = new FloorChallenge
        {
            ID = 1,
            ChallengeDescription =
               "There are Three Rooms.\n" +
               "The Left and the Right ones are unlocked.\n" +
               "Find Middle Room Key\n",
            ChallengeTasks = new List<string>
            {
                "Find Middle Room Key\n"
            }
        };
        var floor2 = new FloorChallenge
        {
            ID = 2,
            ChallengeDescription = "Find the Missing Puzzle Piece and Put it back in its place.",
            ChallengeTasks = new List<string>
            {
                "Find Missing Painting Piece\n",
                "Put it back in its place\n"
            }
        };
        var floor3 = new BossChallenge
        {
            ID = 3,
            Boss = _hHouseBossRepo.GetBoss(),
            ChallengeDescription = "Defeat The Demon with Pins In His Head!",
            ChallengeTasks = new()
            {
                "Defeat The Demon with Pins In His Head!"
            }
        };

        _hHouseChallengeDb.Add(floor1);
        _hHouseChallengeDb.Add(floor2);
        _hHouseChallengeDb.Add(floor3);
    }
}
