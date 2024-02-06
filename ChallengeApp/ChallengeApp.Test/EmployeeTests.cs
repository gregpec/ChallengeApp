namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenAllLGradesAreCorrect()
        {
            // average
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade(80);
            employee.AddGrade('c');

            // act
            var statistics = employee.GetStatistics();

            // asert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual(80, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]

        public void WhenSomeGradesAreOutOfRange()
        {
            // average
            var employee = new Employee();
            employee.AddGrade(454);
            employee.AddGrade(100);
            employee.AddGrade(60);
            employee.AddGrade(50);
            employee.AddGrade("300");
            employee.AddGrade("Kamil");
            employee.AddGrade('G');
            // act
            var statistics = employee.GetStatistics();

            // asert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(50, statistics.Min);
            Assert.AreEqual(70, statistics.Average);
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}
