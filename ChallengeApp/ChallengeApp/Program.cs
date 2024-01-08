using ChallengeApp;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

Employee Employee1 = new Employee("Waldemar","Wituszyński",31);
Employee Employee2 = new Employee("Zuzanna","Pasiuta",35);
Employee Employee3 = new Employee("Karol","Patryczewski",34);

Employee1.Addscore(5);
Employee1.Addscore(3);
Employee1.Addscore(1);

Employee2.Addscore(1);
Employee2.Addscore(6);
Employee2.Addscore(10);

Employee3.Addscore(1);
Employee3.Addscore(30);
Employee3.Addscore(1);

List<Employee> employeers = new List<Employee>()
{ 
    Employee1, Employee2, Employee3
};
int maxResult = -1;
Employee employerWithMaxResult = null;

foreach(var employe in employeers)
{
    if (employe.Result > maxResult)
    {
        maxResult = employe.Result;
        employerWithMaxResult = employe; 
    }
}
Console.WriteLine("Employe max result is " + maxResult);
Console.WriteLine("Employe with max result is " + employerWithMaxResult.Name+ " " + employerWithMaxResult.Surname+" "+ employerWithMaxResult.Age);






