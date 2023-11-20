// Dzień 10
using ChallengeApp;

var employee = new Employee("Adam", "Wroński");
employee.AddGrade("Adam"); 
employee.AddGrade("2000");
employee.AddGrade(long.MaxValue);
employee.AddGrade(double.MaxValue);
employee.AddGrade(decimal.MaxValue);
employee.AddGrade(5.5);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Imię: {employee.Name}, Nazwisko: {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");