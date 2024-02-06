namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee()
        {
        }
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
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("wrong letter");
                    break;
            }
        }
        public void AddGrade(double grade) //nie działa
        {
            Console.Write("the value of number is double and ");
            float doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }
        public void AddGrade(long grade) //nie działa
        {
            Console.Write("the value of number is long and ");
            float longToFloat = (float)grade;
            this.AddGrade(longToFloat); 
        }
        public void AddGrade(int grade) //nie działa
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






