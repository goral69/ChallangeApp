namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddThreeGrades_ShouldMaxBeGood()
        {
            //arrange
            var employee = new EmployeeInMemory("Beata", "Kozidrak", "F");

            // act
            employee.AddGrade(20);
            employee.AddGrade("A");
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            // assert
            //Assert.AreEqual(100, statistics.Max);             // classic model
            Assert.That(statistics.Max, Is.EqualTo(100));     // constraint model
        }

        [Test]
        public void WhenAddThreeGrades_ShouldMinBeGood()
        {
            //arrange
            var employee = new EmployeeInMemory("Beata", "Kozidrak", "F");
 
            // act
            employee.AddGrade(87);
            employee.AddGrade("c");
            employee.AddGrade(65);
            var statistics = employee.GetStatistics();


            // assert
            //Assert.AreEqual(60, statistics.Min);            // classic model
            Assert.That(statistics.Min, Is.EqualTo(60));    // constraint model
        }

        [Test]
        public void WhenAddThreeGrades_ShouldAverageBeGood()
        {
            //arrange
            var employee = new EmployeeInMemory("Beata", "Kozidrak", "F");
            float grade1 = 'B';
            float grade2 = 25;
            float grade3 = 45;

            // act
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            var statistics = employee.GetStatistics();


            // assert
            //Assert.AreEqual(Math.Round(((grade1 + grade2 + grade3) / 3), 2), Math.Round(statistics.Average, 2));             // classic model
            Assert.That(Math.Round(statistics.Average, 2), Is.EqualTo(Math.Round(((grade1 + grade2 + grade3) / 3), 2)));     // constraint model
        }

        [Test]
        public void WhenAddThreeGrades_ShouldAverageLetterBeGood()
        {
            //arrange
            var employee = new EmployeeInMemory("Beata", "Kozidrak", "F");
            float grade1 = 'B';
            float grade2 = 25;
            float grade3 = 45;

            // act
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            var statistics = employee.GetStatistics();


            // assert
            //Assert.AreEqual("C", statistics.AverageLetter);            // classic model
            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));    // constraint model
        }

    }
}