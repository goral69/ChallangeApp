﻿namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, string sex) : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
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
            { Console.WriteLine("Błąd parsowania: "+exception.Message);}

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