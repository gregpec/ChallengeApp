namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Age = age;
        }

        public string Name { get; private set; } 
        public string Surname { get; private set; }
        public int Age { get; private set; }
      
        private List<int> scores = new List<int>();
        public void AddScore(int number)
        {
            this.scores.Add(number);
        }
        public int Result
        {
            get
            {
                return this.scores.Sum();
            }
        }
       
    }
}






