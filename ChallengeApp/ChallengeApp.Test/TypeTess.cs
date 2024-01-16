using System.Formats.Tar;
using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class TypeTess
    {
        [Test]
        public void ChecksIfNameIsTheSame()
        {
            // arrange
            var employeeuser1 = GetUser("Karol","Borowski",31); 
            var employeeuser2 = GetUser("Karol","Kowacz",35);

            //act
          
            // assert
           Assert.AreEqual(employeeuser1.Name,employeeuser2.Name);
        }

        private Employee GetUser(string name, string surname, int age)
        { 
            return new Employee(name,surname,age);
        }

        [Test]
        public void ChecksIfValueAreEqual()
        {
            // arrange
            int a = 1234;
            int b = 1234;

            //act

            // assert
            Assert.AreEqual(a,b);
        }
        [Test]
        public void ChecksIfValueAreDifferent()
        {
            // arrange
            var c = 1125543.34;
            var d = 1125544.21;

            //act

            // assert
            Assert.AreNotEqual(c,d);
        }
        [Test]
        public void ChecksIfStringAreTheSame()
        {
            // arrange
            string meal1 = "PotatoesAndCheese";
            string meal2 = "PotatoesAndCheese";

            //act

            // assert
            Assert.AreEqual(meal1, meal2);
        }

    }
}
