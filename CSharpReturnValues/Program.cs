using System;

class MyClass
{
    static float Square(float value)
    {
        return value * value; 
    }
    static void Main()
    {
        float fivesquared = Square(5);
        Console.WriteLine(fivesquared);

    }
}