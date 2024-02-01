using ChallengeApp;

Employee Employee1 = new Employee("Jacek","Kalinowski");
Employee Employee2 = new Employee("Renata","Walecko");
Employee Employee3 = new Employee("Karol","Patryczewski");

Employee1.AddGrade(5);
Employee1.AddGrade(-3);
Employee1.AddGrade(1);

Employee2.AddGrade(1);
Employee2.AddGrade(6);
Employee2.AddGrade(10);

Employee3.AddGrade(1);
Employee3.AddGrade(30);
Employee3.AddGrade(1);

List<Employee> employeers = new List<Employee>()
{ 
    Employee1, Employee2, Employee3
};
    var statistics = Employee1.GetStatistics(); 
    Console.WriteLine("Employee named " + Employee1.Name + " has " +$"Average: {statistics.Average:N2}");
    Console.WriteLine($" Min: {statistics.Min}");
    Console.WriteLine($" Max: {statistics.Max}");








