namespace Game.Logic;


public class Person :IEquatable<Person>, IComparable<Person>
{
    private int id;
    public int Age
    {
        get
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }

    public Contact Contact { get; set; }

    public DateTime BirthDate = new DateTime(2007, 9, 8);

    private List<Course> courseList;

    public Person() : this(count)
    {
        // Console.WriteLine("Execute: Person()");
    }

    public Person(int pid) 
    {
        // Console.WriteLine("Execute: Person(int pid)");
        id = pid;

        count++;
        courseList = new List<Course>();
    }

    public Person(DateTime bday) : this()
    {
        // Console.WriteLine("Execute: Person(DateTime bday)");
        BirthDate = bday;
    }

    public List<Course> GetCourses()
    {
        return courseList;
    }

    public void AddCourse(Course value)
    {
        courseList.Add(value);
    }

    public Course GetCourse(int courseid)
    {
        List<Course> courses = GetCourses();

        Course retval = new Course(-1);

        foreach (Course c in courses)
        {
            if (c.Id == courseid)
                retval = c;
        }

        return retval;
    }

    private static int count = 1;
    public static int TotalPeople()
    {
        return count;
    }
    public static void ResetCount()
    {
        count = 0;
    }

    public void Foo() { }
    public void Foo(int i) { }

    public void Foo(double num) { }
    public void Foo(float f)
    {
        Foo((double)f);
     }

    public int CompareTo(Person? other)
    {
        throw new NotImplementedException();
    }

    public bool Equals(Person? other)
    {
        throw new NotImplementedException();
    }
}

public class Contact
{
    public string First;
}