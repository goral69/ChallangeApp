namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenComparisonOfTwoVarType_ShouldSumBeGood()
        {
            //arrange
            var number1 = 5;
            var number2 = 7;

            // act

            // assert
            Assert.AreEqual(12, number1 + number2);
        }

        [Test]
        public void WhenComparisonOfTwoStringType_ShouldNotBeTheSame()
        {
            //arrange
            string name1 = "Artur1";
            string name2 = "Artur2";

            // act

            // assert
            Assert.AreNotSame(name1, name2);
        }

        [Test]
        public void WhenComparisonOfTwoStringType_ShouldBeFirstLessThenSecond()
        {
            //arrange
            string name1 = "Artur1";
            string name2 = "Artur21";

            // act

            // assert
            Assert.That(name1.Length, Is.LessThan(name2.Length));
        }

        [Test]
        public void WhenComparisonOfTwoReferenceType_ShouldNotEqual()
        { 
            //arrange
            var employee1 = GetEmployee("Adam", "Wroński", 39);
            var employee2 = GetEmployee("Ewa", "Wanat", 52);

            // act
    
            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

       private Employee GetEmployee(string name, string surname, int age) 
       {
           return new Employee(name, surname, age);
       }
     }
}