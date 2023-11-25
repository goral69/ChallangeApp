using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {

        string Name { get; }

        string Surname { get; }

        string Sex { get; }

        void AddGrade(string grade);

        void AddGrade(float grade);

        void AddGrade(long grade);

        void AddGrade(double grade);

        void AddGrade(decimal grade);

        public abstract event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}
