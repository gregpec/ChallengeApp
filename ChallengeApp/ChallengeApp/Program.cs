using ChallengeApp;

Employee Employee1 = new Employee("Jacek","Kalinowski");

Employee1.AddGrade('c'); //char
Employee1.AddGrade("Karolposzedlnaobiad"); //string as text
Employee1.AddGrade("79.34"); //string to number
Employee1.AddGrade(65.56); //double 
Employee1.AddGrade(59.83); //double
Employee1.AddGrade(54); //int
Employee1.AddGrade(20930296876); //long 
Employee1.AddGrade(113); //int
Employee1.AddGrade(-117613); //int
Employee1.AddGrade(1113); //int
Employee1.AddGrade(1113.15); //double

var statistics = Employee1.GetStatistics();
    Console.Write("\n");
    Console.WriteLine("Employee named " + Employee1.Name + " has " +$"Average: {statistics.Average:N2}");
    Console.WriteLine($" Min: {statistics.Min}");
    Console.WriteLine($" Max: {statistics.Max}");









