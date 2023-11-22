namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee()
        {
        }

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
                        Console.WriteLine("Niewłaściwa litera");
                        break;
                }
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

            if (this.grades.Count > 0)
            {
                statistics.Average /= this.grades.Count;
                switch (statistics.Average)
                {
                    case var a when a >= 80:
                        statistics.AverageLetter = "A";
                        break;
                    case var a when a >= 60:
                        statistics.AverageLetter = "B";
                        break;
                    case var a when a >= 40:
                        statistics.AverageLetter = "C";
                        break;
                    case var a when a >= 20:
                        statistics.AverageLetter = "D";
                        break;
                    default:
                        statistics.AverageLetter = "E";
                        break;
                }
            }
            
            return statistics;
        }
    }
}
