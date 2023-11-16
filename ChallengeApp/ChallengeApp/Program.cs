// Dzień 4
string name = "Ewa";
string gender = "female";
var age = 34;
//
if (gender == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Żaden warunek nie został spełniony");
}