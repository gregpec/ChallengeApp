namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void CheckSumWhenEmployeeHasPositvePoints()
        {
            // arrange
            var user = new Employee("Marek", "Kowalczyk", 34);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-7);

            //act
            var result = user.Result;

            // assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void CheckSumWhenEmployeeHasNegativePoints()

        {
            // arrange
            var user = new Employee("Miros³aw", "Bogdalski", 36);
            user.AddScore(-5);
            user.AddScore(6);
            user.AddScore(-5);

            //act
            var result = user.Result;

            // assert
            Assert.AreEqual(-4, result);
        }
        [Test]
        public void CheckSumWhenEmployeeHasNullPoints()
        {
            // arrange
            var user = new Employee("Piotr", "Szczepanek", 31);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-11);

            //act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}