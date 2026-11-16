using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record QuestionInTest
    {
        int StudentId;
        int TestId;
        int QuestionId;
        int SelectedAnswerId;
        public QuestionInTest() { }
    }
}
