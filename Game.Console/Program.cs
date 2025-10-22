using System.Numerics;
using Game.Logic;




IEnumerable<int> list = [1, 2, 4, 5, 6, 67, 7, 78, 8, 4, 67, 8, 9, 9];
PrintList(list);


var list2 = list.Select(i => i.ToString());
PrintList(list2);


// Make another beginner set that can be solved with where, first, select, and delete

void PrintList(IEnumerable<string)

void PrintList(IEnumerable<int> list)
{
    Action<int> print = (s => Console.Write(s + ", "));

    list.ToList().ForEach(print);
    Console.WriteLine("");

    // list.ForEach(Print);
    // Console.WriteLine("");

    // foreach (int item in list)
    // {
    //     Console.Write(item + ", ");
    // }
    // Console.WriteLine("");
    // for (int i = 0; i < list.Count; i++)
    // {
    //     Console.Write(list[i] + ", ");
    // }
    // Console.WriteLine("");
}

void Print(int item)
{
    Console.Write(item + ", ");
}

