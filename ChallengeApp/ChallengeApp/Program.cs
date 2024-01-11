using ChallengeApp;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

Employee Employee1 = new Employee("Waldemar","Wituszyński",31);
Employee Employee2 = new Employee("Zuzanna","Pasiuta",35);
Employee Employee3 = new Employee("Karol","Patryczewski",34);

Employee1.AddScore(5);
Employee1.AddScore(3);
Employee1.AddScore(1);

Employee2.AddScore(1);
Employee2.AddScore(6);
Employee2.AddScore(10);

Employee3.AddScore(1);
Employee3.AddScore(30);
Employee3.AddScore(1);

List<Employee> employeers = new List<Employee>()
{ 
    Employee1, Employee2, Employee3
};
int maxResult = -1;
Employee employerWithMaxResult = null;

foreach(var employee in employeers)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employerWithMaxResult = employee; 
    }
}
Console.WriteLine("Employee max result is " + maxResult);
Console.WriteLine("Employee with max result is " + employerWithMaxResult.Name+ " " + employerWithMaxResult.Surname+" "+ employerWithMaxResult.Age);






