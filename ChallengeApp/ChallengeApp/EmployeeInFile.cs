namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = @"D:\Projekty\grades.txt";
        public EmployeeInFile(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Console.Write("the value of grade is correct and is converted to float\n");
                using (var writer = File.AppendText(fileName))
                    writer.WriteLine(grade);
            }
            else
            {
                throw new Exception("the value is out of range");
            }
        }
        public override void AddGrade(double grade)
        {

            Console.Write("the value of number is double and ");
            float doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }
        public override void AddGrade(int grade)
        {
            Console.Write("the value of number is int and ");
            float intToFloat = (float)grade;
            this.AddGrade(intToFloat);
        }
        public override void AddGrade(char grade)
        {
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
        }
        public override void AddGrade(long grade)
        {
            Console.Write("the value of number is long and ");
            float longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float stringToFloat))
            {
                Console.Write("the value is string of number and ");
                this.AddGrade(stringToFloat);
            }
            else
            {
                throw new Exception("the value is as string of text and is incorrect");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var counter = 1;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                   var line = reader.ReadLine();
                    while (line != null)
                    {
                            var number = float.Parse(line);
                            Console.WriteLine($"reading line {counter} from file: {number}");
                            statistics.Max = Math.Max(statistics.Max, number);
                            statistics.Min = Math.Min(statistics.Min, number);
                            statistics.Average += number;
                            counter++;
                            line = reader.ReadLine();
                    }
                    statistics.Average /= counter;
                }     
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
            }
            return statistics;
        }
    }     
}
