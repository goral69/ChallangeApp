// Dzień 9
using ChallengeApp;

var employee = new Employee("Adam", "Wroński");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Imię: {employee.Name}, Nazwisko: {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");