

using System.Runtime.CompilerServices;

int i = 12;

Add(i);

Console.WriteLine(i);

int[] greet = {1,2,3,4};

AddArray(greet);

for (int j = 0; j < greet.Length; j++)
{
    Console.Write(greet[j] + ", ");
}
Console.WriteLine("");


void Add(int value)
{
    value = value + 1;
}
void AddArray(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = list[i] + 1;
    }
}


Console.Write("Type a number: ");
string input = Console.ReadLine() ?? "";

int result;

if (!int.TryParse(input, out result))
{
    Console.WriteLine("Must be a number");
}
else
{
    Console.WriteLine(result);
}



bool IsValidInt(string input)
{
    foreach (char c in input)
    {
        if (c < '0' || c > '9')
        {
            return false;
        }
    }

    return true;
}