using System;

class MyClass
{
    static void SayHello(string myName, string yourName)
    {
        Console.WriteLine("Hello, " + yourName + ", my name is" + myName + ".");
    }
    static void Main()
    {
        SayHello("Jame", "Eric");
        SayHello("Rebbeccar", "Bob");
    }


}
