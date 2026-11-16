using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Student
(
    int StudentId,
    string? StudentName,
    int TestId,
    int? Grade
)
    {
        public Student() : this(0, null, 0, null) { }
    }
}
