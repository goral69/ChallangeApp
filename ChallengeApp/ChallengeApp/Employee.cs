namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
         }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Niewłaściwa wartość oceny");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Podana wartość nie jest liczbą zmiennoprzecinkową (float)");
            }
        }

        public void AddGrade(long grade)
        {
            float gradeLongAsFloat = (float)grade;
            this.AddGrade(gradeLongAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeDoubleAsFloat = (float)grade;
            this.AddGrade(gradeDoubleAsFloat);
        }

        public void AddGrade(decimal grade)
        {
            float gradeDecimalAsFloat = (float)grade;
            this.AddGrade(gradeDecimalAsFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
