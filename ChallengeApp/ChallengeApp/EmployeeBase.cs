namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(float grade);


        public abstract void AddGrade(long grade);


        public abstract void AddGrade(double grade);


        public abstract void AddGrade(decimal grade);

        public abstract Statistics GetStatistics();
    }
}