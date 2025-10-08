using System.Numerics;
using Game.Logic;

Console.WriteLine(sizeof(double));


IEnumerable<int> list2 = [];
if (list2.Any())
{
    int item2 = list2.First();
}
var item3 = list2.FirstOrDefault();
if (item3 != 0)
{
    Console.WriteLine(item3);
}

IEnumerable<int> list = [1, 2, 4, 5, 6, 67, 7, 78, 8, 8, 9, 9];
PrintList(list);

if (list.Any(i => i == 27))
{
    int item = list.First(i => i == 27);
    Console.WriteLine(item);

    item = list.First();
    Console.WriteLine(item);
}
// list.Delete(x => x > 27);
list = list.Where(number => number > 8)
           .Where(j => j < 48);
PrintList(list);

Dictionary<int, string> dict = new()
{
    [1] = "bees",
    [2] = "tree",
    [3] = "rutabega"
};
var thing = dict.Where(p => p.Key >1 && p.Value != "tree")
        .FirstOrDefault();

List<string> dlist = list.Select(i => i.ToString() + " int").ToList();







void PrintList(IEnumerable<int> list)
{
    list.ToList().ForEach(x => Console.Write(x + ", "));
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

