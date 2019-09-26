using System;

class MyClass
{
    static void AMethod()
    {
        Console.WriteLine("this is the first line in the method");
        Console.WriteLine("this is the second line in the method");
        Console.WriteLine("this is the third line in the method");


    }
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            AMethod();
        }

        //Console.WriteLine("Jamie");
        //AMethod();
        //Console.WriteLine("King");
        //AMethod();
        //Console.WriteLine("Coach");  
    }


}