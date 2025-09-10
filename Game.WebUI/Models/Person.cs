public class Person
{
    public int Age
    {
        get
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }
    public DateTime BirthDate = new DateTime(2007, 9, 8);

    public Person()
    {
        count++;
    }
    
    private static int count = 0;
    public static int TotalPeople()
    {
        return count;
    }
}