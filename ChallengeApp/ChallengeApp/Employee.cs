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
            if (float.TryParse(grade, out float stringToFloat))
            {
                Console.Write("the value is string of number and ");
                this.AddGrade(stringToFloat);
            }
            else
                Console.WriteLine("the value is as string of text and is incorrect");
        }
        public void AddGrade(char grade)
        {
            Console.Write("the value of number is char and is " + (float)(int)grade + " ");
            this.AddGrade((float)(int)grade);
        }
        public void AddGrade(double grade)
        {
            Console.Write("the value of number is double and ");
            float doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }
        public void AddGrade(long grade)
        {
            Console.Write("the value of number is long and ");
            float longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }
        public void AddGrade(int grade)
        {
            Console.Write("the value of number is int and ");
            float intToFloat = (float)grade;
            this.AddGrade(intToFloat);
        }
        public Statistics GetStatistics() // metoda
        {
            var statistics = new Statistics();  //
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
        public Statistics GetStatisticsWithForEach() // metoda
        {
            var statistics = new Statistics();  //
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            Console.Write("\nthe statistics with for each: ");
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            Console.Write("\nthe statistics with for: ");
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);

            Console.Write("\nthe statistics with do whlie: ");
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            Console.Write("\nthe statistics with whlie: ");
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}






