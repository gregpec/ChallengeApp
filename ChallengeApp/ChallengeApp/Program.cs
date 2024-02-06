using ChallengeApp;
using System.ComponentModel.Design;
using System.Diagnostics;

Employee employee = new Employee();
Console.WriteLine("Employee evaluation program");
Console.WriteLine("======================================");

while (true)
{
    Console.WriteLine("Write the next employee rating: q-quit");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    if (char.TryParse((input), out char result))
    {
        employee.AddGrade(result);
    }
    else
    employee.AddGrade(input);

}
var statistics = employee.GetStatistics();
Console.WriteLine("======================================");
Console.WriteLine($"AVG: {statistics.AverageLetter:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");












