
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //inherits from BaseGradeBook
    {
        //constructor for the class
        public StandardGradeBook(string name, bool isWeighted) :base(name, isWeighted)//call the base constructor upon completion
        {
            Type = Enums.GradeBookType.Standard; 
        }
    }
}
