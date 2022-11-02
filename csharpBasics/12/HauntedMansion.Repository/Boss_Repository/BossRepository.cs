
public class BossRepository
{
    //Fake Database
    public List<Boss> _hHouseBossDb { get; set; } = new List<Boss>();
    //this helps with auto-incrementing the ID for the Boss obj
    public int _count { get; set; } = 0;

    public BossRepository()
    {
        SeedBoss();
    }

    //C.U.R.D
    public bool AddBoss(Boss boss)
    {
        return (boss is null) ? false : SaveToDatabase(boss);
    }

    private bool SaveToDatabase(Boss boss)
    {
        AssignId(boss);
        _hHouseBossDb.Add(boss);
        return true;
    }

    private void AssignId(Boss boss)
    {
        _count++;
        boss.ID = _count;
    }

    public Boss GetBoss()
    {
        return _hHouseBossDb.FirstOrDefault();
    }

    public Boss GetBoss(int id)
    {
        return _hHouseBossDb.SingleOrDefault(x => x.ID == id);
    }

    public void SeedBoss()
    {
        var boss = new Boss
        {
            ID = 1,
            Name = "Demon with Pin In his Head"
        };

        _hHouseBossDb.Add(boss);
    }
}
