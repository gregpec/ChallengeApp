namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // average
            var employee1 = new Employee("Bob","Taylor");
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(5);

            // act
            var statistics = employee1.GetStatistics();

            // asert
            Assert.AreEqual(5, statistics.Max);
        }
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // average
            var employee1 = new Employee("John","James");
            employee1.AddGrade(4);
            employee1.AddGrade(8);
            employee1.AddGrade(6);

            // act
            var statistics = employee1.GetStatistics();

            // asert
            Assert.AreEqual(4, statistics.Min);
        }
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // average
            var employee1 = new Employee("Tom","Mike");
            employee1.AddGrade(3);
            employee1.AddGrade(6);
            employee1.AddGrade(7);

            // act
            var statistics = employee1.GetStatistics();

            // asert
            Assert.AreEqual(Math.Round(5.33,2), Math.Round(statistics.Average,2));
        }

    }
}
