using DalApi;
using DO;
namespace DalList;

internal class QuestionInTestImplementation: IQuestionInTest
{
    public int Create(QuestionInTest item)
    {
        int nextId = DataSource.Config.QuestionInTestNum;
        QuestionInTest copy = item with { Id = nextId };
        DataSource.QuestionInTests.Add(copy);
        return nextId;
    }

    public QuestionInTest? Read(int id)
    {
        return DataSource.QuestionInTests.FirstOrDefault(item => item?.Id == id);
    }

    public List<QuestionInTest> ReadAll()
    {
        return new List<QuestionInTest>(DataSource.QuestionInTests!);
    }

    public void Update(QuestionInTest item)
    {
        QuestionInTest? existing = Read(item.Id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג QuestionInTest עם ID {item.Id} לא קיים");

        DataSource.QuestionInTests.Remove(existing);
        DataSource.QuestionInTests.Add(item);
    }

    public void Delete(int id)
    {
        QuestionInTest? existing = Read(id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג QuestionInTest עם ID {id} לא קיים");

        DataSource.QuestionInTests.Remove(existing);
    }
}
