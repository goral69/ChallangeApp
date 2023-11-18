﻿// Dzień 6
using ChallengeApp;

Employee user1 = new Employee("Adam", "Wroński", 39);
Employee user2 = new Employee("Ewa", "Wanat", 52);
Employee user3 = new Employee("Bartłomiej", "Głowacki", 21);

user1.AddScore(4);
user1.AddScore(1);
user1.AddScore(7);
user1.AddScore(3);
user1.AddScore(9);

user2.AddScore(1);
user2.AddScore(5);
user2.AddScore(8);
user2.AddScore(10);
user2.AddScore(2);

user3.AddScore(2);
user3.AddScore(7);
user3.AddScore(4);
user3.AddScore(8);
user3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    user1, user2, user3
};

int MaxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.result > MaxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult.name + " " + employeeWithMaxResult.surname + ", wiek: " + employeeWithMaxResult.age+", wynik: "+employeeWithMaxResult.result);