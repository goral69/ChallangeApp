using ChallengeApp;

namespace ChellangeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenEmployyeCollectScores_ShouldReturnSumAsResult()
        {
            // arrange
            var employee = new Employee("Adam", "Wroñski", 39);
            employee.AddScore(1);
            employee.AddScore(8);
            employee.AddScore(9);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(18, result);
        }

        [Test]
        public void WhenEmployyeCollectNegativeScores_ShouldReturnSumAsResult()
        {
            // arrange
            var employee = new Employee("Adam", "Wroñski", 39);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-4);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(7, result);
        }

    }
}