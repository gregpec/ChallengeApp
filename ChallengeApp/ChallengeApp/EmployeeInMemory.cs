namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }
        public override event GradeAddedDelegate GradeAdded;
      
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs()); 
                }
            }
            else
            {
                throw new Exception("The value is out of range");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float stringToFloat))
            {
                Console.Write("the value is string of number and: ");
                this.AddGrade(stringToFloat);
            }
            else
            {
                throw new Exception("The value is as string of text and is incorrect");
            }  
        }
        public override void AddGrade(char grade)
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
                    throw new Exception("Wrong letter");
            }
        }
        public override void AddGrade(double grade)
        {
            Console.Write("the value of number is double and: ");
            float doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }
        public override void AddGrade(long grade)
        {
            Console.Write("the value of number is long and: ");
            float longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }
        public override void AddGrade(int grade)
        {
            Console.Write("the value of number is int and: ");
            float intToFloat = (float)grade;
            this.AddGrade(intToFloat);
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}



