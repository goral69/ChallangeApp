using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

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

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float result))
                        {
                            statistics.AddGrade(result);
                            line = reader.ReadLine();
                        }
                        else
                        {
                            throw new Exception("Nie udało się przekonwertować oceny z pliku na liczbę typu float");
                        }
                    }
                }
            }
            return statistics;
        }
    }
}
