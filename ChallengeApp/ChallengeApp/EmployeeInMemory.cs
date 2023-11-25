namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname, string sex) : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Niewłaściwa wartość oceny");
            }
        }

        public override void AddGrade(string grade)
        {
            try
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else if (char.TryParse(grade, out char letter))
                {
                    switch (letter)
                    {
                        case 'A':
                        case 'a':
                            this.AddGrade(100);
                            break;
                        case 'B':
                        case 'b':
                            this.AddGrade(80);
                            break;
                        case 'C':
                        case 'c':
                            this.AddGrade(60);
                            break;
                        case 'D':
                        case 'd':
                            this.AddGrade(40);
                            break;
                        case 'E':
                        case 'e':
                            this.AddGrade(20);
                            break;
                        default:
                            throw new Exception("Niewłaściwa litera");
                    }
                }
                else
                {
                    throw new Exception("Podana wartość nie jest liczbą zmiennoprzecinkową (float)");
                }
            }
            catch (FormatException exception)
            { Console.WriteLine("Błąd parsowania: " + exception.Message); }

        }

        public override void AddGrade(long grade)
        {
            float gradeLongAsFloat = (float)grade;
            this.AddGrade(gradeLongAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeDoubleAsFloat = (float)grade;
            this.AddGrade(gradeDoubleAsFloat);
        }

        public override void AddGrade(decimal grade)
        {
            float gradeDecimalAsFloat = (float)grade;
            this.AddGrade(gradeDecimalAsFloat);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
