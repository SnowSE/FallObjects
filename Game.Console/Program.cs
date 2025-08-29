

List<int> list = [];

int result = -1;


while (result != 0)
{
    Console.Write("Type a number: ");
    string input = Console.ReadLine();

    while (!int.TryParse(input, out result))
    {
        Console.WriteLine("You must type a number");
        Console.Write("Type a number: ");
        input = Console.ReadLine();
    }
    // Console.WriteLine($"You typed: {result}");

    if (result != 0)
    {
        list.Add(result);

    }

}

foreach (var v in list)
{
    Console.Write(v + ", ");
}
// find the average