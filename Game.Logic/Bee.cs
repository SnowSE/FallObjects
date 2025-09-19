

using System.ComponentModel;

public class Bee
{
    public int Num1 { get; }
    public int Num2 { get; private set; }
    public readonly int Num3;
    private readonly int num4;
    public int Num4 => num4;
    private int num5;
    public int Num5 { get => num5; }
    public readonly string Str1;

    public Bee()
    {
        // Num1 = 1; Num2 = 2; Num3 = 3; num4 = 4; num5 = 5;
        Str1 = "word";
    }

    public void SetAll()
    {
        // Str1 = "other";
        // Num1 = 10;
        Num2 = 20;
        // Num3 = 30;
        // num4 = 40;
        num5 = 50;        
    }
    
    // does not work
    // public readonly int NumNo {get; set;}
}