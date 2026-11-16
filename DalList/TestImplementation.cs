
using DalApi;
using DO;
    
namespace DalList;

internal class TestImplementation : ITest
{
    public int Create(Test item)
    {
        int nextId = DataSource.Config.TestNum;
        Test copy = item with { id = nextId }; // אם בישות Test קראת לשדה TestId, שנה כאן ל-TestId
        DataSource.Tests.Add(copy);
        return nextId;
    }

    public Test? Read(int id)
    {
        return DataSource.Tests.FirstOrDefault(item => item?.id == id);
    }

    public List<Test> ReadAll()
    {
        return new List<Test>(DataSource.Tests!);
    }

    public void Update(Test item)
    {
        Test? existing = Read(item.id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Test עם ID {item.id} לא קיים");

        DataSource.Tests.Remove(existing);
        DataSource.Tests.Add(item);
    }

    public void Delete(int id)
    {
        Test? existing = Read(id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Test עם ID {id} לא קיים");

        DataSource.Tests.Remove(existing);
    }
}

