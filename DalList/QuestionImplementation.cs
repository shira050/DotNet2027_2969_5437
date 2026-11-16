
using DalApi;
using DO;

namespace DalList;

internal class QuestionImplementation : IQuestionInTest
{

    public int Create(Question item)
    {
        int nextId = DataSource.Config.QuestionNum; // שליפת מספר רץ
        Question copy = item with { Id = nextId };     // יצירת העתק עם ה-ID החדש (בהנחה שזה record)
        DataSource.Questions.Add(copy);
        return nextId;
    }

    public Question? Read(int id)
    {
        return DataSource.Questions.FirstOrDefault(item => item?.Id == id);
    }

    public List<Question> ReadAll()
    {
        return new List<Question>(DataSource.Questions!); // החזרת עותק של הרשימה
    }

    public void Update(Question item)
    {
        Question? existing = Read(item.Id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Answer עם ID {item.Id} לא קיים");

        DataSource.Questions.Remove(existing);
        DataSource.Questions.Add(item);
    }

    public void Delete(int id)
    {
        Question? existing = Read(id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Question עם ID {id} לא קיים");

        DataSource.Questions.Remove(existing);
    }
}
