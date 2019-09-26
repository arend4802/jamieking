using System;

class Person
{
    public string FirstName;
    public string middleName;
    public string LastName;
    public int Age;
}

class MyClass
{
    static void Main()
    {
        Person myTeacher = new Person
        {
            FirstName = "Jamie",
            LastName = "King",
            middleName = "Neumont University",
            Age = 55

        };
        Person aSTUDENT = new Person
        {
            FirstName = "Chris",
            LastName = "Bob",

        };
        Console.WriteLine(myTeacher.FirstName);
        Console.WriteLine(myTeacher.Age);
    }

}

