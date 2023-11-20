namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddThreeGrades_ShouldMaxBeGood()
        {
            //arrange
            var employee = new Employee("Beata", "Kozidrak");

            // act
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);             // classic model
            Assert.That(statistics.Max, Is.EqualTo(6));     // constraint model
        }

        [Test]
        public void WhenAddThreeGrades_ShouldMinBeGood()
        {
            //arrange
            var employee = new Employee("Beata", "Kozidrak");
 
            // act
            employee.AddGrade(1);
            employee.AddGrade(7);
            employee.AddGrade(9);
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(1, statistics.Min);            // classic model
            Assert.That(statistics.Min, Is.EqualTo(1));    // constraint model
        }

        [Test]
        public void WhenAddThreeGrades_ShouldAverageBeGood()
        {
            //arrange
            var employee = new Employee("Beata", "Kozidrak");
            float grade1 = 1;
            float grade2 = 5;
            float grade3 = 9;

            // act
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(Math.Round(((grade1 + grade2 + grade3) / 3), 2), Math.Round(statistics.Average, 2));             // classic model
            Assert.That(Math.Round(statistics.Average, 2), Is.EqualTo(Math.Round(((grade1 + grade2 + grade3) / 3), 2)));     // constraint model
        }
    }
}