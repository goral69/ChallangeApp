// Dzień 5
int number = 4556;
string numberAsString = number.ToString();
char[] chars = numberAsString.ToCharArray();
int[] digit = new int[10];

foreach (var i in digit)
{
    digit[i] = 0;
}

foreach (char c in chars )
{
    digit[Convert.ToInt32(c) - 48] ++;
}

Console.WriteLine("Liczba: " + number);

for(var i = 0; i < digit.Length; i ++)
{
    Console.WriteLine(i + " => " + digit[i]);
}