using ChallengeApp;

Employee employee = new Employee("Jacek","Kalinowski");

employee.AddGrade('C'); //char
employee.AddGrade("KarolPoszedlNaObiad"); //string as text
employee.AddGrade("79.34"); //string to number
employee.AddGrade(65.56); //double 
employee.AddGrade(59.83); //double
employee.AddGrade(54); //int
employee.AddGrade(20930296876); //long 
employee.AddGrade(113); //int
employee.AddGrade(-117613); //int
employee.AddGrade(1113); //int
employee.AddGrade(1113.15); //double

var statistics = employee.GetStatistics();
    Console.Write("\n");
    Console.WriteLine("Employee named " + employee.Name + " has " +$"Average: {statistics.Average:N2}");
    Console.WriteLine($" Min: {statistics.Min}");
    Console.WriteLine($" Max: {statistics.Max}");









