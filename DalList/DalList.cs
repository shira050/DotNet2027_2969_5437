using DalApi;
using DalList;

using DalApi;

namespace Dal;

public class DalList : IDal
{
    public ITest Test => new TestImplementation();

    // נוסיף את השאר כדי לספק את דרישות הממשק, אבל נחזיר null בינתיים
    public IStudent Student => null!;
    public IQuestion Question => null!;
    public IAnswer Answer => null!;
    public IQuestionInTest QuestionInTest => null!;
}