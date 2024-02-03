namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname; 
        }
        public string Name { get; private set; } 
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Console.Write("the value of grade is correct\n");
                this.grades.Add(grade);
            }
            else 
            {
                Console.Write("the value is out of range\n");
            } 
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                Console.Write("the value is string of number and ");
                this.AddGrade(result);
            }
            else
                Console.WriteLine("the value is as string of text and is incorrect");
        }
        public void AddGrade(char grade)
        {
            Console.WriteLine("the value of number is char and is incorrect");
        }
        public void AddGrade(double grade)
        {
            Console.Write("the value of number is double and ");
            float result = (float)grade;
            this.AddGrade(result); 
        }
        public void AddGrade(long grade)
        {
            Console.Write("the value of number is long and ");
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(int grade)
        {
            Console.Write("the value of number is int and ");
            float result = (float)grade;
            this.AddGrade(result);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }  
}






