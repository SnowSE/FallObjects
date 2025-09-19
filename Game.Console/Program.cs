using Game.Logic;


// int? num = null;

// num = 7;

// Console.WriteLine(num);

// string value = Console.ReadLine()!;

// if (value != null)
// {
//     Console.WriteLine(value);
// }


Console.WriteLine("Call: Person()");
Person p1 = new Person();

p1.AddCourse(new Course(34));
p1.AddCourse(new Course(4));
p1.AddCourse(new Course(2));

Course cour = p1.GetCourse(41);
if (cour.Id == -1)
{
    Console.WriteLine("Course not found");
}

Console.WriteLine("Call: Person(34)");
Person p2 = new Person(34);
Console.WriteLine("Call: Person(date)");
Person p = new Person(new DateTime(2025, 9,17));



p.Foo(5);


p.Foo(4.5f);
