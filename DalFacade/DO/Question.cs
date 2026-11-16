using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Question
(
    int Id,
    string? QuestionText,
    int CorrectAnswerId
)
    {
        public Question() : this(0,  null, 0) { }
    }
}
