
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook //inherits from RankedGradeBook
    {
        public RankedGradeBook(string name) : base(name)//creates the call to the base constructor
        {
            Type = GradeBookType.Ranked;
        }
    }
}
