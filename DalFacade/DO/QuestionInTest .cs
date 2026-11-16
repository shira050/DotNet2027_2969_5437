using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record QuestionInTest
(
    int Id,
    int StudentId,
    int TestId,
    int QuestionId,
    int SelectedAnswerId
)
    {
        public QuestionInTest() : this(0, 0, 0, 0, 0) { }
    }
}
