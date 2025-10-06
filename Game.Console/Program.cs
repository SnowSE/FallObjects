using System.Numerics;
using Game.Logic;










int multiply(int a, int b)
{
    if (b > a)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    int product = 0;
    for (int i = 0; i < b; i++)
    {
        product = product + a;
    }
    return product;
}