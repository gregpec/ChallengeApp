using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public class Employee:IEmployee
    {
        public event GradeAddedDelegate GradeAdded;
        
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
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
         
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;


        }
    }
}








