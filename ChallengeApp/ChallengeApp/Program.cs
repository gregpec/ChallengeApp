using ChallengeApp;

Employee employee = new Employee("Jacek","Kalinowski");

employee.AddGrade('d'); //char
employee.AddGrade("Karolposzedłnaryby"); //string as text
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
Console.WriteLine("Employee named " + employee.Name + " has " + $"average: {statistics.Average:N2}");
Console.WriteLine($" Min: {statistics.Min}");
Console.WriteLine($" Max: {statistics.Max}");


var statisticsWitchForEach = employee.GetStatisticsWithForEach();
Console.Write("\n");
Console.WriteLine("Employee named " + employee.Name + " has " + $"average: {statisticsWitchForEach.Average:N2}");
Console.WriteLine($" Min: {statisticsWitchForEach.Min}");
Console.WriteLine($" Max: {statisticsWitchForEach.Max}");

var statisticsWitchFor = employee.GetStatisticsWithFor();
Console.Write("\n");
Console.WriteLine("Employee named " + employee.Name + " has " + $"average: {statisticsWitchFor.Average:N2}");
Console.WriteLine($" Min: {statisticsWitchFor.Min}");
Console.WriteLine($" Max: {statisticsWitchFor.Max}");


var statisticsWithDoWhile = employee.GetStatisticsWithDoWhile();
Console.Write("\n");
Console.WriteLine("Employee named " + employee.Name + " has " + $"average: {statisticsWithDoWhile.Average:N2}");
Console.WriteLine($" Min: {statisticsWithDoWhile.Min}");
Console.WriteLine($" Max: {statisticsWithDoWhile.Max}");

var statisticsWithWhile = employee.GetStatisticsWithWhile();
Console.Write("\n");
Console.WriteLine("Employee named " + employee.Name + " has " + $"average: {statisticsWithWhile.Average:N2}");
Console.WriteLine($" Min: {statisticsWithWhile.Min}");
Console.WriteLine($" Max: {statisticsWithWhile.Max}");









