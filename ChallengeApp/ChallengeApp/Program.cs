using ChallengeApp;

var employee = new EmployeeInFile("Grzegorz","Pećko",'M');
Console.WriteLine("Employee evaluation program");
Console.WriteLine($"Employee named:  {employee.Name} {employee.Surname} {employee.Sex}");
Console.WriteLine("======================================");

while (true)
{
    Console.WriteLine("Write the next employee rating (0-100 or A-E): q-quit");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    if (char.TryParse((input), out char stringToChar))
    {
        try
        {
            employee.AddGrade(stringToChar);
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

var statisticsForEmployee = employee.GetStatistics();
Console.WriteLine("======================================");
Console.WriteLine($"AVG: {statisticsForEmployee.AverageLetter:N2}");
Console.WriteLine($"Average: {statisticsForEmployee.Average:N2}");
Console.WriteLine($"Min: {statisticsForEmployee.Min}");
Console.WriteLine($"Max: {statisticsForEmployee.Max}");











