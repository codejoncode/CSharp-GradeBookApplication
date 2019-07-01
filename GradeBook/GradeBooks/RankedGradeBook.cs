
using GradeBook.Enums;
using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook //inherits from RankedGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)//creates the call to the base constructor
        {
            Type = GradeBookType.Ranked;
        }
        //override the GetLetterGrade method   returns char and accepts a double named "averageGrade"
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                // requires  using System 
                throw new InvalidOperationException("Ranked grading requries at least 5 students.");
            }
            //integer Math.Ceiling Students.Count multipled by the 20% cast to a int
            int threshold = (int)Math.Ceiling(Students.Count * 0.2); // 20% of students 
            /*
             Equilavent to a for loop and count how many grades are higher or lower than the average grade. 
             first orders then selects average grade and not the object then makes it a list. 
             */
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            //how many students before we go down a later grade subtract one because of zero base indexing
            if (grades[threshold - 1] <= averageGrade)

                return 'A';

            //* 2  because it will be twice what we need to drop a letter grade minus one because of zero base indexing
            else if (grades[(threshold * 2) - 1] <= averageGrade)

                return 'B';

            else if (grades[(threshold * 3) - 1] <= averageGrade)

                return 'C';

            else if (grades[(threshold * 4) - 1] <= averageGrade)

                return 'D';

            else
                return 'F';
           
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }

    
}
