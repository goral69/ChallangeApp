// Dzień 12
using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();
//var employee = new Employee("Adam", "Wroński");
var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
    Console.WriteLine("Aby zakończyć wciśnij 'q'");
}

var statistics = employee.GetStatistics();

if (statistics.AverageLetter == null)
{
    Console.WriteLine("Nie podano żadnej oceny pracownika");
}
else
{
    Console.WriteLine($"Ocena średnia: {statistics.Average:N2}");
    Console.WriteLine($"Ocena minimalna: {statistics.Min}");
    Console.WriteLine($"Ocena maksymalna: {statistics.Max}");
    Console.WriteLine($"Ocena literowa: {statistics.AverageLetter}");
}