namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }
        public Employee(string name, string surname)
           : this(name, surname, 'M')
        {
        }
        public Employee(string name)
           : this(name, "no surname", 'M')
        {
        }
        public Employee()
            : this("no name", "no surname", 'M')
        {
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Console.Write("the value of grade is correct and is converted to float\n");
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("the value is out of range\n");
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
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);

                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);

                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);

                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);

                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("wrong letter");
            }
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

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}








