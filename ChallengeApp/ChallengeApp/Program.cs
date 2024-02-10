using ChallengeApp;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;

Employee employee = new Employee("Mariusz","Borecki");
Console.WriteLine("Employee evaluation program");
Console.WriteLine($"Employee named:  {employee.Name} {employee.Surname} ");
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
        try
        {
            employee.AddGrade(result);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Exception Catched:{exception.Message}");
        }

    }
    else
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Exception Catched:{exception.Message}");
        }
        
}
var statistics = employee.GetStatistics();
Console.WriteLine("======================================");
Console.WriteLine($"AVG: {statistics.AverageLetter:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");












