namespace ChallengeApp
{
    public abstract class Person 
    {
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = name;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

    }   
}
