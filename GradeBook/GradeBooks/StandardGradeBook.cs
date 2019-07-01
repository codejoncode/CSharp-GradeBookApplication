
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //inherits from BaseGradeBook
    {
        //constructor for the class
        public StandardGradeBook(string name) :base(name)//call the base constructor upon completion
        {
            Type = Enums.GradeBookType.Standard; 
        }
    }
}
