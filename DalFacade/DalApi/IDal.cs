using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DalApi;

public interface IDal
{
    IAnswer Answer { get; }
    IQuestion Question { get; }
    IQuestionInTest QuestionInTest { get; }
    IStudent Student { get; }
    ITest Test { get; }
}