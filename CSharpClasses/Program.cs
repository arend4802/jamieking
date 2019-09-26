using System;


class Tuple
{
    public int FirstValue;
    public int Secondvalue;
}
class MyClass
{
    static void Main()
    {
        Tuple myTuple = new Tuple
        {
            FirstValue = 5,
            Secondvalue = 11
        };
        Console.WriteLine(myTuple.FirstValue);
        Console.WriteLine(myTuple.Secondvalue);
    }        
}