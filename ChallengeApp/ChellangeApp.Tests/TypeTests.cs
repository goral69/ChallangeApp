namespace ChallengeApp.Tests

{
    public class TypeTests
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
            employee.AddGrade(-5);
            employee.AddGrade(7);
            employee.AddGrade(9);
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual(-5, statistics.Min);            // classic model
            Assert.That(statistics.Min, Is.EqualTo(-5));    // constraint model
        }

        [Test]
        public void WhenAddThreeGrades_ShouldAverageBeGood()
        {
            //arrange
            var employee = new Employee("Beata", "Kozidrak");
            float grade1 = 2;
            float grade2 = 5;
            float grade3 = 9;

            // act
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            var statistics = employee.GetStatistics();


            // assert
            Assert.AreEqual((grade1 + grade2 + grade3) /3, statistics.Average);             // classic model
            Assert.That(statistics.Average, Is.EqualTo((grade1 + grade2 + grade3) / 3));    // constraint model
        }
    }
}