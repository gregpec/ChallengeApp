namespace ChallengeApp
{
    public class Employee
    {
        private int score;
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Age = age;  
            this.score = 0;
        }
        public string Name { get; private set; } 
        public string Surname { get; private set; }
        public int Age { get; private set; }
      
        List<int> scores = new List<int>();
        public void Addscore(int number)
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






