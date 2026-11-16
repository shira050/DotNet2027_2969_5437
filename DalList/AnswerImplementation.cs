using DO;
using DalApi;

namespace DalList;

internal class AnswerImplementation : IAnswer
{
  


   public int Create(Answer item)
    {
        int nextId = DataSource.Config.AnswerNum; // שליפת מספר רץ
        Answer copy = item with { Id = nextId };     // יצירת העתק עם ה-ID החדש (בהנחה שזה record)
        DataSource.Answers.Add(copy);
        return nextId;
    }

    public Answer? Read(int id)
    {
        return DataSource.Answers.FirstOrDefault(item => item?.Id == id);
    }

    public List<Answer> ReadAll()
    {
        return new List<Answer>(DataSource.Answers!); // החזרת עותק של הרשימה
    }

    public void Update(Answer item)
    {
        Answer? existing = Read(item.Id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Answer עם ID {item.Id} לא קיים");

        DataSource.Answers.Remove(existing);
        DataSource.Answers.Add(item);
    }

    public void Delete(int id)
    {
        Answer? existing = Read(id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Answer עם ID {id} לא קיים");

        DataSource.Answers.Remove(existing);
    }
}

