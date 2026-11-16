using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Test
(
    int id,
    Subject subject,
    DateTime TestDate,
    int QuestionsCount
)
    {
        public Test() : this(0, 0, DateTime.Now, 0) { }
    }
}
