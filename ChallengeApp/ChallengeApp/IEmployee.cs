namespace ChallengeApp
{
    internal interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        char Sex { get; } 
        public void AddGrade(float grade);
        public void AddGrade(double grade);
        public void AddGrade(int grade);
        public void AddGrade(char grade);
        public void AddGrade(long grade);
        public void AddGrade(string grade);
        Statistics GetStatistics();
    }
}
