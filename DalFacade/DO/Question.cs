using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Question
    {
        int id;
        enum Subject;
        string ? QuestionText;
        int CorrectAnswerId;
        public Question() { }
    }
}
