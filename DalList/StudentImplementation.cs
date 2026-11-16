using DO;
using DalApi;

namespace DalList;

internal class StudentImplementation : IStudent
{
    public int Create(Student item)
    {
        if (Read(item.StudentId) is not null)
            throw new Exception($"אובייקט מסוג Student עם ID {item.StudentId} כבר קיים");

        DataSource.Students.Add(item);
        return item.StudentId;
    }

    public Student? Read(int id)
    {
        return DataSource.Students.FirstOrDefault(item => item?.StudentId == id);
    }

    public List<Student> ReadAll()
    {
        return new List<Student>(DataSource.Students!);
    }

    public void Update(Student item)
    {
        Student? existing = Read(item.StudentId);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Student עם ID {item.StudentId} לא קיים");

        DataSource.Students.Remove(existing);
        DataSource.Students.Add(item);
    }

    public void Delete(int id)
    {
        Student? existing = Read(id);
        if (existing is null)
            throw new Exception($"אובייקט מסוג Student עם ID {id} לא קיים");

        DataSource.Students.Remove(existing);
    }
}
