namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, string sex) : base(name, surname, sex)
        {
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

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Niewłaściwa wartość oceny");
            }
        }

        public override void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    var count = 0;
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        statistics.Max = Math.Max(statistics.Max, grade);
                        statistics.Min = Math.Min(statistics.Min, grade);
                        statistics.Average += grade;
                        count++;
                        line = reader.ReadLine();
                    }
                    statistics.Average /= count;
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
            }
            return statistics;
        }
    }
}
