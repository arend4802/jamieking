using System;

class Cow
{
    int numSteaks;
    int mooCount;
    double pounds;
    public void Moo()
    {
        "Moo".P();
        mooCount++;
    }
}

class MainClass
{
    static void Main()
    {
        Cow betsy = new Cow();
        betsy.Moo();

    }

}