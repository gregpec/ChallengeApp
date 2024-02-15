namespace ChallengeApp
{  
    public class Supervisor:IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex= sex;  
        }
        public Supervisor(string name, string surname)
           : this(name, surname, 'M')
        {
        }
        public Supervisor(string name)
           : this(name, "no surname", 'M')
        {
        }
        public Supervisor()
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
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6" or "6-":
                    this.AddGrade(95);
                    break;
                case "+5" or "5+":
                    this.AddGrade(90);
                    break;
                case "5":
                    this.AddGrade(85);
                    break;
                case "-5" or "5-":
                    this.AddGrade(80);
                    break;
                case "+4" or "4+":
                    this.AddGrade(75);
                    break;
                case "4":
                    this.AddGrade(70);
                    break;
                case "-4" or "4-":
                    this.AddGrade(65);
                    break;
                case "+3" or "3+":
                    this.AddGrade(60);
                    break;
                case "3":
                    this.AddGrade(55);
                    break;
                case "-3" or "3-":
                    this.AddGrade(50);
                    break;
                case "+2" or "2+":
                    this.AddGrade(45);
                    break;
                case "2":
                    this.AddGrade(35);
                    break;
                case "-2" or "2-":
                    this.AddGrade(30);
                    break;
                case "1":
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("wrong letter of string");
            }
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
                    throw new Exception("wrong letter of char");
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

   
    

